using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Jellyfin.HardwareVisualizer.Server.Database;

public class HardwareVisualizerDataContext : DbContext
{
	public HardwareVisualizerDataContext(DbContextOptions<HardwareVisualizerDataContext> contextOptions) : base(
		contextOptions)
	{
	}

	public DbSet<GpuType> GpuTypes { get; set; }
	public DbSet<CpuType> CpuTypes { get; set; }
	public DbSet<HardwareCodec> HardwareCodecs { get; set; }
	public DbSet<HardwareSurveyEntry> HardwareSurveyEntries { get; set; }
	public DbSet<HardwareSurveySubmission> HardwareSurveySubmissions { get; set; }
	public DbSet<HardwareDisplay> HardwareDisplays { get; set; }
	public DbSet<TestResolution> TestResolutions { get; set; }

	public DbSet<FfmpegVersion> FfmpegVersions { get; set; }
	public DbSet<MediaTestFile> MediaTestFiles { get; set; }
	public DbSet<TestCase> TestCases { get; set; }
	public DbSet<TestCaseArgument> TestCaseArguments { get; set; }
	public DbSet<Platform> Platform { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		base.OnConfiguring(optionsBuilder);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);

		modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
	}
}
