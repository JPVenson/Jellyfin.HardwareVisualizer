using System.Security.Claims;
using Microsoft.AspNetCore.Components.Authorization;
using ServiceLocator.Attributes;

namespace Jellyfin.HardwareVisualizer.Client.Service.Auth
{
    [SingletonService(typeof(AuthenticationStateProvider))]
	public class GithubAuthenticationStateProvider : AuthenticationStateProvider
	{
		public GithubAuthenticationStateProvider()
		{
			State = new AuthenticationState(ClaimsPrincipal.Current ?? new ClaimsPrincipal());
		}

		public AuthenticationState State { get; set; }

		public override Task<AuthenticationState> GetAuthenticationStateAsync()
		{
			return Task.FromResult(State);
		}
	}
}
