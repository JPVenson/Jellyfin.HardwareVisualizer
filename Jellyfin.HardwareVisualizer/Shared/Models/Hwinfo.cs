using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Jellyfin.HardwareVisualizer.Shared.Models;

public class Hwinfo
{
	[Required]
	public Os Os { get; set; } = null!;
	public Ffmpeg Ffmpeg { get; set; } = null!;

	[Required]
	[MinLength(1)]
	public List<Cpu> Cpu { get; set; } = null!;

	[Required]
	[MinLength(1)]
	public List<Memory> Memory { get; set; } = null!;
	public List<Gpu> Gpu { get; set; } = null!;
}