namespace Jellyfin.HardwareVisualizer.Shared;

public class Gpu
{
	public string id { get; set; }
	public string @class { get; set; }
	public bool claimed { get; set; }
	public string handle { get; set; }
	public string description { get; set; }
	public string product { get; set; }
	public string vendor { get; set; }
	public string physid { get; set; }
	public string businfo { get; set; }
	public string version { get; set; }
	public int width { get; set; }
	public int clock { get; set; }
	public Configuration configuration { get; set; }
	public Capabilities capabilities { get; set; }
}