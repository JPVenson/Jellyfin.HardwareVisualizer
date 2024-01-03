using System.Net.Http.Json;
using System.Text.Json;
using System.Web;
using Jellyfin.HardwareVisualizer.Shared.Models;
using ServiceLocator.Attributes;

namespace Jellyfin.HardwareVisualizer.Client.Service;

[ScopedService()]
public class DataSelectorService
{
	private readonly HttpClient _httpClient;
	private readonly JsonSerializerOptions _jsonSerializerOptions;

	public DataSelectorService(HttpClient httpClient, JsonSerializerOptions jsonSerializerOptions)
	{
		_httpClient = httpClient;
		_jsonSerializerOptions = jsonSerializerOptions;
		SelectedDevices = new List<RenderDeviceViewModel>();
		AllDevices = new List<RenderDeviceViewModel>();
		DeviceData = new Dictionary<Guid, IEnumerable<HardwareDisplayModel>>();
	}
	
	public IList<RenderDeviceViewModel> SelectedDevices { get; set; }
	public IList<RenderDeviceViewModel> AllDevices { get; set; }

	public event EventHandler<RenderDeviceViewModel> DeviceAdded;
	public event EventHandler<RenderDeviceViewModel> DeviceRemoved;

	public IDictionary<Guid, IEnumerable<HardwareDisplayModel>> DeviceData { get; set; }

	private Task<IEnumerable<RenderDeviceViewModel>?> _devicesTask;

	public async Task LoadDevices()
	{
		if (AllDevices.Any())
		{
			return;
		}

		if (_devicesTask is not null)
		{
			await _devicesTask;
			return;
		}
		_devicesTask = _httpClient.GetFromJsonAsync<IEnumerable<RenderDeviceViewModel>>("api/DeviceApi", _jsonSerializerOptions);
		AllDevices = (await _devicesTask).ToArray();
	}

	public async Task AddDevice(RenderDeviceViewModel deviceViewModel)
	{
		SelectedDevices.Add(deviceViewModel);
		if (DeviceData.ContainsKey(deviceViewModel.Id))
		{
			OnDeviceAdded(deviceViewModel);
			return;
		}

		var deviceInfo = await _httpClient.GetFromJsonAsync<IEnumerable<HardwareDisplayModel>>($"api/SubmissionApi?deviceId={HttpUtility.UrlEncode(deviceViewModel.Name)}", _jsonSerializerOptions);
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