using System.Text.Json.Serialization;

namespace Jellyfin.HardwareVisualizer.Shared;

public class ResolutionTest
{
	[JsonPropertyName("scale_from")]
	public string From { get; set; }
	[JsonPropertyName("scale_to")]
	public string To { get; set; }
	[JsonPropertyName("runs")]
	public ICollection<WorkerResult> Runs { get; set; }
	public Results results { get; set; }
}