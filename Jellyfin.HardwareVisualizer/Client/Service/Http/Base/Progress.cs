namespace Jellyfin.HardwareVisualizer.Client.Service.Http.Base;

public class Progress<T> : IProgressEx<T>
{
	private readonly Action<T, T> _progress;
	private T _maximum;

	public Progress(Action<T, T> progress)
	{
		_progress = progress;
	}

	public void Report(T value)
	{
		_progress(value, _maximum);
	}

	public void SetMax(T value)
	{
		_maximum = value;
	}
}