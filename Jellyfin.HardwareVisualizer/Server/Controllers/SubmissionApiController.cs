using System.ComponentModel.DataAnnotations;
using Jellyfin.HardwareVisualizer.Server.Database;
using Jellyfin.HardwareVisualizer.Server.Services.Mapper;
using Jellyfin.HardwareVisualizer.Server.Services.Submission;
using Jellyfin.HardwareVisualizer.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Newtonsoft.Json.Schema.Generation;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace Jellyfin.HardwareVisualizer.Server.Controllers;

/// <summary>
///		Api Controller for submitting or getting the results of an Hardware Survey.
/// </summary>
[ApiController]
[Route("api/v1/[controller]")]
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
	
	/// <summary>
	///		Posts a new Hardware Survey Result.
	///		Rate Limited to 1 call per hour.
	/// </summary>
	/// <param name="submission">A doc containing all set values for the hardware Survey.</param>
	/// <returns>The ID of the single hardware survey.</returns>
	[HttpPost()]
	[ProducesResponseType<string>(StatusCodes.Status200OK)]
	[EnableRateLimiting("fixed_submit")]
	public async Task<IActionResult> Submit([FromBody, Required] TranscodeSubmission submission)
	{
		return Ok(await _submissionService.SubmitHardwareSurvey(submission, base.ModelState));
	}

	[HttpGet("submitSchema")]
	[ProducesResponseType<string>(StatusCodes.Status200OK)]
	public async Task<IActionResult> GetJsonSubmitSchema()
	{
		var jSchemaGenerator = new JSchemaGenerator();
		jSchemaGenerator.DefaultRequired = Required.DisallowNull;
		jSchemaGenerator.ContractResolver = new DefaultContractResolver()
		{
			NamingStrategy = new SnakeCaseNamingStrategy(true, true, true)
		};
		return Ok(jSchemaGenerator.Generate(typeof(TranscodeSubmission)).ToString());
	}


	/// <summary>
	///		Gets the Hardware Survey result of a single submission.
	/// </summary>
	/// <param name="id">The id as returned by <code>POST /</code></param>
	/// <returns></returns>
	[HttpGet("single/{Id}")]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType<HardwareSurveySubmission>(StatusCodes.Status200OK)]
	[EnableRateLimiting("fixed_metadata")]
	public async Task<IActionResult> GetSingleData([FromQuery] Guid id)
	{
		var data = await _submissionService.GetSingleSubmission(id);
		if (data is null)
		{
			return NotFound();
		}
		return Ok(data);
	}

	/// <summary>
	///		Gets a set of aggregated data points of all submissions for the given <see cref="deviceId"/>
	/// </summary>
	/// <param name="deviceId"></param>
	/// <returns></returns>
	[HttpGet("")]
	[ProducesResponseType<IEnumerable<HardwareDisplayModel>>(StatusCodes.Status200OK)]
	[EnableRateLimiting("fixed_metadata")]
	public async Task<IActionResult> GetData([FromQuery, Required]string deviceId)
	{
		var data = await _submissionService.GetSubmissions(deviceId);
		return Ok(_mapperService.ViewModelMapper.Map<IEnumerable<HardwareDisplayModel>>(data));
	}
}