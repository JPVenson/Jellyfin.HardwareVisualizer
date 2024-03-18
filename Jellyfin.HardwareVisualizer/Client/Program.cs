using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Polly;
using Polly.Extensions.Http;
using ServiceLocator.Discovery.Service;

namespace Jellyfin.HardwareVisualizer.Client;

public class Program
{
	public static async Task Main(string[] args)
	{
		var builder = WebAssemblyHostBuilder.CreateDefault(args);
		builder.RootComponents.Add<App>("#app");
		builder.RootComponents.Add<HeadOutlet>("head::after");


		builder.Services
			.AddHttpClient()
			.ConfigureHttpClientDefaults((sp) =>
			{
				sp.ConfigureHttpClient(client =>
				{
					client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
				}).AddPolicyHandler(GetRetryPolicy());
			});


		builder.Services.AddSingleton<JsonSerializerOptions>(new JsonSerializerOptions()
			{
				PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
				Converters = { new JsonStringEnumConverter(JsonNamingPolicy.SnakeCaseLower, false) }
			});
		builder.Services.AddAuthorizationCore();
		builder.Services.UseServiceDiscovery().FromAppDomain().LocateServices();

		await builder.Build().RunAsync();
	}

	static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
	{
		return HttpPolicyExtensions
			.HandleTransientHttpError()
			.OrResult(msg => msg.StatusCode == System.Net.HttpStatusCode.NotFound)
			.WaitAndRetryAsync(6, retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)));
	}
}