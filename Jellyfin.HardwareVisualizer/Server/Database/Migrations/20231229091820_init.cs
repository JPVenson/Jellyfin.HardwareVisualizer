using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jellyfin.HardwareVisualizer.Server.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
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
                name: "HardwareSurveyEntries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    HardwareCodecId = table.Column<Guid>(type: "uuid", nullable: false),
                    GpuTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    CpuTypeId = table.Column<Guid>(type: "uuid", nullable: true),
                    HardwareSurveySubmissionId = table.Column<Guid>(type: "uuid", nullable: false),
                    FromResolutionId = table.Column<Guid>(type: "uuid", nullable: false),
                    ToResolutionId = table.Column<Guid>(type: "uuid", nullable: false),
                    MaxStreams = table.Column<int>(type: "integer", nullable: false)
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
                        name: "FK_HardwareSurveyEntries_HardwareCodecs_HardwareCodecId",
                        column: x => x.HardwareCodecId,
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

            migrationBuilder.CreateIndex(
                name: "IX_HardwareSurveyEntries_CpuTypeId",
                table: "HardwareSurveyEntries",
                column: "CpuTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareSurveyEntries_FromResolutionId",
                table: "HardwareSurveyEntries",
                column: "FromResolutionId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareSurveyEntries_GpuTypeId",
                table: "HardwareSurveyEntries",
                column: "GpuTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareSurveyEntries_HardwareCodecId",
                table: "HardwareSurveyEntries",
                column: "HardwareCodecId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareSurveyEntries_HardwareSurveySubmissionId",
                table: "HardwareSurveyEntries",
                column: "HardwareSurveySubmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareSurveyEntries_ToResolutionId",
                table: "HardwareSurveyEntries",
                column: "ToResolutionId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareSurveySubmissions_RawSurveySubmissionId",
                table: "HardwareSurveySubmissions",
                column: "RawSurveySubmissionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HardwareDisplays");

            migrationBuilder.DropTable(
                name: "HardwareSurveyEntries");

            migrationBuilder.DropTable(
                name: "CpuTypes");

            migrationBuilder.DropTable(
                name: "GpuTypes");

            migrationBuilder.DropTable(
                name: "HardwareCodecs");

            migrationBuilder.DropTable(
                name: "HardwareSurveySubmissions");

            migrationBuilder.DropTable(
                name: "TestResolutions");

            migrationBuilder.DropTable(
                name: "RawSurveySubmission");
        }
    }
}
