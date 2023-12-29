using Jellyfin.HardwareVisualizer.Database;
using Jellyfin.HardwareVisualizer.Shared.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Jellyfin.HardwareVisualizer.Server.Services.Submission;

public interface ISubmissionService
{
	Task RecalcHardwareStats();
	Task<string> SubmitHardwareSurvey(TranscodeSubmission submission, ModelStateDictionary modelStateDictionary);
	Task<HardwareSurveySubmission?> GetSingleSubmission(Guid id);
	Task<HardwareDisplay[]> GetSubmissions(string deviceName);
	Task<CpuType[]> GetCpuRenderDevices();
	Task<GpuType[]> GetGpuRenderDevices();
}