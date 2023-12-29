using Jellyfin.HardwareVisualizer.Client.Service;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace Jellyfin.HardwareVisualizer.Client.Shared;

public partial class NavMenu
{
	[Inject]
	public DataSelectorService DataSelectorService { get; set; }
	
	protected override async Task OnInitializedAsync()
	{
		await DataSelectorService.LoadDevices();
		DataSelectorService.DeviceAdded += DataSelectorService_DeviceAdded;
		DataSelectorService.DeviceRemoved += DataSelectorService_DeviceRemoved;
	}

	private void DataSelectorService_DeviceRemoved(object? sender, HardwareVisualizer.Shared.Models.RenderDeviceViewModel e)
	{
		StateHasChanged();
	}

	private void DataSelectorService_DeviceAdded(object? sender, HardwareVisualizer.Shared.Models.RenderDeviceViewModel e)
	{
		StateHasChanged();
	}

	public Guid SelectedDevice { get; set; }

	private async Task AddDevice()
	{
		var argValue = SelectedDevice.ToString();
		if (string.IsNullOrWhiteSpace(argValue))
		{
			return;
		}

		var renderDeviceViewModel = DataSelectorService.AllDevices.First(e => e.Id.ToString() == argValue);
		await DataSelectorService.AddDevice(renderDeviceViewModel);
		SelectedDevice = Guid.Empty;
	}

	private async Task RemoveDevice(Guid arg)
	{
		var renderDeviceViewModel = DataSelectorService.AllDevices.First(e => e.Id == arg);
		await DataSelectorService.RemoveDevice(renderDeviceViewModel);
	}
}