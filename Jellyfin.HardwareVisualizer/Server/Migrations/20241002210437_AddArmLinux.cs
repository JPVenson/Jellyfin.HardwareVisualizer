using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jellyfin.HardwareVisualizer.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddArmLinux : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Platform",
                columns: new[] { "Id", "Architecture", "DisplayName", "Name", "ReplacementId", "Supported", "Type", "Version", "VersionId" },
                values: new object[] { new Guid("ebe72964-459b-411e-a8da-2ff77c7370e4"), 2, "Linux Generic", "Linux Generic", null, true, 1, "Linux", "Generic" });

            migrationBuilder.InsertData(
                table: "TestCaseArguments",
                columns: new[] { "Id", "FfmpegArgument", "FfmpegVersionGroupId", "FfmpegVersionId", "HardwareCodecId", "TestCaseArgumentDeviceType" },
                values: new object[,]
                {
                    { new Guid("054cf7cf-7c53-36fb-da58-ac394e110595"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -noautoscale -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2 },
                    { new Guid("096c37c5-8513-6035-cb50-0696dea7127d"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1 },
                    { new Guid("0edf7887-8b64-e0ae-3b30-8fa0bc3c2fb8"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2 },
                    { new Guid("29a9155f-59b9-90a9-b3d2-d46de28b15f7"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1 },
                    { new Guid("3861d421-ec9d-65b8-8447-74e0791f49aa"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3 },
                    { new Guid("4001db01-884a-e037-f42f-325556ea5856"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0 },
                    { new Guid("504e45f1-7e32-75c9-dd86-5e86190621f2"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3 },
                    { new Guid("6ee2be9c-8bed-f3f9-86c8-8a3d0ca7a7b9"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -noautoscale -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2 },
                    { new Guid("75faba7d-0ac7-08f1-be29-a7c6390735fd"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1 },
                    { new Guid("76e27726-975c-3d84-704e-e9ff06adf8e9"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1 },
                    { new Guid("913d48e0-9be3-4d51-c432-371747a7971f"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0 },
                    { new Guid("928b027e-8a08-f109-65a1-ddd6df7d3d46"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3 },
                    { new Guid("9de8a2e3-bd17-3fb2-6ce6-e3b43d9b84f5"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0 },
                    { new Guid("b089d568-0d35-6ee6-46ce-e99e83463c8c"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0 },
                    { new Guid("c39dfb4c-e02d-e917-4f82-d5acec7db708"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3 },
                    { new Guid("cd62b384-febe-8940-841d-0e88bb5444f0"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2 },
                    { new Guid("ddb9bd59-b4ea-1876-a0a4-f15c3777fb6d"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0 },
                    { new Guid("f515178b-17a4-9e87-d0c4-5c8909012773"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0 }
                });

            migrationBuilder.InsertData(
                table: "TestCases",
                columns: new[] { "Id", "Bitrate", "FromResolution", "MediaTestFileId", "TestCaseType", "ToCodecId", "ToResolution" },
                values: new object[,]
                {
                    { new Guid("0040874e-d864-4bd9-9c1f-e3c43c82cb55"), 3616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("00995b99-6273-6479-a8cc-281c39220055"), 3616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("010b1902-7763-8035-69ec-46382e54201d"), 3616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("0241259f-3645-f579-6736-7aec0d658edf"), 3616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("03c34c33-b436-c77f-9262-3fa22a2667f0"), 3616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("06bb694b-d724-cd98-71d6-b89f3edaeabe"), 9616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("076e1c1e-d00f-e79b-662b-90ed2160a5ec"), 79616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("07d14d90-732b-3dfb-ec7a-3e01ee1df728"), 79616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("0acc12ee-646c-fa6e-95ec-2169b005b65a"), 79616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("0b733859-ead7-31ae-5573-81a53c941b5a"), 79616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("0c6b257c-f3da-fc9d-b191-717b7ff3bc5f"), 3616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("0f76301f-2d2c-9956-f74e-5ad5d3770fa3"), 79616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("17013de0-7658-1dcc-a089-2400cfc7e9c6"), 79616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("1f8f685a-a4e7-0a77-0f7c-4812f0c9ec2a"), 9616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("28828d3c-2dae-699e-b386-61b1d5934793"), 9616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("2c439fca-7fc0-cd98-f51c-613d79821ea0"), 79616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("34212c5f-df62-586f-17c0-b5ed9418593f"), 3616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("3d15366d-1b37-899a-3ba4-d51e1909f4b3"), 3616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("3deac177-a34d-aef8-94ff-6f85bcdf4e74"), 9616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("3f51055b-f980-80a0-bc74-78799981d1ed"), 9616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("4181949f-7736-e8da-05c0-e332fdd9f171"), 79616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("4c21c242-ad3a-6e3e-1c15-fc2d35f203f2"), 3616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("51110f29-e148-51c0-2ee5-6c141c97e2ca"), 3616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("518d995c-689a-526f-159c-9be152c4831b"), 79616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("5afbfaeb-f1aa-153c-1f6b-6a3f3a275bea"), 3616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("5d38ebce-9eed-5cce-c7e2-97b5628d5928"), 9616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("5ece2013-57df-fc42-f446-23576d091006"), 79616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("60284344-58f6-b4fd-9770-e474c5830901"), 9616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("60c49058-26e5-0999-31d8-991732d6dc07"), 79616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("6438d805-ae1b-d538-cf4d-333b4357636f"), 9616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("67ab4467-1525-33c2-89b1-18fbb8c40ccc"), 79616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("68b3a945-b4bd-ee01-8066-455f20fa7f33"), 9616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("718c1cdf-fefe-7eb7-d7f1-6778ea981c07"), 3616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("75dedf5a-dcd3-87b4-920f-5e5c8a4b83e0"), 79616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("88810e77-5c12-acbd-0c81-24aa36f197f6"), 79616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("8adde4d5-148c-b9c2-e2a5-a52056c8ef65"), 9616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("8af06227-176f-2239-bf74-f9192fb96bc1"), 3616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("8cb98478-2cd0-a933-a217-7f62ba4296b9"), 79616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("8e02f8b5-e252-ee6f-234c-48a7d43dc28f"), 9616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("907dfcad-39cf-573e-a890-b3ee4c5a2df4"), 9616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("92fcef4a-9578-1a31-8fde-30a19aac800e"), 3616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("9320e7cc-f591-1f6e-09b0-2ee79d40ed8e"), 79616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("9aa63ba5-b6ff-8c60-d3b4-cd55b63009ca"), 79616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("a84021fb-09b4-92ee-6f83-6959d826aef7"), 9616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("addb22ae-0dc1-8fed-6aaf-b8e9bf47dd01"), 79616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("afd972cd-6871-09e5-7699-c79e0465045d"), 9616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("b02255f9-7a19-60cd-454a-82b85456cb34"), 9616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("b17b0590-ec50-0ca6-b087-123b24e73873"), 3616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("b43353c1-c4a6-b896-2db1-dd3758d27594"), 79616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("b48784a1-8469-2883-4bcb-3e6a5db5cd9b"), 9616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("b674b2ff-ea30-cb0b-c4ca-75aeb1f32683"), 3616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("c0a42d86-177a-9132-40a0-4cf796a48e5d"), 3616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("c0a479b3-542a-9401-1c92-7876c9ed25bb"), 3616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("c623840d-ee2c-4767-c215-77cc57276b15"), 79616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("c99a1b02-ada5-0269-260b-8fc44bec1669"), 9616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("cad44d58-0323-9348-2e9c-2221ae8341b9"), 9616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("cb7bcbab-10a2-559a-e160-1020a0c69371"), 9616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("cce554a1-fe41-754c-0d15-ee49e0061ab2"), 9616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("d151a3bd-cb93-2d79-2e64-ac92f308d33c"), 3616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("d5f3bf12-6f07-3766-026d-d8d4bcae671a"), 3616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("dc3c8e85-fa15-9558-03da-cbda27cdf373"), 9616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("df500448-b4ce-c010-21be-4e6171a2313c"), 9616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("eabe402c-15ee-37cb-d79d-7a4616436a12"), 79616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("eb7eb7bd-9427-d3d0-f0b2-6d662fad558c"), 79616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("ec4702ba-2408-c0e5-c730-7534bae94de7"), 3616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("ed6be34a-ab59-d54a-ffdb-5c73c6f067ff"), 9616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("f2bb3221-1d1a-ebe2-edda-275e04a510c9"), 79616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("f3ede8bf-09b7-b566-7318-dfc773848230"), 9616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("f446c813-739a-a79e-f589-51b7c69f1d14"), 3616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("f9cfcbd9-16fe-fd7e-cbc0-d81cbd7e7222"), 3616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("fb0ec5b6-884d-8007-70fc-1c0228b04cd8"), 3616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("fb2412a2-d6b9-97b5-cbe0-1781cfb7d090"), 79616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" }
                });

            migrationBuilder.InsertData(
                table: "FfmpegVersions",
                columns: new[] { "Id", "HashMd5", "HashSha256", "PlatformId", "Source", "Version", "VersionGroup" },
                values: new object[] { new Guid("fe43005a-d480-4113-af8a-8ebbc6392071"), "2ab051df11ff755b5b7f51937188e186", "e0e8fd50233578bc68db43b25f63984808c7604b7787b3a30d40aad66902daf8", new Guid("ebe72964-459b-411e-a8da-2ff77c7370e4"), "https://repo.jellyfin.org/files/ffmpeg/linux/7.x/7.0.2-3/arm64/jellyfin-ffmpeg_7.0.2-3_portable_linuxarm64-gpl.tar.xz", "7.0.2-3", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FfmpegVersions",
                keyColumn: "Id",
                keyValue: new Guid("fe43005a-d480-4113-af8a-8ebbc6392071"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("054cf7cf-7c53-36fb-da58-ac394e110595"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("096c37c5-8513-6035-cb50-0696dea7127d"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("0edf7887-8b64-e0ae-3b30-8fa0bc3c2fb8"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("29a9155f-59b9-90a9-b3d2-d46de28b15f7"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("3861d421-ec9d-65b8-8447-74e0791f49aa"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("4001db01-884a-e037-f42f-325556ea5856"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("504e45f1-7e32-75c9-dd86-5e86190621f2"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("6ee2be9c-8bed-f3f9-86c8-8a3d0ca7a7b9"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("75faba7d-0ac7-08f1-be29-a7c6390735fd"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("76e27726-975c-3d84-704e-e9ff06adf8e9"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("913d48e0-9be3-4d51-c432-371747a7971f"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("928b027e-8a08-f109-65a1-ddd6df7d3d46"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("9de8a2e3-bd17-3fb2-6ce6-e3b43d9b84f5"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("b089d568-0d35-6ee6-46ce-e99e83463c8c"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("c39dfb4c-e02d-e917-4f82-d5acec7db708"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("cd62b384-febe-8940-841d-0e88bb5444f0"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("ddb9bd59-b4ea-1876-a0a4-f15c3777fb6d"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("f515178b-17a4-9e87-d0c4-5c8909012773"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0040874e-d864-4bd9-9c1f-e3c43c82cb55"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("00995b99-6273-6479-a8cc-281c39220055"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("010b1902-7763-8035-69ec-46382e54201d"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0241259f-3645-f579-6736-7aec0d658edf"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("03c34c33-b436-c77f-9262-3fa22a2667f0"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("06bb694b-d724-cd98-71d6-b89f3edaeabe"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("076e1c1e-d00f-e79b-662b-90ed2160a5ec"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("07d14d90-732b-3dfb-ec7a-3e01ee1df728"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0acc12ee-646c-fa6e-95ec-2169b005b65a"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0b733859-ead7-31ae-5573-81a53c941b5a"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0c6b257c-f3da-fc9d-b191-717b7ff3bc5f"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0f76301f-2d2c-9956-f74e-5ad5d3770fa3"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("17013de0-7658-1dcc-a089-2400cfc7e9c6"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("1f8f685a-a4e7-0a77-0f7c-4812f0c9ec2a"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("28828d3c-2dae-699e-b386-61b1d5934793"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("2c439fca-7fc0-cd98-f51c-613d79821ea0"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("34212c5f-df62-586f-17c0-b5ed9418593f"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("3d15366d-1b37-899a-3ba4-d51e1909f4b3"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("3deac177-a34d-aef8-94ff-6f85bcdf4e74"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("3f51055b-f980-80a0-bc74-78799981d1ed"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("4181949f-7736-e8da-05c0-e332fdd9f171"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("4c21c242-ad3a-6e3e-1c15-fc2d35f203f2"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("51110f29-e148-51c0-2ee5-6c141c97e2ca"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("518d995c-689a-526f-159c-9be152c4831b"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("5afbfaeb-f1aa-153c-1f6b-6a3f3a275bea"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("5d38ebce-9eed-5cce-c7e2-97b5628d5928"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("5ece2013-57df-fc42-f446-23576d091006"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("60284344-58f6-b4fd-9770-e474c5830901"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("60c49058-26e5-0999-31d8-991732d6dc07"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("6438d805-ae1b-d538-cf4d-333b4357636f"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("67ab4467-1525-33c2-89b1-18fbb8c40ccc"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("68b3a945-b4bd-ee01-8066-455f20fa7f33"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("718c1cdf-fefe-7eb7-d7f1-6778ea981c07"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("75dedf5a-dcd3-87b4-920f-5e5c8a4b83e0"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("88810e77-5c12-acbd-0c81-24aa36f197f6"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("8adde4d5-148c-b9c2-e2a5-a52056c8ef65"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("8af06227-176f-2239-bf74-f9192fb96bc1"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("8cb98478-2cd0-a933-a217-7f62ba4296b9"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("8e02f8b5-e252-ee6f-234c-48a7d43dc28f"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("907dfcad-39cf-573e-a890-b3ee4c5a2df4"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("92fcef4a-9578-1a31-8fde-30a19aac800e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("9320e7cc-f591-1f6e-09b0-2ee79d40ed8e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("9aa63ba5-b6ff-8c60-d3b4-cd55b63009ca"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a84021fb-09b4-92ee-6f83-6959d826aef7"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("addb22ae-0dc1-8fed-6aaf-b8e9bf47dd01"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("afd972cd-6871-09e5-7699-c79e0465045d"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("b02255f9-7a19-60cd-454a-82b85456cb34"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("b17b0590-ec50-0ca6-b087-123b24e73873"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("b43353c1-c4a6-b896-2db1-dd3758d27594"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("b48784a1-8469-2883-4bcb-3e6a5db5cd9b"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("b674b2ff-ea30-cb0b-c4ca-75aeb1f32683"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c0a42d86-177a-9132-40a0-4cf796a48e5d"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c0a479b3-542a-9401-1c92-7876c9ed25bb"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c623840d-ee2c-4767-c215-77cc57276b15"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c99a1b02-ada5-0269-260b-8fc44bec1669"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("cad44d58-0323-9348-2e9c-2221ae8341b9"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("cb7bcbab-10a2-559a-e160-1020a0c69371"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("cce554a1-fe41-754c-0d15-ee49e0061ab2"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("d151a3bd-cb93-2d79-2e64-ac92f308d33c"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("d5f3bf12-6f07-3766-026d-d8d4bcae671a"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("dc3c8e85-fa15-9558-03da-cbda27cdf373"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("df500448-b4ce-c010-21be-4e6171a2313c"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("eabe402c-15ee-37cb-d79d-7a4616436a12"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("eb7eb7bd-9427-d3d0-f0b2-6d662fad558c"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ec4702ba-2408-c0e5-c730-7534bae94de7"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ed6be34a-ab59-d54a-ffdb-5c73c6f067ff"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f2bb3221-1d1a-ebe2-edda-275e04a510c9"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f3ede8bf-09b7-b566-7318-dfc773848230"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f446c813-739a-a79e-f589-51b7c69f1d14"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f9cfcbd9-16fe-fd7e-cbc0-d81cbd7e7222"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("fb0ec5b6-884d-8007-70fc-1c0228b04cd8"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("fb2412a2-d6b9-97b5-cbe0-1781cfb7d090"));

            migrationBuilder.DeleteData(
                table: "Platform",
                keyColumn: "Id",
                keyValue: new Guid("ebe72964-459b-411e-a8da-2ff77c7370e4"));

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
    }
}
