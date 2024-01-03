using Jellyfin.HardwareVisualizer.Client.Service.PubSubEvents;
using Microsoft.AspNetCore.Components;

namespace Jellyfin.HardwareVisualizer.Client.Service.ResLoaded;

public abstract class HtmlResourceBase : IHtmlResource
{
	public HtmlResourceBase()
	{
		OnLoaded = new OneTimePubSubEvent();
	}

	public abstract bool Equals(IHtmlResource? other);
	public abstract RenderFragment Render();

	public OneTimePubSubEvent OnLoaded { get; set; }
}