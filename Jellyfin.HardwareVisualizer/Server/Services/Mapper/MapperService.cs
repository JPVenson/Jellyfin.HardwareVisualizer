using AutoMapper;
using Jellyfin.HardwareVisualizer.Database;
using Jellyfin.HardwareVisualizer.Shared;
using ServiceLocator.Attributes;
using DeviceType = Jellyfin.HardwareVisualizer.Shared.DeviceType;

namespace Jellyfin.HardwareVisualizer.Server.Services.Mapper;

public interface IMapperService
{
	IMapper ViewModelMapper { get; set; }
}

[SingletonService(typeof(IMapperService))]
public class MapperService : IMapperService
{
	public MapperService()
	{
		ViewModelMapper =
			new AutoMapper.Mapper(new MapperConfiguration(expression => expression.AddProfile<ViewModelProfile>()));
	}

	public IMapper ViewModelMapper { get; set; }
}

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