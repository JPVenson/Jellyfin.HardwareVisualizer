using System.Text.Json.Serialization;

namespace Jellyfin.HardwareVisualizer.Shared.Models;

public class Configuration
{
	[JsonPropertyName("driver")]
	public string? Driver { get; set; }
	[JsonPropertyName("latency")]
	public string? Latency { get; set; }
}