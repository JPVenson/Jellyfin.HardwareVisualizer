using ChartJs.Blazor.BarChart;
using ChartJs.Blazor.Common;
using Jellyfin.HardwareVisualizer.Client.Service;
using Jellyfin.HardwareVisualizer.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Jellyfin.HardwareVisualizer.Client.Pages;

public partial class HardwareSurveyChartsPage
{
	[Inject]
	public DataSelectorService DataSelectorService { get; set; }

	private BarConfig _usageChart;

	[SupplyParameterFromQuery(Name = "device")]
	[Parameter]
	public string[]? SelectedDevices { get; set; }

	protected override async Task OnInitializedAsync()
	{
		_usageChart = new BarConfig();
		_usageChart.Options = new BarOptions();
		_usageChart.Options.Responsive = true;
		_usageChart.Options.Title = new OptionsTitle();
		_usageChart.Options.Title.Display = true;
		_usageChart.Options.Title.Text = "Maximum Concurrent Streams";
		_usageChart.Options.Legend = new Legend();
		_usageChart.Options.Legend.Display = true;

		DataSelectorService.DeviceAdded += DataSelectorService_DeviceAdded;
		DataSelectorService.DeviceRemoved += DataSelectorService_DeviceAdded;

		if (SelectedDevices != null)
		{
			await DataSelectorService.LoadDevices();
			foreach (var selectedDevice in SelectedDevices)
			{
				var renderDeviceViewModel = DataSelectorService.AllDevices.FirstOrDefault(e =>
					e.Identifier.Equals(selectedDevice, StringComparison.InvariantCultureIgnoreCase));
				await DataSelectorService.AddDevice(renderDeviceViewModel);
			}
		}
	}

	private string[] ChartBackgroundColors = new[]
	{
		"#003f5c",
		"#665191",
		"#2f4b7c",
		"#a05195",
		"#f95d6a",
		"#d45087",
		"#ff7c43",
		"#ffa600"
	};

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
		for (var i = 0; i < DataSelectorService.SelectedDevices.Count; i++)
		{
			var renderDeviceViewModel = DataSelectorService.SelectedDevices[i];
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
				BackgroundColor = ChartBackgroundColors[i % ChartBackgroundColors.Length]
			});
		}

		StateHasChanged();
	}
}