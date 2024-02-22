using Jellyfin.HardwareVisualizer.Server.Database;
using Jellyfin.HardwareVisualizer.Server.Services.Mapper;
using Jellyfin.HardwareVisualizer.Shared.Models;
using Microsoft.EntityFrameworkCore;
using ServiceLocator.Attributes;
using TestCaseType = Jellyfin.HardwareVisualizer.Shared.Models.TestCaseType;

namespace Jellyfin.HardwareVisualizer.Server.Services.TestData;

[SingletonService()]
public class TestDataService
{
	private readonly IDbContextFactory<HardwareVisualizerDataContext> _dbFactory;
	private readonly IMapperService _mapperService;

	public TestDataService(IDbContextFactory<HardwareVisualizerDataContext> dbFactory, IMapperService mapperService)
	{
		_dbFactory = dbFactory;
		_mapperService = mapperService;
	}

	public async Task<Platform[]> GetPlatforms(CancellationToken stopToken)
	{
		var hardwareVisualizerDataContext = (await _dbFactory.CreateDbContextAsync(stopToken));
		return await hardwareVisualizerDataContext.Platform.ToArrayAsync(stopToken);
	}

	public async Task<TestDataRequestModel?> GetTestDataFor(Guid platformId, CancellationToken cancellationToken)
	{
		var db = await _dbFactory.CreateDbContextAsync(cancellationToken).ConfigureAwait(false);
		var ffmpegForPlatform = await db.FfmpegVersions.FirstOrDefaultAsync(e => e.PlatformId == platformId, cancellationToken).ConfigureAwait(false);

		if (ffmpegForPlatform is null)
		{
			return null;
		}

		var testFiles = await db.MediaTestFiles.Include(e => e.TestCases).ToArrayAsync(cancellationToken);
		var testArguments = await db.TestCaseArguments.Include(testCaseArgument => testCaseArgument.HardwareCodec).ToArrayAsync(cancellationToken);

		var model = new TestDataRequestModel();
		model.Ffmpeg = _mapperService.ViewModelMapper.Map<FfmpegModel>(ffmpegForPlatform);

		var tests = new List<TestCaseModel>();
		foreach (var mediaTestFile in testFiles)
		{
			var testCaseModel = new TestCaseModel()
			{
				Name = mediaTestFile.Name,
				TestType = TestCaseType.Transcode,
				SourceUrl = mediaTestFile.SourceUrl
			};

			var testCases = new List<TestCaseDataModel>();
			foreach (var testCase in mediaTestFile.TestCases)
			{
				var caseModel = _mapperService.ViewModelMapper.Map<TestCaseDataModel>(testCase);
				caseModel.Arguments = testArguments.Select(testCaseArgument => new FfmpegArgumentsModel()
					{
						Codec = testCaseArgument.HardwareCodec.Identifier,
						Type = (FfmpegArgumentDeviceType)testCaseArgument.TestCaseArgumentDeviceType,
						Args = testCaseArgument.FfmpegArgument.Replace("{scale}", mediaTestFile.Size.ToString())
							.Replace("{bitrate}", caseModel.Bitrate.ToString())
					})
					.ToList();
				testCases.Add(caseModel);
			}

			testCaseModel.Data = testCases;
			tests.Add(testCaseModel);
		}

		model.Tests = tests;
		return model;

	}
}