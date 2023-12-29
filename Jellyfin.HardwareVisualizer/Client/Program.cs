using System.Text.Json;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ServiceLocator.Discovery.Service;

namespace Jellyfin.HardwareVisualizer.Client;

public class Program
{
	public static async Task Main(string[] args)
	{
		var builder = WebAssemblyHostBuilder.CreateDefault(args);
		builder.RootComponents.Add<App>("#app");
		builder.RootComponents.Add<HeadOutlet>("head::after");

		builder.Services.UseServiceDiscovery().FromAppDomain().LocateServices();
		builder.Services.AddScoped(sp => new HttpClient
			{
				BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
			})
			.AddSingleton<JsonSerializerOptions>(new JsonSerializerOptions()
			{
				PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
			});

		await builder.Build().RunAsync();
	}
}