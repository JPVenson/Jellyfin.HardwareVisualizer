using System;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jellyfin.HardwareVisualizer.Server.Database.Configuration;

public class HardwareDisplayConfig : IEntityTypeConfiguration<HardwareDisplay>
{
    public void Configure(EntityTypeBuilder<HardwareDisplay> modelBuilder)
    {
        modelBuilder
            .HasKey(e => new { e.HardwareCodec, e.ToResolution, e.FromResolution, e.DeviceType, e.DeviceName });
    }
}
