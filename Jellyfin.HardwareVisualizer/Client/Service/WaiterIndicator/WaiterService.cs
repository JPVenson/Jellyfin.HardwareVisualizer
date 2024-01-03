using Jellyfin.HardwareVisualizer.Client.Service.PubSubEvents;
using Jellyfin.HardwareVisualizer.Client.Shared.ViewUtil;
using ServiceLocator.Attributes;

namespace Jellyfin.HardwareVisualizer.Client.Service.WaiterIndicator;

public class BadgeDisplay
{
	public string Text { get; set; }
	public string Icon { get; set; }
}

[SingletonService()]
public class WaiterService
{
	public WaiterService()
	{
		_waitCounter = 0;
		Badges = new List<BadgeDisplay>();
		IsWaitingChanged = new PubSubEvent<bool>();
	}

	private int _waitCounter;
	public IList<BadgeDisplay> Badges { get; set; }
		
	public bool IsWaiting
	{
		get { return _waitCounter != 0; }
		set
		{
			if (value)
			{
				_waitCounter++;
			}
			else
			{
				_waitCounter--;
			}
				
			if ((_waitCounter == 1 || value) || (_waitCounter == 0 && !value))
			{
				OnIsWaitingChanged();
			}
		}
	}

	public IDisposable WhenDisposed()
	{
		IsWaiting = true;
		return new Disposable(() =>
		{
			IsWaiting = false;
		});
	}

	public Task WhenTask(Task task)
	{
		IsWaiting = true;
		return task.ContinueWith(t =>
		{
			IsWaiting = false;
		});
	}

	public Task<T> WhenTask<T>(Task<T> task)
	{
		IsWaiting = true;
		return task.ContinueWith(t =>
		{
			IsWaiting = false;
			return t.Result;
		});
	}

	public PubSubEvent<bool> IsWaitingChanged { get; set; }
		
	protected virtual async void OnIsWaitingChanged()
	{
		await IsWaitingChanged.Raise(IsWaiting);
	}

	public void DisplayBadge(BadgeDisplay badge)
	{
		Badges.Add(badge);
			
		IsWaiting = true;
		Task.Delay(TimeSpan.FromSeconds(2))
			.ContinueWith(e =>
			{
				Badges.Remove(badge);
				IsWaiting = false;
			});
	}

	public void DisplayOk(string display = null)
	{
		var badge = new BadgeDisplay()
		{
			Icon = "fas fa-check-circle fa-2x text-success",
			Text = display ?? "Common/Saved"
		};
		DisplayBadge(badge);
	}

	public void DisplayError(string display = null)
	{
		var badge = new BadgeDisplay()
		{
			Icon = "fa fa-close fa-2x text-danger",
			Text = display ?? "Common/Error"
		};
		DisplayBadge(badge);
	}
}