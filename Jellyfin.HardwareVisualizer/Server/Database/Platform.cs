using System.ComponentModel.DataAnnotations;

namespace Jellyfin.HardwareVisualizer.Server.Database;

public class Platform
{
	[Key]
	public Guid Id { get; set; }
	public string Name { get; set; }
	public PlatformType Type { get; set; }
	public string Version { get; set; }
	public string VersionId { get; set; }
	public string DisplayName { get; set; }
	public string? ReplacementId { get; set; }
	public bool Supported { get; set; }
}