using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jellyfin.HardwareVisualizer.Server.Database.Configuration;

public class PlatformConfig : IEntityTypeConfiguration<Platform>
{
    public void Configure(EntityTypeBuilder<Platform> modelBuilder)
    {
        modelBuilder.HasData(new Platform[]
            {
                new Platform()
                {
                    Id = new Guid("2C361BE8-C0EC-4020-984B-66C620DAD840"),
                    Name = "Windows 11",
                    Type = PlatformType.Windows,
                    Version = "Windows 11 version 23H2",
                    VersionId = "22631",
                    DisplayName = "Windows 11",
                    Supported = true,
                    Architecture = PlatformArchitecture.Amd64
                },
                new Platform()
                {
                    Id = new Guid("79191671-CAA0-4B52-8A9E-EAA2F040A1CC"),
                    Name = "Windows 10",
                    Type = PlatformType.Windows,
                    Version = "Windows 10 version 22H2",
                    VersionId = "19045",
                    DisplayName = "Windows 10",
                    Supported = true,
                    Architecture = PlatformArchitecture.Amd64
                },
                new Platform()
                {
                    Id = new Guid("8D58B84B-73DC-4275-985D-123ABE886818"),
                    Name = "Ubuntu",
                    Type = PlatformType.Linux,
                    Version = "Ubuntu",
                    VersionId = "22.04",
                    DisplayName = "Ubuntu Focal",
                    Supported = true,
                    Architecture = PlatformArchitecture.Amd64
                },
                new Platform()
                {
                    Id = new Guid("3657b420-2f2a-4940-8ed3-ee70b9b3720d"),
                    Name = "Linux Generic",
                    Type = PlatformType.Linux,
                    Version = "Linux",
                    VersionId = "Generic",
                    DisplayName = "Linux Generic",
                    Supported = true,
                    Architecture = PlatformArchitecture.Amd64
                },
                new Platform()
                {
                    Id = new Guid("EBE72964-459B-411E-A8DA-2FF77C7370E4"),
                    Name = "Linux Generic",
                    Type = PlatformType.Linux,
                    Version = "Linux",
                    VersionId = "Generic",
                    DisplayName = "Linux Generic",
                    Supported = true,
                    Architecture = PlatformArchitecture.Arm64
                },
                new Platform()
                {
                    Id = new Guid("5AEA52AB-60BF-4425-B412-C046A60CCC83"),
                    Name = "MacOS",
                    Type = PlatformType.Mac,
                    Version = "14.5",
                    VersionId = "14.5",
                    DisplayName = "Mac OS Darwin",
                    Supported = true,
                    Architecture = PlatformArchitecture.Amd64
                },
                new Platform()
                {
                    Id = new Guid("6CF9234F-A4BB-4099-8FC8-675A653BA573"),
                    Name = "MacOS",
                    Type = PlatformType.Mac,
                    Version = "14.5",
                    VersionId = "14.5",
                    DisplayName = "Mac OS Darwin",
                    Supported = true,
                    Architecture = PlatformArchitecture.Arm64
                }
            });
    }
}
