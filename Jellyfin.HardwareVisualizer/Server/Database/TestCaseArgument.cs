using System.ComponentModel.DataAnnotations;

namespace Jellyfin.HardwareVisualizer.Server.Database;

public record TestCaseArgument
{
	[Key] public Guid Id { get; set; }
	public string FfmpegArgument { get; set; }
	public TestCaseArgumentDeviceType TestCaseArgumentDeviceType { get; set; }

	public Guid FfmpegVersionGroupId { get; set; }

	public Guid HardwareCodecId { get; set; }
	public HardwareCodec HardwareCodec { get; set; }
}