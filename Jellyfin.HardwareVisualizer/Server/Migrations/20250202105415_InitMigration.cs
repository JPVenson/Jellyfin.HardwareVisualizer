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
                    { new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "h264", "H264" },
                    { new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), "av1", "AV1" }
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
                    { new Guid("2c720157-f8fb-48c9-8686-d4dfe7daae9a"), "369BE12F07E0A61739CFBD4E57AA2AB6", "BA4D7B028C5C6B61813CF92AB1B05376AE545E29C5EC65373FED4E93A45CC160", new Guid("8d58b84b-73dc-4275-985d-123abe886818"), "https://repo.jellyfin.org/files/ffmpeg/linux/7.x/7.0.2-3/amd64/jellyfin-ffmpeg_7.0.2-3_portable_linux64-gpl.tar.xz", "6.0.1-7", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f") },
                    { new Guid("413b53ed-e63f-4410-b901-492173cabf13"), "bc6b6e09b2ec13871250f866e87952e8", "4f3eb2bf612e989d218a26c822d5d008cf3c4eafc54cf41e7816fc2eefc73d10", new Guid("6cf9234f-a4bb-4099-8fc8-675a653ba573"), "https://repo.jellyfin.org/files/ffmpeg/macos/7.x/7.0.2-3/arm64/jellyfin-ffmpeg_7.0.2-3_portable_macarm64-gpl.tar.xz", "7.0.2-3", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5") },
                    { new Guid("501d7e27-8410-40af-b48d-1e7ce0002173"), "369BE12F07E0A61739CFBD4E57AA2AB6", "BA4D7B028C5C6B61813CF92AB1B05376AE545E29C5EC65373FED4E93A45CC160", new Guid("3657b420-2f2a-4940-8ed3-ee70b9b3720d"), "https://repo.jellyfin.org/files/ffmpeg/linux/7.x/7.0.2-3/amd64/jellyfin-ffmpeg_7.0.2-3_portable_linux64-gpl.tar.xz", "6.0.1-7", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f") },
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
                    { new Guid("157f0cf6-672d-88f4-b4ee-c0e23f415036"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("16c162cd-a80a-60fd-5200-8a3a4bcfbe25"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v av1_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v av1_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 3, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("16d68e5f-c1ba-d7ce-077f-7239057323b6"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("19b7573e-a49e-6685-25bd-36c564696281"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("1c323048-e83f-8ff9-a454-070417d0fcd0"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("1c5cf92f-4ee8-4b17-eff6-08762e558a9f"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("1f75776a-1873-d367-b209-561300ac0248"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("2664d9bb-c8aa-9cbb-74bc-ed264c7734cd"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("28b9fea3-d73a-c8db-3977-d314645c2113"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("2ca2dd6d-10fe-3497-a3b7-cc53f668d8f1"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("2edfd8ce-2dda-f2ba-73e5-d78a6c39241c"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v av1_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("308d9541-b7c1-3a9d-23f0-eedddce20a86"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v av1_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("31d5143e-2551-3f80-7e55-13e66a29f36d"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("347ddf68-b6e2-44c2-1406-4b2179433d7e"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("355b09c1-1ef5-762c-3027-ed7dfd31b9aa"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("373f41d1-0bbc-1636-7978-3a7aac04e6e9"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("38c1ca7e-4c2a-b3c5-45a0-6c68dbe49cec"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("42d24fa0-f4b5-92c8-1496-b5c10ace5470"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("42e2178d-7d9f-43bc-c24b-3bb90b174bb9"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("43a27d46-db94-acae-fe65-8234d1947315"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("43ab37bc-59ef-23cd-a449-9fd6d7fa4f39"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("462c8dbb-c521-54dd-ccca-5ff20380d0ee"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("4970baca-731e-7d9f-175e-2629f17aab49"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("5453f03f-c7e7-ffd2-5596-e5fad4fa3c1a"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("55829d95-e48d-4c31-c1d9-fd6cd57332fb"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("64982695-84e0-c90a-274c-2e2dfcb2ac01"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("66c8bd4e-71b7-0330-b175-62343fd78194"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("6719a959-0026-241b-8420-ac9de06932d2"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v av1_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("67387ef3-df9a-6657-a2e6-7bfc6cdd2ab5"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("69675e15-ed30-e683-3624-fcb73f5921d3"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("70412efd-b134-73b7-8953-54927bac64fe"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v av1_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("713ae734-130e-ce12-0292-c29187f8c942"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("7258ce0d-5db4-5563-27bc-b3610509ace2"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v av1_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("74112a4e-dd4d-aa9d-2653-001ff5486f59"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("767e3324-1d7f-1ef0-8d38-afe537304f95"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("7985b193-a7c6-723a-302e-0aabfd734826"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("7cbdc427-cf08-c2ae-159e-4aef7d666e60"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("7eb1697c-c894-7a9e-8714-d039ea023116"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("823c47f8-eeb5-df57-87d1-da966615efe1"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("82459dac-b10d-2610-b2aa-1eeb3d21fe16"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("8272ff2c-afc2-b90f-d10e-fe091c8b57c2"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("834b1be1-5e52-dcc5-9174-ae7edc37b44c"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v av1_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("8370a0d8-00ee-83df-c442-81e3d4d917d6"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("89370be0-a506-205d-e40b-f4838d7c25fd"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("89e370db-cffc-aa42-1f1b-9797a7798378"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("91f88d27-6dfd-2b25-cb9f-66a05f5982a0"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("9620cb34-f52f-bdf3-e7c0-6b071477d64c"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v av1_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("970ee7fb-afaf-75bb-6897-0359a97b22b9"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("9889785b-8c5b-3414-f300-719e1c963d3c"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v av1_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("9c887f66-62d5-87cb-a711-beeeb2535137"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("a1e60d44-843b-3629-8a0a-5501871ef247"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v av1_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v av1_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 3, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("a38537c2-62ea-be74-d05a-728864486d37"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v av1_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("a43b2807-6e2f-f57d-674c-103c65de2694"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v av1_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("a538ea4e-4761-56bb-52d2-2d2186071c45"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("a7a92bb3-7a39-2f10-446a-36c8e9e592b9"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("a85401ad-715e-9d28-e98c-3b0a0082c692"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("aea68114-5402-ac41-ddd9-a5f30283f6f3"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("af22b5bf-89ab-a060-717e-d2e576bfa26d"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("b14fc2d7-f9a5-43c9-0e73-79bebafa70c3"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v av1_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("b6e02566-f54a-2920-2d04-cc022e629103"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("bf0c4da8-7031-4b70-ee5e-946fbe707d84"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v av1_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("bfaed98c-90d1-5f55-5b27-be45034199c6"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("c1bd918a-110d-6a2b-147a-ffd8d2c9ab96"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("c5e2237f-dc17-09b8-9c4b-137cee69837a"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v av1_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("d129cf56-a15a-7466-fe91-a643b382b45b"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("d4f70ac2-41e6-6e7f-c640-2551395c7a7c"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("d6a774cc-d691-36ee-2552-a87a0cff5154"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("d75a16a5-e709-d8c5-94ff-be50e457f092"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("dc0f0ee0-c3c8-352c-7c8c-d7319de0e9f3"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("dd2baeb0-125d-2267-a59f-29ab169fe757"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("e372f1f0-1a8f-c339-ce2f-f8cbfcd9494f"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v av1_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("e761372c-06d6-9873-9173-719feeb5e156"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("ead90cb9-3d31-b5e6-4f40-e4a13e258de0"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("f046dad9-f9e6-1970-db8e-ed7cc3cdac19"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("f06f902a-bc1e-8342-e52a-90af1c15818c"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("f0d388e7-e83d-e024-d403-1c36e175e773"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("f21e1651-5c1c-042c-b564-685397fe5f4e"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("f3b5aded-ad48-2301-07f4-1cdbec21e634"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("f55acd4b-5791-0031-d8f4-7fe63c449372"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("f6ac7eb9-1f0d-d83c-e65e-23741f10bbf0"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("f77c165c-94e1-fe04-c5c8-cbca664718b7"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") }
                });

            migrationBuilder.InsertData(
                table: "TestCases",
                columns: new[] { "Id", "Bitrate", "FromResolution", "MediaTestFileId", "TestCaseType", "ToCodecId", "ToResolution" },
                values: new object[,]
                {
                    { new Guid("042f4944-e183-f79c-a964-f47d85cf1a87"), 9616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("06b0cfb7-5110-49ab-f868-4c895e2fa46b"), 3616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("0955f6fe-426b-bfc2-cfa6-18c56210a24f"), 79616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("0b9d2f26-cbb0-ea47-59c5-e9a68c40bff2"), 3616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("0bcc1e48-3738-4338-c465-923bde607ed1"), 9616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("0d10a500-4d1b-d5f7-8a42-4c362a7103a4"), 9616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("0e5a3bfe-386e-3b73-697d-aaaf168ee787"), 3616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("104820f8-575a-c82f-4633-676c2ae1ff55"), 79616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("12649d4c-4e3a-b52e-58ee-47dd20788e80"), 3616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("1606c069-1453-c647-2495-48e1abfb57ae"), 3616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("1964fffd-c8df-8b1b-25b0-5c5112840825"), 79616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("1dc553d9-98e2-68e1-e3cc-88fdd3b0bcd3"), 9616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("24096ed4-32f6-fe87-cb5f-4248eae66d44"), 9616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("26e486d1-7bf3-7563-2640-ed9e150c8c20"), 3616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("35127d52-132d-ccc3-c956-37bd7754a0a9"), 9616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("3a9b74ff-4493-fe81-b3fc-3929baf6a2f7"), 9616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("3aa13caf-c009-b359-b893-42b995d47dba"), 9616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("3b4ee84e-97ef-db5e-0f39-f06148d85004"), 9616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("446732b1-3bf4-c4a3-8644-6e449d7632a0"), 3616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("46c0bd6e-0cca-277f-026e-4cc63119949b"), 79616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("4a12cba1-3e16-b897-b46b-42ad637a8691"), 79616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("4a496390-ef51-5a58-748a-c48444548048"), 79616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("4aaa6a51-f785-93b4-92be-eff963871618"), 79616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("539331e2-5d7a-b75b-f2d5-ad5494b4c3c0"), 79616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("5c302bb7-2da2-2ad6-75b9-03d114fb02e7"), 79616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("6296cc91-a047-7fb8-7ac9-ddbe468e1298"), 3616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("63266fa0-29ab-3a5e-2696-313f2f47c38e"), 9616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("687cce10-935d-39fb-954d-05c039555737"), 79616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("6b237233-d15a-2d45-06bd-e7416bf757b3"), 79616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("77cfac1f-731c-63a3-c76c-d585bc4a3a12"), 79616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("7a1a61c8-a5d4-d446-3788-c78147edbbe3"), 9616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("7b31cdb1-e186-b7d5-c991-2fffad1db1d0"), 9616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("86c47dae-dae7-b1c2-c64d-a492c400f393"), 9616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("874b642d-f361-362b-444b-3193b5ac2965"), 79616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("8853cbe5-6bfa-9900-efc2-36da9143f782"), 79616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("888d6062-7ca4-72ea-31b3-a139e01cb7a0"), 3616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("89725e21-823e-994e-bc34-a391d793bf4c"), 3616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("8a4a240b-18e0-325c-e9c9-679cac7261e2"), 3616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("91e03792-1cfb-3b4a-54a4-2fe1d51cca86"), 9616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("926b6d7b-3acf-a133-6472-26c3369a58d6"), 79616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("95937555-09b8-5fc1-d394-5093dda01c71"), 79616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("9ad67fcd-071b-82f8-4250-f3e2c3b1226d"), 9616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("9f79cbeb-592e-5461-bd6e-b04058fcf160"), 3616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("a27638b7-f478-51f7-6233-ed046616b2d2"), 79616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("a493d24a-b58c-2bf4-77a4-c8269646ca75"), 9616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("a4e6e8c6-489e-37d0-6f3a-2ea5e3ed427f"), 9616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("a64eb052-3bf2-8b24-90c6-a4d61bb4fe2f"), 3616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("a7a6677d-2be1-324b-36f3-6400eb9b5677"), 3616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("ab0f04fa-c4b2-7c3f-908b-1cb2e60006ac"), 9616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("abfe0bac-8fcc-83d6-1647-b6bd9f33a53f"), 9616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("ac6193e0-bd5b-8021-38ee-662a5497dffb"), 3616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("b66a6747-8314-53a2-420f-52d6f9a7bac7"), 79616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("bc86271d-df45-443b-a5d5-4185d5764949"), 9616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("bccac77a-d107-1c5b-ba1f-c91010fa6ae6"), 3616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("bdc5a853-77cd-8d1a-28e1-60e6583b42c1"), 3616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("bf053775-7882-2224-2694-0d7fdabc2424"), 9616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("bf561e14-475d-7365-b922-c6eb4ce28210"), 3616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("c3e8f217-da95-c621-44a1-366ea9508bd2"), 3616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("d4efb984-605d-3711-7c69-a3c497b66cda"), 3616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("d6debecf-5209-5d7a-cd84-1a9bd492ed72"), 79616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("de109e51-6dd3-fefb-86cc-a97434c6f1f2"), 3616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("e5ec04b4-1e46-8ab2-65b9-070e3a17cf56"), 9616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("e668e036-e096-eacd-d3ed-3402198d4656"), 3616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("e71f54c8-b291-d82c-82d6-a06eeead7e9e"), 79616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("e9b79cf0-a64b-cf09-b27a-8fc58f896551"), 3616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("ec32a7e8-e712-bb18-8513-756c6b281330"), 9616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("ee92b18b-71ce-b644-7950-b13126ab5126"), 79616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("f61ead2a-ea25-dcba-e440-8e6494f43eeb"), 79616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("f65d5c3e-3b99-75c6-c155-5679874afaf0"), 3616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("f740bd29-812c-6d1b-e6d3-9f596797188d"), 9616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("fd02944a-0db5-7d91-b77d-6565e6477d7f"), 79616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("ff0e5d38-2f1a-85f0-f8d1-37f4a036bf1b"), 79616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" }
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
