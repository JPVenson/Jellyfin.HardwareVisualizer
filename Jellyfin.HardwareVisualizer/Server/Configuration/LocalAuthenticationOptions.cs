using ServiceLocator.Discovery.Option;

namespace Jellyfin.HardwareVisualizer.Server.Configuration;

[FromConfig("Auth")]
public class LocalAuthenticationOptions
{
	public string Authority { get; set; }
	public SwaggerAuthOptions Swagger { get; set; }
	
}