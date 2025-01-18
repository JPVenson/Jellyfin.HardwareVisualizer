using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jellyfin.HardwareVisualizer.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
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
                    Architecture = table.Column<int>(type: "integer", nullable: false),
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
                name: "MediaTestFiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    SourceUrl = table.Column<string>(type: "text", nullable: false),
                    Bitrate = table.Column<long>(type: "bigint", nullable: false),
                    Size = table.Column<long>(type: "bigint", nullable: false),
                    VideoCodecId = table.Column<Guid>(type: "uuid", nullable: false),
                    AudioCodec = table.Column<string>(type: "text", nullable: false),
                    HashMd5 = table.Column<string>(type: "text", nullable: true),
                    HashSha256 = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaTestFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MediaTestFiles_HardwareCodecs_VideoCodecId",
                        column: x => x.VideoCodecId,
                        principalTable: "HardwareCodecs",
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
                name: "TestCaseArguments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FfmpegArgument = table.Column<string>(type: "text", nullable: false),
                    TestCaseArgumentDeviceType = table.Column<int>(type: "integer", nullable: false),
                    FfmpegVersionGroupId = table.Column<Guid>(type: "uuid", nullable: false),
                    FromHardwareCodecId = table.Column<Guid>(type: "uuid", nullable: false),
                    ToHardwareCodecId = table.Column<Guid>(type: "uuid", nullable: false),
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
                        name: "FK_TestCaseArguments_HardwareCodecs_FromHardwareCodecId",
                        column: x => x.FromHardwareCodecId,
                        principalTable: "HardwareCodecs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestCaseArguments_HardwareCodecs_ToHardwareCodecId",
                        column: x => x.ToHardwareCodecId,
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
                table: "Platform",
                columns: new[] { "Id", "Architecture", "DisplayName", "Name", "ReplacementId", "Supported", "Type", "Version", "VersionId" },
                values: new object[,]
                {
                    { new Guid("2c361be8-c0ec-4020-984b-66c620dad840"), 1, "Windows 11", "Windows 11", null, true, 0, "Windows 11 version 23H2", "22631" },
                    { new Guid("3657b420-2f2a-4940-8ed3-ee70b9b3720d"), 1, "Linux Generic", "Linux Generic", null, true, 1, "Linux", "Generic" },
                    { new Guid("5aea52ab-60bf-4425-b412-c046a60ccc83"), 1, "Mac OS Darwin", "MacOS", null, true, 2, "14.5", "14.5" },
                    { new Guid("6cf9234f-a4bb-4099-8fc8-675a653ba573"), 2, "Mac OS Darwin", "MacOS", null, true, 2, "14.5", "14.5" },
                    { new Guid("79191671-caa0-4b52-8a9e-eaa2f040a1cc"), 1, "Windows 10", "Windows 10", null, true, 0, "Windows 10 version 22H2", "19045" },
                    { new Guid("8d58b84b-73dc-4275-985d-123abe886818"), 1, "Ubuntu Focal", "Ubuntu", null, true, 1, "Ubuntu", "22.04" },
                    { new Guid("ebe72964-459b-411e-a8da-2ff77c7370e4"), 2, "Linux Generic", "Linux Generic", null, true, 1, "Linux", "Generic" }
                });

            migrationBuilder.InsertData(
                table: "FfmpegVersions",
                columns: new[] { "Id", "HashMd5", "HashSha256", "PlatformId", "Source", "Version", "VersionGroup" },
                values: new object[,]
                {
                    { new Guid("2c720157-f8fb-48c9-8686-d4dfe7daae9a"), "d41d8cd98f00b204e9800998ecf8427e", "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855", new Guid("8d58b84b-73dc-4275-985d-123abe886818"), "https://repo.jellyfin.org/files/ffmpeg/linux/6.x/6.0.1-7/amd64/jellyfin-ffmpeg_6.0.1-7_portable_linux64-gpl.tar.xz", "6.0.1-7", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f") },
                    { new Guid("413b53ed-e63f-4410-b901-492173cabf13"), "bc6b6e09b2ec13871250f866e87952e8", "4f3eb2bf612e989d218a26c822d5d008cf3c4eafc54cf41e7816fc2eefc73d10", new Guid("6cf9234f-a4bb-4099-8fc8-675a653ba573"), "https://repo.jellyfin.org/files/ffmpeg/macos/7.x/7.0.2-3/arm64/jellyfin-ffmpeg_7.0.2-3_portable_macarm64-gpl.tar.xz", "7.0.2-3", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5") },
                    { new Guid("501d7e27-8410-40af-b48d-1e7ce0002173"), "d41d8cd98f00b204e9800998ecf8427e", "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855", new Guid("3657b420-2f2a-4940-8ed3-ee70b9b3720d"), "https://repo.jellyfin.org/files/ffmpeg/linux/6.x/6.0.1-7/amd64/jellyfin-ffmpeg_6.0.1-7_portable_linux64-gpl.tar.xz", "6.0.1-7", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f") },
                    { new Guid("5af82644-47a0-4c0c-ab83-31a5dff71153"), "db3ede0396234e92991f45c5ef9058b7", "ed4061fc90e35ac405cb824dc99781481879a20e0a6b447934ddadd54bc40b3d", new Guid("5aea52ab-60bf-4425-b412-c046a60ccc83"), "https://repo.jellyfin.org/files/ffmpeg/macos/7.x/7.0.2-3/x86_64/jellyfin-ffmpeg_7.0.2-3_portable_mac64-gpl.tar.xz", "7.0.2-3", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5") },
                    { new Guid("7f9e0bb6-7346-400f-881c-33c3c1558d78"), "73a6a7f9d02a9abbda0f6aadd39abc89", "824542b798f04c482b171417002c3aee94f880eec2aa1ee9f016de6d912e31bd", new Guid("79191671-caa0-4b52-8a9e-eaa2f040a1cc"), "https://repo.jellyfin.org/files/ffmpeg/windows/latest-5.x/amd64/jellyfin-ffmpeg_5.1.4-3-portable_win64.zip", "5.1.6-3", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512") },
                    { new Guid("a3f734be-fb92-4a1f-bd8c-b6701e0f7e9f"), "73a6a7f9d02a9abbda0f6aadd39abc89", "824542b798f04c482b171417002c3aee94f880eec2aa1ee9f016de6d912e31bd", new Guid("2c361be8-c0ec-4020-984b-66c620dad840"), "https://repo.jellyfin.org/files/ffmpeg/windows/latest-5.x/amd64/jellyfin-ffmpeg_5.1.4-3-portable_win64.zip", "5.1.6-3", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512") },
                    { new Guid("fe43005a-d480-4113-af8a-8ebbc6392071"), "2ab051df11ff755b5b7f51937188e186", "e0e8fd50233578bc68db43b25f63984808c7604b7787b3a30d40aad66902daf8", new Guid("ebe72964-459b-411e-a8da-2ff77c7370e4"), "https://repo.jellyfin.org/files/ffmpeg/linux/7.x/7.0.2-3/arm64/jellyfin-ffmpeg_7.0.2-3_portable_linuxarm64-gpl.tar.xz", "7.0.2-3", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f") }
                });

            migrationBuilder.InsertData(
                table: "MediaTestFiles",
                columns: new[] { "Id", "AudioCodec", "Bitrate", "HashMd5", "HashSha256", "Name", "Size", "SourceUrl", "VideoCodecId" },
                values: new object[,]
                {
                    { new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), "", 30L, "7b0f05d66d0897bf9d5e3746a973acce", "9851037c599bb02bebfb2e77a6d88ab4d3e295542e3ad6b8f062711dae5112ec", "Test Jellyfin 1080p AVC 30M.mp4", 106L, "https://repo.jellyfin.org/test-videos/SDR/AVC/Test%20Jellyfin%201080p%20AVC%2030M.mp4", new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), "", 40L, "8530221143ce1fc59c1be6947b82c4bd", "738a7fb8fd951421791286a9609f03b963acd3d424420b3e58edac50ec8cf31c", "Test Jellyfin 4K HEVC 10bit 40M.mp4", 141L, "https://repo.jellyfin.org/test-videos/SDR/HEVC%2010bit/Test%20Jellyfin%204K%20HEVC%2010bit%2040M.mp4", new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("e1e58b15-6664-454c-868a-20442db30557"), "", 150L, "75330504461b4920b51bd7e7f67096d2", "71b6633c593a8aab36a050db0369901640ec102caf00735a1fa7b16cbbb2aa42", "Test Jellyfin 4K AVC 150M.mp4", 528L, "https://repo.jellyfin.org/test-videos/SDR/AVC/Test%20Jellyfin%204K%20AVC%20150M.mp4", new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), "", 150L, "caf635e717ce87c40f751da542e18f16", "08bec94467502aec0123f7a1a7f7ba11240de7ff784c1b2b3b66f2936a3e56a1", "Test Jellyfin 4K HEVC 10bit 150M", 528L, "https://repo.jellyfin.org/test-videos/SDR/HEVC%2010bit/Test%20Jellyfin%204K%20HEVC%2010bit%20150M.mp4", new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") }
                });

            migrationBuilder.InsertData(
                table: "TestCaseArguments",
                columns: new[] { "Id", "FfmpegArgument", "FfmpegVersionGroupId", "FfmpegVersionId", "FromHardwareCodecId", "TestCaseArgumentDeviceType", "ToHardwareCodecId" },
                values: new object[,]
                {
                    { new Guid("05f63ec9-068d-44e4-efe3-3f833ea2876f"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("0a1ba650-c8c9-1aa1-72dc-ff0cb2880881"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("35d0028e-139e-df9d-1d07-9f56b94975b3"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("469e1053-ae97-b1f9-ef24-5f1d95138715"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("4a2fe920-8a57-9723-b9a5-f81804414878"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("500e6440-c7fc-5d18-e7e1-82773b31aa03"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("561792ff-a20b-cfc7-9912-323acc900ddd"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("5bc22f30-b4bd-e51d-e6d5-6fc1c2709fb5"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("676daa76-8557-8b8a-bca2-1ce90cfe8e75"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("69d8cbca-6268-3967-f560-4bf6229858b3"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("6a5b0be0-66b3-9404-8cf9-5bc5afce61f9"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("71e277b0-267d-a5d5-69a7-9840b5970222"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("782482dd-1d13-1c1a-c51b-32b578d7e6ec"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("7d0a7a20-0d59-9eb7-a84e-a7fbcc505f68"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("7e8ff566-90c9-0fc6-3742-42545bc26cb5"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("8baddd33-a587-0996-4056-adaa81a5deb8"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("8e48eaea-724c-9b4c-1e4b-db47a07214c2"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -noautoscale -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("94031f12-1b7f-c30e-7e73-a080421e785d"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -noautoscale -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("96432aad-a8ae-bd50-d72c-1e67eaec0369"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("99a47908-f009-fc68-e033-c09b1f6e3af1"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("9c13eaf2-11ea-21b0-f8aa-a49c39f723f2"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("a44b626b-d79a-aade-b785-be3fe9b37e8a"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -noautoscale -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("ad833710-00e3-8fdf-acb3-0832656ba3c0"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("aee1af78-898f-8d48-3f25-1de6ddc40de8"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("c4d9cff7-1e10-1498-8555-3f32833b18a1"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("c6935287-0329-b052-9f0f-958485200cb9"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("cbea1bb6-d7f7-a7ea-bbcb-fbf4813fa1ed"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("ce1eacee-7d66-8d35-8267-77e93ec6837e"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("e15f4b0e-6ce9-277c-bf80-9bca957b774a"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -noautoscale -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("e2374439-3f63-4c45-077a-d27031779c3d"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("e78c26c4-68fa-3ced-64ba-ae3f19ae4251"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("f28df60c-8da7-90f6-4929-0b7f8e5395f9"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") }
                });

            migrationBuilder.InsertData(
                table: "TestCases",
                columns: new[] { "Id", "Bitrate", "FromResolution", "MediaTestFileId", "TestCaseType", "ToCodecId", "ToResolution" },
                values: new object[,]
                {
                    { new Guid("028fb801-8d30-61d7-dc07-5b504eb0d8ef"), 3616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("04005d73-f676-23f4-2eb5-9f40d37a3602"), 79616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("058d6227-9a3e-151a-ac00-5918d3a81c39"), 79616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("0940b20d-ab22-d1e6-82c9-830f503d4f17"), 9616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("0b6ae35d-7b27-4893-6b6c-0bf12a44265d"), 3616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("104d798f-42e5-c43a-4ceb-d2d1390138db"), 79616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("186d1538-5184-1edd-bccc-4158b39722ec"), 3616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("1aa729fd-0db1-ab27-e6f1-11b101175a93"), 3616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("237784b1-b14e-79ee-1149-8bb8823bb857"), 79616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("25d8d497-a8df-d043-cfaf-c82aa1b2f4bd"), 3616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("273e5834-df8f-8d86-740a-342cd8b4539b"), 79616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("287ae63b-67e7-86b3-65b3-f69012bbdde5"), 3616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("299ec5e3-24c7-48a7-b5e5-5ea61fee8e91"), 79616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("31266d7f-3c6a-059c-97f9-0c350a48cf9b"), 9616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("3eafe542-7078-cec9-1a46-d1592121a98d"), 9616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("3ef39e22-3637-e014-a100-e8e86304fe23"), 3616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("41b541bf-26ee-670f-904c-b5c4ffe6d9ca"), 3616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("4491f98d-fdfd-9fc5-85fe-fe02cdcbd702"), 9616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("45becaa0-1aeb-8eb2-a4ad-434d723bdb31"), 9616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("4922e1eb-3b73-6dcb-700c-5dafc9229f0d"), 3616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("4cd38095-40c9-e973-048a-e050a753723e"), 3616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("50500185-56a9-bb96-a5d8-a397323d3927"), 9616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("56d96104-770b-77fd-e092-d14de768287c"), 3616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("58e3e5dc-097f-de4a-0229-0ccb7c28c316"), 79616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("5d20e63b-3205-47e1-7cc1-af8a5fcb0866"), 9616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("61f4077a-0853-ccf5-338d-5541ab3fca89"), 9616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("65b4d34d-3e49-2493-9dc1-19c49735fad7"), 9616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("71479a7d-e7c1-8433-6687-c708251c67ed"), 3616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("73d58f04-30d6-caec-2e26-fb821289e00a"), 79616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("76f35ad1-93a3-89c2-9656-c35ea763d780"), 79616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("7ad6bd3f-dc74-34a3-309c-b9ca91d47bee"), 9616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("94505991-fad8-d5a8-b233-be8cee34035a"), 9616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("99f7c506-1843-1fb9-f75c-d1d17e04f4c3"), 3616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("9da57263-4c3e-4809-c956-5ab6dcce4614"), 9616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("a0629d1f-fd93-a896-76ec-075f58abe87e"), 9616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("a2d26f38-e087-af2c-caf5-e63552260524"), 79616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("a32a1387-0ace-a0b7-8a9f-10ddcd1456e5"), 3616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("a38de7a4-f2e1-9f7d-4f60-010e17334632"), 9616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("a4419a87-e4f1-b9ed-553a-315aae865e6c"), 3616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("a648145d-ed89-2600-fe1d-f0cb3bf5eeff"), 3616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("acb121d7-7d14-8fd1-3cd2-43619067470a"), 3616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("ae62cf76-bca6-3424-b4cc-d1e8afb101f2"), 9616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("b1a12f3e-9abe-ffaa-6bfd-2291cfc5737b"), 79616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("b1ca338e-f699-c55a-25f7-ad9cdb3e6fce"), 79616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("b824e20d-1ccf-2f8c-b5a5-ed3ec5e5f4b2"), 9616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("b932b237-7833-ed9d-6b0f-480ddabbec2e"), 9616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("b939b7ad-40c5-71f9-37b2-a30b8f472502"), 3616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("baad8de8-1a0c-c866-112a-a1ba7522ec7e"), 79616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("be92d513-ee64-11e8-bdfd-1e9f6a781719"), 79616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("c11c2319-d0ed-e6f8-3b3a-b5ccd09616fe"), 79616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("c247dafa-0a10-cae1-dc80-4f50835111c6"), 79616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("c2dd6534-108b-c68e-7006-e2a50ae79c9b"), 9616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("c785197c-4d91-e7a8-af7f-0dac07ab317e"), 9616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("cae5d47a-6d0f-08c2-0a36-2b2f4144e83f"), 9616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("d403dd5a-846c-a316-312a-ba6bacb6550c"), 9616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("d94a75b0-1545-44b2-dbaa-5c97c25a8af5"), 79616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("d9e632af-5f93-1f18-0f9c-f1b59c7edce1"), 79616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("da30a954-cbb9-50e8-c622-ffecfce769fe"), 3616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("db728ba4-1a2f-2382-acbe-5bda19a1b33f"), 9616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("dbe5100d-04db-d57c-7554-29fcd768bd24"), 79616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("dd1dc434-071b-7abe-ca70-3c3dcf905638"), 79616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("df699354-ed8a-882f-16d2-c7b531b94f5d"), 79616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("e0dc8fcb-2400-8ea7-3b8b-15dd5b12ae54"), 79616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("e2cd9414-20c6-2c1d-35cd-85dc9bd209ff"), 3616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("e5fb9e53-3bfd-9bd0-6488-219adb956c38"), 79616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("e7b5164d-233b-a614-ca78-0ad5e9b21ff2"), 79616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("efc6dc0b-d2e9-7072-fbea-cfe0c3711158"), 9616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("f344a948-2aad-b19b-bde1-94c6981ea8b6"), 3616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("f860694f-70ab-b0ff-81f2-aa8af23bf543"), 9616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("fa88abfc-836b-5423-506e-9b2cc188c843"), 3616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("fb547eaf-9fa5-6ad7-e54a-8c4ddce6505b"), 3616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("fe89439a-5602-f69e-ea5e-c5b9b310586d"), 3616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" }
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
                name: "IX_MediaTestFiles_VideoCodecId",
                table: "MediaTestFiles",
                column: "VideoCodecId");

            migrationBuilder.CreateIndex(
                name: "IX_TestCaseArguments_FfmpegVersionId",
                table: "TestCaseArguments",
                column: "FfmpegVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_TestCaseArguments_FromHardwareCodecId",
                table: "TestCaseArguments",
                column: "FromHardwareCodecId");

            migrationBuilder.CreateIndex(
                name: "IX_TestCaseArguments_ToHardwareCodecId",
                table: "TestCaseArguments",
                column: "ToHardwareCodecId");

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
                name: "MediaTestFiles");

            migrationBuilder.DropTable(
                name: "RawSurveySubmission");

            migrationBuilder.DropTable(
                name: "Platform");

            migrationBuilder.DropTable(
                name: "HardwareCodecs");
        }
    }
}
