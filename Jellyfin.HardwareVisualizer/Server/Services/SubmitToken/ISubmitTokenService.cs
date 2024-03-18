using System.IdentityModel.Tokens.Jwt;

namespace Jellyfin.HardwareVisualizer.Server.Services.SubmitToken;

public interface ISubmitTokenService
{
	(string? token, TimeSpan? retryAfter) GenerateToken();
	JwtPayload? ReadToken(string tokenJson);
	void RedeemToken(JwtPayload token);
}