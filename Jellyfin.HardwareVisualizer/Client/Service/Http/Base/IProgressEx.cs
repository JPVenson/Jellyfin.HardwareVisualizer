namespace Jellyfin.HardwareVisualizer.Client.Service.Http.Base;

public interface IProgressEx<in T> : IProgress<T>
{
	void SetMax(T value);
}