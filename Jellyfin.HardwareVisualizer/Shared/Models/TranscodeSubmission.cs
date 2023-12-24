using System.ComponentModel.DataAnnotations;

namespace Jellyfin.HardwareVisualizer.Shared.Models;

public class TranscodeSubmission
{
	[Required]
	public Hwinfo Hwinfo { get; set; }
	[Required]
	[MinLength(1)]
	public ICollection<CodecTest> Tests { get; set; }
}