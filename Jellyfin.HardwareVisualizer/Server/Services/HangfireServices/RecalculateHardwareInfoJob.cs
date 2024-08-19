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
			var cpuDevice = await db.CpuTypes.FirstOrDefaultAsync(e => e.Id == deviceId);
			var gpuDevice = await db.GpuTypes.FirstOrDefaultAsync(e => e.Id == deviceId);

			if(cpuDevice is null && gpuDevice is null)
			{
				throw new Exception("Cannot determine device type");
			}

			IQueryable<HardwareSurveyEntry> query = db.HardwareSurveyEntries;

			if(cpuDevice is not null)
			{
				query = query.Where(e => e.CpuType.Id == deviceId);
			}
			else
			{
				query = query.Where(e => e.GpuType.Id == deviceId);
			}

			var submissions = await query
					.GroupBy(e => new
						{
							CodecName = e.ToHardwareCodec.Name,
							From = e.FromResolution.Name,
							To = e.ToResolution.Name,
						})
						.ToArrayAsync()
					.ConfigureAwait(true);

			var submissionsByGpu =
					submissions
					.Select(e => new HardwareDisplay()
					{
						HardwareCodec = e.Key.CodecName,
						Diviation = 0,
						FromResolution = e.Key.From,
						ToResolution = e.Key.To,
						DeviceType = cpuDevice == null ? DeviceType.Gpu : DeviceType.Cpu,
						DeviceName = gpuDevice?.Name ?? cpuDevice!.Name,
						MaxStreams = e.Average(f => f.MaxStreams)
					})
					.ToArray();

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