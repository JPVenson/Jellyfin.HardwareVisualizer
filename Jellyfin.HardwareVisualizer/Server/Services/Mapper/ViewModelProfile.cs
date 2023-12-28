using AutoMapper;
using Jellyfin.HardwareVisualizer.Database;
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
	}
}