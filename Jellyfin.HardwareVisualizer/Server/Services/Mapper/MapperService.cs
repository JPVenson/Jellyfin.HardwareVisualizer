using AutoMapper;
using ServiceLocator.Attributes;

namespace Jellyfin.HardwareVisualizer.Server.Services.Mapper;

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