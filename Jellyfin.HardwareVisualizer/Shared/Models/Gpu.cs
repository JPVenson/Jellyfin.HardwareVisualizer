using System.ComponentModel.DataAnnotations;

namespace Jellyfin.HardwareVisualizer.Shared.Models;

public class Gpu
{
	public string? Id { get; set; }
	public string? Class { get; set; }
	public bool Claimed { get; set; }
	public string? Handle { get; set; }
	public string? Description { get; set; }
	[Required]
	public string Product { get; set; } = null!;
	[Required]
	public string Vendor { get; set; } = null!;
	public string? Physid { get; set; }
	public string? Businfo { get; set; }
	public string? Version { get; set; }
	public int? Width { get; set; }
	public int? Clock { get; set; }
	public Configuration? Configuration { get; set; }
	public Capabilities? Capabilities { get; set; }
}