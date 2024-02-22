namespace Jellyfin.HardwareVisualizer.Server.Database;

public class HardwareDisplay
{
	public DeviceType DeviceType { get; set; }
	public string DeviceName { get; set; }
	public string HardwareCodec { get; set; }
	public string FromResolution { get; set; } = null!;
	public string ToResolution { get; set; } = null!;

	public double MaxStreams { get; set; }
	public float Diviation { get; set; }
}