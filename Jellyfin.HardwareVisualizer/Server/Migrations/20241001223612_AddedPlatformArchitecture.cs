using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jellyfin.HardwareVisualizer.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedPlatformArchitecture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Architecture",
                table: "Platform",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: new Guid("2c361be8-c0ec-4020-984b-66c620dad840"),
                column: "Architecture",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: new Guid("3657b420-2f2a-4940-8ed3-ee70b9b3720d"),
                column: "Architecture",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: new Guid("79191671-caa0-4b52-8a9e-eaa2f040a1cc"),
                column: "Architecture",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: new Guid("8d58b84b-73dc-4275-985d-123abe886818"),
                column: "Architecture",
                value: 1);

            migrationBuilder.InsertData(
                table: "Platform",
                columns: new[] { "Id", "Architecture", "DisplayName", "Name", "ReplacementId", "Supported", "Type", "Version", "VersionId" },
                values: new object[,]
                {
                    { new Guid("5aea52ab-60bf-4425-b412-c046a60ccc83"), 1, "Mac OS Darwin", "Mac OS", null, true, 2, "14.5", "14.5" },
                    { new Guid("6cf9234f-a4bb-4099-8fc8-675a653ba573"), 1, "Mac OS Darwin", "Mac OS", null, true, 2, "14.5", "14.5" }
                });

            migrationBuilder.InsertData(
                table: "FfmpegVersions",
                columns: new[] { "Id", "HashMd5", "HashSha256", "PlatformId", "Source", "Version", "VersionGroup" },
                values: new object[,]
                {
                    { new Guid("413b53ed-e63f-4410-b901-492173cabf13"), "bc6b6e09b2ec13871250f866e87952e8", "4f3eb2bf612e989d218a26c822d5d008cf3c4eafc54cf41e7816fc2eefc73d10", new Guid("6cf9234f-a4bb-4099-8fc8-675a653ba573"), "https://repo.jellyfin.org/files/ffmpeg/macos/7.x/7.0.2-3/arm64/jellyfin-ffmpeg_7.0.2-3_portable_macarm64-gpl.tar.xz", "7.0.2-3", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5") },
                    { new Guid("5af82644-47a0-4c0c-ab83-31a5dff71153"), "db3ede0396234e92991f45c5ef9058b7", "ed4061fc90e35ac405cb824dc99781481879a20e0a6b447934ddadd54bc40b3d", new Guid("5aea52ab-60bf-4425-b412-c046a60ccc83"), "https://repo.jellyfin.org/files/ffmpeg/macos/7.x/7.0.2-3/x86_64/jellyfin-ffmpeg_7.0.2-3_portable_mac64-gpl.tar.xz", "7.0.2-3", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FfmpegVersions",
                keyColumn: "Id",
                keyValue: new Guid("413b53ed-e63f-4410-b901-492173cabf13"));

            migrationBuilder.DeleteData(
                table: "FfmpegVersions",
                keyColumn: "Id",
                keyValue: new Guid("5af82644-47a0-4c0c-ab83-31a5dff71153"));

            migrationBuilder.DeleteData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: new Guid("5aea52ab-60bf-4425-b412-c046a60ccc83"));

            migrationBuilder.DeleteData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: new Guid("6cf9234f-a4bb-4099-8fc8-675a653ba573"));

            migrationBuilder.DropColumn(
                name: "Architecture",
                table: "Platform");
        }
    }
}
