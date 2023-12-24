namespace Jellyfin.HardwareVisualizer.Shared;
public class WorkerResult
{
	public int Worker { get; set; }
	public int frame { get; set; }
	public double speed { get; set; }
	public double time_s { get; set; }
	public double rss_kb { get; set; }
}