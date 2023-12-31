using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Jellyfin.HardwareVisualizer.Shared.Models;
public class WorkerResult
{
	[Required]
	[JsonPropertyName("workers")]
	[Newtonsoft.Json.JsonProperty("workers")]
	public int Worker { get; set; }
	[Required]
	public int Frame { get; set; }
	[Required]
	public double Speed { get; set; }
	[Required]
	public double TimeS { get; set; }
	public double RssKb { get; set; }
}