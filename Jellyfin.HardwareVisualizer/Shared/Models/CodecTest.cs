using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Jellyfin.HardwareVisualizer.Shared.Models;

public class CodecTest
{
	[JsonPropertyName("codec")]
	[Required]
	public string MediaCodec { get; set; }

	[JsonPropertyName("resolutions")]
	[Required]
	[MinLength(1)]
	public ICollection<ResolutionTest> ResolutionMap { get; set; }
}