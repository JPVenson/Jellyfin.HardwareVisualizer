namespace Jellyfin.HardwareVisualizer.Client.Shared.ViewUtil;

public class AsyncDisposable : IAsyncDisposable
{
	private readonly Func<ValueTask> _action;

	public AsyncDisposable() : this(() => ValueTask.CompletedTask)
	{

	}

	public AsyncDisposable(Func<ValueTask> action)
	{
		_action = action;
	}

	public ValueTask DisposeAsync()
	{
		return _action();
	}
}