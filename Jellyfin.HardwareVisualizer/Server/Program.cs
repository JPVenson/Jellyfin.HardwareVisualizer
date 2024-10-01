using Jellyfin.HardwareVisualizer.Server.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using ServiceLocator.Discovery.Option;
using ServiceLocator.Discovery.Service;
using System.Reflection;
using System.Threading.RateLimiting;
using Microsoft.AspNetCore.RateLimiting;
using System.Net.Http.Headers;
using System.Text.Json;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using System.Text.Json.Serialization;
using Hangfire;
using Hangfire.AspNetCore;
using Hangfire.PostgreSql;
using Jellyfin.HardwareVisualizer.Server.Database;
using Microsoft.AspNetCore.Authentication.Cookies;
using Octokit;
using Octokit.Internal;
using ProductHeaderValue = Octokit.ProductHeaderValue;
using System.Net;
using Microsoft.AspNetCore.HttpOverrides;

namespace Jellyfin.HardwareVisualizer.Server;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);
		builder.Configuration
			.AddEnvironmentVariables("PG_")
			.AddEnvironmentVariables("JF_")
			.AddEnvironmentVariables("GH_")
			.AddEnvironmentVariables("HOSTING_");
		// Add services to the container.
			

		string GetConnectionString()
		{
			var efCoreOptions = builder.Configuration.Get<EFCoreOptions>();
			var s = $"User ID={efCoreOptions.User};Password={efCoreOptions.Password};Host={efCoreOptions.Host};Port={efCoreOptions.Port};Database={efCoreOptions.Database};Pooling=true;";
			return s;
		}

		builder.Services
			.UseServiceDiscovery()
			.FromAssembly(typeof(Program).Assembly)
			.DiscoverOptions(builder.Configuration)
			.FromAssembly(typeof(Program).Assembly)
			.LocateServices();

		builder.Services.AddMemoryCache();
		builder.Services.AddResponseCaching();
		builder.Services.AddResponseCompression();
		builder.Services.AddControllersWithViews()
			.AddJsonOptions(e =>
			{
				e.JsonSerializerOptions.AllowTrailingCommas = true;
				e.JsonSerializerOptions.DictionaryKeyPolicy = null;
				e.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
				e.JsonSerializerOptions.Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
				e.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower;
				e.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.SnakeCaseLower, false));
			});
		builder.Services.AddRazorPages();
		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddHttpContextAccessor();
		builder.Services.AddHangfire(e => 
			e.SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
				.UseSimpleAssemblyNameTypeSerializer()
				.UseRecommendedSerializerSettings()
				.UsePostgreSqlStorage(f => f.UseNpgsqlConnection(() => GetConnectionString()))
		);

		builder.Services.Configure<ForwardedHeadersOptions>(options =>
		{				
			var hostingOptions = builder.Configuration.Get<HostingOptions>();
			options.ForwardLimit = 2;
			options.ForwardedHeaders = ForwardedHeaders.XForwardedFor;
			Console.WriteLine("Add Proxy Settings.");
			foreach(var proxy in hostingOptions.KnownProxies ?? [])
			{
				Console.WriteLine($"Add Proxy: {proxy}");
				options.KnownProxies.Add(IPAddress.Parse(proxy));
			}
		});
		

		builder.Services.AddRateLimiter(_ => _.AddFixedWindowLimiter("fixed_submit", options =>
		{
			options.PermitLimit = 1;
			options.Window = TimeSpan.FromHours(1);
			options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
			options.QueueLimit = 1;
		}));
		builder.Services.AddRateLimiter(_ => _.AddFixedWindowLimiter("fixed_metadata", options =>
		{
			options.PermitLimit = 10;
			options.Window = TimeSpan.FromMinutes(1);
			options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
			options.QueueLimit = 10;
		}));
		var authenticationBuilder = builder.Services
			.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
			.AddCookie();
		var oauthSettings = builder.Configuration.GetSection("GH").Get<GithubOauthOptions>();
		if (oauthSettings != null)
		{
			Console.WriteLine("Add Github Authentication.");
			authenticationBuilder.AddGitHub(options =>
				{
					var oauthSettings = builder.Configuration.GetSection("GH").Get<GithubOauthOptions>();
					options.ClientId = oauthSettings.ClientId;
					options.ClientSecret = oauthSettings.ClientSecret;
					options.Scope.Add("user:email");
					options.Scope.Add("read:org");

					options.SaveTokens = true;
					options.ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "id");
					options.ClaimActions.MapJsonKey(ClaimTypes.Name, "name");
					options.ClaimActions.MapJsonKey("urn:github:login", "login");
					options.ClaimActions.MapJsonKey("urn:github:url", "html_url");
					options.ClaimActions.MapJsonKey("urn:github:avatar", "avatar_url");


					options.Events.OnCreatingTicket = async context =>
					{
						var request = new HttpRequestMessage(HttpMethod.Get, context.Options.UserInformationEndpoint);
						request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
						request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", context.AccessToken);
						var response = await context.Backchannel.SendAsync(request,
							HttpCompletionOption.ResponseHeadersRead, context.HttpContext.RequestAborted);
						response.EnsureSuccessStatusCode();
						var json = JsonDocument.Parse(await response.Content.ReadAsStringAsync());
						context.RunClaimActions(json.RootElement);
						var octClient =
							new GitHubClient(new ProductHeaderValue("Jellyfin.HardwareSurvey.Server"), new InMemoryCredentialStore(new Credentials(context.AccessToken)));
						var organizations = await octClient.Organization.GetAllForCurrent();
						if (organizations.All(e => e.Id != 45698031))
						{
							context.Fail("Not part of the Jellyfin Organization");
							return;
						}
					};
				})
				;
		}
		else
		{
			Console.WriteLine("Github Authentication is not enabled.");
		}

				

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

			options.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
			{
				Description = "ApiKey must appear in header",
				Type = SecuritySchemeType.ApiKey,
				Name = "XApiKey",
				In = ParameterLocation.Header,
				Scheme = "ApiKeyScheme"
			});
			var key = new OpenApiSecurityScheme()
			{
				Reference = new OpenApiReference
				{
					Type = ReferenceType.SecurityScheme,
					Id = "ApiKey"
				},
				In = ParameterLocation.Header
			};
			var requirement = new OpenApiSecurityRequirement
			{
				{ key, new List<string>() }
			};
			options.AddSecurityRequirement(requirement);

			var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
			options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
		});

		builder.Services.AddDbContextFactory<HardwareVisualizerDataContext>(opt =>
		{
			var connectionString = GetConnectionString();
			opt.UseNpgsql(connectionString);
		});

		var app = builder.Build();
		app.UseForwardedHeaders();
		
		using (var scope = app.Services.CreateScope())
		{
			var services = scope.ServiceProvider;
			DbSetupHelper.SetupDbIfNotExist(GetConnectionString());
			var context = services.GetRequiredService<HardwareVisualizerDataContext>();
			var pending = context.Database.GetPendingMigrations();
			context.Database.Migrate();
		}

		var serviceScopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();

		app.UseHangfireServer(() =>
		{
			return new BackgroundJobServer(new BackgroundJobServerOptions()
			{
				Activator = new AspNetCoreJobActivator(serviceScopeFactory)
			});
		});

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
		app.UseAuthentication();
		app.UseAuthorization();

		app.UseSwagger();
		app.UseSwaggerUI(options =>
		{
			options.OAuthClientId("api-swagger");
			options.OAuthScopes("profile", "openid", "api");
			options.OAuthUsePkce();
			options.EnablePersistAuthorization();
		});

		app.MapRazorPages();
		app.MapControllers();
		app.MapFallbackToFile("index.html");
		app.MapSwagger();


		app.Run();
	}
}