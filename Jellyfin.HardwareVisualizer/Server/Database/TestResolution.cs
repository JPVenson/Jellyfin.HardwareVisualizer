using System.ComponentModel.DataAnnotations;

namespace Jellyfin.HardwareVisualizer.Server.Database;

public class TestResolution
{
	[Key] public Guid Id { get; set; }
	public string Name { get; set; }
	public string Identifier { get; set; }
}