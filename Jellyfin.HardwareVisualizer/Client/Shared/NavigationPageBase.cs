using Jellyfin.HardwareVisualizer.Client.Service.Plugins;
using Jellyfin.HardwareVisualizer.Client.Service.WaiterIndicator;
using Jellyfin.HardwareVisualizer.Client.Shared.ViewUtil;
using Microsoft.AspNetCore.Components;

namespace Jellyfin.HardwareVisualizer.Client.Shared;

public abstract class NavigationPageBase : ComponentViewBase
{
	protected NavigationPageBase()
	{
		ViewState = ViewInitState.Uninitialized;
	}

	public void AddPlugin(string name, RenderFragment content, PluginLocation pluginLocation)
	{
		AddDisposable(PluginService.AddPlugin(name, content, pluginLocation));
	}

	public void AddPlugin(string name, RenderFragment content, PluginLocation pluginLocation, PluginOrientation alignment)
	{
		AddDisposable(PluginService.AddPlugin(name, content, pluginLocation, alignment));
	}

	public virtual void OnSetPlugins()
	{

	}

	public virtual Task OnSetPluginsAsync()
	{
		return Task.CompletedTask;
	}

	[Inject]
	public IJSRuntime JsRuntime { get; set; }

	[Inject]
	public PluginService PluginService { get; set; }
	
	[Inject]
	public WaiterService WaiterService { get; set; }
	
	protected override void OnInitialized()
	{
		base.OnInitialized();
		OnSetPlugins();
	}

	public virtual Task LoadDataAsync()
	{
		return Task.CompletedTask;
	}

	private ViewInitState _viewState;

	public ViewInitState ViewState
	{
		get { return _viewState; }
		set { SetProperty(ref _viewState, value); }
	}

	private int _parameterState = 0;

	public override async Task SetParametersAsync(ParameterView parameters)
	{
		try
		{
			var param = parameters.ToDictionary();
			int newState = 0;
			if (param.Count > 0)
			{
				newState = param.Select((e) => e.Key + e.Value?.ToString()).Select(f => f.GetHashCode()).Aggregate((e, f) => e ^ f);
			}

			if (newState != _parameterState)
			{
				_parameterState = newState;
				ViewState = ViewInitState.Unknown;

				await SoftDispose();
				OnPropertyChanged.Dispose();
			}

			await base.SetParametersAsync(parameters);
		}
		catch (Exception e)
		{
			Console.WriteLine(e);
			throw;
		}
		
	}

	protected override async Task OnInitializedAsync()
	{
		if (ViewState == ViewInitState.Uninitialized)
		{
			return;
		}

		ViewState = ViewInitState.Initializing;

		using (WaiterService.WhenDisposed())
		{
			Render();
			try
			{
				OnPropertyChanged.Register(() => PluginService.PluginsChanged.Raise());

				await LoadDataAsync();
				await OnSetPluginsAsync();
			}
			catch(Exception e)
			{
#if DEBUG
				Console.WriteLine("ERROR WHILE LOADING: " + e);
#endif
				ViewState = ViewInitState.Error;
			}
			finally
			{
				if (ViewState != ViewInitState.Error)
				{
					ViewState = ViewInitState.Initialized;
				}
			}
		}
			
	}
}