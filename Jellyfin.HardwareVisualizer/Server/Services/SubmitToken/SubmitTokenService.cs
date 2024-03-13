using System.IdentityModel.Tokens.Jwt;
using System.Net;
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

	private readonly byte[] _key;
	private readonly byte[] _iv;

	public SubmitTokenService(IHttpContextAccessor httpContextAccessor, IMemoryCache memoryCache)
	{
		_httpContextAccessor = httpContextAccessor;
		_memoryCache = memoryCache;


		// Create a new DES object to generate a random _key
		// and initialization vector (IV).
		using (DES des = DES.Create())
		{
			_key = des.Key;
			_iv = des.IV;
		}
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
			if (jwtPayload is null)
			{
				return null;
			}

			return Encrypt(jwtPayload);
		}

		var expiresAt = DateTime.Now.AddHours(4);
		jwtPayload = new JwtPayload("jhwa/server", "jhwa/client", [new Claim("ip", ipAddress)],
			DateTime.Now, expiresAt, DateTime.Now);

		_memoryCache.Set(cacheKey, jwtPayload, expiresAt);
		//_memoryCache.CreateEntry(cacheKey).SetAbsoluteExpiration(expiresAt).SetValue(jwtPayload);

		return Encrypt(jwtPayload);
	}

	private string? Encrypt(JwtPayload jwtPayload)
	{
		var serializeToJson = jwtPayload.SerializeToJson();

		using DES des = DES.Create();
		using ICryptoTransform encryptor = des.CreateEncryptor(_key, _iv);
		using var dStream = new MemoryStream();
		using var cStream = new CryptoStream(dStream, encryptor, CryptoStreamMode.Write);
		var token = Encoding.UTF8.GetBytes(serializeToJson);
		cStream.Write(token, 0, token.Length);

		return Convert.ToBase64String(dStream.ToArray());
	}

	public JwtPayload? ReadToken(string tokenJson)
	{
		try
		{
			using var dStream = new MemoryStream(Convert.FromBase64String(tokenJson));
			using DES des = DES.Create();
			using ICryptoTransform decryptor = des.CreateDecryptor(_key, _iv);
			using var cStream = new CryptoStream(dStream, decryptor, CryptoStreamMode.Read);
			using StreamReader reader = new StreamReader(cStream, Encoding.UTF8);
			return JwtPayload.Deserialize(reader.ReadToEnd());
		}
		catch (Exception e)
		{
			return null;
		}
	}
}