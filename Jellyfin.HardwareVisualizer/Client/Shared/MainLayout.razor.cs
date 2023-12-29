using System.Web;
using Jellyfin.HardwareVisualizer.Client.Service;
using Microsoft.AspNetCore.Components;

namespace Jellyfin.HardwareVisualizer.Client.Shared;

public partial class MainLayout
{
	[Inject]
	public DataSelectorService DataSelectorService { get; set; }

	protected override async Task OnInitializedAsync()
	{
		DataSelectorService.DeviceAdded += DataSelectorService_DeviceAdded;
		DataSelectorService.DeviceRemoved += DataSelectorService_DeviceAdded;
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