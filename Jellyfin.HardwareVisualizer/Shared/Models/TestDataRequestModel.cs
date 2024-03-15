namespace Jellyfin.HardwareVisualizer.Shared.Models;

public class PlatformData
{
	public SupportedPlatform[] Platforms { get; set; }
}

public class SupportedPlatform
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public string Type { get; set; }
	public string Version { get; set; }
	public string VersionId { get; set; }
	public string DisplayName { get; set; }
	public string ReplacementId { get; set; }
	public bool Supported { get; set; }
}

public class TestDataRequestModel
{
	public string Token { get; set; }

	public FfmpegModel Ffmpeg { get; set; }

	public IEnumerable<TestCaseModel> Tests { get; set; }

}

public class FfmpegModel
{
	public string FfmpegSourceUrl { get; set; }
	public string FfmpegVersion { get; set; }
	public IEnumerable<ExternalFileHashModel> FfmpegHashs { get; set; }
}

public class TestCaseModel
{
	public string Name { get; set; }
	public string SourceUrl { get; set; }
	public IEnumerable<ExternalFileHashModel> SourceHashs { get; set; }
	public TestCaseType TestType { get; set; }
	public IEnumerable<TestCaseDataModel> Data { get; set; }

}

public class TestCaseDataModel
{
	public string Id { get; set; }
	public string FromResolution { get; set; }
	public string ToResolution { get; set; }
	public long Bitrate { get; set; }

	public IEnumerable<FfmpegArgumentsModel> Arguments { get; set; }
}

public class FfmpegArgumentsModel
{
	public FfmpegArgumentDeviceType Type { get; set; }
	public string Args { get; set; }
	public string Codec { get; set; }
}

public enum FfmpegArgumentDeviceType
{
	Cpu,
	Nvidia,
	Amd,
	Intel
}

public enum TestCaseType
{
	Transcode
}

public class ExternalFileHashModel
{
	public string Type { get; set; }
	public string Hash { get; set; }
}