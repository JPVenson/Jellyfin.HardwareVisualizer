using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Jellyfin.HardwareVisualizer.Shared.Models;

public class Os
{
	[Required]
	public string PrettyName { get; set; }
	[Required]
	public string Name { get; set; }
	[Required]
	public string VersionId { get; set; }
	[Required]
	public string Version { get; set; }
	[Required]
	public string VersionCodename { get; set; }
	[Required]
	public string Id { get; set; }
	public string? HomeUrl { get; set; }
	public string? SupportUrl { get; set; }
	public string? BugReportUrl { get; set; }
	public string? Codename { get; set; }
}