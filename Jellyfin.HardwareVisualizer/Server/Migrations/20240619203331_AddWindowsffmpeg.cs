using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jellyfin.HardwareVisualizer.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddWindowsffmpeg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "FfmpegVersions",
                keyColumn: "Id",
                keyValue: new Guid("a3f734be-fb92-4a1f-bd8c-b6701e0f7e9f"),
                column: "VersionGroup",
                value: new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"));

            migrationBuilder.InsertData(
                table: "TestCaseArguments",
                columns: new[] { "Id", "FfmpegArgument", "FfmpegVersionGroupId", "FfmpegVersionId", "HardwareCodecId", "TestCaseArgumentDeviceType" },
                values: new object[,]
                {
                    { new Guid("183375a4-8d8e-44da-a32f-8bde2df1a89f"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -autoscale 0 -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3 },
                    { new Guid("34888563-6946-4eb1-92b6-a3a7a79ed981"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -autoscale 0 -an -sn -vf scale=-1:{scale}:format=nv12 -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2 },
                    { new Guid("40a624a3-5df0-4ad9-a81e-5faa3f29df17"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -autoscale 0 -an -sn -vf scale_cuda=-1:{scale}:yuv420p -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1 },
                    { new Guid("dd920765-e078-474c-8e39-5e1a3d8857ef"), "-c:v hevc -i {video_file} -autoscale 0 -an -sn -vf scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0 },
                    { new Guid("e9258a1d-0b54-44ff-881f-133d89eac405"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -autoscale 0 -an -sn -vf scale=-1:{scale}:format=nv12 -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2 },
                    { new Guid("ec18dd27-1243-47ae-a639-e037ae992ab7"), "-c:v h264 -i {video_file} -autoscale 0 -an -sn -vf scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0 },
                    { new Guid("ec598d96-372e-45c3-82c3-a39a0f4b86b8"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -autoscale 0 -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3 },
                    { new Guid("f24ca383-2d7b-4188-a906-1a6e93391d2f"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -autoscale 0 -an -sn -vf scale_cuda=-1:{scale}:yuv420p -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("183375a4-8d8e-44da-a32f-8bde2df1a89f"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("34888563-6946-4eb1-92b6-a3a7a79ed981"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("40a624a3-5df0-4ad9-a81e-5faa3f29df17"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("dd920765-e078-474c-8e39-5e1a3d8857ef"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("e9258a1d-0b54-44ff-881f-133d89eac405"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("ec18dd27-1243-47ae-a639-e037ae992ab7"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("ec598d96-372e-45c3-82c3-a39a0f4b86b8"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("f24ca383-2d7b-4188-a906-1a6e93391d2f"));

            migrationBuilder.UpdateData(
                table: "FfmpegVersions",
                keyColumn: "Id",
                keyValue: new Guid("a3f734be-fb92-4a1f-bd8c-b6701e0f7e9f"),
                column: "VersionGroup",
                value: new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"));
        }
    }
}
