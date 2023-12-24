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
	}

	public Guid SelectedDevice { get; set; }

	private async Task AddDevice()
	{
		var argValue = SelectedDevice.ToString();
		if (string.IsNullOrWhiteSpace(argValue))
		{
			return;
		}

		Console.WriteLine(argValue);

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