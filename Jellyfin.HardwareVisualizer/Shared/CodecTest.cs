using System.Text.Json.Serialization;

namespace Jellyfin.HardwareVisualizer.Shared;

public class CodecTest
{
	[JsonPropertyName("codec")]
	public string MediaCodec { get; set; }
	[JsonPropertyName("resolutions")]

	public ICollection<ResolutionTest> ResolutionMap { get; set; }
}