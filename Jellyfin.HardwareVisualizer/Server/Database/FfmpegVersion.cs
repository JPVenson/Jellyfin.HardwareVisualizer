using System.ComponentModel.DataAnnotations;

namespace Jellyfin.HardwareVisualizer.Server.Database;

public class FfmpegVersion : HashedExternalEntity
{
	[Key] public Guid Id { get; set; }

	public string Source { get; set; }
	public string Version { get; set; }
	public Guid VersionGroup { get; set; }

	public Guid PlatformId { get; set; }
	public Platform Platform { get; set; }

	public ICollection<TestCaseArgument> TestCaseArguments { get; set; }
}