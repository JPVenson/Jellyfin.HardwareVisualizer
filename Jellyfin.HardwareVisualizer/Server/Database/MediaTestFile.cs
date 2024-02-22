using System.ComponentModel.DataAnnotations;

namespace Jellyfin.HardwareVisualizer.Server.Database;

public class MediaTestFile : HashedExternalEntity
{
	[Key] public Guid Id { get; set; }

	public string? Name { get; set; }
	public string SourceUrl { get; set; }

	public long Bitrate { get; set; }
	public long Size { get; set; }
	public string VideoCodec { get; set; }
	public string AudioCodec { get; set; }

	public ICollection<TestCase> TestCases { get; set; }
}