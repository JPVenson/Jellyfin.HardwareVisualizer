using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jellyfin.HardwareVisualizer.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddPlatform : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "TestCases",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MediaTestFileId = table.Column<Guid>(type: "uuid", nullable: false),
                    TestCaseType = table.Column<int>(type: "integer", nullable: false),
                    FromResolution = table.Column<string>(type: "text", nullable: false),
                    ToResolution = table.Column<string>(type: "text", nullable: false),
                    Bitrate = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestCases", x => x.Id);
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
                    { new Guid("8d58b84b-73dc-4275-985d-123abe886818"), "Ubuntu Focal", "Ubuntu", null, true, 1, "Ubuntu", "22.04" }
                });

            migrationBuilder.InsertData(
                table: "FfmpegVersions",
                columns: new[] { "Id", "HashMd5", "HashSha256", "PlatformId", "Source", "Version", "VersionGroup" },
                values: new object[,]
                {
                    { new Guid("2c720157-f8fb-48c9-8686-d4dfe7daae9a"), null, "dbe5bf6d194abfec209e8ec3d25d526d12b1d51638902535fb2df233aedb62c2", new Guid("8d58b84b-73dc-4275-985d-123abe886818"), "https://repo.jellyfin.org/releases/server/ubuntu/versions/jellyfin-ffmpeg/6.0.1-2/jellyfin-ffmpeg6_6.0.1-2-focal_amd64.deb", "6.0.1-2", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f") },
                    { new Guid("a3f734be-fb92-4a1f-bd8c-b6701e0f7e9f"), null, "47f4ea0da73f7835748c4549004877eb9abc6070", new Guid("2c361be8-c0ec-4020-984b-66c620dad840"), "https://repo.jellyfin.org/releases/server/windows/versions/jellyfin-ffmpeg/5.1.4-3/jellyfin-ffmpeg_5.1.4-3-portable_win64.zip", "5.1.6-3", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f") }
                });

            migrationBuilder.InsertData(
                table: "TestCaseArguments",
                columns: new[] { "Id", "FfmpegArgument", "FfmpegVersionGroupId", "FfmpegVersionId", "HardwareCodecId", "TestCaseArgumentDeviceType" },
                values: new object[,]
                {
                    { new Guid("1c76b8cc-7a23-4c9d-8ed7-9cbf2d741631"), "-c:v h264 -i {video_file} -autoscale 0 -an -sn -vf scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0 },
                    { new Guid("26b70d55-42e0-4def-8288-f00b562c0d6d"), "-c:v hevc -i {video_path}/{video_file} -autoscale 0 -an -sn -vf scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0 },
                    { new Guid("2a255052-3128-4e2a-a511-bef273f4889c"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_path}/{video_file} -autoscale 0 -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2 },
                    { new Guid("49463914-c696-4dca-8f62-c041ec2d8200"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_path}/{video_file} -autoscale 0 -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3 },
                    { new Guid("4ff85976-2046-4560-94fd-a79af116f154"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_path}/{video_file} -autoscale 0 -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2 },
                    { new Guid("5535efbb-bcee-4196-961d-7c7358c1c232"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_path}/{video_file} -autoscale 0 -an -sn -vf scale_cuda=-1:{scale}:yuv420p -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1 },
                    { new Guid("a3af8e6a-456a-41c2-91c6-f1a4cde9c7f4"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_path}/{video_file} -autoscale 0 -an -sn -vf scale_cuda=-1:{scale}:yuv420p -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1 },
                    { new Guid("ec73eeb5-e095-40f5-8b84-4d2307f13bfd"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_path}/{video_file} -autoscale 0 -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3 }
                });

            migrationBuilder.InsertData(
                table: "TestCases",
                columns: new[] { "Id", "Bitrate", "FromResolution", "MediaTestFileId", "TestCaseType", "ToResolution" },
                values: new object[,]
                {
                    { new Guid("362c0f37-8198-427c-ba51-d1ba96f9c596"), 79616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, "2160p" },
                    { new Guid("4474e738-42e7-47fd-bd72-eb90abe21df5"), 9616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, "1080p" },
                    { new Guid("4e42e35c-6b04-497c-8e3a-e1a559d7fe21"), 79616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, "2160p" },
                    { new Guid("6d5a1cb8-cae9-4f42-9531-38770f1842e1"), 3616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, "720p" },
                    { new Guid("6ea0ced7-b484-4f36-adb2-cb9e31cfa69b"), 9616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, "1080p" },
                    { new Guid("81ec0c23-4b92-42e5-bc73-e84eb8c7cf54"), 3616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, "720p" },
                    { new Guid("8cd41078-f7b6-4f8a-9a14-05988136d920"), 3616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, "720p" },
                    { new Guid("93664b93-4b26-48ac-87df-c11bf781700c"), 9616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, "1080p" },
                    { new Guid("f024a101-1748-48c3-a363-c7319c908af6"), 79616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, "2160p" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FfmpegVersions_PlatformId",
                table: "FfmpegVersions",
                column: "PlatformId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestCaseArguments");

            migrationBuilder.DropTable(
                name: "TestCases");

            migrationBuilder.DropTable(
                name: "FfmpegVersions");

            migrationBuilder.DropTable(
                name: "MediaTestFiles");

            migrationBuilder.DropTable(
                name: "Platform");

            migrationBuilder.DeleteData(
                table: "HardwareCodecs",
                keyColumn: "Id",
                keyValue: new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"));

            migrationBuilder.DeleteData(
                table: "HardwareCodecs",
                keyColumn: "Id",
                keyValue: new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"));
        }
    }
}
