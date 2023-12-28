using Jellyfin.HardwareVisualizer.Server.Configuration;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using AspNet.Security.OAuth.GitHub;
using Jellyfin.HardwareVisualizer.Shared.Internals;
using Microsoft.AspNetCore.Authorization;

namespace Jellyfin.HardwareVisualizer.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
[EnableRateLimiting("fixed_metadata")]
public class AuthController : Controller
{
	private readonly IOptions<LocalAuthenticationOptions> _authOptions;
	private readonly IHttpContextAccessor _context;

	public AuthController(IOptions<LocalAuthenticationOptions> authOptions, IHttpContextAccessor context)
	{
		_authOptions = authOptions;
		_context = context;
	}

	[HttpGet]
	public IActionResult Login(string returnUrl = "/Admin/Dashboard")
	{
		//return Challenge(new AuthenticationProperties()
		//{
		//	RedirectUri = $"{_authOptions.Value.Authority}/oauth/gh",
		//});

		var provider = GitHubAuthenticationDefaults.AuthenticationScheme;
		// Note: the "provider" parameter corresponds to the external
		// authentication provider chosen by the user agent.
		if (string.IsNullOrWhiteSpace(provider))
		{
			return BadRequest();
		}
		
		// Instruct the middleware corresponding to the requested external identity
		// provider to redirect the user agent to its own authorization endpoint.
		// Note: the authenticationScheme parameter must match the value configured in Startup.cs
		return Challenge(new AuthenticationProperties { RedirectUri = returnUrl }, provider);
	}

	[HttpGet("UserData")]
	[Authorize]
	public IActionResult GetUserData()
	{
		return Ok(new UserData()
		{
			Id = User.FindFirstValue(ClaimTypes.NameIdentifier),
			Email = User.FindFirstValue(ClaimTypes.Email),
			UserIcon = User.FindFirstValue("urn:github:avatar"),
			Username = User.FindFirstValue("urn:github:login"),
		});
	}
}