using System.ComponentModel.DataAnnotations;

namespace Jellyfin.HardwareVisualizer.Server.Database;

public class HardwareSurveySubmission
{
	[Key] public Guid Id { get; set; }

	public ICollection<HardwareSurveyEntry> HardwareSurveyEntry { get; set; } = null!;

	public Guid RawSurveySubmissionId { get; set; }
	public RawSurveySubmission RawSurveySubmission { get; set; }
}