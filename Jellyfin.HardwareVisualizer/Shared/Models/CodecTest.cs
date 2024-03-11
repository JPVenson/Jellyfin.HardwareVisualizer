using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Jellyfin.HardwareVisualizer.Shared.Models;

public class CodecTest
{
	[JsonPropertyName("id")]
	[Required]
	public Guid TestId { get; set; }

	[JsonPropertyName("selected_gpu")]
	public int? SelectedGpu { get; set; } = null!;

	[JsonPropertyName("selected_cpu")]
	public int? SelectedCpu { get; set; } = null!;

	[JsonPropertyName("runs")]
	[Required]
	[MinLength(1)]
	public ICollection<WorkerResult> Runs { get; set; } = null!;

	[Required]
	public Results Results { get; set; } = null!;
}