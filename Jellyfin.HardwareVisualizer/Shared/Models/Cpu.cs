using System.Text.Json.Serialization;

namespace Jellyfin.HardwareVisualizer.Shared.Models;

public class Cpu
{
	public string? Id { get; set; }
	public string? Class { get; set; }
	public bool Claimed { get; set; }
	public string Product { get; set; } = null!;
	public string Vendor { get; set; } = null!;
	public string? Physid { get; set; }
	public string? Businfo { get; set; }
	public string? Units { get; set; }
	public int? Size { get; set; }
	public long? Capacity { get; set; }
	public int? Width { get; set; }
	public Capabilities? Capabilities { get; set; }
}