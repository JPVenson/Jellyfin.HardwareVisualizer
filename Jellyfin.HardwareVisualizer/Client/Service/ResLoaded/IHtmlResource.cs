using Jellyfin.HardwareVisualizer.Client.Service.PubSubEvents;
using Microsoft.AspNetCore.Components;

namespace Jellyfin.HardwareVisualizer.Client.Service.ResLoaded;

public interface IHtmlResource : IEquatable<IHtmlResource>
{
	RenderFragment Render();
	OneTimePubSubEvent OnLoaded { get; }
}