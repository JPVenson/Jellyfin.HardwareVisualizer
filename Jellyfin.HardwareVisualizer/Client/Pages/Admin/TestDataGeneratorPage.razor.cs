using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Jellyfin.HardwareVisualizer.Client.Service.Http;
using Jellyfin.HardwareVisualizer.Client.Service.Http.Base;
using Jellyfin.HardwareVisualizer.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Jellyfin.HardwareVisualizer.Client.Pages.Admin;

public partial class TestDataGeneratorPage
{
	[Inject] public HttpService HttpService { get; set; }
	[Inject] public JsonSerializerOptions JsonSerializerOptions { get; set; }

	public List<SupportedPlatform> Platforms { get; set; }

	public SupportedPlatform SelectedPlatform { get; set; }

	public string TestData { get; set; }

	public string Seed { get; set; } = "1337";

	protected override async Task OnInitializedAsync()
	{
		Platforms = (await HttpService.TestDataApiAccessor.GetPlatforms().Unpack().ConfigureAwait(false)).Platforms
			.ToList();
		SelectedPlatform = Platforms.First();
	}

	public async Task GenerateTestData()
	{
		var testData = await HttpService.TestDataApiAccessor.GetTestData(SelectedPlatform.Id).Unpack();
		var submission = new TranscodeSubmission();
		submission.Token = testData.Token;
		submission.Hwinfo = new Hwinfo()
		{
			Ffmpeg = new Ffmpeg()
			{
				Version = testData.Ffmpeg.FfmpegVersion,
				Path = testData.Ffmpeg.FfmpegSourceUrl
			},
			Cpu =
			[
				new Cpu()
				{
					Product = "Generic Test CPU",
					Vendor = "Intel"
				}
			],
			Gpu =
			[
				new Gpu()
				{
					Product = "Generic Test GPU",
					Vendor = "Intel",
				}
			],
			Memory =
			[
				new Memory()
				{
					Size = 1337000,
					Units = "b"
				}
			],
			Os = new Os()
			{
				Name = "Test OS",
				Id = "TestOS",
				PrettyName = "TestOS",
				VersionCodename = "TEstOS",
				VersionId = "1",
				Version = "TestVersion"
			}
		};

		var random = new Random(Encoding.UTF8.GetBytes(Seed).Sum(e => (int)e));

		submission.Tests = new List<CodecTest>();
		foreach (var test in testData.Tests)
		{
			var next = random.Next(7);

			foreach (var testCaseDataModel in test.Data)
			{
				submission.Tests.Add(new CodecTest()
				{
					TestId = testCaseDataModel.Id,
					SelectedCpu = 0,
					Results = new Results()
					{
						FailureReasons = ["performance"],
						MaxStreams = next,
						SingleWorkerRssKb = 0,
						SingleWorkerSpeed = 1
					},
					Runs = Enumerable.Range(1, 1).Select(e => new WorkerResult()
					{
						Frame = 500,
						RssKb = 500,
						Speed = 2,
						TimeS = 60,
						Worker = next
					}).ToArray()
				});
				next = random.Next(next, next * 2);
				submission.Tests.Add(new CodecTest()
				{
					TestId = testCaseDataModel.Id,
					SelectedGpu = 0,
					Results = new Results()
					{
						FailureReasons = ["performance"],
						MaxStreams = next,
						SingleWorkerRssKb = 0,
						SingleWorkerSpeed = 1
					},
					Runs = Enumerable.Range(1, 1).Select(e => new WorkerResult()
					{
						Frame = 500,
						RssKb = 500,
						Speed = 2,
						TimeS = 60,
						Worker = next
					}).ToArray()
				});
			}
		}
		using var output = new MemoryStream();
		await JsonSerializer.SerializeAsync(output, submission, new JsonSerializerOptions(JsonSerializerOptions)
		{
			DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
		});

		TestData = Encoding.ASCII.GetString(output.ToArray());
		StateHasChanged();
	}
}