using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jellyfin.HardwareVisualizer.Server.Migrations
{
    /// <inheritdoc />
    public partial class ReseedIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("117f674d-8e74-bd23-fe25-d9833b7eb2fb"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("17c39b94-479a-92c5-a571-5240af8f7b8c"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("3d9a8b90-e87f-ee23-2f8c-6265d6a6cc06"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("3ed39041-dbe7-6ce8-2d82-5d74f6f5dbfd"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("62a3da11-b8a9-3d1b-2d93-24db39e9eea4"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("7802e94c-75ee-216b-49fd-bf19e670b55e"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("8b4a26d5-ee24-4113-2eca-5ebbc637e255"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("90d5d58d-d383-173c-9637-2963cfc8c380"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("9ba7a106-1eb9-e4f3-70f2-756fab4cfd36"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("ab2c6c62-20ba-4353-4e57-8956256f7b33"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("c6507796-9b39-c7ca-98ed-27faa0a5939c"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("c89ff168-2f7b-78aa-d6c8-f8ef124bcac3"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("d2c1da76-9b4c-d3bd-e44e-a219a13215bc"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("d860a164-0a09-74da-01d1-838d0f25a63f"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("e1bc9f99-6b22-6df4-22c3-8e818c61d818"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("e37313e4-acba-235e-0cbe-5382e4a6152b"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("f0aa2b32-2477-5646-6be4-16cc03570361"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("fdee0a28-d2ce-3589-d22e-9e8879468d31"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("015a0a1e-34a9-9231-a21d-4b15ec42d141"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("06f5c567-430f-24be-f8d3-dc159511cd95"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("076cf703-7ee5-1a57-27e8-a0a111c31a85"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0f65142e-2049-ed1f-2cb0-ef121d475d30"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("18d9a777-349a-8310-d154-706f3d727d77"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("18ff0796-5806-6b41-943c-e1cca7d4e6ca"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("1914ea3d-26af-4462-4204-508ff43b3a3c"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("19edacdb-2dd6-c531-120f-592709a05dff"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("1bb8fcd0-bcae-10e7-c4c2-75ceac402de5"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("1e9ab4a0-8f79-a716-0049-bba6b8f9d889"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("1ed49bdb-ba01-138b-bd10-582e045276bd"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("20c8f8ce-c7be-00bb-4f2d-c2045286c983"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("294ff237-006a-d65d-a073-4f4f5b55e75b"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("302be0cc-5c07-70e3-8d7a-51eac584ab55"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("31112c5b-9863-5fb6-4904-3851e849b02e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("3599c887-bb8b-160c-6278-1ee46d81b462"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("35a12b02-8d1f-b521-1d01-2c68b318369f"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("373284d8-8f7a-9449-826e-ce5573308d93"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("39f755a2-c13f-b9a4-7a35-cbefb15a7914"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("3c957ec9-0d73-cae0-5da6-01d4d1328aad"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("41b32dc5-424c-494b-064c-1262934aea65"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("43d6fd0f-4a9a-b163-f7fa-d28d9dc1b2bb"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("45239d21-b849-b2b1-2eeb-6241a199d58b"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("46511e81-9b30-5b93-d810-ac57c484ff0d"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("4796af18-d657-25f7-f4fd-96393adcb494"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("4c369e3b-1f85-d6c5-f868-e9e075e6d605"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("4c57524b-eb14-f57c-eaf4-4ca827c33e9b"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("5331890d-6bc3-bae6-016a-3576b0e9c854"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("5b1ed0bb-e551-f34b-54bf-b36897510fb0"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("64b08787-b682-c061-5f9c-89559bb42b02"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("661ea5be-2991-2d4d-ec9b-5358d45c1d1c"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("6e385c45-4e6f-8ffd-58d4-90f2548aa4db"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("74d802dd-1d9d-9c56-0e1f-d5558373b514"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("7c46964c-d220-d2bf-f4fe-4220079eb312"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("7e1d8214-6320-f13b-e80e-24a172fb9a38"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("8303a5de-8a8e-ab9b-4cf4-256055afc023"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("8338a9d6-eb93-ff1b-fc24-433409ee8901"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("85062a60-45b8-c2a5-6640-c1655f477ea6"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("898b02d0-2e44-5db7-9247-a1e20eb301b0"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("8ea61d42-afba-5da7-68cd-85cbafabdfd9"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("937c31ba-57ed-ffa2-0b7f-1fddf74b43f8"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("943845b8-22fe-a89f-ccfa-81809bc8844e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a1bf0b03-b4d8-10b2-9ae1-26d9ed177aaa"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a22cfed0-de9e-5c8e-e5c6-2eaadc54d237"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a3a485e0-3e74-6ac2-d114-29fe72d30ffe"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a4610770-eb26-70d3-639c-6bde8eaafc5a"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a61d27e8-f684-c359-67c7-3007786b34df"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a78b8132-dc15-cca3-b853-b0306921e51e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a94ad4eb-95e1-19c3-4984-d5fbdc8b1883"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("b3052422-8f3c-0b07-c08a-371b5e2f8d22"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("b45e60a3-5574-ac6e-0ad7-ce3e1ea067c4"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("b5857f48-0aa8-24f7-ce73-7dbdc9677d1b"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ba7f575e-52db-13ea-509b-5393cf392243"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("bb5c247f-cd74-125f-511d-176e3d6c2cf7"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("bb9ed8ac-74ae-995b-6c96-d7889ab2bf56"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c69da312-3cb1-8606-4a4f-2884df0ecabc"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c7d1b1ba-bb7f-5398-5419-7eac0564df53"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c8a4c6ac-d233-1401-4cc6-07a6846fce3e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c998591b-fde6-517f-17cd-6c031c15cfcb"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("d25848aa-c06f-b57b-9c23-ca419400535a"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("d5450fe5-b4d1-4f9b-e506-a80c02ff1e2f"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("db60b70a-54c1-945c-acdb-c6a37fb8105a"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("dc34f7f8-67b7-6aaf-f9ee-b5576dd77aec"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("dd03aa1a-2e1a-a166-d9bd-034358c6da7e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("e22c2837-441d-5fe9-b8d1-67131ce19874"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ea42fc73-052c-292a-2f22-943da75dd031"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ee22af83-85c0-1f16-3d51-b283ebfd0e80"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f160f0ed-f3f8-4390-8287-c069262bfbeb"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f5ea926d-8c07-d740-82ac-2ebcaadd1b2e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f7aca1e1-aa7f-b3b9-f7c4-b3265edc3ae0"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("fe26ca6d-7f17-971b-364f-43c9e2eb6fac"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ff58cdd4-17de-f21c-eb37-2ccb1ef6f2ec"));

            migrationBuilder.UpdateData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: new Guid("5aea52ab-60bf-4425-b412-c046a60ccc83"),
                column: "Name",
                value: "MacOS");

            migrationBuilder.UpdateData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: new Guid("6cf9234f-a4bb-4099-8fc8-675a653ba573"),
                column: "Name",
                value: "MacOS");

            migrationBuilder.InsertData(
                table: "TestCaseArguments",
                columns: new[] { "Id", "FfmpegArgument", "FfmpegVersionGroupId", "FfmpegVersionId", "HardwareCodecId", "TestCaseArgumentDeviceType" },
                values: new object[,]
                {
                    { new Guid("20b32c74-9643-da3f-4282-b8976e9ac854"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3 },
                    { new Guid("28c710f3-3e00-a718-d677-3ff418b623ae"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0 },
                    { new Guid("2d55724b-42c3-7116-676e-4f88e1d847ea"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -noautoscale -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2 },
                    { new Guid("54286f39-a532-58e4-501a-903a66ab13f9"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1 },
                    { new Guid("584dde28-17bb-8b87-3b6b-4ecf57f6fdba"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0 },
                    { new Guid("60ee8fe4-6e5d-7f36-a632-8628dae25a3b"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1 },
                    { new Guid("700b9ed7-c40d-17e3-a4af-adc72d38d0ca"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2 },
                    { new Guid("722b827d-8b9d-d5c4-498c-989a9c12e376"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -noautoscale -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2 },
                    { new Guid("94f63550-8431-c4b2-2e9c-cffca32efdc6"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0 },
                    { new Guid("a2df5978-ed4c-1f1b-d5e9-5d0f8657bfbb"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0 },
                    { new Guid("ca96839b-4455-251c-78fb-fa327620a451"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0 },
                    { new Guid("cec8ea3f-809a-ff7a-428d-cbfbb92601e2"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0 },
                    { new Guid("d6b67591-b31e-6cda-2525-417a9b3890a5"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1 },
                    { new Guid("de03f458-35ce-f20a-ddbd-e3535c478dbf"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1 },
                    { new Guid("ee040f21-8fbc-9d9d-9316-d8be53a756a9"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2 },
                    { new Guid("f04d214e-df84-156f-f459-d1a0c876e437"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3 },
                    { new Guid("f9796b9e-8bd7-b76d-395e-e0ebe325507e"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3 },
                    { new Guid("f98a60a1-c6ce-bde4-719e-243309c16f27"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3 }
                });

            migrationBuilder.InsertData(
                table: "TestCases",
                columns: new[] { "Id", "Bitrate", "FromResolution", "MediaTestFileId", "TestCaseType", "ToCodecId", "ToResolution" },
                values: new object[,]
                {
                    { new Guid("0133cc2c-9339-b83e-fbb3-b2843b14c0cc"), 9616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("035ea5e3-9c50-2348-5259-7d5c30e7242a"), 9616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("07bda6b4-cbe2-10c1-6b9a-5fa95103cac6"), 3616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("0900237c-d30c-742f-750c-afd537b3dfc1"), 9616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("0930f2c7-d7ae-d5f9-6fbf-a78afcc48bb8"), 9616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("0a065b45-a195-3d0f-6637-0f3c40e64dac"), 3616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("0ba3ae46-4da4-b8bc-e801-43e83bfe5d8f"), 3616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("11ddc039-0cbb-dcb4-b3fc-04766fe66d67"), 3616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("16a5835b-ace7-37e5-362e-b11ae0ccb82b"), 3616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("18fe574d-b933-7718-d812-0b912cb646d9"), 3616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("218846bc-a479-e6ab-5450-c18556bbdee3"), 79616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("2498d87f-22ae-f77b-ead9-778ba1006be7"), 3616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("26061168-1682-0200-54cd-a389fa025229"), 79616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("29a3eb20-e6c8-f139-13f0-5b8d8cd83832"), 9616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("308be817-fe1f-af6e-737d-aed57bad2dc4"), 79616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("33e943d3-205c-0797-70bf-128f0dc79c1b"), 79616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("361a171f-81a2-e943-f35e-37639618ef79"), 9616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("36af2532-154b-805d-668d-f24f1fff1158"), 3616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("37a63128-44fa-9d93-6e1c-578cec9fbf75"), 79616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("3853f222-d443-467e-f427-de0257619c83"), 3616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("3c927254-e003-0b52-bd6e-7ea2e8c6b872"), 79616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("3f3ba241-fee2-5cb4-1e71-258e51cc8efd"), 3616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("3fba2234-9665-6b4c-30fd-f873428fc08c"), 3616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("46370955-18c3-0410-18b5-5a744eaad3e5"), 79616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("4693c653-f75e-71a2-01a4-9eacab46dad1"), 9616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("50aa176b-7cdb-3417-0186-3923d7152ce2"), 3616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("5306caaa-5609-1074-fc15-d621cc10f6a3"), 3616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("53456200-42db-3a92-d0de-204693e64e82"), 3616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("580d05f5-2a56-2501-c7fc-6eebda5f25c1"), 79616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("59f7cd2f-e264-1c67-073d-860ca1cd30cc"), 79616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("5da22b0b-af0d-206f-ea78-2fa44812b9c4"), 79616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("65930c4e-255e-a642-3479-12c444e18866"), 79616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("6d18bdbe-7847-edfb-2d2f-61992b93f716"), 9616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("6ff1f381-6f62-9255-db9e-6ef1fe39c0bd"), 3616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("8816e0b0-ce7a-bf76-64f0-ba121dd693cc"), 79616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("8818fe57-2790-ea39-4e77-f53ac4c71c75"), 79616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("8a8756a8-2f7b-c31b-e128-42f3e4942d33"), 9616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("8f0679cc-880a-ff63-ff5c-c4c23ab8b66a"), 79616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("9bb42046-6191-ba72-be28-a9f8efd1d1bc"), 9616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("a39940a5-168c-3458-00e4-a2ed79033289"), 9616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("a7f08b48-8f15-9b67-060d-641fdef436fa"), 3616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("ad5f35b2-b573-524b-2c10-71f8282f562d"), 79616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("af7e362a-4d1e-47a5-c1ba-b2f56cdb3dc1"), 9616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("b2c4b9a4-77e3-f3d1-80d8-f82b7a3be485"), 79616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("b5bfb22b-1913-d4be-e19d-b50acf9ac775"), 9616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("b85599a8-0cf2-f517-bbae-4424024a8b65"), 3616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("bc46399f-60bf-99f6-a4bc-65bc9eefe506"), 9616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("bda1ff1c-62ee-8bd1-aa08-bf59d602d158"), 9616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("c02451ae-0d89-09a7-a051-46c8155bf173"), 9616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("ca710c7e-5e50-f891-1f4e-af1a8940f155"), 9616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("cbe5a9ad-36f6-68dd-c90f-1f99c4ff21fa"), 9616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("d7aa6338-b59d-a67e-da7d-d760209d22d0"), 3616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("db67144c-a181-29e0-47d5-418d27da8a02"), 79616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("dcbaeea9-f411-0b48-77e8-8fe9c1d24ef0"), 79616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("dce70169-f2f1-a9e6-8208-080191c08854"), 79616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("dd0c7ad5-c1ca-2af8-9119-ae47884469fc"), 3616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("e7477aba-dd43-ada5-79b9-95f984a2b0e3"), 3616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("e8403417-a972-04de-82d7-e3a97b68dbee"), 79616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("eab69487-883d-a662-c756-04d4a3637688"), 3616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("ec0f99d8-3fb9-0ee6-a810-d19ea92ad5fc"), 3616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("ec922b48-8d96-bae3-2c5d-00221bd51b33"), 9616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("ed553bbd-ee36-b974-eb2a-02557cfc1e54"), 79616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("ee071b05-4463-7659-1b59-ad903a4ad436"), 3616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("ee69909b-5667-284b-324f-fb0775c23c37"), 9616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("ef8542af-51ef-92c0-b8d0-950a8ca96929"), 9616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("f341f26a-2ffb-5bf6-520c-6fdafe80e41f"), 3616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("f3a33e5f-aff9-5471-458a-217e029bfa07"), 79616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("f3b57ef0-20ce-cacc-563b-31a326ad8af2"), 9616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("f3df7775-cd63-b684-3b4b-c07ee7f6969c"), 9616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("f4ec5ebc-3de1-0ea2-ce3d-ff6ce718369a"), 79616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("fa80c35d-0beb-0c5f-3d19-b9dd9a4e1c4b"), 9616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("fd8af228-78bf-62cc-eba4-1c5e8cff2786"), 79616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("20b32c74-9643-da3f-4282-b8976e9ac854"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("28c710f3-3e00-a718-d677-3ff418b623ae"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("2d55724b-42c3-7116-676e-4f88e1d847ea"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("54286f39-a532-58e4-501a-903a66ab13f9"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("584dde28-17bb-8b87-3b6b-4ecf57f6fdba"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("60ee8fe4-6e5d-7f36-a632-8628dae25a3b"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("700b9ed7-c40d-17e3-a4af-adc72d38d0ca"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("722b827d-8b9d-d5c4-498c-989a9c12e376"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("94f63550-8431-c4b2-2e9c-cffca32efdc6"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("a2df5978-ed4c-1f1b-d5e9-5d0f8657bfbb"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("ca96839b-4455-251c-78fb-fa327620a451"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("cec8ea3f-809a-ff7a-428d-cbfbb92601e2"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("d6b67591-b31e-6cda-2525-417a9b3890a5"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("de03f458-35ce-f20a-ddbd-e3535c478dbf"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("ee040f21-8fbc-9d9d-9316-d8be53a756a9"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("f04d214e-df84-156f-f459-d1a0c876e437"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("f9796b9e-8bd7-b76d-395e-e0ebe325507e"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("f98a60a1-c6ce-bde4-719e-243309c16f27"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0133cc2c-9339-b83e-fbb3-b2843b14c0cc"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("035ea5e3-9c50-2348-5259-7d5c30e7242a"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("07bda6b4-cbe2-10c1-6b9a-5fa95103cac6"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0900237c-d30c-742f-750c-afd537b3dfc1"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0930f2c7-d7ae-d5f9-6fbf-a78afcc48bb8"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0a065b45-a195-3d0f-6637-0f3c40e64dac"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0ba3ae46-4da4-b8bc-e801-43e83bfe5d8f"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("11ddc039-0cbb-dcb4-b3fc-04766fe66d67"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("16a5835b-ace7-37e5-362e-b11ae0ccb82b"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("18fe574d-b933-7718-d812-0b912cb646d9"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("218846bc-a479-e6ab-5450-c18556bbdee3"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("2498d87f-22ae-f77b-ead9-778ba1006be7"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("26061168-1682-0200-54cd-a389fa025229"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("29a3eb20-e6c8-f139-13f0-5b8d8cd83832"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("308be817-fe1f-af6e-737d-aed57bad2dc4"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("33e943d3-205c-0797-70bf-128f0dc79c1b"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("361a171f-81a2-e943-f35e-37639618ef79"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("36af2532-154b-805d-668d-f24f1fff1158"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("37a63128-44fa-9d93-6e1c-578cec9fbf75"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("3853f222-d443-467e-f427-de0257619c83"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("3c927254-e003-0b52-bd6e-7ea2e8c6b872"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("3f3ba241-fee2-5cb4-1e71-258e51cc8efd"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("3fba2234-9665-6b4c-30fd-f873428fc08c"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("46370955-18c3-0410-18b5-5a744eaad3e5"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("4693c653-f75e-71a2-01a4-9eacab46dad1"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("50aa176b-7cdb-3417-0186-3923d7152ce2"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("5306caaa-5609-1074-fc15-d621cc10f6a3"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("53456200-42db-3a92-d0de-204693e64e82"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("580d05f5-2a56-2501-c7fc-6eebda5f25c1"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("59f7cd2f-e264-1c67-073d-860ca1cd30cc"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("5da22b0b-af0d-206f-ea78-2fa44812b9c4"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("65930c4e-255e-a642-3479-12c444e18866"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("6d18bdbe-7847-edfb-2d2f-61992b93f716"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("6ff1f381-6f62-9255-db9e-6ef1fe39c0bd"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("8816e0b0-ce7a-bf76-64f0-ba121dd693cc"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("8818fe57-2790-ea39-4e77-f53ac4c71c75"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("8a8756a8-2f7b-c31b-e128-42f3e4942d33"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("8f0679cc-880a-ff63-ff5c-c4c23ab8b66a"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("9bb42046-6191-ba72-be28-a9f8efd1d1bc"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a39940a5-168c-3458-00e4-a2ed79033289"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a7f08b48-8f15-9b67-060d-641fdef436fa"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ad5f35b2-b573-524b-2c10-71f8282f562d"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("af7e362a-4d1e-47a5-c1ba-b2f56cdb3dc1"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("b2c4b9a4-77e3-f3d1-80d8-f82b7a3be485"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("b5bfb22b-1913-d4be-e19d-b50acf9ac775"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("b85599a8-0cf2-f517-bbae-4424024a8b65"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("bc46399f-60bf-99f6-a4bc-65bc9eefe506"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("bda1ff1c-62ee-8bd1-aa08-bf59d602d158"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c02451ae-0d89-09a7-a051-46c8155bf173"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ca710c7e-5e50-f891-1f4e-af1a8940f155"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("cbe5a9ad-36f6-68dd-c90f-1f99c4ff21fa"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("d7aa6338-b59d-a67e-da7d-d760209d22d0"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("db67144c-a181-29e0-47d5-418d27da8a02"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("dcbaeea9-f411-0b48-77e8-8fe9c1d24ef0"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("dce70169-f2f1-a9e6-8208-080191c08854"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("dd0c7ad5-c1ca-2af8-9119-ae47884469fc"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("e7477aba-dd43-ada5-79b9-95f984a2b0e3"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("e8403417-a972-04de-82d7-e3a97b68dbee"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("eab69487-883d-a662-c756-04d4a3637688"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ec0f99d8-3fb9-0ee6-a810-d19ea92ad5fc"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ec922b48-8d96-bae3-2c5d-00221bd51b33"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ed553bbd-ee36-b974-eb2a-02557cfc1e54"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ee071b05-4463-7659-1b59-ad903a4ad436"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ee69909b-5667-284b-324f-fb0775c23c37"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ef8542af-51ef-92c0-b8d0-950a8ca96929"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f341f26a-2ffb-5bf6-520c-6fdafe80e41f"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f3a33e5f-aff9-5471-458a-217e029bfa07"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f3b57ef0-20ce-cacc-563b-31a326ad8af2"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f3df7775-cd63-b684-3b4b-c07ee7f6969c"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f4ec5ebc-3de1-0ea2-ce3d-ff6ce718369a"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("fa80c35d-0beb-0c5f-3d19-b9dd9a4e1c4b"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("fd8af228-78bf-62cc-eba4-1c5e8cff2786"));

            migrationBuilder.UpdateData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: new Guid("5aea52ab-60bf-4425-b412-c046a60ccc83"),
                column: "Name",
                value: "Mac OS");

            migrationBuilder.UpdateData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: new Guid("6cf9234f-a4bb-4099-8fc8-675a653ba573"),
                column: "Name",
                value: "Mac OS");

            migrationBuilder.InsertData(
                table: "TestCaseArguments",
                columns: new[] { "Id", "FfmpegArgument", "FfmpegVersionGroupId", "FfmpegVersionId", "HardwareCodecId", "TestCaseArgumentDeviceType" },
                values: new object[,]
                {
                    { new Guid("117f674d-8e74-bd23-fe25-d9833b7eb2fb"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -autoscale 0 -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3 },
                    { new Guid("17c39b94-479a-92c5-a571-5240af8f7b8c"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -autoscale 0 -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2 },
                    { new Guid("3d9a8b90-e87f-ee23-2f8c-6265d6a6cc06"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -autoscale 0 -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3 },
                    { new Guid("3ed39041-dbe7-6ce8-2d82-5d74f6f5dbfd"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -autoscale 0 -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2 },
                    { new Guid("62a3da11-b8a9-3d1b-2d93-24db39e9eea4"), "-c:v hevc -i {video_file} -autoscale 0 -an -sn -vf scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0 },
                    { new Guid("7802e94c-75ee-216b-49fd-bf19e670b55e"), "-c:v hevc -i {video_file} -autoscale 0 -an -sn -vf scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0 },
                    { new Guid("8b4a26d5-ee24-4113-2eca-5ebbc637e255"), "-c:v h264 -i {video_file} -autoscale 0 -an -sn -vf scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0 },
                    { new Guid("90d5d58d-d383-173c-9637-2963cfc8c380"), "-c:v hevc -i {video_file} -autoscale 0 -an -sn -vf scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0 },
                    { new Guid("9ba7a106-1eb9-e4f3-70f2-756fab4cfd36"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -autoscale 0 -an -sn -vf scale_cuda=-1:{scale}:yuv420p -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1 },
                    { new Guid("ab2c6c62-20ba-4353-4e57-8956256f7b33"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -autoscale 0 -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3 },
                    { new Guid("c6507796-9b39-c7ca-98ed-27faa0a5939c"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -autoscale 0 -an -sn -vf scale=-1:{scale}:format=nv12 -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2 },
                    { new Guid("c89ff168-2f7b-78aa-d6c8-f8ef124bcac3"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -autoscale 0 -an -sn -vf scale_cuda=-1:{scale}:yuv420p -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1 },
                    { new Guid("d2c1da76-9b4c-d3bd-e44e-a219a13215bc"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -autoscale 0 -an -sn -vf scale=-1:{scale}:format=nv12 -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2 },
                    { new Guid("d860a164-0a09-74da-01d1-838d0f25a63f"), "-c:v h264 -i {video_file} -autoscale 0 -an -sn -vf scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0 },
                    { new Guid("e1bc9f99-6b22-6df4-22c3-8e818c61d818"), "-c:v h264 -i {video_file} -autoscale 0 -an -sn -vf scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0 },
                    { new Guid("e37313e4-acba-235e-0cbe-5382e4a6152b"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -autoscale 0 -an -sn -vf scale_cuda=-1:{scale}:yuv420p -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1 },
                    { new Guid("f0aa2b32-2477-5646-6be4-16cc03570361"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -autoscale 0 -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3 },
                    { new Guid("fdee0a28-d2ce-3589-d22e-9e8879468d31"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -autoscale 0 -an -sn -vf scale_cuda=-1:{scale}:yuv420p -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1 }
                });

            migrationBuilder.InsertData(
                table: "TestCases",
                columns: new[] { "Id", "Bitrate", "FromResolution", "MediaTestFileId", "TestCaseType", "ToCodecId", "ToResolution" },
                values: new object[,]
                {
                    { new Guid("015a0a1e-34a9-9231-a21d-4b15ec42d141"), 3616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("06f5c567-430f-24be-f8d3-dc159511cd95"), 9616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("076cf703-7ee5-1a57-27e8-a0a111c31a85"), 3616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("0f65142e-2049-ed1f-2cb0-ef121d475d30"), 9616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("18d9a777-349a-8310-d154-706f3d727d77"), 9616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("18ff0796-5806-6b41-943c-e1cca7d4e6ca"), 79616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("1914ea3d-26af-4462-4204-508ff43b3a3c"), 9616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("19edacdb-2dd6-c531-120f-592709a05dff"), 79616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("1bb8fcd0-bcae-10e7-c4c2-75ceac402de5"), 9616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("1e9ab4a0-8f79-a716-0049-bba6b8f9d889"), 3616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("1ed49bdb-ba01-138b-bd10-582e045276bd"), 79616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("20c8f8ce-c7be-00bb-4f2d-c2045286c983"), 3616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("294ff237-006a-d65d-a073-4f4f5b55e75b"), 9616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("302be0cc-5c07-70e3-8d7a-51eac584ab55"), 79616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("31112c5b-9863-5fb6-4904-3851e849b02e"), 9616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("3599c887-bb8b-160c-6278-1ee46d81b462"), 79616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("35a12b02-8d1f-b521-1d01-2c68b318369f"), 79616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("373284d8-8f7a-9449-826e-ce5573308d93"), 79616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("39f755a2-c13f-b9a4-7a35-cbefb15a7914"), 3616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("3c957ec9-0d73-cae0-5da6-01d4d1328aad"), 3616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("41b32dc5-424c-494b-064c-1262934aea65"), 79616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("43d6fd0f-4a9a-b163-f7fa-d28d9dc1b2bb"), 9616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("45239d21-b849-b2b1-2eeb-6241a199d58b"), 3616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("46511e81-9b30-5b93-d810-ac57c484ff0d"), 3616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("4796af18-d657-25f7-f4fd-96393adcb494"), 9616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("4c369e3b-1f85-d6c5-f868-e9e075e6d605"), 9616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("4c57524b-eb14-f57c-eaf4-4ca827c33e9b"), 79616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("5331890d-6bc3-bae6-016a-3576b0e9c854"), 79616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("5b1ed0bb-e551-f34b-54bf-b36897510fb0"), 79616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("64b08787-b682-c061-5f9c-89559bb42b02"), 3616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("661ea5be-2991-2d4d-ec9b-5358d45c1d1c"), 3616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("6e385c45-4e6f-8ffd-58d4-90f2548aa4db"), 3616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("74d802dd-1d9d-9c56-0e1f-d5558373b514"), 9616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("7c46964c-d220-d2bf-f4fe-4220079eb312"), 9616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("7e1d8214-6320-f13b-e80e-24a172fb9a38"), 79616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("8303a5de-8a8e-ab9b-4cf4-256055afc023"), 9616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("8338a9d6-eb93-ff1b-fc24-433409ee8901"), 3616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("85062a60-45b8-c2a5-6640-c1655f477ea6"), 3616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("898b02d0-2e44-5db7-9247-a1e20eb301b0"), 3616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("8ea61d42-afba-5da7-68cd-85cbafabdfd9"), 9616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("937c31ba-57ed-ffa2-0b7f-1fddf74b43f8"), 79616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("943845b8-22fe-a89f-ccfa-81809bc8844e"), 79616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("a1bf0b03-b4d8-10b2-9ae1-26d9ed177aaa"), 9616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("a22cfed0-de9e-5c8e-e5c6-2eaadc54d237"), 3616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("a3a485e0-3e74-6ac2-d114-29fe72d30ffe"), 79616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("a4610770-eb26-70d3-639c-6bde8eaafc5a"), 9616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("a61d27e8-f684-c359-67c7-3007786b34df"), 79616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("a78b8132-dc15-cca3-b853-b0306921e51e"), 9616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("a94ad4eb-95e1-19c3-4984-d5fbdc8b1883"), 79616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("b3052422-8f3c-0b07-c08a-371b5e2f8d22"), 9616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("b45e60a3-5574-ac6e-0ad7-ce3e1ea067c4"), 3616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("b5857f48-0aa8-24f7-ce73-7dbdc9677d1b"), 79616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("ba7f575e-52db-13ea-509b-5393cf392243"), 9616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("bb5c247f-cd74-125f-511d-176e3d6c2cf7"), 9616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("bb9ed8ac-74ae-995b-6c96-d7889ab2bf56"), 79616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("c69da312-3cb1-8606-4a4f-2884df0ecabc"), 3616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("c7d1b1ba-bb7f-5398-5419-7eac0564df53"), 3616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("c8a4c6ac-d233-1401-4cc6-07a6846fce3e"), 3616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("c998591b-fde6-517f-17cd-6c031c15cfcb"), 9616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("d25848aa-c06f-b57b-9c23-ca419400535a"), 79616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("d5450fe5-b4d1-4f9b-e506-a80c02ff1e2f"), 3616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("db60b70a-54c1-945c-acdb-c6a37fb8105a"), 9616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("dc34f7f8-67b7-6aaf-f9ee-b5576dd77aec"), 79616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("dd03aa1a-2e1a-a166-d9bd-034358c6da7e"), 3616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("e22c2837-441d-5fe9-b8d1-67131ce19874"), 9616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("ea42fc73-052c-292a-2f22-943da75dd031"), 3616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("ee22af83-85c0-1f16-3d51-b283ebfd0e80"), 79616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("f160f0ed-f3f8-4390-8287-c069262bfbeb"), 9616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("f5ea926d-8c07-d740-82ac-2ebcaadd1b2e"), 79616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("f7aca1e1-aa7f-b3b9-f7c4-b3265edc3ae0"), 3616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("fe26ca6d-7f17-971b-364f-43c9e2eb6fac"), 79616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("ff58cdd4-17de-f21c-eb37-2ccb1ef6f2ec"), 3616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" }
                });
        }
    }
}
