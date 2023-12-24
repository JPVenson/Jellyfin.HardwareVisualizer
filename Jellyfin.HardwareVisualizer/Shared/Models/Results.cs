using System.ComponentModel.DataAnnotations;

namespace Jellyfin.HardwareVisualizer.Shared.Models;

public class Results
{
	[Required]
	public int MaxStreams { get; set; }
	[Required]
	[MinLength(1)]
	public List<string> FailureReasons { get; set; }
	[Required]
	public double SingleWorkerSpeed { get; set; }
	public double SingleWorkerRssKb { get; set; }
}