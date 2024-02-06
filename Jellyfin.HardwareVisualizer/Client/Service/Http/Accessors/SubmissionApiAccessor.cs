using Jellyfin.HardwareVisualizer.Client.Service.Http.Base;
using Jellyfin.HardwareVisualizer.Shared.Models;

namespace Jellyfin.HardwareVisualizer.Client.Service.Http.Accessors;

public class SubmissionApiAccessor : HttpAccessBase
{
	public SubmissionApiAccessor(HttpService httpService) : base(httpService, "v1/SubmissionApi")
	{

	}

	public ValueTask<ApiResult<string>> GetSubmitSchema()
	{
		return Get<string>(BuildApi("submitSchema"));
	}

	public ValueTask<ApiResult<string>> SubmitResults(string jsonResult)
	{
		return Post<string, string>(BuildApi(""), jsonResult, "application/json");
	}

	public ValueTask<ApiResult<IEnumerable<HardwareDisplayModel>>> GetSubmissionData(string deviceId)
	{
		return Get<IEnumerable<HardwareDisplayModel>>(BuildApi("", new
		{
			deviceId
		}));
	}
}

public class DeviceApiAccessor : HttpAccessBase
{
	public DeviceApiAccessor(HttpService httpService) : base(httpService, "v1/DeviceApi")
	{
	}

	public ValueTask<ApiResult<IEnumerable<RenderDeviceViewModel>>> GetDevices()
	{
		return Get<IEnumerable<RenderDeviceViewModel>>(BuildApi(""));
	}
}