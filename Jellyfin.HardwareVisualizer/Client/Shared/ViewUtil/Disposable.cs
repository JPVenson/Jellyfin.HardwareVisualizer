namespace Jellyfin.HardwareVisualizer.Client.Shared.ViewUtil;

public class Disposable : IDisposable
{
	private readonly Action _action;

	public Disposable() : this(() => { })
	{

	}

	public Disposable(Action action)
	{
		_action = action;
	}

	public void Dispose()
	{
		_action();
	}
}