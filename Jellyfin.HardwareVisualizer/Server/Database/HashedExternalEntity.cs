namespace Jellyfin.HardwareVisualizer.Server.Database;

public class HashedExternalEntity
{
	public string? HashMd5 { get; set; }
	public string? HashSha256 { get; set; }
}