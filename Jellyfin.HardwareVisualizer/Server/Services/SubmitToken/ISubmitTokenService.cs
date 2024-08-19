namespace Jellyfin.HardwareVisualizer.Server.Services.SubmitToken;

public interface ISubmitTokenService
{
	(string? token, TimeSpan? retryAfter) GenerateToken();
	JwtPayload? ReadToken(string tokenJson);
	void RedeemToken(JwtPayload token);
	bool Validate(JwtPayload token, out TimeSpan? retryAfter);
}