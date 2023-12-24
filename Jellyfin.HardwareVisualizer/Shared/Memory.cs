namespace Jellyfin.HardwareVisualizer.Shared;

public class Memory
{
	public string id { get; set; }
	public string @class { get; set; }
	public bool claimed { get; set; }
	public string description { get; set; }
	public string physid { get; set; }
	public string units { get; set; }
	public long size { get; set; }
}