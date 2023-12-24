using System.Text.Json.Serialization;

namespace Jellyfin.HardwareVisualizer.Shared;

public class Hwinfo
{
	public Os os { get; set; }
	public Ffmpeg ffmpeg { get; set; }
	public List<Cpu> cpu { get; set; }
	public List<Memory> memory { get; set; }
	public List<Gpu> gpu { get; set; }

	[JsonPropertyName("selected_gpu")]
	public int? SelectedGpu { get; set; }

	[JsonPropertyName("selected_cpu")]
	public int? SelectedCpu { get; set; }
}