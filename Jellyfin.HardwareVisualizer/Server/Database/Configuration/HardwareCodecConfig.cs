using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jellyfin.HardwareVisualizer.Server.Database.Configuration;

public class HardwareCodecConfig : IEntityTypeConfiguration<HardwareCodec>
{
    public static Guid h264CodecId = new Guid("BF2065DC-9B03-48B8-9A30-206A12A6319C");
    public static Guid hvecCodecId = new Guid("104537DB-E1E2-4490-A82A-AFAEDE9A8FD4");
    public void Configure(EntityTypeBuilder<HardwareCodec> modelBuilder)
    {
        modelBuilder
            .HasData(new HardwareCodec[]
            {
                new HardwareCodec()
                {
                    Id  = HardwareCodecConfig.h264CodecId,
                    Identifier = "h264",
                    Name = "H264"
                },
                new HardwareCodec()
                {
                    Id  = HardwareCodecConfig.hvecCodecId,
                    Identifier = "h265",
                    Name = "HVEC"
                },
            });
    }
}
