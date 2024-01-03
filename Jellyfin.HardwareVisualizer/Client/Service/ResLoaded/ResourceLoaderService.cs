using Jellyfin.HardwareVisualizer.Client.Service.PubSubEvents;
using Jellyfin.HardwareVisualizer.Client.Shared.ViewUtil;
using ServiceLocator.Attributes;

namespace Jellyfin.HardwareVisualizer.Client.Service.ResLoaded;

[SingletonService()]
public class ResourceLoaderService
{
	public ResourceLoaderService()
	{
		Resources = new HashSet<IHtmlResource>();
		ResourceAdded = new PubSubEvent<IHtmlResource>();
		ResourceRemoved = new PubSubEvent<IHtmlResource>();
	}

	public HashSet<IHtmlResource> Resources { get; set; }

	public PubSubEvent<IHtmlResource> ResourceAdded { get; set; }
	public PubSubEvent<IHtmlResource> ResourceRemoved { get; set; }

	public async Task<IAsyncDisposable> AddResource(IHtmlResource resource, bool nowait = false)
	{
		var hasResource = Resources.FirstOrDefault(e => e.Equals(resource));
		if (hasResource != null)
		{
			Console.WriteLine("Resource: " + resource + " Is already present");
			resource = hasResource;
		}

		var taskSource = new TaskCompletionSource();
			
		if (resource.OnLoaded != null)
		{
			resource.OnLoaded.Register(() => taskSource.SetResult());
		}
		else
		{
			taskSource.SetResult();
		}

		if (hasResource == null)
		{
			Resources.Add(resource);
			await ResourceAdded.Raise(resource);
		}

		if (!nowait)
		{
			await taskSource.Task;
		}
		return new AsyncDisposable(async () =>
		{
			await taskSource.Task;
			Resources.Remove(resource);
			await ResourceRemoved.Raise(resource);
		});
	}
}