using Jellyfin.HardwareVisualizer.Database;
using Jellyfin.HardwareVisualizer.Shared.Models;

namespace Jellyfin.HardwareVisualizer.Server.Services.Submission;

public interface ISubmissionService
{
	Task RecalcHardwareStats();
	Task<string> SubmitHardwareSurvey(TranscodeSubmission submission);
	Task<HardwareSurveySubmission?> GetSingleSubmission(Guid id);
	Task<HardwareDisplay[]> GetSubmissions(string deviceName);
	Task<CpuType[]> GetCpuRenderDevices();
	Task<GpuType[]> GetGpuRenderDevices();
}