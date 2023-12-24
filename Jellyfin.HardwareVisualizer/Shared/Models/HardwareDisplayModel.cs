namespace Jellyfin.HardwareVisualizer.Shared.Models;

public class HardwareDisplayModel
{
	public DeviceType DeviceType { get; set; }
	public string DeviceName { get; set; }
	public string HardwareCodec { get; set; }
	public string FromResolution { get; set; } = null!;
	public string ToResolution { get; set; } = null!;

	public int MaxStreams { get; set; }
	public float Diviation { get; set; }
}

public enum DeviceType
{
	Cpu,
	Gpu,
}

public class RenderDeviceViewModel
{
	public Guid Id { get; set; }
	public string Name { get; set; }
	public string Identifier { get; set; }
	public string Vendor { get; set; }
	public DeviceType DeviceType { get; set; }
}