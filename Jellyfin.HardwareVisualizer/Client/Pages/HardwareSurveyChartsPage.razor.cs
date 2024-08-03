using ChartJs.Blazor.BarChart;
using ChartJs.Blazor.BarChart.Axes;
using ChartJs.Blazor.Common;
using ChartJs.Blazor.Common.Axes;
using ChartJs.Blazor.Common.Axes.Ticks;
using ChartJs.Blazor.Common.Enums;
using Jellyfin.HardwareVisualizer.Client.Service;
using Jellyfin.HardwareVisualizer.Client.Service.Http;
using Jellyfin.HardwareVisualizer.Client.Service.ResLoaded;
using Jellyfin.HardwareVisualizer.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Jellyfin.HardwareVisualizer.Client.Pages;

public partial class HardwareSurveyChartsPage
{
	[Inject]
	public DataSelectorService DataSelectorService { get; set; }

	[Inject]
	public ResourceLoaderService ResourceLoaderService { get; set; }

	private BarConfig _usageChart;

	[SupplyParameterFromQuery(Name = "device")]
	[Parameter]
	public string[]? SelectedDevices { get; set; }
	
	[SupplyParameterFromQuery(Name = "submission")]
	[Parameter]
	public Guid? Submission { get; set; }

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

	private static bool _horizontalChart = true;

	protected override async Task OnInitializedAsync()
	{
		await ResourceLoaderService.AddResource(
			new ScriptLinkResource("_content/ChartJs.Blazor.Fork/ChartJsBlazorInterop.js"));

		var usageChart = new BarConfig(_horizontalChart);

		usageChart.Options = new BarOptions
		{
			Responsive = true,
			Title = new OptionsTitle
			{
				Display = true,
				Text = "Maximum Concurrent Streams"
			},
			Legend = new Legend
			{
				Display = true,
				Position = Position.Top
			},
			Scales = new BarScales
			{
				XAxes = new List<CartesianAxis>(){
					new BarLinearCartesianAxis (){	
						Ticks = new LinearCartesianTicks(){
							BeginAtZero = true
						}
					}
				}
			}
		};

		_usageChart = usageChart;
		StateHasChanged();
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

		var lastCodecAdded = "";
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
					if (lastCodecAdded == hardwareDisplayModel.HardwareCodec)
					{
						label = $"{hardwareDisplayModel.FromResolution} -> {hardwareDisplayModel.ToResolution}";
					}
					_usageChart.Data.Labels.Add(label);
					lastCodecAdded = hardwareDisplayModel.HardwareCodec;
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

			_usageChart.Data.Datasets.Add(new BarDataset<int>(values, _horizontalChart)
			{
				Label = renderDeviceViewModel.Name,
				BackgroundColor = ChartBackgroundColors[i % ChartBackgroundColors.Length],
			});
		}

		StateHasChanged();
	}
}