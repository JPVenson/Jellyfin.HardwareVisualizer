using System.IdentityModel.Tokens.Jwt;

namespace Jellyfin.HardwareVisualizer.Server.Services.SubmitToken;

public interface ISubmitTokenService
{
	string GenerateToken();
	JwtPayload? ReadToken(string tokenJson);
	void RedeemToken(JwtPayload token);
}