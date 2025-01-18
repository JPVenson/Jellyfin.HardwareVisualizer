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
			.ForMember(e => e.FfmpegVersion, e => e.MapFrom(f => f.Version))
			.ForMember(e => e.FfmpegHashs, e => e.ConvertUsing(new FileHashConverter(), e => e));

		CreateMap<TestCase, TestCaseDataModel>();
		CreateMap<TestCase, TestCaseModel>()
			.ForMember(e => e.SourceHashs, e => e.ConvertUsing(new FileHashConverter(), e => e.MediaTestFile));
	}
}

public class FileHashConverter : IValueConverter<HashedExternalEntity, IEnumerable<ExternalFileHashModel>>
{
    public IEnumerable<ExternalFileHashModel> Convert(HashedExternalEntity source, ResolutionContext context)
    {
		var hashes = new List<ExternalFileHashModel>();
		if (!string.IsNullOrWhiteSpace(source.HashMd5))
		{
			hashes.Add(new ExternalFileHashModel()
			{
				Hash = source.HashMd5,
				Type = "md5"
			});
		}
		if (!string.IsNullOrWhiteSpace(source.HashSha256))
		{
			hashes.Add(new ExternalFileHashModel()
			{
				Hash = source.HashSha256,
				Type = "sha526"
			});
		}
		return hashes;
    }
}