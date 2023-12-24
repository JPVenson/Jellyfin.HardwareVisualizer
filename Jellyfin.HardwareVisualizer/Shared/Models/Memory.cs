using System.ComponentModel.DataAnnotations;

namespace Jellyfin.HardwareVisualizer.Shared.Models;

public class Memory
{
	public string? Id { get; set; }
	public string? Class { get; set; }
	public bool Claimed { get; set; }
	public string? Description { get; set; }
	public string? Physid { get; set; }
	[Required] public string Units { get; set; } = null!;

	[Required] public long Size { get; set; }
}