using Jellyfin.HardwareVisualizer.Client.Service.ResLoaded;
using Microsoft.AspNetCore.Components;

namespace Jellyfin.HardwareVisualizer.Client.Components;

public partial class ResourcesListComponent
{
	[Inject]
	public ResourceLoaderService ResourceLoaderService { get; set; }

	protected override void OnInitialized()
	{
		ResourceLoaderService.ResourceAdded.Register(StateHasChanged);
		ResourceLoaderService.ResourceRemoved.Register(StateHasChanged);
		base.OnInitialized();
	}
}