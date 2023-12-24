using System.ComponentModel.DataAnnotations;
using System.Net;
using Jellyfin.HardwareVisualizer.Database;
using Jellyfin.HardwareVisualizer.Server.Services.Mapper;
using Jellyfin.HardwareVisualizer.Server.Services.Submission;
using Jellyfin.HardwareVisualizer.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Jellyfin.HardwareVisualizer.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubmissionApiController : ControllerBase
{
	private readonly ISubmissionService _submissionService;
	private readonly ILogger<SubmissionApiController> _logger;
	private readonly IMapperService _mapperService;

	public SubmissionApiController(ISubmissionService submissionService,
		ILogger<SubmissionApiController> logger,
		IMapperService mapperService)
	{
		_submissionService = submissionService;
		_logger = logger;
		_mapperService = mapperService;
	}
	
	[HttpPost()]
	[ProducesResponseType<string>(StatusCodes.Status200OK)]
	public async Task<IActionResult> Submit([FromBody, Required] TranscodeSubmission submission)
	{
		return Ok(await _submissionService.SubmitHardwareSurvey(submission));
	}
	
	[HttpPost("Recalc")]
	[ProducesResponseType(StatusCodes.Status200OK)]
	public async Task<IActionResult> Recalc()
	{
		await _submissionService.RecalcHardwareStats();
		return Ok();
	}

	[HttpGet("single/{Id}")]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType<HardwareSurveySubmission>(StatusCodes.Status200OK)]
	public async Task<IActionResult> GetSingleData([FromQuery] Guid id)
	{
		var data = await _submissionService.GetSingleSubmission(id);
		if (data is null)
		{
			return NotFound();
		}
		return Ok(data);
	}

	[HttpGet("")]
	[ProducesResponseType<IEnumerable<HardwareDisplayModel>>(StatusCodes.Status200OK)]
	public async Task<IActionResult> GetData([FromQuery, Required]string deviceId)
	{
		var data = await _submissionService.GetSubmissions(deviceId);
		return Ok(_mapperService.ViewModelMapper.Map<IEnumerable<HardwareDisplayModel>>(data));
	}
}