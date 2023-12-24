using System.Net.Http.Json;
using System.Web;
using Jellyfin.HardwareVisualizer.Shared;
using Jellyfin.HardwareVisualizer.Shared.Models;
using ServiceLocator.Attributes;

namespace Jellyfin.HardwareVisualizer.Client.Service;

[ScopedService()]
public class DataSelectorService
{
	private readonly HttpClient _httpClient;

	public DataSelectorService(HttpClient httpClient)
	{
		_httpClient = httpClient;
		SelectedDevices = new List<RenderDeviceViewModel>();
		AllDevices = new List<RenderDeviceViewModel>();
		DeviceData = new Dictionary<Guid, IEnumerable<HardwareDisplayModel>>();
	}
	
	public IList<RenderDeviceViewModel> SelectedDevices { get; set; }
	public IList<RenderDeviceViewModel> AllDevices { get; set; }

	public event EventHandler<RenderDeviceViewModel> DeviceAdded;
	public event EventHandler<RenderDeviceViewModel> DeviceRemoved;

	public IDictionary<Guid, IEnumerable<HardwareDisplayModel>> DeviceData { get; set; }

	public async Task LoadDevices()
	{
		if (AllDevices.Any())
		{
			return;
		}

		var devices = _httpClient.GetFromJsonAsync<IEnumerable<RenderDeviceViewModel>>("api/DeviceApi");
		AllDevices = (await devices).ToArray();
	}

	public async Task AddDevice(RenderDeviceViewModel deviceViewModel)
	{
		SelectedDevices.Add(deviceViewModel);
		if (DeviceData.ContainsKey(deviceViewModel.Id))
		{
			OnDeviceAdded(deviceViewModel);
			return;
		}

		var deviceInfo = await _httpClient.GetFromJsonAsync<IEnumerable<HardwareDisplayModel>>($"api/SubmissionApi?deviceId={HttpUtility.UrlEncode(deviceViewModel.Name)}");
		DeviceData[deviceViewModel.Id] = deviceInfo.ToArray();
		OnDeviceAdded(deviceViewModel);
	}

	protected virtual void OnDeviceAdded(RenderDeviceViewModel e)
	{
		DeviceAdded?.Invoke(this, e);
	}

	protected virtual void OnDeviceRemoved(RenderDeviceViewModel e)
	{
		DeviceRemoved?.Invoke(this, e);
	}

	public async Task RemoveDevice(RenderDeviceViewModel renderDeviceViewModel)
	{
		SelectedDevices.Remove(renderDeviceViewModel);
		OnDeviceRemoved(renderDeviceViewModel);
	}
}