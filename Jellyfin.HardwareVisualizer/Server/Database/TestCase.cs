using System.ComponentModel.DataAnnotations;

namespace Jellyfin.HardwareVisualizer.Server.Database;

public class TestCase
{
	[Key] public Guid Id { get; set; }

	public Guid MediaTestFileId { get; set; }
	public MediaTestFile MediaTestFile { get; set; }
	public TestCaseType TestCaseType { get; set; }

	public string FromResolution { get; set; }
	public string ToResolution { get; set; }
	public long Bitrate { get; set; }

}