using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Jellyfin.HardwareVisualizer.Database;

public class HardwareVisualizerDataContext : DbContext
{
	public HardwareVisualizerDataContext(DbContextOptions contextOptions) : base(contextOptions)
	{
		
	}

	public DbSet<GpuType> GpuTypes { get; set; }
	public DbSet<CpuType> CpuTypes { get; set; }
	public DbSet<HardwareCodec> HardwareCodecs { get; set; }
	public DbSet<HardwareSurveyEntry> HardwareSurveyEntries { get; set; }
	public DbSet<HardwareSurveySubmission> HardwareSurveySubmissions { get; set; }
	public DbSet<HardwareDisplay> HardwareDisplays { get; set; }
	public DbSet<TestResolution> TestResolutions { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		base.OnConfiguring(optionsBuilder);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.Entity<HardwareDisplay>()
			.HasKey(e => new { e.HardwareCodec, e.ToResolution, e.FromResolution, e.DeviceType, e.DeviceName });
	}
}

public class DeviceBase
{
	[Key]
	public Guid Id { get; set; }
	public string Name { get; set; }
	public string Identifier { get; set; }
	public string Vendor { get; set; }
}

public class GpuType : DeviceBase
{
}

public class CpuType : DeviceBase
{
}

public class HardwareCodec
{
	[Key]
	public Guid Id { get; set; }
	public string Name { get; set; }
	public string Identifier { get; set; }
}

public class TestResolution
{
	[Key]
	public Guid Id { get; set; }
	public string Name { get; set; }
	public string Identifier { get; set; }
}

public class HardwareSurveyEntry
{
	[Key]
	public Guid Id { get; set; }
	public Guid HardwareCodecId { get; set; }
	public HardwareCodec HardwareCodec { get; set; }


	public Guid? GpuTypeId { get; set; }
	public GpuType? GpuType { get; set; } = null!;

	public Guid? CpuTypeId { get; set; }
	public CpuType? CpuType { get; set; } = null!;

	public Guid HardwareSurveySubmissionId { get; set; }
	public HardwareSurveySubmission HardwareSurveySubmission { get; set; } = null!;

	public Guid FromResolutionId { get; set; }
	public TestResolution FromResolution { get; set; } = null!;
	public Guid ToResolutionId { get; set; }
	public TestResolution ToResolution { get; set; } = null!;

	public int MaxStreams { get; set; }
}

public class HardwareSurveySubmission
{
	[Key]
	public Guid Id { get; set; }

	public ICollection<HardwareSurveyEntry> HardwareSurveyEntry { get; set; } = null!;

	public Guid RawSurveySubmissionId { get; set; }
	public RawSurveySubmission RawSurveySubmission { get; set; }
}

public class RawSurveySubmission
{
	public Guid Id { get; set; }
	public string Json { get; set; }
}

public class HardwareDisplay
{
	public DeviceType DeviceType { get; set; }
	public string DeviceName { get; set; }
	public string HardwareCodec { get; set; }
	public string FromResolution { get; set; } = null!;
	public string ToResolution { get; set; } = null!;

	public double MaxStreams { get; set; }
	public float Diviation { get; set; }
}

public enum DeviceType
{
	Cpu,
	Gpu,
}