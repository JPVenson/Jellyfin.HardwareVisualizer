using Jellyfin.HardwareVisualizer.Server.Database;
using Jellyfin.HardwareVisualizer.Shared.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ServiceLocator.Attributes;
using DeviceType = Jellyfin.HardwareVisualizer.Server.Database.DeviceType;

namespace Jellyfin.HardwareVisualizer.Server.Services.Submission;

[ScopedService(typeof(ISubmissionService))]
public class SubmissionService : ISubmissionService
{
	private readonly IDbContextFactory<HardwareVisualizerDataContext> _dbContextFactory;

	public SubmissionService(IDbContextFactory<HardwareVisualizerDataContext> dbContextFactory)
	{
		_dbContextFactory = dbContextFactory;
	}

	public async Task RecalcHardwareStats()
	{
		await using var db = await _dbContextFactory.CreateDbContextAsync();
		var submissionsByGpu =
			await db.HardwareSurveyEntries.GroupBy(e => new
				{
					DeviceType = e.GpuType == null ? DeviceType.Cpu : DeviceType.Gpu,
					DeviceName = e.GpuType!.Name ?? e.CpuType!.Name,
					CodecName = e.HardwareCodec.Name,
					From = e.FromResolution.Name,
					To = e.ToResolution.Name,
				})
				.Select(e => new HardwareDisplay()
				{
					HardwareCodec = e.Key.CodecName,
					Diviation = 0,
					FromResolution = e.Key.From,
					ToResolution = e.Key.To,
					DeviceType = e.Key.DeviceType,
					DeviceName = e.Key.DeviceName,
					MaxStreams = e.Average(f => f.MaxStreams)
				})
				.ToArrayAsync();

		await db.HardwareDisplays.ExecuteDeleteAsync();
		await db.HardwareDisplays.AddRangeAsync(submissionsByGpu);
		await db.SaveChangesAsync();
	}

	public async Task<string> SubmitHardwareSurvey(TranscodeSubmission submission,
		ModelStateDictionary modelStateDictionary)
	{
		await using var db = await _dbContextFactory.CreateDbContextAsync();

		var rawSubmission = new RawSurveySubmission()
		{
			Id = Guid.NewGuid(),
			Json = JsonConvert.SerializeObject(submission)
		};
		
		var submissionEntity = new HardwareSurveySubmission()
		{
			RawSurveySubmission = rawSubmission,
			Id = Guid.NewGuid(),
			HardwareSurveyEntry = new List<HardwareSurveyEntry>()
		};
		var submissionTests = submission.Tests.ToArray();
		for (var index = 0; index < submissionTests.Length; index++)
		{
			var fromCodec = submissionTests[index];
			if (fromCodec is null)
			{
				modelStateDictionary.AddModelError($"{nameof(TranscodeSubmission.Tests)}[{index}]", "cannot be null");
				continue;
			}

			await foreach (var surveyEntry in GetResolutionTest(db, submission, fromCodec, index, modelStateDictionary))
			{
				submissionEntity.HardwareSurveyEntry.Add(surveyEntry);
			}
		}

		db.HardwareSurveySubmissions.Add(submissionEntity);

		await db.SaveChangesAsync(true);
		Task.Run(RecalcHardwareStats);
		return submissionEntity.Id.ToString();
	}

	public async Task<HardwareDisplay[]> GetSubmissions(string deviceName)
	{
		var context = await _dbContextFactory.CreateDbContextAsync();
		return await context.HardwareDisplays.Where(e => e.DeviceName == deviceName).ToArrayAsync();
	}

	public async Task<GpuType[]> GetGpuRenderDevices()
	{
		var dbContext = await _dbContextFactory.CreateDbContextAsync();
		var gpuTypes = await dbContext.GpuTypes.ToArrayAsync();
		return gpuTypes;
	}

	public async Task<CpuType[]> GetCpuRenderDevices()
	{
		var dbContext = await _dbContextFactory.CreateDbContextAsync();
		var cpuTypes = await dbContext.CpuTypes.ToArrayAsync();
		return cpuTypes;
	}

	public async Task<HardwareSurveySubmission?> GetSingleSubmission(Guid id)
	{
		var dbContext = await _dbContextFactory.CreateDbContextAsync();
		return await dbContext.HardwareSurveySubmissions
			.Include(e => e.HardwareSurveyEntry)
			.Include(e => e.HardwareSurveyEntry.First().FromResolution)
			.Include(e => e.HardwareSurveyEntry.First().ToResolution)
			.Include(e => e.HardwareSurveyEntry.First().HardwareCodec)
			.FirstOrDefaultAsync(e => e.Id == id);
	}

	private async IAsyncEnumerable<HardwareSurveyEntry> GetResolutionTest(HardwareVisualizerDataContext db,
		TranscodeSubmission submission,
		CodecTest codecTest,
		int index,
		ModelStateDictionary modelStateDictionary)
	{
		Gpu selectedGpu = null;
		Cpu selectedCpu = null;

		if (codecTest.SelectedGpu is >= 0 && submission.Hwinfo.Gpu.Count >= codecTest.SelectedGpu)
		{
			selectedGpu = submission.Hwinfo.Gpu[codecTest.SelectedGpu.Value];
		}
		if (codecTest.SelectedCpu is >= 0)
		{
			selectedCpu = submission.Hwinfo.Cpu[codecTest.SelectedCpu.Value];
		}

		if (selectedCpu is null && selectedGpu is null)
		{
			modelStateDictionary.AddModelError($"{nameof(TranscodeSubmission.Tests)}[{index}].{nameof(CodecTest.SelectedCpu)}", "Either selected_cpu or selected_gpu must be set and reference an index in the list of cpus or gpus.");
			yield break;
		}

		var testReference = await db.TestCases.Include(testCase => testCase.MediaTestFile).FirstOrDefaultAsync(e => e.Id == codecTest.TestId);

		if (testReference is null)
		{
			modelStateDictionary.AddModelError($"{nameof(TranscodeSubmission.Tests)}[{index}].{nameof(CodecTest.TestId)}", "The provided Test ID does not relate to any known test id.");
			yield break;
		}

		yield return new HardwareSurveyEntry()
		{
			FromResolutionId = await GetOrAddResolution(db, testReference.FromResolution),
			ToResolutionId = await GetOrAddResolution(db, testReference.ToResolution),
			MaxStreams = codecTest.Results.MaxStreams,
			HardwareCodecId = await GetOrAddCodec(db, testReference.MediaTestFile.VideoCodec),
			GpuTypeId = selectedGpu is not null ? await GetOrAddGpuType(db, selectedGpu) : null,
			CpuTypeId = selectedCpu is not null ? await GetOrAddCpuType(db, selectedCpu) : null,
			Id = Guid.NewGuid(),
		};
	}

	private async Task<Guid> GetOrAddCodec(HardwareVisualizerDataContext db, string codecName)
	{
		var findCodec = db.HardwareCodecs.Local.FirstOrDefault(e => e.Identifier == codecName) 
		                ?? await db.HardwareCodecs.FirstOrDefaultAsync(e => e.Identifier == codecName);
		if (findCodec == null)
		{
			findCodec = new HardwareCodec() { Id = Guid.NewGuid(), Identifier = codecName, Name = codecName };
			db.HardwareCodecs.Add(findCodec);
		}
		return findCodec.Id;
	}

	private async Task<Guid> GetOrAddResolution(HardwareVisualizerDataContext db, string resolutionName)
	{
		var findResolution = db.TestResolutions.Local.FirstOrDefault(e => e.Identifier == resolutionName) ??
			await db.TestResolutions.FirstOrDefaultAsync(e => e.Identifier == resolutionName);
		if (findResolution == null)
		{
			findResolution = new TestResolution() { Id = Guid.NewGuid(), Identifier = resolutionName, Name = resolutionName };
			db.TestResolutions.Add(findResolution);
		}
		return findResolution.Id;
	}

	private async Task<Guid> GetOrAddGpuType(HardwareVisualizerDataContext db, Gpu gpu)
	{
		var findGpu = db.GpuTypes.Local.FirstOrDefault(e => e.Identifier == gpu.Product) ?? 
		              await db.GpuTypes.FirstOrDefaultAsync(e => e.Identifier == gpu.Product);
		if (findGpu is null)
		{
			findGpu = new GpuType()
			{
				Id = Guid.NewGuid(),
				Identifier = gpu.Product,
				Name = gpu.Product,
				Vendor = gpu.Vendor,
			};
			db.GpuTypes.Add(findGpu);
		}
		return findGpu.Id;
	}

	private async Task<Guid?> GetOrAddCpuType(HardwareVisualizerDataContext db, Cpu selectedCpu)
	{
		var findCpu = db.CpuTypes.Local.FirstOrDefault(e => e.Identifier == selectedCpu.Product) ?? 
		              await db.CpuTypes.FirstOrDefaultAsync(e => e.Identifier == selectedCpu.Product);
		if (findCpu is null)
		{
			findCpu = new CpuType()
			{
				Id = Guid.NewGuid(),
				Identifier = selectedCpu.Product,
				Name = selectedCpu.Product,
				Vendor = selectedCpu.Vendor,
			};
			db.CpuTypes.Add(findCpu);
		}
		return findCpu.Id;
	}
}