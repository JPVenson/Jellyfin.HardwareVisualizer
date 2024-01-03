using Jellyfin.HardwareVisualizer.Client.Shared;
using Jellyfin.HardwareVisualizer.Client.Shared.ViewUtil;

namespace Jellyfin.HardwareVisualizer.Client.Service.PubSubEvents;

public class PubSubEvent : IDisposable
{
	public PubSubEvent()
	{
		Subscriber = new List<Delegate>();
	}

	protected IList<Delegate> Subscriber { get; }

	public TrackableDisposable Register(Action action)
	{
		Subscriber.Add(action);
		return new TrackableDisposable(() => Subscriber.Remove(action));
	}

	public TrackableDisposable Register(Func<Task> action)
	{
		Subscriber.Add(action);
		return new TrackableDisposable(() => Subscriber.Remove(action));
	}

	public async ValueTask Raise()
	{
		var enumerable = Subscriber.ToArray();

		foreach (var action in enumerable)
		{
			if (action is Action act)
			{
				act.Invoke();
			}
			else if (action is Func<Task> func)
			{
				await func();
			}
		}
	}

	public virtual void Dispose()
	{
		Subscriber.Clear();
	}

	public class TrackableDisposable : Disposable
	{
		public TrackableDisposable(Action action) : base(action)
		{
				
		}

		public TrackableDisposable TrackedBy(ComponentViewBase component)
		{
			component.AddDisposable(this);
			return this;
		}
	}
}

public class PubSubEvent<TArg> : PubSubEvent
{
	public TrackableDisposable Register(Action<TArg> action)
	{
		Subscriber.Add(action);
		return new TrackableDisposable(() => Subscriber.Remove(action));
	}

	public TrackableDisposable Register(Func<TArg, Task> action)
	{
		Subscriber.Add(action);
		return new TrackableDisposable(() => Subscriber.Remove(action));
	}

	public async ValueTask Raise(TArg arg)
	{
		await base.Raise();
		var enumerable = Subscriber.ToArray();

		foreach (var action in enumerable)
		{
			if (action is Action<TArg> act)
			{
				act.Invoke(arg);
			}
			else if (action is Func<TArg, Task> func)
			{
				await func(arg);
			}
		}
	}
}


public class OneTimePubSubEvent<TArg> : PubSubEvent
{
	public TrackableDisposable Register(Action<TArg> action)
	{
		if (Subscriber == null)
		{
			action(_argument);
			return new TrackableDisposable(() => { });
		}
		Subscriber.Add(action);
		return new TrackableDisposable(() => Subscriber.Remove(action));
	}

	public async Task<TrackableDisposable> Register(Func<TArg, Task> action)
	{
		if (Subscriber == null)
		{
			await action(_argument);
			return new TrackableDisposable(() => { });
		}
		Subscriber.Add(action);
		return new TrackableDisposable(() => Subscriber.Remove(action));
	}

	private TArg _argument;

	public async ValueTask Raise(TArg arg)
	{
		_argument = arg;
		await base.Raise();
		var enumerable = Subscriber.ToArray();

		foreach (var action in enumerable)
		{
			if (action is Action<TArg> act)
			{
				act.Invoke(arg);
			}
			else if (action is Func<TArg, Task> func)
			{
				await func(arg);
			}
		}
	}
}