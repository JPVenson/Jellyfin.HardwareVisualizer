using System.Collections;
using System.Net;
using System.Net.Http.Formatting;
using System.Net.Http.Json;
using System.Runtime.ExceptionServices;
using System.Web;
using Jellyfin.HardwareVisualizer.Shared.Models;
using Microsoft.AspNetCore.Components.Forms;
using Newtonsoft.Json;

namespace Jellyfin.HardwareVisualizer.Client.Service.Http.Base;

public abstract class HttpAccessBase
{
	protected HttpAccessBase(HttpService httpService, string url)
	{
		HttpService = httpService;
		Url = url;
		SingalRRoutes = new List<string>();
	}

	public HttpService HttpService { get; }
	public string Url { get; }

	public List<string> SingalRRoutes { get; set; }
	public bool SkipUnauthorisedCheck { get; set; }

	private void CheckForUnauthorizedAccess(HttpResponseMessage message, bool skipCheck)
	{
		if (skipCheck)
		{
			return;
		}

		HttpService.CheckForUnauthorizedAccess(message);
	}

	protected async Task<ApiResult> Download(Stream targetStream, string url, IProgressEx<long> progress = null, object body = null)
	{
		var skipCheck = SkipUnauthorisedCheck;
		SkipUnauthorisedCheck = false;
		HttpResponseMessage content = null;
		try
		{
			var request = new HttpRequestMessage
			{
				Method = body == null ? HttpMethod.Get : HttpMethod.Post,
				RequestUri = new Uri(url, UriKind.Relative),
			};
			if (body != null)
			{
				request.Content = new ObjectContent(body.GetType(), body, new JsonMediaTypeFormatter());
			}

			using (content = await HttpService.Client().SendAsync(request, HttpCompletionOption.ResponseHeadersRead))
			{
				CheckForUnauthorizedAccess(content, skipCheck);
				if (content.IsSuccessStatusCode)
				{
					using (var resource = await content.Content.ReadAsStreamAsync())
					{
						if (progress != null)
						{
							progress.SetMax(content.Content.Headers.ContentLength ?? 0);
							await resource.CopyToAsync(targetStream, 2024, progress, CancellationToken.None);
						}
						else
						{
							await resource.CopyToAsync(targetStream, 2024, CancellationToken.None);
						}

						targetStream.Seek(0, SeekOrigin.Begin);
					}
				}

				return new ApiResult(content.StatusCode,
					content.IsSuccessStatusCode,
					content.ReasonPhrase);
			}
		}
		catch (Exception e)
		{
			return new ApiResult(content?.StatusCode ?? HttpStatusCode.ServiceUnavailable,
				false,
				content?.ReasonPhrase,
				ExceptionDispatchInfo.Capture(e));
		}
	}

	public const int MaxFileSize = 10000000;

	protected async ValueTask<ApiResult<T>> PostUpload<T>(IBrowserFile[] files, string url)
	{
		var skipCheck = SkipUnauthorisedCheck;
		SkipUnauthorisedCheck = false;
		HttpResponseMessage content = null;
		string readAsString;
		try
		{
			var multipartFormDataContent = new MultipartFormDataContent();
			foreach (var browserFile in files)
			{
				multipartFormDataContent.Add(new StreamContent(browserFile.OpenReadStream(MaxFileSize)), "fileCollection", browserFile.Name);
			}

			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Post,
				RequestUri = new Uri(url, UriKind.Relative),
			};
			request.Content = multipartFormDataContent;

			using (content = await HttpService.Client().SendAsync(request))
			{
				CheckForUnauthorizedAccess(content, skipCheck);
				readAsString = await content.Content.ReadAsStringAsync();
				return new ApiResult<T>(content.StatusCode,
					content.IsSuccessStatusCode,
					(JsonConvert.DeserializeObject<T>(readAsString)),
					content.ReasonPhrase);
			}
		}
		catch (Exception e)
		{
			return new ApiResult<T>(content?.StatusCode ?? HttpStatusCode.ServiceUnavailable,
				false,
				content?.ReasonPhrase,
				ExceptionDispatchInfo.Capture(e));
		}
	}

	protected async Task<ApiResult<T>> Upload<T>(Stream stream, string url)
	{
		var skipCheck = SkipUnauthorisedCheck;
		SkipUnauthorisedCheck = false;
		HttpResponseMessage content = null;
		string readAsString;
		try
		{
			using (content = await HttpService.Client().PostAsync(url, new MultipartContent()
			       {
				       new StreamContent(stream)
			       }))
			{
				CheckForUnauthorizedAccess(content, skipCheck);
				readAsString = await content.Content.ReadAsStringAsync();
				return new ApiResult<T>(content.StatusCode,
					content.IsSuccessStatusCode,
					(JsonConvert.DeserializeObject<T>(readAsString)),
					content.ReasonPhrase);
			}
		}
		catch (Exception e)
		{
			return new ApiResult<T>(content?.StatusCode ?? HttpStatusCode.ServiceUnavailable,
				false,
				content?.ReasonPhrase,
				ExceptionDispatchInfo.Capture(e));
		}
	}

	protected async Task<ApiResult> Upload(Stream stream, string url)
	{
		var skipCheck = SkipUnauthorisedCheck;
		SkipUnauthorisedCheck = false;
		HttpResponseMessage content = null;
		try
		{
			using (content = await HttpService.Client().PostAsync(url, new MultipartContent()
			       {
				       new StreamContent(stream)
			       }))
			{
				CheckForUnauthorizedAccess(content, skipCheck);
				return new ApiResult(content.StatusCode,
					content.IsSuccessStatusCode,
					content.ReasonPhrase);
			}
		}
		catch (Exception e)
		{
			return new ApiResult(content?.StatusCode ?? HttpStatusCode.ServiceUnavailable,
				false,
				content?.ReasonPhrase,
				ExceptionDispatchInfo.Capture(e));
		}
	}

	private async ValueTask<ApiResult<T>> GetResult<T>(HttpResponseMessage response)
	{
		if (!response.IsSuccessStatusCode)
		{
			return new ApiResult<T>(response.StatusCode, false, response.ReasonPhrase, await response.Content.ReadFromJsonAsync<ProblemDetails>(), null);
		}

		T content;

		if (response.StatusCode == HttpStatusCode.NoContent)
		{
			if (typeof(T).IsArray)
			{
				content = (T)Activator.CreateInstance(typeof(T), 0);
			}
			else
			{
				content = default;
			}
		}
		else
		{
			content = await response.Content.ReadFromJsonAsync<T>(HttpService.GetJsonSerializerSettings());
		}
		return new ApiResult<T>(response.StatusCode, true, content, response.ReasonPhrase);
	}

	protected async ValueTask<ApiResult<T>> Get<T>(string url)
	{
		var skipCheck = SkipUnauthorisedCheck;
		SkipUnauthorisedCheck = false;
		HttpResponseMessage content = null;
		try
		{
			Console.WriteLine("Get: " + url);

			var requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
			using (content = await HttpService.Client()
				       .SendAsync(requestMessage, HttpCompletionOption.ResponseContentRead)
				       .ConfigureAwait(false))
			{
				CheckForUnauthorizedAccess(content, skipCheck);
				return await GetResult<T>(content);
			}
		}
		catch (Exception e)
		{
			return new ApiResult<T>(content?.StatusCode ?? HttpStatusCode.ServiceUnavailable,
				false,
				content?.ReasonPhrase,
				ExceptionDispatchInfo.Capture(e));
		}
	}

	protected async ValueTask<T> GetValue<T>(string url)
	{
		return (await Get<T>(url)).Object;
	}

	protected async ValueTask<ApiResult> Post<T>(string url, T data)
	{
		var skipCheck = SkipUnauthorisedCheck;
		SkipUnauthorisedCheck = false;
		HttpResponseMessage content = null;
		try
		{
			using (content = await HttpService.Client()
				       .PostAsync(url, JsonContent.Create(data, data?.GetType() ?? typeof(object), null, HttpService.GetJsonSerializerSettings()))
					   .ConfigureAwait(false))
			{
				CheckForUnauthorizedAccess(content, skipCheck);
				if (!content.IsSuccessStatusCode)
				{
					return new ApiResult(content.StatusCode, false, content.ReasonPhrase, await content.Content.ReadFromJsonAsync<ProblemDetails>(HttpService.GetJsonSerializerSettings()), null);
				}

				return new ApiResult(content.StatusCode, content.IsSuccessStatusCode, content.ReasonPhrase);
			}
		}
		catch (Exception e)
		{
			return new ApiResult(content?.StatusCode ?? HttpStatusCode.ServiceUnavailable,
				false,
				content?.ReasonPhrase,
				ExceptionDispatchInfo.Capture(e));
		}
	}

	protected async ValueTask<ApiResult> Post(string url)
	{
		var skipCheck = SkipUnauthorisedCheck;
		SkipUnauthorisedCheck = false;
		HttpResponseMessage content = null;
		try
		{
			using (content = await HttpService.Client().PostAsync(url, null)
				       .ConfigureAwait(false))
			{
				CheckForUnauthorizedAccess(content, skipCheck);
				if (!content.IsSuccessStatusCode)
				{
					return new ApiResult(content.StatusCode, false, content.ReasonPhrase, await content.Content.ReadFromJsonAsync<ProblemDetails>(HttpService.GetJsonSerializerSettings()), null);
				}
				return new ApiResult(content.StatusCode, content.IsSuccessStatusCode, content.ReasonPhrase);
			}
		}
		catch (Exception e)
		{
			return new ApiResult(content?.StatusCode ?? HttpStatusCode.ServiceUnavailable,
				false,
				content?.ReasonPhrase,
				ExceptionDispatchInfo.Capture(e));
		}
	}

	protected ValueTask<ApiResult<TOut>> Post<TIn, TOut>(string url, TIn data)
	{
		return Post<TIn, TOut>(url, data, null);
	}
	protected async ValueTask<ApiResult<TOut>> Post<TIn, TOut>(string url, TIn data, string mediaType = null)
	{
		var skipCheck = SkipUnauthorisedCheck;
		SkipUnauthorisedCheck = false;
		HttpResponseMessage content = null;
		try
		{
			using (content = await HttpService.Client()
				       .PostAsync(url, JsonContent.Create(data, data?.GetType() ?? typeof(object), null, HttpService.GetJsonSerializerSettings()))
					   .ConfigureAwait(false))
			{
				CheckForUnauthorizedAccess(content, skipCheck);
				if (!content.IsSuccessStatusCode)
				{
					return new ApiResult<TOut>(content.StatusCode, false, content.ReasonPhrase, await content.Content.ReadFromJsonAsync<ProblemDetails>(HttpService.GetJsonSerializerSettings()), null);
				}

				return new ApiResult<TOut>(content.StatusCode,
					content.IsSuccessStatusCode,
					await content.Content.ReadFromJsonAsync<TOut>(HttpService.GetJsonSerializerSettings()),
					content.ReasonPhrase);
			}
		}
		catch (Exception e)
		{
			return new ApiResult<TOut>(content?.StatusCode ?? HttpStatusCode.ServiceUnavailable,
				false,
				content?.ReasonPhrase,
				ExceptionDispatchInfo.Capture(e));
		}

	}

	protected async ValueTask<ApiResult<string>> PostGetString<T>(string url, T data)
	{
		var skipCheck = SkipUnauthorisedCheck;
		SkipUnauthorisedCheck = false;
		HttpResponseMessage content = null;
		try
		{
			using (content = await HttpService.Client()
				       .PostAsync(url, JsonContent.Create(data, data?.GetType() ?? typeof(object), null, HttpService.GetJsonSerializerSettings()))
				       .ConfigureAwait(false))
			{
				CheckForUnauthorizedAccess(content, skipCheck);
				if (!content.IsSuccessStatusCode)
				{
					return new ApiResult<string>(content.StatusCode, false, content.ReasonPhrase, await content.Content.ReadFromJsonAsync<ProblemDetails>(), (ExceptionDispatchInfo)null);
				}

				return new ApiResult<string>(content.StatusCode,
					content.IsSuccessStatusCode,
					await content.Content.ReadAsStringAsync(),
					content.ReasonPhrase);
			}
		}
		catch (Exception e)
		{
			return new ApiResult<string>(content?.StatusCode ?? HttpStatusCode.ServiceUnavailable,
				false,
				content?.ReasonPhrase,
				ExceptionDispatchInfo.Capture(e));
		}
	}

	public static string EncodeUrlString(object data)
	{
		if (data is string dataString)
		{
			return HttpUtility.UrlPathEncode(dataString);
		}

		var values = data.GetType().GetProperties()
			.Select(e => new Tuple<string, object>(e.Name, e.GetMethod.Invoke(data, null)))
			.Where(e => e.Item2 != null)
			.ToArray();

		if (!values.Any())
		{
			return null;
		}

		return values
			.SelectMany(e =>
			{
				if (e.Item2 is IEnumerable enumerable && !(enumerable is string))
				{
					var sb = new List<string>();
					foreach (var item in enumerable)
					{
						sb.Add(WebUtility.UrlEncode(e.Item1) + "=" + WebUtility.UrlEncode(item.ToString()));
					}

					return sb.ToArray();
				}

				return new string[]
				{
					WebUtility.UrlEncode(e.Item1) + "=" + WebUtility.UrlEncode(e.Item2.ToString())
				};
			})
			.Aggregate((e, f) => e + "&" + f);
	}

	public string QueryUrl(string basePath, object data = null)
	{
		if (data == null)
		{
			return basePath;
		}

		return basePath + "?" + EncodeUrlString(data);
	}

	protected string BuildApi(string methodName, object data = null)
	{
		var buildApi = "/api/" + Url.Trim('/') + "/" + methodName;
		if (data != null)
		{
			var query = EncodeUrlString(data);
			if (query != null)
			{
				buildApi += "?" + query;
			}
		}

		return buildApi;
	}
}