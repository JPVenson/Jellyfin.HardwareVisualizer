using System.ComponentModel.DataAnnotations;
using Jellyfin.HardwareVisualizer.Server.Database;
using Jellyfin.HardwareVisualizer.Server.Services.Mapper;
using Jellyfin.HardwareVisualizer.Server.Services.Submission;
using Jellyfin.HardwareVisualizer.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Jellyfin.HardwareVisualizer.Server.Services.SubmitToken;
using Microsoft.Extensions.Primitives;

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
	private readonly ISubmitTokenService _submitTokenService;
	private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly IJsonSubmitSchemaService _jsonSubmitSchemaService;

	public SubmissionApiController(ISubmissionService submissionService,
		ILogger<SubmissionApiController> logger,
		IMapperService mapperService,
		ISubmitTokenService submitTokenService,
		IHttpContextAccessor httpContextAccessor,
		IJsonSubmitSchemaService jsonSubmitSchemaService)
	{
		_submissionService = submissionService;
		_logger = logger;
		_mapperService = mapperService;
		_submitTokenService = submitTokenService;
		_httpContextAccessor = httpContextAccessor;
		_jsonSubmitSchemaService = jsonSubmitSchemaService;
	}
	
	/// <summary>
	///		Posts a new Hardware Survey Result.
	///		Rate Limited to 1 call per hour.
	/// </summary>
	/// <param name="submission">A doc containing all set values for the hardware Survey.</param>
	/// <returns>The ID of the single hardware survey.</returns>
	[HttpPost()]
	[ProducesResponseType<string>(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status401Unauthorized)]
	//[EnableRateLimiting("fixed_submit")]
	public async Task<IActionResult> Submit([Required, FromBody]TranscodeSubmission submission)
	{
		var token = _submitTokenService.ReadToken(submission.Token);

		if (token is null)
		{
			return BadRequest("No valid submit token provided");
		}

		if (token.ValidTo <= DateTime.UtcNow)
		{
			return Unauthorized();
		}

		if (token.Claims.FirstOrDefault(e => e.Type == "ip")?.Value !=
		    _httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString())
		{
			return Unauthorized();
		}

		if (!_submitTokenService.Validate(token, out var retry))
		{
			Response.Headers.RetryAfter = new StringValues(retry.Value.Seconds.ToString());
			return Unauthorized();
		}

		var submitHardwareSurvey = await _submissionService.SubmitHardwareSurvey(submission, base.ModelState);
		if (submitHardwareSurvey is not null)
		{
			_submitTokenService.RedeemToken(token);
		}
		return Ok(submitHardwareSurvey);
	}

	/// <summary>
	///		Gets the JSON schema to submit data.
	/// </summary>
	/// <returns></returns>
	[HttpGet("submitSchema")]
	[ProducesResponseType<string>(StatusCodes.Status200OK)]
	[ResponseCache(Duration = 3600)]
	public async Task<IActionResult> GetJsonSubmitSchema()
	{
		return Ok(_jsonSubmitSchemaService.GetSubmitSchema());
	}


	/// <summary>
	///		Gets the Hardware Survey result of a single submission.
	/// </summary>
	/// <param name="id">The id as returned by <code>POST /</code></param>
	/// <returns></returns>
	[HttpGet("single/{Id}")]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesResponseType<HardwareSurveySubmission>(StatusCodes.Status200OK)]
	//[EnableRateLimiting("fixed_metadata")]
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
	//[EnableRateLimiting("fixed_metadata")]
	public async Task<IActionResult> GetData([FromQuery, Required]string deviceId)
	{
		var data = await _submissionService.GetSubmissions(deviceId);
		return Ok(_mapperService.ViewModelMapper.Map<IEnumerable<HardwareDisplayModel>>(data));
	}

	
#if DEBUG
/// <summary>
	///		Gets a set of aggregated data points of all submissions for the given <see cref="deviceId"/>
	/// </summary>
	/// <param name="deviceId"></param>
	/// <returns></returns>
	[HttpGet("Recalc")]
	//[EnableRateLimiting("fixed_metadata")]
	public IActionResult Recalc([FromQuery, Required]Guid groupId)
	{
		_submissionService.BeginRecalcHardwareStats(groupId);
		return Ok();
	}	
#endif
	
}