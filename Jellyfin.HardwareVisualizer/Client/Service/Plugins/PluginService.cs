using Jellyfin.HardwareVisualizer.Client.Shared.ViewUtil;
using Microsoft.AspNetCore.Components;
using ServiceLocator.Attributes;

namespace Jellyfin.HardwareVisualizer.Client.Service.Plugins;

[SingletonService()]
public class PluginService
{
	private IList<Plugin> _plugins;

	public PluginService()
	{
		_plugins = new List<Plugin>();
	}

	public IEnumerable<Plugin> Plugins
	{
		get { return _plugins; }
	}

	public EventCallback PluginsChanged { get; set; }

	public IDisposable AddPlugin(string name, RenderFragment content, PluginLocation pluginLocation)
	{
		return AddPlugin(name, content, pluginLocation, PluginOrientation.Left);
	}

	public IDisposable AddPlugin(string name, RenderFragment content, PluginLocation pluginLocation, PluginOrientation alignment)
	{
		var plugin = new Plugin()
		{
			Content = content,
			Location = pluginLocation,
			Name = name,
			Row = name.Contains('.') ? name.Split('.')[0] : null,
			Orientation = alignment
		};
		_plugins.Add(plugin);
		PluginsChanged.Raise();
			
		return new PluginDisposable(this, plugin);
	}

	public void Remove(Plugin plugin)
	{
		_plugins.Remove(plugin);
		PluginsChanged.Raise();
	}
}

public class PluginDisposable : IDisposable
{
	private readonly PluginService _pluginService;
	private readonly Plugin _plugin;

	public PluginDisposable(PluginService pluginService, Plugin plugin)
	{
		_pluginService = pluginService;
		_plugin = plugin;
	}

	public void Dispose()
	{
		_pluginService.Remove(_plugin);
	}
}

public class Plugin
{
	public string Name { get; set; }
	public string Row { get; set; }
	public RenderFragment Content { get; set; }
	public PluginLocation Location { get; set; }
	public PluginOrientation Orientation { get; set; }
}

[Flags]
public enum PluginLocation
{
	Header = 1 << 0,
	Footer = 1 << 1
}

public enum PluginOrientation
{
	Left,
	Right
}