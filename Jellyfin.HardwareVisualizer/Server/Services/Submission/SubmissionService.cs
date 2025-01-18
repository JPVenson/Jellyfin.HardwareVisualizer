using System.Text.Json;
using System.Text.Json.Serialization;
using Hangfire;
using Jellyfin.HardwareVisualizer.Server.Database;
using Jellyfin.HardwareVisualizer.Server.Services.HangfireServices;
using Jellyfin.HardwareVisualizer.Shared.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using ServiceLocator.Attributes;

namespace Jellyfin.HardwareVisualizer.Server.Services.Submission;

[ScopedService(typeof(ISubmissionService))]
public class SubmissionService : ISubmissionService
{
	private readonly IDbContextFactory<HardwareVisualizerDataContext> _dbContextFactory;
	private readonly IBackgroundJobClientFactory _backgroundJobClientFactory;
    private readonly JsonSerializerOptions _jsonSerializerSettings;

    public SubmissionService(IDbContextFactory<HardwareVisualizerDataContext> dbContextFactory,
		IBackgroundJobClientFactory backgroundJobClientFactory)
	{
		_dbContextFactory = dbContextFactory;
		_backgroundJobClientFactory = backgroundJobClientFactory;
        _jsonSerializerSettings = new JsonSerializerOptions()
			{
				PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
				Converters = { new JsonStringEnumConverter(JsonNamingPolicy.SnakeCaseLower, false) }
			};
    }

	public void BeginRecalcHardwareStats(Guid group)
	{
		_backgroundJobClientFactory.GetClient(JobStorage.Current)
			.Enqueue<RecalculateHardwareInfoJob>((job) => job.RecalcHardwareStats(group));
	}

	public async Task<string> SubmitHardwareSurvey(TranscodeSubmission submission,
		ModelStateDictionary modelStateDictionary)
	{
		await using var db = await _dbContextFactory.CreateDbContextAsync();

		var rawSubmission = new RawSurveySubmission()
		{
			Id = Guid.NewGuid(),
			Json = JsonSerializer.Serialize(submission, _jsonSerializerSettings)
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

		foreach (var entry in submissionEntity.HardwareSurveyEntry.GroupBy(e => e.CpuType?.Id ?? e.GpuType?.Id)
			         .Where(e => e.Key.HasValue).Select(f => f.Key))
		{
			BeginRecalcHardwareStats(entry.Value);
		}

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
			.Include(e => e.HardwareSurveyEntry.First().ToHardwareCodec)
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
			modelStateDictionary.AddModelError(
				$"{nameof(TranscodeSubmission.Tests)}[{index}].{nameof(CodecTest.SelectedCpu)}",
				"Either selected_cpu or selected_gpu must be set and reference an index in the list of cpus or gpus.");
			yield break;
		}

		var testReference = await db.TestCases.Include(testCase => testCase.MediaTestFile)
			.FirstOrDefaultAsync(e => e.Id == codecTest.TestId);

		if (testReference is null)
		{
			modelStateDictionary.AddModelError(
				$"{nameof(TranscodeSubmission.Tests)}[{index}].{nameof(CodecTest.TestId)}",
				"The provided Test ID does not relate to any known test id.");
			yield break;
		}

		yield return new HardwareSurveyEntry()
		{
			FromResolutionId = await GetOrAddResolution(db, testReference.FromResolution),
			ToResolutionId = await GetOrAddResolution(db, testReference.ToResolution),
			MaxStreams = codecTest.Results.MaxStreams,
			FromHardwareCodecId = testReference.MediaTestFile.VideoCodecId,
			ToHardwareCodecId = testReference.ToCodecId,
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
			findResolution = new TestResolution()
				{ Id = Guid.NewGuid(), Identifier = resolutionName, Name = resolutionName };
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