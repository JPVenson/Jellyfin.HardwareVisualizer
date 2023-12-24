namespace Jellyfin.HardwareVisualizer.Shared;

public class Cpu
{
	public string id { get; set; }
	public string @class { get; set; }
	public bool claimed { get; set; }
	public string product { get; set; }
	public string vendor { get; set; }
	public string physid { get; set; }
	public string businfo { get; set; }
	public string units { get; set; }
	public int size { get; set; }
	public long capacity { get; set; }
	public int width { get; set; }
	public Capabilities capabilities { get; set; }
}