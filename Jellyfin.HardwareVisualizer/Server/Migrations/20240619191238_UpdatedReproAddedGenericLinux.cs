using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jellyfin.HardwareVisualizer.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedReproAddedGenericLinux : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FfmpegVersions",
                keyColumn: "Id",
                keyValue: new Guid("2c720157-f8fb-48c9-8686-d4dfe7daae9a"),
                columns: new[] { "HashMd5", "HashSha256", "Source" },
                values: new object[] { "183e22d865e9d99ab86506f4313b3bae", "a01b7d556f69941041e3265f916c22613b2f58fd39a062ccf8a3104b3c99350d", "https://repo.jellyfin.org/files/ffmpeg/ubuntu/latest-6.x/amd64/jellyfin-ffmpeg6_6.0.1-7-focal_amd64.deb" });

            migrationBuilder.UpdateData(
                table: "FfmpegVersions",
                keyColumn: "Id",
                keyValue: new Guid("a3f734be-fb92-4a1f-bd8c-b6701e0f7e9f"),
                columns: new[] { "HashMd5", "HashSha256", "Source" },
                values: new object[] { "73a6a7f9d02a9abbda0f6aadd39abc89", "824542b798f04c482b171417002c3aee94f880eec2aa1ee9f016de6d912e31bd", "https://repo.jellyfin.org/files/ffmpeg/windows/latest-5.x/amd64/jellyfin-ffmpeg_5.1.4-3-portable_win64.zip" });

            migrationBuilder.InsertData(
                table: "Platform",
                columns: new[] { "Id", "DisplayName", "Name", "ReplacementId", "Supported", "Type", "Version", "VersionId" },
                values: new object[] { new Guid("3657b420-2f2a-4940-8ed3-ee70b9b3720d"), "Linux Generic", "Linux Generic", null, false, 1, "Linux", "Generic" });

            migrationBuilder.InsertData(
                table: "FfmpegVersions",
                columns: new[] { "Id", "HashMd5", "HashSha256", "PlatformId", "Source", "Version", "VersionGroup" },
                values: new object[] { new Guid("501d7e27-8410-40af-b48d-1e7ce0002173"), "d41d8cd98f00b204e9800998ecf8427e", "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855", new Guid("3657b420-2f2a-4940-8ed3-ee70b9b3720d"), "https://repo.jellyfin.org/files/ffmpeg/linux/6.x/6.0.1-7/amd64/jellyfin-ffmpeg_6.0.1-7_portable_linux64-gpl.tar.xz", "6.0.1-7", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FfmpegVersions",
                keyColumn: "Id",
                keyValue: new Guid("501d7e27-8410-40af-b48d-1e7ce0002173"));

            migrationBuilder.DeleteData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: new Guid("3657b420-2f2a-4940-8ed3-ee70b9b3720d"));

            migrationBuilder.UpdateData(
                table: "FfmpegVersions",
                keyColumn: "Id",
                keyValue: new Guid("2c720157-f8fb-48c9-8686-d4dfe7daae9a"),
                columns: new[] { "HashMd5", "HashSha256", "Source" },
                values: new object[] { null, "dbe5bf6d194abfec209e8ec3d25d526d12b1d51638902535fb2df233aedb62c2", "https://repo.jellyfin.org/releases/server/ubuntu/versions/jellyfin-ffmpeg/6.0.1-2/jellyfin-ffmpeg6_6.0.1-2-focal_amd64.deb" });

            migrationBuilder.UpdateData(
                table: "FfmpegVersions",
                keyColumn: "Id",
                keyValue: new Guid("a3f734be-fb92-4a1f-bd8c-b6701e0f7e9f"),
                columns: new[] { "HashMd5", "HashSha256", "Source" },
                values: new object[] { null, "47f4ea0da73f7835748c4549004877eb9abc6070", "https://repo.jellyfin.org/releases/server/windows/versions/jellyfin-ffmpeg/5.1.4-3/jellyfin-ffmpeg_5.1.4-3-portable_win64.zip" });
        }
    }
}
