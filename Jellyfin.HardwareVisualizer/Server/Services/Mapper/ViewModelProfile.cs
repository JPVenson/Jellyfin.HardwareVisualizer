using AutoMapper;
using Jellyfin.HardwareVisualizer.Server.Database;
using Jellyfin.HardwareVisualizer.Shared.Models;
using DeviceType = Jellyfin.HardwareVisualizer.Shared.Models.DeviceType;

namespace Jellyfin.HardwareVisualizer.Server.Services.Mapper;

public class ViewModelProfile : Profile
{
	public ViewModelProfile()
	{
		CreateMap<HardwareDisplay, HardwareDisplayModel>();
		CreateMap<CpuType, RenderDeviceViewModel>()
			.ForMember(e => e.DeviceType, f => f.MapFrom(e => DeviceType.Cpu));
		CreateMap<GpuType, RenderDeviceViewModel>()
			.ForMember(e => e.DeviceType, f => f.MapFrom(e => DeviceType.Gpu));

		CreateMap<IEnumerable<Platform>, PlatformData>()
			.ForMember(e => e.Platforms, f => f.MapFrom(e => e));

		CreateMap<Platform, SupportedPlatform>();
		CreateMap<FfmpegVersion, FfmpegModel>()
			.ForMember(e => e.FfmpegSourceUrl, e => e.MapFrom(f => f.Source))
			.ForMember(e => e.FfmpegVersion, e => e.MapFrom(f => f.Version));

		CreateMap<TestCase, TestCaseDataModel>();
	}
}