using ServiceLocator.Discovery.Option;

namespace Jellyfin.HardwareVisualizer.Server.Configuration;

[FromConfig("PG")]
public class EFCoreOptions
{
	public string User { get; set; }
	public string Password { get; set; }
	public string Host { get; set; }
	public int Port { get; set; }
	public string Database { get; set; }
}