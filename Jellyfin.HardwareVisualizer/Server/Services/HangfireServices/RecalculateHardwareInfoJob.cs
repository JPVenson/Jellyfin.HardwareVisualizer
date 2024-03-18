using System.Transactions;
using Jellyfin.HardwareVisualizer.Server.Database;
using Microsoft.EntityFrameworkCore;
using ServiceLocator.Attributes;

namespace Jellyfin.HardwareVisualizer.Server.Services.HangfireServices;

[ScopedService]
public class RecalculateHardwareInfoJob
{
	private readonly IDbContextFactory<HardwareVisualizerDataContext> _dbContextFactory;

	public RecalculateHardwareInfoJob(IDbContextFactory<HardwareVisualizerDataContext> dbContextFactory)
	{
		_dbContextFactory = dbContextFactory;
	}

	public async Task RecalcHardwareStats(Guid deviceId)
	{
		try
		{
			await using var db = await _dbContextFactory.CreateDbContextAsync();
			var submissionsByGpu =
				await db.HardwareSurveyEntries.Where(e => e.GpuType.Id == deviceId || e.CpuType.Id == deviceId).GroupBy(
						e => new
						{
							DeviceType = e.GpuType == null ? DeviceType.Cpu : DeviceType.Gpu,
							DeviceName = e.GpuType!.Name ?? e.CpuType!.Name,
							CodecName = e.HardwareCodec.Name,
							From = e.FromResolution.Name,
							To = e.ToResolution.Name,
						})
					.Select(e => new HardwareDisplay()
					{
						HardwareCodec = e.Key.CodecName,
						Diviation = 0,
						FromResolution = e.Key.From,
						ToResolution = e.Key.To,
						DeviceType = e.Key.DeviceType,
						DeviceName = e.Key.DeviceName,
						MaxStreams = e.Average(f => f.MaxStreams)
					})
					.ToArrayAsync()
					.ConfigureAwait(true);

			var changedDevices = submissionsByGpu.Select(e => e.DeviceName).Distinct().ToArray();

			await db.HardwareDisplays
				.Where(e => changedDevices.Contains(e.DeviceName))
				.ExecuteDeleteAsync()
				.ConfigureAwait(true);
			await db.HardwareDisplays
				.AddRangeAsync(submissionsByGpu)
				.ConfigureAwait(true);
			await db.HardwareSurveyEntries
				.Where(e => !e.Processed)
				.Where(e => e.GpuType.Id == deviceId || e.CpuType.Id == deviceId)
				.ExecuteUpdateAsync(e => e.SetProperty(f => f.Processed, true))
				.ConfigureAwait(true);
			await db.SaveChangesAsync();
		}
		catch (Exception e)
		{
			Console.WriteLine(e);
			throw;
		}
	}
}