using System.Net.Http.Json;
using System.Web;
using ChartJs.Blazor.BarChart;
using ChartJs.Blazor.Common;
using ChartJs.Blazor.Util;
using Jellyfin.HardwareVisualizer.Client.Service;
using Jellyfin.HardwareVisualizer.Shared;
using Microsoft.AspNetCore.Components;

namespace Jellyfin.HardwareVisualizer.Client.Pages;

public partial class Index
{
	[Inject]
	public DataSelectorService DataSelectorService { get; set; }
	
	private BarConfig _usageChart;

	protected override async Task OnInitializedAsync()
	{
		_usageChart = new BarConfig();
		_usageChart.Options = new BarOptions();
		_usageChart.Options.Responsive = true;
		_usageChart.Options.Title = new OptionsTitle();
		_usageChart.Options.Title.Display = true;
		_usageChart.Options.Title.Text = "Test Title";

		DataSelectorService.DeviceAdded += DataSelectorService_DeviceAdded;
		DataSelectorService.DeviceRemoved += DataSelectorService_DeviceAdded;
	}

	private void DataSelectorService_DeviceAdded(object? sender, RenderDeviceViewModel arg)
	{
		_usageChart.Data.Labels.Clear();
		_usageChart.Data.Datasets.Clear();

		var labelData = new Dictionary<string, IList<HardwareDisplayModel>>();
		
		foreach (var deviceData in DataSelectorService
			         .SelectedDevices
			         .Select(f => (f, DataSelectorService.DeviceData[f.Id])))
		{
			foreach (var hardwareDisplayModel in deviceData.Item2)
			{
				var label = $"{hardwareDisplayModel.HardwareCodec} - {hardwareDisplayModel.FromResolution} -> {hardwareDisplayModel.ToResolution}";
				if (!labelData.TryGetValue(label, out var valuesForCodec))
				{
					valuesForCodec = new List<HardwareDisplayModel>();
					labelData[label] = valuesForCodec;
					_usageChart.Data.Labels.Add(label);
				}
				valuesForCodec.Add(hardwareDisplayModel);
			}
		}
		
		var hardwareDisplayModels = labelData.Values.ToArray();
		foreach (var renderDeviceViewModel in DataSelectorService.SelectedDevices)
		{
			var values = new int[labelData.Count];

			for (var index = 0; index < hardwareDisplayModels.Length; index++)
			{
				var labelDataInfo = hardwareDisplayModels[index];
				var hasData = labelDataInfo.FirstOrDefault(e => e.DeviceName == renderDeviceViewModel.Name)
					?.MaxStreams ?? 0;
				values[index] = hasData;
			}
			
			_usageChart.Data.Datasets.Add(new BarDataset<int>(values)
			{
				Label = renderDeviceViewModel.Name,
				BackgroundColor = ColorUtil.RandomColorString()
			});
		}
		StateHasChanged();
	}
}