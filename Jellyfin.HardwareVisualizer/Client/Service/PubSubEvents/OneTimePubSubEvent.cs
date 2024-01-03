using Jellyfin.HardwareVisualizer.Client.Shared;
using Jellyfin.HardwareVisualizer.Client.Shared.ViewUtil;

namespace Jellyfin.HardwareVisualizer.Client.Service.PubSubEvents;

public class OneTimePubSubEvent : IDisposable
{
	public OneTimePubSubEvent()
	{
		Subscriber = new List<Delegate>();
	}

	protected IList<Delegate> Subscriber { get; set; }

	public TrackableDisposable Register(Action action)
	{
		if (Subscriber == null)
		{
			action();
			return new TrackableDisposable(() => { });
		}

		Subscriber.Add(action);
		return new TrackableDisposable(() => Subscriber.Remove(action));
	}

	public async Task<TrackableDisposable> Register(Func<Task> action)
	{
		if (Subscriber == null)
		{
			await action();
			return new TrackableDisposable(() => { });
		}
		Subscriber.Add(action);
		return new TrackableDisposable(() => Subscriber.Remove(action));
	}

	public async ValueTask Raise()
	{
		var enumerable = Subscriber.ToArray();
		Subscriber = null;

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