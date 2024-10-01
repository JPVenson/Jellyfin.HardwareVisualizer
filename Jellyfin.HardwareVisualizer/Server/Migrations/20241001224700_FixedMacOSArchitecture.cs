using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jellyfin.HardwareVisualizer.Server.Migrations
{
    /// <inheritdoc />
    public partial class FixedMacOSArchitecture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: new Guid("6cf9234f-a4bb-4099-8fc8-675a653ba573"),
                column: "Architecture",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: new Guid("6cf9234f-a4bb-4099-8fc8-675a653ba573"),
                column: "Architecture",
                value: 1);
        }
    }
}
