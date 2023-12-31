using Jellyfin.HardwareVisualizer.Client.Service;
using Microsoft.AspNetCore.Components;
using System.Web;

namespace Jellyfin.HardwareVisualizer.Client.Shared;

public partial class UnauthorizedTopBar
{
	[Inject]
	public DataSelectorService DataSelectorService { get; set; }

	[Inject]
	public NavigationManager NavigationManager { get; set; }

	protected override async Task OnInitializedAsync()
	{
		DataSelectorService.DeviceAdded += DataSelectorService_DeviceAdded;
		DataSelectorService.DeviceRemoved += DataSelectorService_DeviceAdded;
		NavigationManager.LocationChanged += NavigationManager_LocationChanged;
	}

	private void NavigationManager_LocationChanged(object? sender, Microsoft.AspNetCore.Components.Routing.LocationChangedEventArgs e)
	{
		StateHasChanged();
	}

	public string SelectedDevicesQuery { get; set; }

	private void DataSelectorService_DeviceAdded(object? sender, HardwareVisualizer.Shared.Models.RenderDeviceViewModel e)
	{
		RebuildSelectedDevicesQuery();
	}

	private void RebuildSelectedDevicesQuery()
	{
		SelectedDevicesQuery = string.Join('&',
			DataSelectorService.SelectedDevices.Select(f => $"device={HttpUtility.UrlPathEncode(f.Identifier)}"));
		StateHasChanged();
	}
}