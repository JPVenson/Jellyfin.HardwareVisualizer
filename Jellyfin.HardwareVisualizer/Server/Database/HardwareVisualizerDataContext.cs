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
		modelBuilder.Entity<HardwareDisplay>()
			.HasKey(e => new { e.HardwareCodec, e.ToResolution, e.FromResolution, e.DeviceType, e.DeviceName });

		modelBuilder.Entity<Platform>()
			.HasData(new Platform[]
			{
				new Platform()
				{
					Id = new Guid("2C361BE8-C0EC-4020-984B-66C620DAD840"),
					Name = "Windows 11",
					Type = PlatformType.Windows,
					Version = "Windows 11 version 23H2",
					VersionId = "22631",
					DisplayName = "Windows 11",
					Supported = true
				},
				new Platform()
				{
					Id = new Guid("8D58B84B-73DC-4275-985D-123ABE886818"),
					Name = "Ubuntu",
					Type = PlatformType.Linux,
					Version = "Ubuntu",
					VersionId = "22.04",
					DisplayName = "Ubuntu Focal",
					Supported = true
				},
				new Platform()
				{
					Id = new Guid("3657b420-2f2a-4940-8ed3-ee70b9b3720d"),
					Name = "Linux Generic",
					Type = PlatformType.Linux,
					Version = "Linux",
					VersionId = "Generic",
					DisplayName = "Linux Generic",
					Supported = false
				}
			});

		modelBuilder.Entity<FfmpegVersion>()
			.HasData(new FfmpegVersion[]
			{
				new FfmpegVersion()
				{
					Id = new Guid("A3F734BE-FB92-4A1F-BD8C-B6701E0F7E9F"),
					PlatformId = new Guid("2C361BE8-C0EC-4020-984B-66C620DAD840"),
					Source =
						"https://repo.jellyfin.org/files/ffmpeg/windows/latest-5.x/amd64/jellyfin-ffmpeg_5.1.4-3-portable_win64.zip",
					Version = "5.1.6-3",
					HashSha256 = "824542b798f04c482b171417002c3aee94f880eec2aa1ee9f016de6d912e31bd",
					HashMd5 = "73a6a7f9d02a9abbda0f6aadd39abc89",					
					VersionGroup = new Guid("9F9565F1-4661-484B-8C80-433BC909E70F")
				},
				new FfmpegVersion()
				{
					Id = new Guid("2C720157-F8FB-48C9-8686-D4DFE7DAAE9A"),
					PlatformId = new Guid("8D58B84B-73DC-4275-985D-123ABE886818"),
					Source =
						"https://repo.jellyfin.org/files/ffmpeg/ubuntu/latest-6.x/amd64/jellyfin-ffmpeg6_6.0.1-7-focal_amd64.deb",
					Version = "6.0.1-2",
					HashSha256 = "a01b7d556f69941041e3265f916c22613b2f58fd39a062ccf8a3104b3c99350d",
					HashMd5 = "183e22d865e9d99ab86506f4313b3bae",
					VersionGroup = new Guid("9F9565F1-4661-484B-8C80-433BC909E70F")
				},
				// new FfmpegVersion()
				// {
				// 	Id = new Guid("2C720157-F8FB-48C9-8686-D4DFE7DAAE9A"),
				// 	PlatformId = new Guid("3657b420-2f2a-4940-8ed3-ee70b9b3720d"),
				// 	Source =
				// 		"https://repo.jellyfin.org/files/ffmpeg/linux/6.x/6.0.1-7/amd64/jellyfin-ffmpeg_6.0.1-7_portable_linux64-gpl.tar.xz",
				// 	Version = "6.0.1-7",
				// 	HashSha256 = "",
				// 	HashMd5 = "",
				// 	VersionGroup = new Guid("9F9565F1-4661-484B-8C80-433BC909E70F")
				// }
			});

		modelBuilder.Entity<HardwareCodec>()
			.HasData(new HardwareCodec[]
			{
				new HardwareCodec()
				{
					Id = new Guid("BF2065DC-9B03-48B8-9A30-206A12A6319C"),
					Identifier = "h264",
					Name = "H264"
				},
				new HardwareCodec()
				{
					Id = new Guid("104537DB-E1E2-4490-A82A-AFAEDE9A8FD4"),
					Identifier = "h265",
					Name = "HVEC"
				},
			});

		modelBuilder.Entity<MediaTestFile>()
			.HasData(new MediaTestFile[]
			{
				new MediaTestFile()
				{
					Id = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
					Name = "jellyfish-120-mbps-4k-uhd-hevc-10bit",
					SourceUrl = "https://repo.jellyfin.org/jellyfish/media/jellyfish-120-mbps-4k-uhd-hevc-10bit.mkv",
					Bitrate = 120,
					Size = 429,
					VideoCodec = "HEVC",
					AudioCodec = "",
					HashSha256 = "",
					HashMd5 = "",
				},
				new MediaTestFile()
				{
					Id = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
					Name = "jellyfish-120-mbps-4k-uhd-h264",
					SourceUrl = "https://repo.jellyfin.org/jellyfish/media/jellyfish-120-mbps-4k-uhd-h264.mkv",
					Bitrate = 120,
					Size = 431,
					VideoCodec = "h264",
					AudioCodec = "",
					HashSha256 = "",
					HashMd5 = "",
				},
				new MediaTestFile()
				{
					Id = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
					Name = "jellyfish-40-mbps-hd-hevc-10bit",
					SourceUrl = "https://repo.jellyfin.org/jellyfish/media/jellyfish-40-mbps-hd-hevc-10bit.mkv",
					Bitrate = 40,
					Size = 143,
					VideoCodec = "HEVC",
					AudioCodec = "",
					HashSha256 = "",
					HashMd5 = "",
				},
				new MediaTestFile()
				{
					Id = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
					Name = "jellyfish-40-mbps-hd-h264",
					SourceUrl = "https://repo.jellyfin.org/jellyfish/media/jellyfish-40-mbps-hd-h264.mkv",
					Bitrate = 40,
					Size = 142,
					VideoCodec = "h264",
					AudioCodec = "",
					HashSha256 = "",
					HashMd5 = "",
				}
			});

		var caseCounter = 0;
		var random = new Random(1337);

		Guid GetNext()
		{
			var bytes = new byte[16];
			random.NextBytes(bytes);
			return new Guid(bytes);
		}

		modelBuilder.Entity<TestCase>()
			.HasData(new TestCase[]
			{
				#region File E8A75E65-A3F3-4D92-A45B-84E71A13EFAB
							

				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "2160p",
					ToResolution = "2160p",
					Bitrate = 79616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "2160p",
					ToResolution = "1080p",
					Bitrate = 9616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "2160p",
					ToResolution = "720p",
					Bitrate = 3616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "1080p",
					ToResolution = "2160p",
					Bitrate = 79616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "1080p",
					ToResolution = "1080p",
					Bitrate = 9616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "1080p",
					ToResolution = "720p",
					Bitrate = 3616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "720p",
					ToResolution = "2160p",
					Bitrate = 79616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "720p",
					ToResolution = "1080p",
					Bitrate = 9616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("E8A75E65-A3F3-4D92-A45B-84E71A13EFAB"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "720p",
					ToResolution = "720p",
					Bitrate = 3616000,
				},
				#endregion

				#region File E1E58B15-6664-454C-868A-20442DB30557
				
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "2160p",
					ToResolution = "2160p",
					Bitrate = 79616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "2160p",
					ToResolution = "1080p",
					Bitrate = 9616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "2160p",
					ToResolution = "720p",
					Bitrate = 3616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "1080p",
					ToResolution = "2160p",
					Bitrate = 79616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "1080p",
					ToResolution = "1080p",
					Bitrate = 9616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "1080p",
					ToResolution = "720p",
					Bitrate = 3616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "720p",
					ToResolution = "2160p",
					Bitrate = 79616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "720p",
					ToResolution = "1080p",
					Bitrate = 9616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("E1E58B15-6664-454C-868A-20442DB30557"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "720p",
					ToResolution = "720p",
					Bitrate = 3616000,
				},
				#endregion

				#region File 70DAEBE7-C9FC-4E02-A524-2FC825A49355

				

				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "2160p",
					ToResolution = "2160p",
					Bitrate = 79616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "2160p",
					ToResolution = "1080p",
					Bitrate = 9616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "2160p",
					ToResolution = "720p",
					Bitrate = 3616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "1080p",
					ToResolution = "2160p",
					Bitrate = 79616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "1080p",
					ToResolution = "1080p",
					Bitrate = 9616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "1080p",
					ToResolution = "720p",
					Bitrate = 3616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "720p",
					ToResolution = "2160p",
					Bitrate = 79616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "720p",
					ToResolution = "1080p",
					Bitrate = 9616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("70DAEBE7-C9FC-4E02-A524-2FC825A49355"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "720p",
					ToResolution = "720p",
					Bitrate = 3616000,
				},
				#endregion
				#region File 1D943D13-586D-4562-A968-EB1D0FFAE947
				
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "2160p",
					ToResolution = "2160p",
					Bitrate = 79616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "2160p",
					ToResolution = "1080p",
					Bitrate = 9616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "2160p",
					ToResolution = "720p",
					Bitrate = 3616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "1080p",
					ToResolution = "2160p",
					Bitrate = 79616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "1080p",
					ToResolution = "1080p",
					Bitrate = 9616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "1080p",
					ToResolution = "720p",
					Bitrate = 3616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "720p",
					ToResolution = "2160p",
					Bitrate = 79616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "720p",
					ToResolution = "1080p",
					Bitrate = 9616000,
				},
				new TestCase()
				{
					Id = GetNext(),
					MediaTestFileId = new Guid("1D943D13-586D-4562-A968-EB1D0FFAE947"),
					TestCaseType = TestCaseType.Transcode,
					FromResolution = "720p",
					ToResolution = "720p",
					Bitrate = 3616000,
				},
				#endregion
			});

		modelBuilder.Entity<TestCaseArgument>()
			.HasData(new TestCaseArgument[]
			{
				new TestCaseArgument()
				{
					Id = new Guid("1C76B8CC-7A23-4C9D-8ED7-9CBF2D741631"),
					FfmpegArgument = "-c:v h264 -i {video_file} -autoscale 0 -an -sn -vf scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
					TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Cpu,
					FfmpegVersionGroupId = new Guid("9F9565F1-4661-484B-8C80-433BC909E70F"),
					HardwareCodecId = new Guid("BF2065DC-9B03-48B8-9A30-206A12A6319C"),
				},
				new TestCaseArgument()
				{
					Id = new Guid("26B70D55-42E0-4DEF-8288-F00B562C0D6D"),
					FfmpegArgument = "-c:v hevc -i {video_file} -autoscale 0 -an -sn -vf scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
					TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Cpu,
					FfmpegVersionGroupId = new Guid("9F9565F1-4661-484B-8C80-433BC909E70F"),
					HardwareCodecId = new Guid("104537DB-E1E2-4490-A82A-AFAEDE9A8FD4"),
				},
				new TestCaseArgument()
				{
					Id = new Guid("5535EFBB-BCEE-4196-961D-7C7358C1C232"),
					FfmpegArgument = "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -autoscale 0 -an -sn -vf scale_cuda=-1:{scale}:yuv420p -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
					TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Nvidia,
					FfmpegVersionGroupId = new Guid("9F9565F1-4661-484B-8C80-433BC909E70F"),
					HardwareCodecId = new Guid("BF2065DC-9B03-48B8-9A30-206A12A6319C"),
				},
				new TestCaseArgument()
				{
					Id = new Guid("A3AF8E6A-456A-41C2-91C6-F1A4CDE9C7F4"),
					FfmpegArgument = "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -autoscale 0 -an -sn -vf scale_cuda=-1:{scale}:yuv420p -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
					TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Nvidia,
					FfmpegVersionGroupId = new Guid("9F9565F1-4661-484B-8C80-433BC909E70F"),
					HardwareCodecId = new Guid("104537DB-E1E2-4490-A82A-AFAEDE9A8FD4"),
				},
				new TestCaseArgument()
				{
					Id = new Guid("4FF85976-2046-4560-94FD-A79AF116F154"),
					FfmpegArgument = "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -autoscale 0 -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
					TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Amd,
					FfmpegVersionGroupId = new Guid("9F9565F1-4661-484B-8C80-433BC909E70F"),
					HardwareCodecId = new Guid("BF2065DC-9B03-48B8-9A30-206A12A6319C"),
				},
				new TestCaseArgument()
				{
					Id = new Guid("2A255052-3128-4E2A-A511-BEF273F4889C"),
					FfmpegArgument = "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -autoscale 0 -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
					TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Amd,
					FfmpegVersionGroupId = new Guid("9F9565F1-4661-484B-8C80-433BC909E70F"),
					HardwareCodecId = new Guid("104537DB-E1E2-4490-A82A-AFAEDE9A8FD4"),
				},
				new TestCaseArgument()
				{
					Id = new Guid("49463914-C696-4DCA-8F62-C041EC2D8200"),
					FfmpegArgument = "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -autoscale 0 -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
					TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Intel,
					FfmpegVersionGroupId = new Guid("9F9565F1-4661-484B-8C80-433BC909E70F"),
					HardwareCodecId = new Guid("BF2065DC-9B03-48B8-9A30-206A12A6319C"),
				},
				new TestCaseArgument()
				{
					Id = new Guid("EC73EEB5-E095-40F5-8B84-4D2307F13BFD"),
					FfmpegArgument = "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -autoscale 0 -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark",
					TestCaseArgumentDeviceType = TestCaseArgumentDeviceType.Intel,
					FfmpegVersionGroupId = new Guid("9F9565F1-4661-484B-8C80-433BC909E70F"),
					HardwareCodecId = new Guid("104537DB-E1E2-4490-A82A-AFAEDE9A8FD4"),
				}
			});
	}
}