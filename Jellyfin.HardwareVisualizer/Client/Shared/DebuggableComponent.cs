using Microsoft.AspNetCore.Components;

namespace Jellyfin.HardwareVisualizer.Client.Shared;

public class DebuggableComponent : ComponentBase
{
	[Parameter]
	public bool Log { get; set; }

	public void WriteLine(object content)
	{
		if (Log)
		{
			Console.WriteLine(content);
		}
	}
}