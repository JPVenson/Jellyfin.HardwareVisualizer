using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jellyfin.HardwareVisualizer.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePlatform10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FfmpegVersions",
                keyColumn: "Id",
                keyValue: new Guid("2c720157-f8fb-48c9-8686-d4dfe7daae9a"),
                columns: new[] { "Source", "Version" },
                values: new object[] { "https://repo.jellyfin.org/files/ffmpeg/ubuntu/6.x/6.0.1-8/amd64/jellyfin-ffmpeg6_6.0.1-8-focal_amd64.deb", "6.0.1-8" });

            migrationBuilder.InsertData(
                table: "Platform",
                columns: new[] { "Id", "DisplayName", "Name", "ReplacementId", "Supported", "Type", "Version", "VersionId" },
                values: new object[] { new Guid("79191671-caa0-4b52-8a9e-eaa2f040a1cc"), "Windows 10", "Windows 10", null, true, 0, "Windows 10 version 22H2", "19045" });

            migrationBuilder.InsertData(
                table: "FfmpegVersions",
                columns: new[] { "Id", "HashMd5", "HashSha256", "PlatformId", "Source", "Version", "VersionGroup" },
                values: new object[] { new Guid("7f9e0bb6-7346-400f-881c-33c3c1558d78"), "73a6a7f9d02a9abbda0f6aadd39abc89", "824542b798f04c482b171417002c3aee94f880eec2aa1ee9f016de6d912e31bd", new Guid("79191671-caa0-4b52-8a9e-eaa2f040a1cc"), "https://repo.jellyfin.org/files/ffmpeg/windows/latest-5.x/amd64/jellyfin-ffmpeg_5.1.4-3-portable_win64.zip", "5.1.6-3", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FfmpegVersions",
                keyColumn: "Id",
                keyValue: new Guid("7f9e0bb6-7346-400f-881c-33c3c1558d78"));

            migrationBuilder.DeleteData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: new Guid("79191671-caa0-4b52-8a9e-eaa2f040a1cc"));

            migrationBuilder.UpdateData(
                table: "FfmpegVersions",
                keyColumn: "Id",
                keyValue: new Guid("2c720157-f8fb-48c9-8686-d4dfe7daae9a"),
                columns: new[] { "Source", "Version" },
                values: new object[] { "https://repo.jellyfin.org/files/ffmpeg/ubuntu/latest-6.x/amd64/jellyfin-ffmpeg6_6.0.1-7-focal_amd64.deb", "6.0.1-2" });
        }
    }
}
