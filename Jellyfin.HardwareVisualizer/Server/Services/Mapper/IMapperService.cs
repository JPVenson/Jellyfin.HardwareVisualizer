using AutoMapper;

namespace Jellyfin.HardwareVisualizer.Server.Services.Mapper;

public interface IMapperService
{
	IMapper ViewModelMapper { get; set; }
}