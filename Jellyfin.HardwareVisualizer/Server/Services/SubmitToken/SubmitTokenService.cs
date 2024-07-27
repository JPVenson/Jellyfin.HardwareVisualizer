using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Caching.Memory;
using ServiceLocator.Attributes;

namespace Jellyfin.HardwareVisualizer.Server.Services.SubmitToken;

[SingletonService(typeof(ISubmitTokenService))]
public class SubmitTokenService : ISubmitTokenService
{
	private readonly IHttpContextAccessor _httpContextAccessor;
	private readonly IMemoryCache _memoryCache;
    private readonly ILogger<SubmitTokenService> _logger;
    private readonly byte[] _key;
	private readonly byte[] _iv;

	public SubmitTokenService(IHttpContextAccessor httpContextAccessor, IMemoryCache memoryCache, ILogger<SubmitTokenService> logger)
	{
		_httpContextAccessor = httpContextAccessor;
		_memoryCache = memoryCache;
        _logger = logger;

        // Create a new DES object to generate a random _key
        // and initialization vector (IV).
        using (DES des = DES.Create())
		{
			_key = des.Key;
			_iv = des.IV;
		}
	}

	private class TokenStore
	{
		public JwtPayload JwtPayload { get; set; }

		public bool Expired { get; set; }
	}

	public void RedeemToken(JwtPayload token)
	{
		var cacheKey = "ip-token-" + token.Claims.FirstOrDefault(e => e.Type == "ip")!.Value;
		_memoryCache.Remove(cacheKey);
		_memoryCache.CreateEntry(cacheKey).SetAbsoluteExpiration(DateTimeOffset.Now.AddDays(1)).SetValue(new TokenStore()
		{
			Expired = true,
			JwtPayload = token
		}).Dispose();
	}

	public bool Validate(JwtPayload token, out TimeSpan? retryAfter)
	{
		var ipAddress = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
		var cacheKey = "ip-token-" + ipAddress;
		if (_memoryCache.TryGetValue<TokenStore>(cacheKey, out var tokenStore))
		{
			if (tokenStore.Expired)
			{
				retryAfter = tokenStore.JwtPayload.ValidTo - DateTime.UtcNow;
				return false;
			}

			retryAfter = null;
			return true;
		}

		retryAfter = null;
		return token.ValidTo > DateTime.UtcNow;
	}

	public (string? token, TimeSpan? retryAfter) GenerateToken()
	{
		var ipAddress = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();

		_logger.LogInformation($"Ip {ipAddress} requested a new Token.");

		var cacheKey = "ip-token-" + ipAddress;
		if (_memoryCache.TryGetValue<TokenStore>(cacheKey, out var tokenStore) 
			&& tokenStore.JwtPayload.ValidTo > DateTime.UtcNow)
		{
			if (tokenStore.Expired)
			{
				return (null, tokenStore.JwtPayload.ValidTo - DateTime.UtcNow);
			}

			return (Encrypt(tokenStore.JwtPayload), null);
		}

		var expiresAt = DateTime.UtcNow.AddHours(4);
		tokenStore = new TokenStore();
		tokenStore.JwtPayload = new JwtPayload("jhwa/server", "jhwa/client", [new Claim("ip", ipAddress)],
			DateTime.UtcNow, expiresAt, DateTime.UtcNow);

		_memoryCache.Set(cacheKey, tokenStore, DateTime.Now.AddMinutes(10));
		return (Encrypt(tokenStore.JwtPayload), null);
	}

	private string? Encrypt(JwtPayload jwtPayload)
	{
		var serializeToJson = jwtPayload.SerializeToJson();

		using (DES des = DES.Create())
		{
			des.Padding = PaddingMode.PKCS7;
			using (ICryptoTransform encryptor = des.CreateEncryptor(_key, _iv))
			{
				using var dStream = new MemoryStream();
				{
					using (var cStream = new CryptoStream(dStream, encryptor, CryptoStreamMode.Write))
					{
						var token = Encoding.UTF8.GetBytes(serializeToJson);
						cStream.Write(token, 0, token.Length);
					}
					return Convert.ToBase64String(dStream.ToArray());
				}
			}
		}
	}

	public JwtPayload? ReadToken(string tokenJson)
	{
		try
		{
			using (var dStream = new MemoryStream(Convert.FromBase64String(tokenJson)))
			{
				dStream.Seek(0, SeekOrigin.Begin);
				using (DES des = DES.Create())
				{
					des.Padding = PaddingMode.PKCS7;
					using (ICryptoTransform decryptor = des.CreateDecryptor(_key, _iv))
					{
						using (var cStream = new CryptoStream(dStream, decryptor, CryptoStreamMode.Read))
						{
							using (StreamReader reader = new StreamReader(cStream, Encoding.UTF8))
							{
								return JwtPayload.Deserialize(reader.ReadToEnd());
							}
						}
					}
				}
			}
		}
		catch (Exception e)
		{
			return null;
		}
	}
}