using Jellyfin.HardwareVisualizer.Database;
using Jellyfin.HardwareVisualizer.Shared;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ServiceLocator.Attributes;
using DeviceType = Jellyfin.HardwareVisualizer.Database.DeviceType;

namespace Jellyfin.HardwareVisualizer.Server.Services.Submission;

public interface ISubmissionService
{
	Task RecalcHardwareStats();
	Task<string> SubmitHardwareSurvey(TranscodeSubmission submission);
	Task<HardwareSurveySubmission?> GetSingleSubmission(Guid id);
	Task<HardwareDisplay[]> GetSubmissions(string deviceName);
	Task<CpuType[]> GetCpuRenderDevices();
	Task<GpuType[]> GetGpuRenderDevices();
}

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
					DeviceType = e.HardwareSurveySubmission.GpuType == null ? DeviceType.Cpu : DeviceType.Gpu,
					DeviceName = e.HardwareSurveySubmission.GpuType.Name ?? e.HardwareSurveySubmission.CpuType.Name,
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

	public async Task<string> SubmitHardwareSurvey(TranscodeSubmission submission)
	{
		await using var db = await _dbContextFactory.CreateDbContextAsync();

		var rawSubmission = new RawSurveySubmission()
		{
			Id = Guid.NewGuid(),
			Json = JsonConvert.SerializeObject(submission)
		};

		Gpu selectedGpu = null;
		Cpu selectedCpu = null;
		if (submission.hwinfo.SelectedGpu is >= 0 && submission.hwinfo.gpu.Count >= submission.hwinfo.SelectedGpu)
		{
			selectedGpu = submission.hwinfo.gpu[submission.hwinfo.SelectedGpu.Value];
		}
		if (submission.hwinfo.SelectedCpu is >= 0)
		{
			selectedCpu = submission.hwinfo.cpu[submission.hwinfo.SelectedCpu.Value];
		}

		if (selectedCpu is null && selectedGpu is null)
		{
			return null;
		}
		
		var submissionEntity = new HardwareSurveySubmission()
		{
			RawSurveySubmission = rawSubmission,
			GpuTypeId = selectedGpu is not null ? await GetOrAddGpuType(db, selectedGpu) : null,
			CpuTypeId = selectedCpu is not null ? await GetOrAddCpuType(db, selectedCpu) : null,
			Id = Guid.NewGuid(),
			HardwareSurveyEntry = new List<HardwareSurveyEntry>()
		};
		foreach (var fromCodec in submission.tests)
		{
			await foreach (var surveyEntry in GetResolutionTest(db, fromCodec))
			{
				submissionEntity.HardwareSurveyEntry.Add(surveyEntry);
			}
		}

		db.HardwareSurveySubmissions.Add(submissionEntity);

		await db.SaveChangesAsync(true);
		Task.Run(RecalcHardwareStats);
		return submissionEntity.Id.ToString();
	}

	private async Task<Guid?> GetOrAddCpuType(HardwareVisualizerDataContext db, Cpu selectedCpu)
	{
		var findCpu = await db.CpuTypes.FirstOrDefaultAsync(e => e.Identifier == selectedCpu.product);
		if (findCpu is null)
		{
			findCpu = new CpuType()
			{
				Id = Guid.NewGuid(),
				Identifier = selectedCpu.product,
				Name = selectedCpu.product,
				Vendor = selectedCpu.vendor,
			};
			db.CpuTypes.Add(findCpu);
		}
		return findCpu.Id;
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
			.Include(e => e.GpuType)
			.FirstOrDefaultAsync(e => e.Id == id);
	}

	private async IAsyncEnumerable<HardwareSurveyEntry> GetResolutionTest(HardwareVisualizerDataContext db,
		CodecTest arg)
	{
		foreach (var resolutionTest in arg.ResolutionMap)
		{
			yield return new HardwareSurveyEntry()
			{
				FromResolutionId = await GetOrAddResolution(db, resolutionTest.From),
				ToResolutionId = await GetOrAddResolution(db, resolutionTest.To),
				MaxStreams = resolutionTest.results.max_streams,
				HardwareCodecId = await GetOrAddCodec(db, arg.MediaCodec),
				Id = Guid.NewGuid(),
			};
		}
	}

	private async Task<Guid> GetOrAddCodec(HardwareVisualizerDataContext db, string codecName)
	{
		var findCodec = await db.HardwareCodecs.FirstOrDefaultAsync(e => e.Identifier == codecName);
		if (findCodec == null)
		{
			findCodec = new HardwareCodec() { Id = Guid.NewGuid(), Identifier = codecName, Name = codecName };
			db.HardwareCodecs.Add(findCodec);
		}
		return findCodec.Id;
	}

	private async Task<Guid> GetOrAddResolution(HardwareVisualizerDataContext db, string resolutionName)
	{
		var findResolution = await db.TestResolutions.FirstOrDefaultAsync(e => e.Identifier == resolutionName);
		if (findResolution == null)
		{
			findResolution = new TestResolution() { Id = Guid.NewGuid(), Identifier = resolutionName, Name = resolutionName };
			db.TestResolutions.Add(findResolution);
		}
		return findResolution.Id;
	}

	private async Task<Guid> GetOrAddGpuType(HardwareVisualizerDataContext db, Gpu gpu)
	{
		var findGpu = await db.GpuTypes.FirstOrDefaultAsync(e => e.Identifier == gpu.product);
		if (findGpu is null)
		{
			findGpu = new GpuType()
			{
				Id = Guid.NewGuid(),
				Identifier = gpu.product,
				Name = gpu.product,
				Vendor = gpu.vendor,
			};
			db.GpuTypes.Add(findGpu);
		}
		return findGpu.Id;
	}
}