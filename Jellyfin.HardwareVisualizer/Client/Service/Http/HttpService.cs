using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;
using Jellyfin.HardwareVisualizer.Client.Service.Http.Accessors;
using Jellyfin.HardwareVisualizer.Client.Service.Http.Base;
using Microsoft.AspNetCore.Components;
using ServiceLocator.Attributes;

namespace Jellyfin.HardwareVisualizer.Client.Service.Http;

[SingletonService()]
public class HttpService
{
	private readonly IHttpClientFactory _httpClient;
	private readonly NavigationManager _navigationService;

	private JsonSerializerOptions _jsonSerializerSettings;

	public HttpService(IHttpClientFactory httpClient, NavigationManager navigationService, JsonSerializerOptions jsonSerializerSettings)
	{
		_jsonSerializerSettings = jsonSerializerSettings;
		_httpClient = httpClient;
		_navigationService = navigationService;
		_accessesors = new List<HttpAccessBase>();
		foreach (var propertyInfo in GetType().GetProperties().Where(e => typeof(HttpAccessBase).IsAssignableFrom(e.PropertyType)))
		{
			var instance = Activator.CreateInstance(propertyInfo.PropertyType, this) as HttpAccessBase;
			_accessesors.Add(instance);
			propertyInfo.SetValue(this, instance);
		}
	}

	private IList<HttpAccessBase> _accessesors;

	public SubmissionApiAccessor SubmissionApiAccessor { get; set; }
	public DeviceApiAccessor DeviceApiAccessor { get; set; }
	public TestDataApiAccessor TestDataApiAccessor { get; set; }


	public HttpClient Client()
	{
		var httpClient = _httpClient.CreateClient();

		httpClient.DefaultRequestHeaders.Accept.Clear();
		httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
		return httpClient;
	}

	public JsonSerializerOptions GetJsonSerializerSettings()
	{
		return _jsonSerializerSettings;
	}

	//public void SetToken(string tokenToken)
	//{
	//	_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", tokenToken);
	//	//_client.DefaultRequestHeaders.TryAddWithoutValidation("Authentification", "Bearer " + tokenToken);
	//}

	public RestHttpAccessBase<TEntity> For<TEntity>()
	{
		return _accessesors.OfType<RestHttpAccessBase<TEntity>>().FirstOrDefault() ?? throw new InvalidOperationException($"Cannot get an repository for {typeof(TEntity)}");
	}

	public void CheckForUnauthorizedAccess(HttpResponseMessage message)
	{
		if (message.StatusCode == HttpStatusCode.Unauthorized)
		{
			_navigationService.NavigateTo("/Unauthorized");
		}
	}

	//public void SignalChangeId(string connectionId)
	//{
	//	_httpClient.DefaultRequestHeaders.Remove("x-mw-changeTrackingId");
	//	_httpClient.DefaultRequestHeaders.Add("x-mw-changeTrackingId", connectionId);
	//}
}