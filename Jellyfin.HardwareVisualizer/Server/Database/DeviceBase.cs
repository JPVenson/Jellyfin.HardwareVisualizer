using System.ComponentModel.DataAnnotations;

namespace Jellyfin.HardwareVisualizer.Server.Database;

public class DeviceBase
{
	[Key] public Guid Id { get; set; }
	public string Name { get; set; }
	public string Identifier { get; set; }
	public string Vendor { get; set; }
}