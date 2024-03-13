using Jellyfin.HardwareVisualizer.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using System.ComponentModel.DataAnnotations;
using Jellyfin.HardwareVisualizer.Server.Services.Mapper;
using Jellyfin.HardwareVisualizer.Server.Services.TestData;
using Jellyfin.HardwareVisualizer.Server.Services.SubmitToken;

namespace Jellyfin.HardwareVisualizer.Server.Controllers;

/// <summary>
///		Controller for obtaining all relevant data to run a Benchmark.
/// </summary>
[ApiController]
[Route("api/v1/[controller]")]
public class TestDataApiController : ControllerBase
{
	private readonly TestDataService _testDataService;
	private readonly IMapperService _mapperService;
	private readonly ISubmitTokenService _submitTokenService;

	public TestDataApiController(TestDataService testDataService, 
		IMapperService mapperService,
		ISubmitTokenService submitTokenService)
	{
		_testDataService = testDataService;
		_mapperService = mapperService;
		_submitTokenService = submitTokenService;
	}

	/// <summary>
	///		Obtains a set of supported Platforms.
	/// </summary>
	/// <returns>A model that contains all nesseary data for testing hardware performance.</returns>
	[HttpGet("Platforms")]
	[ProducesResponseType<PlatformData>(StatusCodes.Status200OK)]
	[EnableRateLimiting("fixed_start_testing")]
	public async Task<IActionResult> GetPlatforms(CancellationToken cancellationToken)
	{
		return Ok(_mapperService.ViewModelMapper.Map<PlatformData>(await _testDataService.GetPlatforms(cancellationToken)));
	}

	/// <summary>
	///		Obtains a set of Test Data
	/// </summary>
	/// <returns>A model that contains all nesseary data for testing hardware performance.</returns>
	[HttpGet()]
	[ProducesResponseType<TestDataRequestModel>(StatusCodes.Status200OK)]
	[ProducesResponseType(StatusCodes.Status400BadRequest)]
	[ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
	[EnableRateLimiting("fixed_start_testing")]
	public async Task<IActionResult> GetTestData([Required, FromQuery]Guid platformId, CancellationToken cancellationToken)
	{
		var testDataToken = _submitTokenService.GenerateToken();
		if (testDataToken is null)
		{
			return new StatusCodeResult(503);
		}

		var testData = await _testDataService.GetTestDataFor(platformId, cancellationToken);
		if (testData != null)
		{
			testData.Token = testDataToken;
			return Ok(testData);
		}

		return BadRequest();
	}
}