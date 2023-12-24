using System.Text.Json.Serialization;

namespace Jellyfin.HardwareVisualizer.Shared.Models;

public class Capabilities
{
	[JsonExtensionData]
	public IDictionary<string, object> Values { get; set; }
}