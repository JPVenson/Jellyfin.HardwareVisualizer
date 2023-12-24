using Jellyfin.HardwareVisualizer.Database;
using Jellyfin.HardwareVisualizer.Server.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using ServiceLocator.Discovery.Option;
using ServiceLocator.Discovery.Service;
using System.Reflection;

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

			builder.Services.AddResponseCaching();
			builder.Services.AddResponseCompression();
			builder.Services.AddControllersWithViews();
			builder.Services.AddRazorPages();
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen(options =>
			{
				options.SwaggerDoc("v1", new OpenApiInfo
				{
					Version = "v1",
					Title = "Jellyfin Hardware Survey API",
					Description = "Web API for storing Hardware Survey results for the Jellyfin Project",
					TermsOfService = new Uri("https://example.com/terms"),
					Contact = new OpenApiContact
					{
						Name = "Jellyfin Contact",
						Url = new Uri("https://jellyfin.org/contact")
					},
					License = new OpenApiLicense
					{
						Name = "GNU GENERAL PUBLIC LICENSE",
						Url = new Uri("https://github.com/joshuaboniface/hwatest/blob/master/LICENSE")
					}
				});

				// using System.Reflection;
				var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
				options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
			});
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

			app.UseResponseCaching();
			app.UseResponseCompression();
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