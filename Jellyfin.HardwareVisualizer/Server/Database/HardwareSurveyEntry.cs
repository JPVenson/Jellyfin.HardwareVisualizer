using System.ComponentModel.DataAnnotations;

namespace Jellyfin.HardwareVisualizer.Server.Database;

public class HardwareSurveyEntry
{
	[Key] public Guid Id { get; set; }
	public Guid HardwareCodecId { get; set; }
	public HardwareCodec HardwareCodec { get; set; }


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
}