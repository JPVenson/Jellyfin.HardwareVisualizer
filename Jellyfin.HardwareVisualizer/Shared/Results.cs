namespace Jellyfin.HardwareVisualizer.Shared;

public class Results
{
	public int max_streams { get; set; }
	public List<string> failure_reasons { get; set; }
	public double single_worker_speed { get; set; }
	public double single_worker_rss_kb { get; set; }
}