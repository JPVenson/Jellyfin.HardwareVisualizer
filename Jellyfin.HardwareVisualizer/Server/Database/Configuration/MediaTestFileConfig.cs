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
                    Name = "jellyfish-120-mbps-4k-uhd-hevc-10bit",
                    SourceUrl = "https://repo.jellyfin.org/jellyfish/media/jellyfish-120-mbps-4k-uhd-hevc-10bit.mkv",
                    Bitrate = 120,
                    Size = 429,
                    VideoCodec = "HEVC",
                    AudioCodec = "",
                    HashSha256 = "",
                    HashMd5 = "",
                },
                new MediaTestFile()
                {
                    Id = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
                    Name = "jellyfish-120-mbps-4k-uhd-h264",
                    SourceUrl = "https://repo.jellyfin.org/jellyfish/media/jellyfish-120-mbps-4k-uhd-h264.mkv",
                    Bitrate = 120,
                    Size = 431,
                    VideoCodec = "h264",
                    AudioCodec = "",
                    HashSha256 = "",
                    HashMd5 = "",
                },
                new MediaTestFile()
                {
                    Id = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
                    Name = "jellyfish-40-mbps-hd-hevc-10bit",
                    SourceUrl = "https://repo.jellyfin.org/jellyfish/media/jellyfish-40-mbps-hd-hevc-10bit.mkv",
                    Bitrate = 40,
                    Size = 143,
                    VideoCodec = "HEVC",
                    AudioCodec = "",
                    HashSha256 = "",
                    HashMd5 = "",
                },
                new MediaTestFile()
                {
                    Id = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
                    Name = "jellyfish-40-mbps-hd-h264",
                    SourceUrl = "https://repo.jellyfin.org/jellyfish/media/jellyfish-40-mbps-hd-h264.mkv",
                    Bitrate = 40,
                    Size = 142,
                    VideoCodec = "h264",
                    AudioCodec = "",
                    HashSha256 = "",
                    HashMd5 = "",
                }
            });
    }
}
