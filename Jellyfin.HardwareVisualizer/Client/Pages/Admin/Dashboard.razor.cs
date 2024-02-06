using Jellyfin.HardwareVisualizer.Client.Service.Http;
using Microsoft.AspNetCore.Components;

namespace Jellyfin.HardwareVisualizer.Client.Pages.Admin;

public partial class Dashboard
{
	[Inject]
	public HttpService HttpService { get; set; }


	protected override async Task OnInitializedAsync()
	{
	}
}