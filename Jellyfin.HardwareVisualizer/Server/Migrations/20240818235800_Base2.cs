#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jellyfin.HardwareVisualizer.Server.Migrations
{
    /// <inheritdoc />
    public partial class Base2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CpuTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Identifier = table.Column<string>(type: "text", nullable: false),
                    Vendor = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CpuTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GpuTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Identifier = table.Column<string>(type: "text", nullable: false),
                    Vendor = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GpuTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HardwareCodecs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Identifier = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardwareCodecs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HardwareDisplays",
                columns: table => new
                {
                    DeviceType = table.Column<int>(type: "integer", nullable: false),
                    DeviceName = table.Column<string>(type: "text", nullable: false),
                    HardwareCodec = table.Column<string>(type: "text", nullable: false),
                    FromResolution = table.Column<string>(type: "text", nullable: false),
                    ToResolution = table.Column<string>(type: "text", nullable: false),
                    MaxStreams = table.Column<double>(type: "double precision", nullable: false),
                    Diviation = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardwareDisplays", x => new { x.HardwareCodec, x.ToResolution, x.FromResolution, x.DeviceType, x.DeviceName });
                });

            migrationBuilder.CreateTable(
                name: "MediaTestFiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    SourceUrl = table.Column<string>(type: "text", nullable: false),
                    Bitrate = table.Column<long>(type: "bigint", nullable: false),
                    Size = table.Column<long>(type: "bigint", nullable: false),
                    VideoCodec = table.Column<string>(type: "text", nullable: false),
                    AudioCodec = table.Column<string>(type: "text", nullable: false),
                    HashMd5 = table.Column<string>(type: "text", nullable: true),
                    HashSha256 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaTestFiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Platform",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Version = table.Column<string>(type: "text", nullable: false),
                    VersionId = table.Column<string>(type: "text", nullable: false),
                    DisplayName = table.Column<string>(type: "text", nullable: false),
                    ReplacementId = table.Column<string>(type: "text", nullable: true),
                    Supported = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platform", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RawSurveySubmission",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Json = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RawSurveySubmission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestResolutions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Identifier = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestResolutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestCases",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MediaTestFileId = table.Column<Guid>(type: "uuid", nullable: false),
                    TestCaseType = table.Column<int>(type: "integer", nullable: false),
                    ToCodecId = table.Column<Guid>(type: "uuid", nullable: false),
                    FromResolution = table.Column<string>(type: "text", nullable: false),
                    ToResolution = table.Column<string>(type: "text", nullable: false),
                    Bitrate = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestCases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestCases_HardwareCodecs_ToCodecId",
                        column: x => x.ToCodecId,
                        principalTable: "HardwareCodecs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestCases_MediaTestFiles_MediaTestFileId",
                        column: x => x.MediaTestFileId,
                        principalTable: "MediaTestFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FfmpegVersions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Source = table.Column<string>(type: "text", nullable: false),
                    Version = table.Column<string>(type: "text", nullable: false),
                    VersionGroup = table.Column<Guid>(type: "uuid", nullable: false),
                    PlatformId = table.Column<Guid>(type: "uuid", nullable: false),
                    HashMd5 = table.Column<string>(type: "text", nullable: true),
                    HashSha256 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FfmpegVersions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FfmpegVersions_Platform_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platform",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HardwareSurveySubmissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RawSurveySubmissionId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardwareSurveySubmissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HardwareSurveySubmissions_RawSurveySubmission_RawSurveySubm~",
                        column: x => x.RawSurveySubmissionId,
                        principalTable: "RawSurveySubmission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TestCaseArguments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FfmpegArgument = table.Column<string>(type: "text", nullable: false),
                    TestCaseArgumentDeviceType = table.Column<int>(type: "integer", nullable: false),
                    FfmpegVersionGroupId = table.Column<Guid>(type: "uuid", nullable: false),
                    HardwareCodecId = table.Column<Guid>(type: "uuid", nullable: false),
                    FfmpegVersionId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestCaseArguments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestCaseArguments_FfmpegVersions_FfmpegVersionId",
                        column: x => x.FfmpegVersionId,
                        principalTable: "FfmpegVersions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TestCaseArguments_HardwareCodecs_HardwareCodecId",
                        column: x => x.HardwareCodecId,
                        principalTable: "HardwareCodecs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HardwareSurveyEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FromHardwareCodecId = table.Column<Guid>(type: "uuid", nullable: false),
                    ToHardwareCodecId = table.Column<Guid>(type: "uuid", nullable: false),
                    GpuTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    CpuTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    HardwareSurveySubmissionId = table.Column<Guid>(type: "uuid", nullable: false),
                    FromResolutionId = table.Column<Guid>(type: "uuid", nullable: false),
                    ToResolutionId = table.Column<Guid>(type: "uuid", nullable: false),
                    MaxStreams = table.Column<int>(type: "integer", nullable: false),
                    Processed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardwareSurveyEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HardwareSurveyEntries_CpuTypes_CpuTypeId",
                        column: x => x.CpuTypeId,
                        principalTable: "CpuTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HardwareSurveyEntries_GpuTypes_GpuTypeId",
                        column: x => x.GpuTypeId,
                        principalTable: "GpuTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HardwareSurveyEntries_HardwareCodecs_FromHardwareCodecId",
                        column: x => x.FromHardwareCodecId,
                        principalTable: "HardwareCodecs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HardwareSurveyEntries_HardwareCodecs_ToHardwareCodecId",
                        column: x => x.ToHardwareCodecId,
                        principalTable: "HardwareCodecs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HardwareSurveyEntries_HardwareSurveySubmissions_HardwareSur~",
                        column: x => x.HardwareSurveySubmissionId,
                        principalTable: "HardwareSurveySubmissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HardwareSurveyEntries_TestResolutions_FromResolutionId",
                        column: x => x.FromResolutionId,
                        principalTable: "TestResolutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HardwareSurveyEntries_TestResolutions_ToResolutionId",
                        column: x => x.ToResolutionId,
                        principalTable: "TestResolutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "HardwareCodecs",
                columns: new[] { "Id", "Identifier", "Name" },
                values: new object[,]
                {
                    { new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "h265", "HVEC" },
                    { new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "h264", "H264" }
                });

            migrationBuilder.InsertData(
                table: "MediaTestFiles",
                columns: new[] { "Id", "AudioCodec", "Bitrate", "HashMd5", "HashSha256", "Name", "Size", "SourceUrl", "VideoCodec" },
                values: new object[,]
                {
                    { new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), "", 40L, "", "", "jellyfish-40-mbps-hd-h264", 142L, "https://repo.jellyfin.org/jellyfish/media/jellyfish-40-mbps-hd-h264.mkv", "h264" },
                    { new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), "", 40L, "", "", "jellyfish-40-mbps-hd-hevc-10bit", 143L, "https://repo.jellyfin.org/jellyfish/media/jellyfish-40-mbps-hd-hevc-10bit.mkv", "HEVC" },
                    { new Guid("e1e58b15-6664-454c-868a-20442db30557"), "", 120L, "", "", "jellyfish-120-mbps-4k-uhd-h264", 431L, "https://repo.jellyfin.org/jellyfish/media/jellyfish-120-mbps-4k-uhd-h264.mkv", "h264" },
                    { new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), "", 120L, "", "", "jellyfish-120-mbps-4k-uhd-hevc-10bit", 429L, "https://repo.jellyfin.org/jellyfish/media/jellyfish-120-mbps-4k-uhd-hevc-10bit.mkv", "HEVC" }
                });

            migrationBuilder.InsertData(
                table: "Platform",
                columns: new[] { "Id", "DisplayName", "Name", "ReplacementId", "Supported", "Type", "Version", "VersionId" },
                values: new object[,]
                {
                    { new Guid("2c361be8-c0ec-4020-984b-66c620dad840"), "Windows 11", "Windows 11", null, true, 0, "Windows 11 version 23H2", "22631" },
                    { new Guid("3657b420-2f2a-4940-8ed3-ee70b9b3720d"), "Linux Generic", "Linux Generic", null, true, 1, "Linux", "Generic" },
                    { new Guid("79191671-caa0-4b52-8a9e-eaa2f040a1cc"), "Windows 10", "Windows 10", null, true, 0, "Windows 10 version 22H2", "19045" },
                    { new Guid("8d58b84b-73dc-4275-985d-123abe886818"), "Ubuntu Focal", "Ubuntu", null, true, 1, "Ubuntu", "22.04" }
                });

            migrationBuilder.InsertData(
                table: "FfmpegVersions",
                columns: new[] { "Id", "HashMd5", "HashSha256", "PlatformId", "Source", "Version", "VersionGroup" },
                values: new object[,]
                {
                    { new Guid("2c720157-f8fb-48c9-8686-d4dfe7daae9a"), "d41d8cd98f00b204e9800998ecf8427e", "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855", new Guid("8d58b84b-73dc-4275-985d-123abe886818"), "https://repo.jellyfin.org/files/ffmpeg/linux/6.x/6.0.1-7/amd64/jellyfin-ffmpeg_6.0.1-7_portable_linux64-gpl.tar.xz", "6.0.1-7", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f") },
                    { new Guid("501d7e27-8410-40af-b48d-1e7ce0002173"), "d41d8cd98f00b204e9800998ecf8427e", "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855", new Guid("3657b420-2f2a-4940-8ed3-ee70b9b3720d"), "https://repo.jellyfin.org/files/ffmpeg/linux/6.x/6.0.1-7/amd64/jellyfin-ffmpeg_6.0.1-7_portable_linux64-gpl.tar.xz", "6.0.1-7", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f") },
                    { new Guid("7f9e0bb6-7346-400f-881c-33c3c1558d78"), "73a6a7f9d02a9abbda0f6aadd39abc89", "824542b798f04c482b171417002c3aee94f880eec2aa1ee9f016de6d912e31bd", new Guid("79191671-caa0-4b52-8a9e-eaa2f040a1cc"), "https://repo.jellyfin.org/files/ffmpeg/windows/latest-5.x/amd64/jellyfin-ffmpeg_5.1.4-3-portable_win64.zip", "5.1.6-3", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512") },
                    { new Guid("a3f734be-fb92-4a1f-bd8c-b6701e0f7e9f"), "73a6a7f9d02a9abbda0f6aadd39abc89", "824542b798f04c482b171417002c3aee94f880eec2aa1ee9f016de6d912e31bd", new Guid("2c361be8-c0ec-4020-984b-66c620dad840"), "https://repo.jellyfin.org/files/ffmpeg/windows/latest-5.x/amd64/jellyfin-ffmpeg_5.1.4-3-portable_win64.zip", "5.1.6-3", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512") }
                });

            migrationBuilder.InsertData(
                table: "TestCaseArguments",
                columns: new[] { "Id", "FfmpegArgument", "FfmpegVersionGroupId", "FfmpegVersionId", "HardwareCodecId", "TestCaseArgumentDeviceType" },
                values: new object[,]
                {
                    { new Guid("018ca3e9-19f4-ba19-2cb4-0294cd19e5e3"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -autoscale 0 -an -sn -vf scale_cuda=-1:{scale}:yuv420p -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1 },
                    { new Guid("0891f1aa-1993-8fd2-fe68-3af0074f2f44"), "-c:v h264 -i {video_file} -autoscale 0 -an -sn -vf scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0 },
                    { new Guid("1be730c5-357b-766c-421f-796d0ed9e94a"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -autoscale 0 -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2 },
                    { new Guid("1dce6c92-cc4c-2fc9-a7e6-c622baf6cd92"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -autoscale 0 -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2 },
                    { new Guid("332e69da-6c46-3b75-2ac9-c2c1068dcdc2"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -autoscale 0 -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3 },
                    { new Guid("36c317cc-6ad9-f893-67b7-73946e49bc4c"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -autoscale 0 -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3 },
                    { new Guid("3f5be651-27ba-01d6-dda8-9ef038a7ced0"), "-c:v h264 -i {video_file} -autoscale 0 -an -sn -vf scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0 },
                    { new Guid("613e75dc-d052-95e8-4f22-3444b6a87ba3"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -autoscale 0 -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3 },
                    { new Guid("78d39a65-b56e-863f-2e15-4dc69c0ad727"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -autoscale 0 -an -sn -vf scale=-1:{scale}:format=nv12 -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2 },
                    { new Guid("7ad0479f-9f7b-a59f-40c1-5830cba2c0bf"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -autoscale 0 -an -sn -vf scale_cuda=-1:{scale}:yuv420p -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1 },
                    { new Guid("a3556c08-9732-a6b9-3c26-5abc1cfab734"), "-c:v hevc -i {video_file} -autoscale 0 -an -sn -vf scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0 },
                    { new Guid("b48f8f93-bd06-dbbe-a63d-772a071fa30a"), "-c:v hevc -i {video_file} -autoscale 0 -an -sn -vf scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0 },
                    { new Guid("c11fcf11-9074-258e-7e5c-942160d7de59"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -autoscale 0 -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3 },
                    { new Guid("d6d2ea5b-da40-ec44-33b6-6255a2a887df"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -autoscale 0 -an -sn -vf scale_cuda=-1:{scale}:yuv420p -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1 },
                    { new Guid("f0506af1-54d7-6954-cdb0-62703e89da99"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -autoscale 0 -an -sn -vf scale=-1:{scale}:format=nv12 -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2 },
                    { new Guid("fad3ec09-1cd8-704c-3b99-aee4f15bab0a"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -autoscale 0 -an -sn -vf scale_cuda=-1:{scale}:yuv420p -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1 }
                });

            migrationBuilder.InsertData(
                table: "TestCases",
                columns: new[] { "Id", "Bitrate", "FromResolution", "MediaTestFileId", "TestCaseType", "ToCodecId", "ToResolution" },
                values: new object[,]
                {
                    { new Guid("04062623-a591-c68b-566b-e519cc207e24"), 79616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("08baf6bd-197d-c126-608b-b583104d6a6a"), 79616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("097a9f8c-93fb-803d-b661-636d473a43d2"), 9616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("0a62d7f3-7eca-a107-998b-3b8f4d44ace2"), 79616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("0ad21a90-d4c1-86cf-4eba-6a4cee8c7c0d"), 3616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("0d684fb2-71d4-4290-b3a5-26a3b132d35d"), 9616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("11dfaadf-13dc-0016-c3d6-a52e2ca91cc9"), 79616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("147183c7-3f87-1ccc-adb8-6f19c12f6b0a"), 79616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("197e68ac-1e23-5449-5c59-03c99659f2b4"), 9616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("1b61e958-77ea-4fe3-e287-483d8b2bbc34"), 9616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("1c9bbacd-3b0c-0e69-b16d-1caabb5e5d33"), 3616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("28efd25d-ca42-f9cb-b93c-a5bbd981d30b"), 9616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("2909b3bb-ebf5-aa8a-268e-30d957c7030b"), 9616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("29755a9c-2670-f91d-ac43-130a6f95282d"), 79616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("29c9f9a8-b3c0-2385-a4dc-493ab757d61b"), 79616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("2a25432e-1f5d-51b1-5d76-87a49c43cc34"), 9616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("2b51a90a-cc94-f2a7-c5da-c06770fc3249"), 3616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("3423dd1d-2943-4c32-4f7f-b1418d962c43"), 3616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("35d9fee7-ee4f-f3ca-9655-8ff692540bd5"), 79616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("3ff4f7ee-f4b9-ab21-fae8-843e3b0d6a1d"), 79616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("502f4082-68ae-b9e3-4e34-e8229c978c5f"), 9616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("50568481-5469-6623-3f4a-0b2ac2829f78"), 9616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("51585605-4769-f7f0-9251-68be2678c51b"), 3616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("56398356-cd67-18e1-1206-3489c3754ade"), 79616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("5f2f3607-8461-6f48-f4e7-63a8afce220f"), 9616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("5fa366d5-e1ba-ec78-d922-3c767caa3e53"), 3616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("622d5521-077e-82d9-98ba-c596afc2c974"), 9616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("638fd910-5444-35c9-f26f-6a3c3364ec20"), 3616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("651a1429-b825-27a3-2ed4-c5a155504290"), 3616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("672ebae6-976d-5f2a-bc97-66d793ae9099"), 3616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("69a47cb5-7811-1d2c-7f52-6a7d5b399383"), 9616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("6c770f23-6c1d-81d1-e0b7-5f5eedf2c176"), 3616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("7690d373-dc4e-a22f-df5a-de76f9d765a5"), 79616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("774fa97a-0274-cd8a-ed41-20a9767c5e82"), 3616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("7857d0e2-57cb-190f-44e5-86ab8cf6ab77"), 9616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("7f310440-5cde-6c14-f774-109bd052ebbf"), 9616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("99dc4bc0-d405-49e9-25ae-04b7634817eb"), 79616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("9eacf12d-ed12-4cad-86a7-14c39c8c940b"), 9616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("9f0be794-ea9e-ec37-3096-f1de916ce744"), 3616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("aadc3d7e-8ee7-2cd0-3bfe-86df8f994a45"), 79616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("ad290d8a-2c4c-b34b-598a-2f6566d08e4b"), 3616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("b254896a-12e5-1eef-9af7-227ef036e328"), 9616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("b2e8c4df-e892-2001-6574-94f031be41d3"), 9616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("b320b73d-eba6-063d-786f-3b7b7928c159"), 3616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("b3332698-6127-b00f-a6eb-ea8f2ce2cef6"), 9616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("b645bf2e-8bac-77f6-7759-28e4972dd79d"), 9616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("b7ea429f-f7b1-a593-1d18-08495a415adc"), 3616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("b7ef62d7-1905-fdfe-d97d-3b3cb28bc72f"), 9616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("b7fa8d15-aa69-329d-340b-c3904ef0a865"), 3616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("baf3bb5a-59f6-5524-10d6-2d4c3c84b98b"), 79616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("bba8fafb-5fb0-1ad4-2408-503d0bb8ae05"), 9616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("bd30c9e2-1401-e18d-3fcd-84d17a7f5b0e"), 3616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("bf801b8a-be7d-1c02-32e0-7c13490f1915"), 79616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("c07ceb60-14dc-40ff-a3b1-92baa5e5ceeb"), 3616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("c1d474a5-ba17-69e3-c756-e60d4fa4da45"), 3616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("c4b19ba7-c1e0-e26a-e3db-2651d870f25f"), 3616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("c7f40068-5e43-aa02-c27c-4fd927fc2227"), 79616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("c84b0320-56a3-62c0-b138-a037fb4859cc"), 9616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("c8ba3a3e-15a1-0a5e-5072-b07223ac9438"), 79616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("ce2bfcee-c9ba-d88d-56fa-c5e694592e67"), 3616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("d0f1f207-37b5-0984-da97-377dec6925e0"), 9616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("d2f2a7bf-a56d-f685-bf29-88ff1527dcba"), 3616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("d5b81f94-7813-e7bb-dc18-fef5b34b0ab2"), 79616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("d5c7f3fe-09ea-3572-f81a-7f33b3d75ab0"), 79616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("d5d8af04-568e-9c20-c848-c6e4f75c14a2"), 79616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("d629f0e4-ca51-655f-7887-86d2b58b2de3"), 9616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("d71cdaf6-5401-eb86-ff5c-f4852a62e401"), 79616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("dda726f3-d61e-50e9-7b15-fc98fb85ea87"), 3616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("de1bfb76-8a36-63a2-ce46-5ba6c5f42536"), 79616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("f3c9a86a-8a60-d48b-f8f7-663cb9e5f86f"), 79616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("fd1e3495-dde0-88fa-4dce-578f75dec742"), 79616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("fd28a846-75c2-1171-cd89-ef5feb17de7f"), 3616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FfmpegVersions_PlatformId",
                table: "FfmpegVersions",
                column: "PlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareSurveyEntries_CpuTypeId",
                table: "HardwareSurveyEntries",
                column: "CpuTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareSurveyEntries_FromHardwareCodecId",
                table: "HardwareSurveyEntries",
                column: "FromHardwareCodecId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareSurveyEntries_FromResolutionId",
                table: "HardwareSurveyEntries",
                column: "FromResolutionId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareSurveyEntries_GpuTypeId",
                table: "HardwareSurveyEntries",
                column: "GpuTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareSurveyEntries_HardwareSurveySubmissionId",
                table: "HardwareSurveyEntries",
                column: "HardwareSurveySubmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareSurveyEntries_ToHardwareCodecId",
                table: "HardwareSurveyEntries",
                column: "ToHardwareCodecId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareSurveyEntries_ToResolutionId",
                table: "HardwareSurveyEntries",
                column: "ToResolutionId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareSurveySubmissions_RawSurveySubmissionId",
                table: "HardwareSurveySubmissions",
                column: "RawSurveySubmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_TestCaseArguments_FfmpegVersionId",
                table: "TestCaseArguments",
                column: "FfmpegVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_TestCaseArguments_HardwareCodecId",
                table: "TestCaseArguments",
                column: "HardwareCodecId");

            migrationBuilder.CreateIndex(
                name: "IX_TestCases_MediaTestFileId",
                table: "TestCases",
                column: "MediaTestFileId");

            migrationBuilder.CreateIndex(
                name: "IX_TestCases_ToCodecId",
                table: "TestCases",
                column: "ToCodecId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HardwareDisplays");

            migrationBuilder.DropTable(
                name: "HardwareSurveyEntries");

            migrationBuilder.DropTable(
                name: "TestCaseArguments");

            migrationBuilder.DropTable(
                name: "TestCases");

            migrationBuilder.DropTable(
                name: "CpuTypes");

            migrationBuilder.DropTable(
                name: "GpuTypes");

            migrationBuilder.DropTable(
                name: "HardwareSurveySubmissions");

            migrationBuilder.DropTable(
                name: "TestResolutions");

            migrationBuilder.DropTable(
                name: "FfmpegVersions");

            migrationBuilder.DropTable(
                name: "HardwareCodecs");

            migrationBuilder.DropTable(
                name: "MediaTestFiles");

            migrationBuilder.DropTable(
                name: "RawSurveySubmission");

            migrationBuilder.DropTable(
                name: "Platform");
        }
    }
}
