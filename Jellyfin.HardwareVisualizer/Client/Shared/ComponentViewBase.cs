using System.ComponentModel;
using System.Runtime.CompilerServices;
using Jellyfin.HardwareVisualizer.Client.Service.PubSubEvents;
using Jellyfin.HardwareVisualizer.Client.Shared.ViewUtil;
using Microsoft.AspNetCore.Components;

namespace Jellyfin.HardwareVisualizer.Client.Shared;

public abstract class ComponentViewBase : DebuggableComponent, 
	IDisposable, 
	IAsyncDisposable, 
	INotifyPropertyChanged, 
	INotifyPropertyChanging
{
	public ComponentViewBase()
	{
		Disposables = new List<IDisposable>();
		AsyncDisposables = new List<IAsyncDisposable>();
		OnPropertyChanged = new PubSubEvent<string>();
		_onNextRender = new List<Delegate>();
	}

	private List<IDisposable> Disposables { get; set; }
	private List<IAsyncDisposable> AsyncDisposables { get; set; }

	private List<Delegate> _onNextRender;
		
	public void OnNextRender(Action action)
	{
		_onNextRender.Add(action);
	}

	public void OnNextRender(Func<Task> action)
	{
		_onNextRender.Add(action);
	}
		
	public void OnContinuesRender(Action action)
	{
		_onNextRender.Add(new Func<bool, bool>((isFirstRender) =>
		{
			if (!isFirstRender)
			{
				action();
				return true;
			}

			return false;
		}));
	}

	public void OnContinuesRender(Func<Task> action)
	{
		_onNextRender.Add(new Func<bool, Task<bool>>(async (isFirstRender) =>
		{
			if (!isFirstRender)
			{
				await action();
				return true;
			}

			return false;
		}));
	}

	protected override void OnAfterRender(bool firstRender)
	{
		base.OnAfterRender(firstRender);
		foreach (var action in _onNextRender.OfType<Action>().ToArray())
		{
			action();
			_onNextRender.Remove(action);
		}
		foreach (var action in _onNextRender.OfType<Func<bool, bool>>().ToArray())
		{
			if (action(firstRender))
			{
				_onNextRender.Remove(action);
			}
		}
	}

	protected override async Task OnAfterRenderAsync(bool firstRender)
	{
		await base.OnAfterRenderAsync(firstRender);
		foreach (var action in _onNextRender.OfType<Func<Task>>().ToArray())
		{
			_onNextRender.Remove(action);
			await action();
		}
		foreach (var action in _onNextRender.OfType<Func<bool, Task<bool>>>().ToArray())
		{
			_onNextRender.Remove(action);
			if (!(await action(firstRender)))
			{
				_onNextRender.Add(action);
			}
		}
	}

	public void WhenDisposed(Action action)
	{
		Disposables.Add(new Disposable(action));
	}

	public void WhenDisposed(Func<ValueTask> func)
	{
		AsyncDisposables.Add(new AsyncDisposable(func));
	}

	public T AddDisposable<T>(T disposable) where T : IDisposable
	{
		Disposables.Add(disposable);
		return disposable;
	}

	public T AddAsyncDisposable<T>(T disposable) where T : IAsyncDisposable
	{
		AsyncDisposables.Add(disposable);
		return disposable;
	}

	public virtual void Render()
	{
		StateHasChanged();
	}

	public ChangeAdapter TrackWhen()
	{
		return AddDisposable(new ChangeAdapter());
	}

	public ChangeAdapter WhenChanged(params INotifyPropertyChanged[] changed)
	{
		return TrackWhen().Changed(changed);
	}

	public bool SetProperty<T>(ref T member, T value, [CallerMemberName] string propertyName = null)
	{
		if (Equals(member, value))
		{
			return false;
		}
		SendPropertyChanging(propertyName);
		member = value;
		SendPropertyChanged(propertyName);
		return true;
	}

	public bool SetProperty<T>(ref T member, T value, EventCallback callback, [CallerMemberName] string propertyName = null)
	{
		if (SetProperty(ref member, value, propertyName))
		{
			callback.Raise();
			return true;
		}

		return false;
	}

	public bool SetProperty<T>(ref T member, T value, EventCallback<T> callback, [CallerMemberName] string propertyName = null)
	{
		if (SetProperty(ref member, value, propertyName))
		{
			callback.Raise(value);
			return true;
		}

		return false;
	}

	public bool SetProperty<T>(ref T member, T value, EventHandler callback, [CallerMemberName] string propertyName = null)
	{
		if (SetProperty<T>(ref member, value, propertyName))
		{
			callback?.Invoke(this, new EventArgs());
			return true;
		}
		return false;
	}

	public bool SetProperty<T>(ref T member, T value, EventHandler<T> callback, [CallerMemberName] string propertyName = null)
	{
		if (SetProperty<T>(ref member, value, propertyName))
		{
			callback?.Invoke(this, value);
			return true;
		}
		return false;
	}
		
	public virtual void OnDispose()
	{

	}

	public async void Dispose()
	{
		await DisposeData();
	}

	public ValueTask DisposeAsync()
	{
		return DisposeData();
	}

	protected virtual async ValueTask SoftDispose()
	{
		foreach (var asyncDisposable in AsyncDisposables)
		{
			await asyncDisposable.DisposeAsync();
		}
		AsyncDisposables.Clear();

		foreach (var disposable in Disposables)
		{
			disposable.Dispose();
		}
		Disposables.Clear();
	}

	protected virtual async ValueTask DisposeData()
	{
		OnDispose();
		await SoftDispose();
		OnPropertyChanged.Dispose();
	}

	public PubSubEvent<string> OnPropertyChanged { get; set; }

	public event PropertyChangedEventHandler PropertyChanged;

	protected virtual async void SendPropertyChanged([CallerMemberName] string propertyName = null)
	{
		await OnPropertyChanged.Raise(propertyName);
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}

	public event PropertyChangingEventHandler PropertyChanging;

	protected virtual void SendPropertyChanging([CallerMemberName] string propertyName = null)
	{
		PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
	}
}