using Hangfire;

namespace Jellyfin.HardwareVisualizer.Server.Services.HangfireServices
{
	public class ServiceCollectionActivator : JobActivator
	{
		public override object ActivateJob(Type jobType)
		{
			return base.ActivateJob(jobType);
		}
	}
}
