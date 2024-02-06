using Newtonsoft.Json;

namespace Jellyfin.HardwareVisualizer.Client.Service.Http.Base;

public static class HttpErrorExtentions
{
	private class ErrorMessageClass
	{
		[JsonProperty("message")]
		public string Message { get; set; }
	}

	public static async Task<object> ObtainMessage(this HttpContent content)
	{
		var error = await content.ReadAsStringAsync();
		try
		{
			if (string.IsNullOrWhiteSpace(error))
			{
				return string.Empty;
			}

			object errorMessage;
			errorMessage = JsonConvert.DeserializeObject<ErrorMessageClass>(error);
			if (errorMessage is ErrorMessageClass { Message: { } })
			{
				return errorMessage;
			}


			var anyError = JsonConvert.DeserializeObject<IDictionary<string, object>>(error);
			if (anyError is not null)
			{
				var firstEntry = anyError.FirstOrDefault();
				return new ErrorMessageClass()
				{
					Message = firstEntry.Key + firstEntry.Value
				};
			}

			return errorMessage;
		}
		catch
		{
			return error;
		}
	}
}