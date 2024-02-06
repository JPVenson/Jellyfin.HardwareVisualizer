using Jellyfin.HardwareVisualizer.Shared.Models;
using System.Net;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Jellyfin.HardwareVisualizer.Client.Service.Http.Base;

public struct ApiResult : IApiResult
{
	public ApiResult(HttpStatusCode statusCode, bool success, string statusMessage, ProblemDetails errorResult, ExceptionDispatchInfo exception = null)
	{
		StatusCode = statusCode;
		Success = success;
		StatusMessage = statusMessage;
		ErrorResult = errorResult;
		Exception = exception;
	}

	public ApiResult(HttpStatusCode statusCode, bool success, string statusMessage, ExceptionDispatchInfo exception = null)
	{
		StatusCode = statusCode;
		Success = success;
		StatusMessage = statusMessage;
		ErrorResult = null;
		Exception = exception;
	}

	public HttpStatusCode StatusCode { get; private set; }
	public bool Success { get; private set; }
	public string StatusMessage { get; private set; }
	public ProblemDetails ErrorResult { get; }
	public ExceptionDispatchInfo Exception { get; }

	public ApiResult UnpackOrThrow()
	{
		if (Success)
		{
			return this;
		}

		Exception?.Throw();
		return this;
	}
}

public struct ApiResult<T> : IApiResult
{
	public ApiResult(HttpStatusCode statusCode, bool success, string statusMessage, ProblemDetails errorResult, ExceptionDispatchInfo exception)
	{
		StatusCode = statusCode;
		Success = success;
		StatusMessage = statusMessage;
		ErrorResult = errorResult;
		Exception = exception;
		Object = default(T);
	}
	public ApiResult(HttpStatusCode statusCode, bool success, string statusMessage, ExceptionDispatchInfo exception)
	{
		StatusCode = statusCode;
		Success = success;
		StatusMessage = statusMessage;
		Exception = exception;
		Object = default(T);
		ErrorResult = null;
	}

	public ApiResult(HttpStatusCode statusCode, bool success, T o, string statusMessage)
	{
		StatusCode = statusCode;
		Success = success;
		Object = o;
		StatusMessage = statusMessage;
		Exception = null;
		ErrorResult = null;
	}

	public T Object { get; private set; }
	public HttpStatusCode StatusCode { get; private set; }
	public bool Success { get; private set; }
	public string StatusMessage { get; private set; }
	public ProblemDetails ErrorResult { get; }
	public ExceptionDispatchInfo Exception { get; private set; }

	public ApiResult<T> UnpackOrThrow()
	{
		if (Success)
		{
			return this;
		}

		Exception?.Throw();
		return this;
	}

	public override string ToString()
	{
		var sb = new StringBuilder();
		sb.Append("Success: ");
		sb.AppendLine(Success.ToString());
		sb.Append("StatusCode: ");
		sb.AppendLine(StatusCode.ToString());
		sb.Append("StatusMessage: ");
		sb.AppendLine(StatusMessage);
		sb.Append("Object: ");
		sb.AppendLine(Object?.ToString());
		sb.Append("Exception: ");
		sb.AppendLine(Exception?.SourceException?.ToString());
		return sb.ToString();
	}

	public ApiResult With()
	{
		return new ApiResult(StatusCode, Success, StatusMessage, Exception);
	}

	public ApiResult<TNew> With<TNew>(Func<T, TNew> newData)
	{
		return With(newData(Object));
	}

	public ApiResult<TNew> With<TNew>(TNew newData)
	{
		return new ApiResult<TNew>(StatusCode, Success, newData, StatusMessage)
		{
			Exception = Exception
		};
	}
}