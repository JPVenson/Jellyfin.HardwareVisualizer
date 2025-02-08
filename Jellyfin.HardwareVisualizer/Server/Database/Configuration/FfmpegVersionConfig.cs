using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jellyfin.HardwareVisualizer.Server.Database.Configuration;

public class FfmpegVersionConfig : IEntityTypeConfiguration<FfmpegVersion>
{
    public static Guid WindowsVersionGroup = new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512");
    public static Guid GenericLinuxVersionGroup = new Guid("9F9565F1-4661-484B-8C80-433BC909E70F");
    public static Guid MacVersionGroup = new Guid("3504C0A3-19B6-418D-995E-C8731C9789A5");

    public void Configure(EntityTypeBuilder<FfmpegVersion> modelBuilder)
    {
        modelBuilder
            .HasData(new FfmpegVersion[]
            {
                new FfmpegVersion()
                {
                    Id = new Guid("A3F734BE-FB92-4A1F-BD8C-B6701E0F7E9F"),
                    PlatformId = new Guid("2C361BE8-C0EC-4020-984B-66C620DAD840"),
                    Source =
                        "https://repo.jellyfin.org/files/ffmpeg/windows/latest-5.x/amd64/jellyfin-ffmpeg_5.1.4-3-portable_win64.zip",
                    Version = "5.1.6-3",
                    HashSha256 = "824542b798f04c482b171417002c3aee94f880eec2aa1ee9f016de6d912e31bd",
                    HashMd5 = "73a6a7f9d02a9abbda0f6aadd39abc89",
                    VersionGroup  = FfmpegVersionConfig.WindowsVersionGroup,
                },
                new FfmpegVersion()
                {
                    Id = new Guid("7F9E0BB6-7346-400F-881C-33C3C1558D78"),
                    PlatformId = new Guid("79191671-CAA0-4B52-8A9E-EAA2F040A1CC"),
                    Source =
                        "https://repo.jellyfin.org/files/ffmpeg/windows/latest-5.x/amd64/jellyfin-ffmpeg_5.1.4-3-portable_win64.zip",
                    Version = "5.1.6-3",
                    HashSha256 = "824542b798f04c482b171417002c3aee94f880eec2aa1ee9f016de6d912e31bd",
                    HashMd5 = "73a6a7f9d02a9abbda0f6aadd39abc89",
                    VersionGroup  = FfmpegVersionConfig.WindowsVersionGroup,
                },
                new FfmpegVersion()
                {
                    Id = new Guid("2C720157-F8FB-48C9-8686-D4DFE7DAAE9A"),
                    PlatformId = new Guid("8D58B84B-73DC-4275-985D-123ABE886818"),
                    Source =
                        "https://repo.jellyfin.org/files/ffmpeg/linux/7.x/7.0.2-3/amd64/jellyfin-ffmpeg_7.0.2-3_portable_linux64-gpl.tar.xz",
                    Version = "7.0.2-3",
                    HashSha256 = "C737508DCE127A871EAE0D7537181CEAC6C39D3086348B8E2B100251FAD2071D",
                    HashMd5 = "2BCE8782024607AE0104B8C6DA6F0636",
                    VersionGroup  = FfmpegVersionConfig.GenericLinuxVersionGroup,
                },
                new FfmpegVersion()
                {
                    Id = new Guid("501d7e27-8410-40af-b48d-1e7ce0002173"),
                    PlatformId = new Guid("3657b420-2f2a-4940-8ed3-ee70b9b3720d"),
                    Source =
                        "https://repo.jellyfin.org/files/ffmpeg/linux/7.x/7.0.2-3/amd64/jellyfin-ffmpeg_7.0.2-3_portable_linux64-gpl.tar.xz",
                    Version = "7.0.2-3",
                    HashSha256 = "C737508DCE127A871EAE0D7537181CEAC6C39D3086348B8E2B100251FAD2071D",
                    HashMd5 = "2BCE8782024607AE0104B8C6DA6F0636",
                    VersionGroup  = FfmpegVersionConfig.GenericLinuxVersionGroup,
                },
                new FfmpegVersion()
                {
                    Id = new Guid("5AF82644-47A0-4C0C-AB83-31A5DFF71153"),
                    PlatformId = new Guid("5AEA52AB-60BF-4425-B412-C046A60CCC83"),
                    Source =
                        "https://repo.jellyfin.org/files/ffmpeg/macos/7.x/7.0.2-3/x86_64/jellyfin-ffmpeg_7.0.2-3_portable_mac64-gpl.tar.xz",
                    Version = "7.0.2-3",
                    HashSha256 = "ed4061fc90e35ac405cb824dc99781481879a20e0a6b447934ddadd54bc40b3d",
                    HashMd5 = "db3ede0396234e92991f45c5ef9058b7",
                    VersionGroup  = FfmpegVersionConfig.MacVersionGroup,
                },
                new FfmpegVersion()
                {
                    Id = new Guid("413B53ED-E63F-4410-B901-492173CABF13"),
                    PlatformId = new Guid("6CF9234F-A4BB-4099-8FC8-675A653BA573"),
                    Source =
                        "https://repo.jellyfin.org/files/ffmpeg/macos/7.x/7.0.2-3/arm64/jellyfin-ffmpeg_7.0.2-3_portable_macarm64-gpl.tar.xz",
                    Version = "7.0.2-3",
                    HashSha256 = "4f3eb2bf612e989d218a26c822d5d008cf3c4eafc54cf41e7816fc2eefc73d10",
                    HashMd5 = "bc6b6e09b2ec13871250f866e87952e8",
                    VersionGroup  = FfmpegVersionConfig.MacVersionGroup,
                },
                new FfmpegVersion()
                {
                    Id = new Guid("FE43005A-D480-4113-AF8A-8EBBC6392071"),
                    PlatformId = new Guid("EBE72964-459B-411E-A8DA-2FF77C7370E4"),
                    Source =
                        "https://repo.jellyfin.org/files/ffmpeg/linux/7.x/7.0.2-3/arm64/jellyfin-ffmpeg_7.0.2-3_portable_linuxarm64-gpl.tar.xz",
                    Version = "7.0.2-3",
                    HashSha256 = "e0e8fd50233578bc68db43b25f63984808c7604b7787b3a30d40aad66902daf8",
                    HashMd5 = "2ab051df11ff755b5b7f51937188e186",
                    VersionGroup  = FfmpegVersionConfig.GenericLinuxVersionGroup,
                }
            });
    }
}
