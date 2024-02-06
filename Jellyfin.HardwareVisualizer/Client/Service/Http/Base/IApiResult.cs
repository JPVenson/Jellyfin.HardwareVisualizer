using Jellyfin.HardwareVisualizer.Shared.Models;
using System.Net;

namespace Jellyfin.HardwareVisualizer.Client.Service.Http.Base;

public interface IApiResult
{
	HttpStatusCode StatusCode { get; }
	bool Success { get; }
	string StatusMessage { get; }
	ProblemDetails ErrorResult { get; }
}