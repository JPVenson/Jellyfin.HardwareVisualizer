using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jellyfin.HardwareVisualizer.Server.Migrations
{
    /// <inheritdoc />
    public partial class FixedFfmpegHashAndVersion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FfmpegVersions",
                keyColumn: "Id",
                keyValue: new Guid("2c720157-f8fb-48c9-8686-d4dfe7daae9a"),
                columns: new[] { "HashMd5", "HashSha256", "Version" },
                values: new object[] { "2BCE8782024607AE0104B8C6DA6F0636", "C737508DCE127A871EAE0D7537181CEAC6C39D3086348B8E2B100251FAD2071D", "7.0.2-3" });

            migrationBuilder.UpdateData(
                table: "FfmpegVersions",
                keyColumn: "Id",
                keyValue: new Guid("501d7e27-8410-40af-b48d-1e7ce0002173"),
                columns: new[] { "HashMd5", "HashSha256", "Version" },
                values: new object[] { "2BCE8782024607AE0104B8C6DA6F0636", "C737508DCE127A871EAE0D7537181CEAC6C39D3086348B8E2B100251FAD2071D", "7.0.2-3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FfmpegVersions",
                keyColumn: "Id",
                keyValue: new Guid("2c720157-f8fb-48c9-8686-d4dfe7daae9a"),
                columns: new[] { "HashMd5", "HashSha256", "Version" },
                values: new object[] { "369BE12F07E0A61739CFBD4E57AA2AB6", "BA4D7B028C5C6B61813CF92AB1B05376AE545E29C5EC65373FED4E93A45CC160", "6.0.1-7" });

            migrationBuilder.UpdateData(
                table: "FfmpegVersions",
                keyColumn: "Id",
                keyValue: new Guid("501d7e27-8410-40af-b48d-1e7ce0002173"),
                columns: new[] { "HashMd5", "HashSha256", "Version" },
                values: new object[] { "369BE12F07E0A61739CFBD4E57AA2AB6", "BA4D7B028C5C6B61813CF92AB1B05376AE545E29C5EC65373FED4E93A45CC160", "6.0.1-7" });
        }
    }
}
