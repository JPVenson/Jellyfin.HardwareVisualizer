using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Jellyfin.HardwareVisualizer.Shared.Models;

public class ResolutionTest
{
	[JsonPropertyName("scale_from")]
	[Newtonsoft.Json.JsonProperty("scale_from")]
	[Required]
	public string From { get; set; } = null!;

	[JsonPropertyName("scale_to")]
	[Newtonsoft.Json.JsonProperty("scale_to")]
	[Required]
	public string To { get; set; } = null!;

	[JsonPropertyName("runs")]
	[Newtonsoft.Json.JsonProperty("runs")]
	[Required]
	[MinLength(1)]
	public ICollection<WorkerResult> Runs { get; set; } = null!;

	[Required]
	public Results Results { get; set; } = null!;
}