using ServiceLocator.Discovery.Option;

namespace Jellyfin.HardwareVisualizer.Server.Configuration;

[FromConfig("GH")]
public class GithubOauthOptions
{
	public string ClientSecret { get; set; }
	public string ClientId { get; set; }
}