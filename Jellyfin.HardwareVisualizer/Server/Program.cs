using Jellyfin.HardwareVisualizer.Database;
using Jellyfin.HardwareVisualizer.Server.Configuration;
using Microsoft.EntityFrameworkCore;
using ServiceLocator.Discovery.Option;
using ServiceLocator.Discovery.Service;

namespace Jellyfin.HardwareVisualizer.Server
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Configuration.AddEnvironmentVariables("PG_").AddEnvironmentVariables("JF_");
			// Add services to the container.

			builder.Services
				.UseServiceDiscovery()
				.FromAssembly(typeof(Program).Assembly)
				.DiscoverOptions(builder.Configuration)
				.FromAssembly(typeof(Program).Assembly)
				.LocateServices();

			builder.Services.AddControllersWithViews();
			builder.Services.AddRazorPages();
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();
			builder.Services.AddDbContextFactory<HardwareVisualizerDataContext>(opt =>
			{
				var efCoreOptions = builder.Configuration.Get<EFCoreOptions>();
				opt.UseNpgsql($"User ID={efCoreOptions.User};Password={efCoreOptions.Password};Host={efCoreOptions.Host};Port={efCoreOptions.Port};Database={efCoreOptions.Database};Pooling=true;");
			});

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseWebAssemblyDebugging();
			}
			else
			{
				app.UseExceptionHandler("/Error");
			}

			app.UseBlazorFrameworkFiles();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseSwagger();
			app.UseSwaggerUI();

			app.MapRazorPages();
			app.MapControllers();
			app.MapFallbackToFile("index.html");
			app.MapSwagger();

			using (var scope = app.Services.CreateScope())
			{
				var services = scope.ServiceProvider;

				var context = services.GetRequiredService<HardwareVisualizerDataContext>();
				context.Database.Migrate();
			}

			app.Run();
		}
	}
}