using System.ComponentModel.DataAnnotations;

namespace Jellyfin.HardwareVisualizer.Server.Database;

public class HardwareSurveyEntry
{
	[Key] public Guid Id { get; set; }
	public Guid FromHardwareCodecId { get; set; }
	public HardwareCodec FromHardwareCodec { get; set; }
	public Guid ToHardwareCodecId { get; set; }
	public HardwareCodec ToHardwareCodec { get; set; }


	public Guid? GpuTypeId { get; set; }
	public GpuType? GpuType { get; set; } = null!;

	public Guid? CpuTypeId { get; set; }
	public CpuType? CpuType { get; set; } = null!;

	public Guid HardwareSurveySubmissionId { get; set; }
	public HardwareSurveySubmission HardwareSurveySubmission { get; set; } = null!;

	public Guid FromResolutionId { get; set; }
	public TestResolution FromResolution { get; set; } = null!;
	public Guid ToResolutionId { get; set; }
	public TestResolution ToResolution { get; set; } = null!;

	public int MaxStreams { get; set; }

	public bool Processed { get; set; }
}