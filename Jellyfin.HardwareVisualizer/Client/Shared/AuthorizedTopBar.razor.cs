using System.Net.Http.Json;
using System.Text.Json;
using Jellyfin.HardwareVisualizer.Shared.Internals;
using Microsoft.AspNetCore.Components;

namespace Jellyfin.HardwareVisualizer.Client.Shared;

public partial class AuthorizedTopBar : UnauthorizedTopBar
{
	public UserData UserJson { get; set; }

	[Inject]
	public HttpClient HttpClient { get; set; }

	[Inject]
	public JsonSerializerOptions JsonSerializerOptions { get; set; }

	protected override async Task OnInitializedAsync()
	{
		UserJson = await HttpClient.GetFromJsonAsync<UserData>("api/AuthApi/UserData", JsonSerializerOptions);
		
	}
}