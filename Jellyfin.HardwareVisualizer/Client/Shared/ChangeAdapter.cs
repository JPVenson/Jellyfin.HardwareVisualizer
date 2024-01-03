using System.ComponentModel;
using Jellyfin.HardwareVisualizer.Client.Shared.ViewUtil;

namespace Jellyfin.HardwareVisualizer.Client.Shared;

public class ChangeAdapter : IDisposable
{
	private IList<Action> _deregister;
	public IList<Action> Actions { get; set; }

	public ChangeAdapter()
	{
		Actions = new List<Action>();
		_deregister = new List<Action>();
	}

	public ChangeAdapter Changed(params INotifyPropertyChanged[] vm)
	{
		return Changed(null, vm);
	}

	public ChangeAdapter Changed(IEnumerable<string> propertyNames, params INotifyPropertyChanged[] vm)
	{
		void Vm_PropertyChanged(object sender, PropertyChangedEventArgs args)
		{
			if(string.IsNullOrWhiteSpace(args.PropertyName) || propertyNames == null || propertyNames.Contains(args.PropertyName))
			{
				RunActions();
			}
		}

		_deregister.Add(() =>
		{
			foreach (var notifyPropertyChanged in vm)
			{
				notifyPropertyChanged.PropertyChanged -= Vm_PropertyChanged;
			}
		});
		foreach (var notifyPropertyChanged in vm)
		{
			notifyPropertyChanged.PropertyChanged += Vm_PropertyChanged;	
		}

		return this;
	}
		
	public ChangeAdapter ThenRefresh(ComponentViewBase component)
	{
		Actions.Add(component.Render);
		if (component is NavigationPageBase navPage)
		{
			Actions.Add(() => navPage.PluginService.PluginsChanged.Raise());
		}
		return this;
	}

	private bool _runningAction = false;
	private void RunActions()
	{
		if (_runningAction)
		{
			return;
		}

		try
		{
			_runningAction = true;
			foreach (var action in Actions)
			{
				action();
			}
		}
		finally
		{
			_runningAction = false;
		}
	}

	public void Dispose()
	{
		Unregister();
		Actions.Clear();
	}

	public void Unregister()
	{
		foreach (var action in _deregister)
		{
			action();
		}

		_deregister.Clear();
	}

	public ChangeAdapter Then(Action action)
	{
		Actions.Add(action);
		return this;
	}

	public ChangeAdapter Trigger()
	{
		RunActions();
		return this;
	}
}