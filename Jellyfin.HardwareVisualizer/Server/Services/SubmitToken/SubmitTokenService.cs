using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using Microsoft.Extensions.Caching.Memory;

namespace Jellyfin.HardwareVisualizer.Server.Services.SubmitToken;

public class SubmitTokenService : ISubmitTokenService
{
	private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly IMemoryCache _memoryCache;

	public SubmitTokenService(IHttpContextAccessor httpContextAccessor, IMemoryCache memoryCache)
	{
		_httpContextAccessor = httpContextAccessor;
		_memoryCache = memoryCache;
	}

	public void RedeemToken(JwtPayload token)
	{
		var cacheKey = "ip-token-" + token.Claims.FirstOrDefault(e => e.Type == "ip")!.Value;
		_memoryCache.Remove(cacheKey);
		_memoryCache.CreateEntry(cacheKey).SetAbsoluteExpiration(DateTimeOffset.Now.AddDays(1)).SetValue(null);
	}

	public string? GenerateToken()
	{
		var ipAddress = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();

		var cacheKey = "ip-token-" + ipAddress;
		if (_memoryCache.TryGetValue<JwtPayload>(cacheKey, out var jwtPayload))
		{
			return jwtPayload?.SerializeToJson();
		}

		var expiresAt = DateTime.Now.AddHours(4);
		jwtPayload = new JwtPayload("jhwa/server", "jhwa/client", [new Claim("ip", ipAddress)],
			DateTime.Now, expiresAt, DateTime.Now);

		_memoryCache.CreateEntry(cacheKey).SetAbsoluteExpiration(expiresAt).SetValue(jwtPayload);

		return jwtPayload.SerializeToJson();
	}

	public JwtPayload? ReadToken(string tokenJson)
	{
		try
		{
			return JwtPayload.Deserialize(tokenJson);
		}
		catch (Exception e)
		{
			return null;
		}
	}
}