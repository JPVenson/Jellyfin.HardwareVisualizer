using Jellyfin.HardwareVisualizer.Client.Service.Http;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace Jellyfin.HardwareVisualizer.Client.Pages.Admin;

public partial class Dashboard
{
	[Inject]
	public HttpService HttpService { get; set; }

	[Inject]
	public AuthenticationStateProvider AuthState { get; set; }
	[Inject]
	public NavigationManager NavigationManager { get; set; }

	public AuthenticationState AuthenticationState { get; set; }

	protected override async Task OnInitializedAsync()
	{
        AuthenticationState = await AuthState.GetAuthenticationStateAsync();		
	}
}