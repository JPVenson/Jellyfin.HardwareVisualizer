using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Jellyfin.HardwareVisualizer.Shared.Models;

public class CodecTest
{
	[JsonPropertyName("codec")]
	[Newtonsoft.Json.JsonProperty("codec")]
	[Required]
	public string MediaCodec { get; set; }

	[JsonPropertyName("selected_gpu")]
	[Newtonsoft.Json.JsonProperty("selected_gpu")]
	public int? SelectedGpu { get; set; } = null!;

	[JsonPropertyName("selected_cpu")]
	[Newtonsoft.Json.JsonProperty("selected_cpu")]
	public int? SelectedCpu { get; set; } = null!;

	[JsonPropertyName("resolutions")]
	[Newtonsoft.Json.JsonProperty("resolutions")]
	[Required]
	[MinLength(1)]
	public ICollection<ResolutionTest> ResolutionMap { get; set; }
}