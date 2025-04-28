namespace Jellyfin.HardwareVisualizer.Server.Database;
using System.ComponentModel;

public enum PlatformType
{
	Windows,
	Linux,
	[Description("Darwin")]
	Mac
}