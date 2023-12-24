using Jellyfin.HardwareVisualizer.Database;
using Jellyfin.HardwareVisualizer.Server.Services.Mapper;
using Jellyfin.HardwareVisualizer.Server.Services.Submission;
using Jellyfin.HardwareVisualizer.Shared;
using Jellyfin.HardwareVisualizer.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jellyfin.HardwareVisualizer.Server.Controllers;

/// <summary>
///		Provides lookup values for device data.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class DeviceApiController : ControllerBase
{

	private readonly ISubmissionService _submissionService;
	private readonly ILogger<DeviceApiController> _logger;
	private readonly IMapperService _mapperService;

	public DeviceApiController(ISubmissionService submissionService,
		ILogger<DeviceApiController> logger,
		IMapperService mapperService)
	{
		_submissionService = submissionService;
		_logger = logger;
		_mapperService = mapperService;
	}

	/// <summary>
	///		Gets a list of CPU and GPU render devices that were submitted.
	/// </summary>
	/// <returns></returns>
	[HttpGet("")]
	[ResponseCache(VaryByHeader = "User-Agent", Duration = 60)]
	[ProducesResponseType<IEnumerable<RenderDeviceViewModel>>(StatusCodes.Status200OK)]
	public async Task<IActionResult> GetDevices()
	{
		var cpuTypes = await _submissionService.GetCpuRenderDevices();
		var gpuTypes = await _submissionService.GetGpuRenderDevices();
		return Ok(_mapperService.ViewModelMapper.Map<IEnumerable<RenderDeviceViewModel>>(cpuTypes).Concat(_mapperService.ViewModelMapper.Map<IEnumerable<RenderDeviceViewModel>>(gpuTypes)));
	}
}