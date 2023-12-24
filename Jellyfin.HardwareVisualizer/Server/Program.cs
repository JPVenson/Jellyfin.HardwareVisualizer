using Jellyfin.HardwareVisualizer.Database;
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

			// Add services to the container.

			builder.Services.AddControllersWithViews();
			builder.Services.AddRazorPages();
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();
			builder.Services.AddDbContextFactory<HardwareVisualizerDataContext>(opt => opt.UseNpgsql());
			//builder.Services.AddDbContextFactory<HardwareVisualizerDataContext>(opt => opt.UseInMemoryDatabase("JellyfinHardwareVisual"));
			builder.Services
				.UseServiceDiscovery()
				.FromAssembly(typeof(Program).Assembly)
				.DiscoverOptions(builder.Configuration)
				.FromAssembly(typeof(Program).Assembly)
				.LocateServices();

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
			app.Run();
		}
	}
}