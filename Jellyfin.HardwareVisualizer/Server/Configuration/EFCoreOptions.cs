using ServiceLocator.Discovery.Option;

namespace Jellyfin.HardwareVisualizer.Server.Configuration;

[FromConfig("GH")]
public class GithubOauthOptions
{
	public string ClientSecret { get; set; }
	public string ClientId { get; set; }
}

[FromConfig("Auth")]
public class LocalAuthenticationOptions
{
	public string Authority { get; set; }
	public SwaggerAuthOptions Swagger { get; set; }
	
}

public class SwaggerAuthOptions
{
	public string AuthorizationUrl { get; set; }
	public string Authority { get; set; }

}

[FromConfig("PG")]
public class EFCoreOptions
{
	public string User { get; set; }
	public string Password { get; set; }
	public string Host { get; set; }
	public int Port { get; set; }
	public string Database { get; set; }
}