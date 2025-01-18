using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jellyfin.HardwareVisualizer.Server.Database.Configuration;

public class MediaTestFileConfig : IEntityTypeConfiguration<MediaTestFile>
{
    public void Configure(EntityTypeBuilder<MediaTestFile> modelBuilder)
    {
        modelBuilder.HasData(new MediaTestFile[]
            {
                new MediaTestFile()
                {
                    Id = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
                    Name = "Test Jellyfin 4K HEVC 10bit 150M",
                    SourceUrl = "https://repo.jellyfin.org/test-videos/SDR/HEVC%2010bit/Test%20Jellyfin%204K%20HEVC%2010bit%20150M.mp4",
                    Bitrate = 150,
                    Size = 528,
                    VideoCodecId = HardwareCodecConfig.hvecCodecId,
                    AudioCodec = "",
                    HashSha256 = "08bec94467502aec0123f7a1a7f7ba11240de7ff784c1b2b3b66f2936a3e56a1",
                    HashMd5 = "caf635e717ce87c40f751da542e18f16",
                },
                new MediaTestFile()
                {
                    Id = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
                    Name = "Test Jellyfin 4K AVC 150M.mp4",
                    SourceUrl = "https://repo.jellyfin.org/test-videos/SDR/AVC/Test%20Jellyfin%204K%20AVC%20150M.mp4",
                    Bitrate = 150,
                    Size = 528,
                    VideoCodecId = HardwareCodecConfig.h264CodecId,
                    AudioCodec = "",
                    HashSha256 = "71b6633c593a8aab36a050db0369901640ec102caf00735a1fa7b16cbbb2aa42",
                    HashMd5 = "75330504461b4920b51bd7e7f67096d2",
                },
                new MediaTestFile()
                {
                    Id = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
                    Name = "Test Jellyfin 4K HEVC 10bit 40M.mp4",
                    SourceUrl = "https://repo.jellyfin.org/test-videos/SDR/HEVC%2010bit/Test%20Jellyfin%204K%20HEVC%2010bit%2040M.mp4",
                    Bitrate = 40,
                    Size = 141,
                    VideoCodecId = HardwareCodecConfig.hvecCodecId,
                    AudioCodec = "",
                    HashSha256 = "738a7fb8fd951421791286a9609f03b963acd3d424420b3e58edac50ec8cf31c",
                    HashMd5 = "8530221143ce1fc59c1be6947b82c4bd",
                },
                new MediaTestFile()
                {
                    Id = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
                    Name = "Test Jellyfin 1080p AVC 30M.mp4",
                    SourceUrl = "https://repo.jellyfin.org/test-videos/SDR/AVC/Test%20Jellyfin%201080p%20AVC%2030M.mp4",
                    Bitrate = 30,
                    Size = 106,
                    VideoCodecId = HardwareCodecConfig.h264CodecId,
                    AudioCodec = "",
                    HashSha256 = "9851037c599bb02bebfb2e77a6d88ab4d3e295542e3ad6b8f062711dae5112ec",
                    HashMd5 = "7b0f05d66d0897bf9d5e3746a973acce",
                }
            });
    }
}
