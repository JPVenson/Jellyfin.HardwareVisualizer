using Jellyfin.HardwareVisualizer.Database;
using Jellyfin.HardwareVisualizer.Server.Services.Mapper;
using Jellyfin.HardwareVisualizer.Server.Services.Submission;
using Jellyfin.HardwareVisualizer.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Jellyfin.HardwareVisualizer.Server.Controllers;

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

	[HttpGet("")]
	[ProducesResponseType<IEnumerable<RenderDeviceViewModel>>(StatusCodes.Status200OK)]
	public async Task<IActionResult> GetDevices()
	{
		var cpuTypes = await _submissionService.GetCpuRenderDevices();
		var gpuTypes = await _submissionService.GetGpuRenderDevices();
		return Ok(_mapperService.ViewModelMapper.Map<IEnumerable<RenderDeviceViewModel>>(cpuTypes).Concat(_mapperService.ViewModelMapper.Map<IEnumerable<RenderDeviceViewModel>>(gpuTypes)));
	}
}