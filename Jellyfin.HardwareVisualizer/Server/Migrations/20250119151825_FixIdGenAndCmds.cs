using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jellyfin.HardwareVisualizer.Server.Migrations
{
    /// <inheritdoc />
    public partial class FixIdGenAndCmds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("05f63ec9-068d-44e4-efe3-3f833ea2876f"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("0a1ba650-c8c9-1aa1-72dc-ff0cb2880881"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("35d0028e-139e-df9d-1d07-9f56b94975b3"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("469e1053-ae97-b1f9-ef24-5f1d95138715"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("4a2fe920-8a57-9723-b9a5-f81804414878"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("500e6440-c7fc-5d18-e7e1-82773b31aa03"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("561792ff-a20b-cfc7-9912-323acc900ddd"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("5bc22f30-b4bd-e51d-e6d5-6fc1c2709fb5"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("676daa76-8557-8b8a-bca2-1ce90cfe8e75"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("69d8cbca-6268-3967-f560-4bf6229858b3"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("6a5b0be0-66b3-9404-8cf9-5bc5afce61f9"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("71e277b0-267d-a5d5-69a7-9840b5970222"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("782482dd-1d13-1c1a-c51b-32b578d7e6ec"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("7d0a7a20-0d59-9eb7-a84e-a7fbcc505f68"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("7e8ff566-90c9-0fc6-3742-42545bc26cb5"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("8baddd33-a587-0996-4056-adaa81a5deb8"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("8e48eaea-724c-9b4c-1e4b-db47a07214c2"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("94031f12-1b7f-c30e-7e73-a080421e785d"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("96432aad-a8ae-bd50-d72c-1e67eaec0369"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("99a47908-f009-fc68-e033-c09b1f6e3af1"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("9c13eaf2-11ea-21b0-f8aa-a49c39f723f2"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("a44b626b-d79a-aade-b785-be3fe9b37e8a"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("ad833710-00e3-8fdf-acb3-0832656ba3c0"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("aee1af78-898f-8d48-3f25-1de6ddc40de8"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("c4d9cff7-1e10-1498-8555-3f32833b18a1"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("c6935287-0329-b052-9f0f-958485200cb9"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("cbea1bb6-d7f7-a7ea-bbcb-fbf4813fa1ed"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("ce1eacee-7d66-8d35-8267-77e93ec6837e"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("e15f4b0e-6ce9-277c-bf80-9bca957b774a"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("e2374439-3f63-4c45-077a-d27031779c3d"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("e78c26c4-68fa-3ced-64ba-ae3f19ae4251"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("f28df60c-8da7-90f6-4929-0b7f8e5395f9"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("028fb801-8d30-61d7-dc07-5b504eb0d8ef"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("04005d73-f676-23f4-2eb5-9f40d37a3602"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("058d6227-9a3e-151a-ac00-5918d3a81c39"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0940b20d-ab22-d1e6-82c9-830f503d4f17"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0b6ae35d-7b27-4893-6b6c-0bf12a44265d"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("104d798f-42e5-c43a-4ceb-d2d1390138db"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("186d1538-5184-1edd-bccc-4158b39722ec"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("1aa729fd-0db1-ab27-e6f1-11b101175a93"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("237784b1-b14e-79ee-1149-8bb8823bb857"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("25d8d497-a8df-d043-cfaf-c82aa1b2f4bd"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("273e5834-df8f-8d86-740a-342cd8b4539b"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("287ae63b-67e7-86b3-65b3-f69012bbdde5"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("299ec5e3-24c7-48a7-b5e5-5ea61fee8e91"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("31266d7f-3c6a-059c-97f9-0c350a48cf9b"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("3eafe542-7078-cec9-1a46-d1592121a98d"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("3ef39e22-3637-e014-a100-e8e86304fe23"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("41b541bf-26ee-670f-904c-b5c4ffe6d9ca"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("4491f98d-fdfd-9fc5-85fe-fe02cdcbd702"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("45becaa0-1aeb-8eb2-a4ad-434d723bdb31"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("4922e1eb-3b73-6dcb-700c-5dafc9229f0d"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("4cd38095-40c9-e973-048a-e050a753723e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("50500185-56a9-bb96-a5d8-a397323d3927"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("56d96104-770b-77fd-e092-d14de768287c"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("58e3e5dc-097f-de4a-0229-0ccb7c28c316"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("5d20e63b-3205-47e1-7cc1-af8a5fcb0866"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("61f4077a-0853-ccf5-338d-5541ab3fca89"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("65b4d34d-3e49-2493-9dc1-19c49735fad7"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("71479a7d-e7c1-8433-6687-c708251c67ed"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("73d58f04-30d6-caec-2e26-fb821289e00a"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("76f35ad1-93a3-89c2-9656-c35ea763d780"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("7ad6bd3f-dc74-34a3-309c-b9ca91d47bee"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("94505991-fad8-d5a8-b233-be8cee34035a"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("99f7c506-1843-1fb9-f75c-d1d17e04f4c3"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("9da57263-4c3e-4809-c956-5ab6dcce4614"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a0629d1f-fd93-a896-76ec-075f58abe87e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a2d26f38-e087-af2c-caf5-e63552260524"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a32a1387-0ace-a0b7-8a9f-10ddcd1456e5"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a38de7a4-f2e1-9f7d-4f60-010e17334632"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a4419a87-e4f1-b9ed-553a-315aae865e6c"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a648145d-ed89-2600-fe1d-f0cb3bf5eeff"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("acb121d7-7d14-8fd1-3cd2-43619067470a"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ae62cf76-bca6-3424-b4cc-d1e8afb101f2"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("b1a12f3e-9abe-ffaa-6bfd-2291cfc5737b"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("b1ca338e-f699-c55a-25f7-ad9cdb3e6fce"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("b824e20d-1ccf-2f8c-b5a5-ed3ec5e5f4b2"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("b932b237-7833-ed9d-6b0f-480ddabbec2e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("b939b7ad-40c5-71f9-37b2-a30b8f472502"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("baad8de8-1a0c-c866-112a-a1ba7522ec7e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("be92d513-ee64-11e8-bdfd-1e9f6a781719"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c11c2319-d0ed-e6f8-3b3a-b5ccd09616fe"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c247dafa-0a10-cae1-dc80-4f50835111c6"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c2dd6534-108b-c68e-7006-e2a50ae79c9b"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c785197c-4d91-e7a8-af7f-0dac07ab317e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("cae5d47a-6d0f-08c2-0a36-2b2f4144e83f"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("d403dd5a-846c-a316-312a-ba6bacb6550c"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("d94a75b0-1545-44b2-dbaa-5c97c25a8af5"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("d9e632af-5f93-1f18-0f9c-f1b59c7edce1"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("da30a954-cbb9-50e8-c622-ffecfce769fe"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("db728ba4-1a2f-2382-acbe-5bda19a1b33f"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("dbe5100d-04db-d57c-7554-29fcd768bd24"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("dd1dc434-071b-7abe-ca70-3c3dcf905638"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("df699354-ed8a-882f-16d2-c7b531b94f5d"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("e0dc8fcb-2400-8ea7-3b8b-15dd5b12ae54"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("e2cd9414-20c6-2c1d-35cd-85dc9bd209ff"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("e5fb9e53-3bfd-9bd0-6488-219adb956c38"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("e7b5164d-233b-a614-ca78-0ad5e9b21ff2"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("efc6dc0b-d2e9-7072-fbea-cfe0c3711158"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f344a948-2aad-b19b-bde1-94c6981ea8b6"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f860694f-70ab-b0ff-81f2-aa8af23bf543"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("fa88abfc-836b-5423-506e-9b2cc188c843"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("fb547eaf-9fa5-6ad7-e54a-8c4ddce6505b"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("fe89439a-5602-f69e-ea5e-c5b9b310586d"));

            migrationBuilder.InsertData(
                table: "HardwareCodecs",
                columns: new[] { "Id", "Identifier", "Name" },
                values: new object[] { new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), "av1", "AV1" });

            migrationBuilder.InsertData(
                table: "TestCaseArguments",
                columns: new[] { "Id", "FfmpegArgument", "FfmpegVersionGroupId", "FfmpegVersionId", "FromHardwareCodecId", "TestCaseArgumentDeviceType", "ToHardwareCodecId" },
                values: new object[,]
                {
                    { new Guid("0c5576b4-b54c-e5fb-bf85-8d9c39701c2f"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("22ea782b-8fa6-1f9c-015d-81c0c7c282af"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("276ec8e3-d3b8-8457-237b-a60619e5bb3f"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("2dde49e0-7c69-fdb0-1fad-f0ae2201b207"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("377f2b1b-f3ab-0e3e-fd88-cf867e10c340"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("3e673757-b030-3f62-79c3-84ccb52de154"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("5537564f-7fd9-1c5f-a89b-36356e846fbb"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("5b0e2919-261e-e3c9-2758-d6be4efca895"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("60eed668-efcf-c5d8-b0f7-2b45b9cecbb2"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("633b5158-6583-1476-c608-ed67340f9a65"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("68d80cd6-d419-d3ba-1946-491d5ea485cb"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("6c5d13f2-970f-cb21-f48c-68a57fa6f5ac"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("77bcbea6-2b15-0d89-a582-22c349b605d8"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("7ddc0e8d-3b17-8a03-7764-886ef2f15b25"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("826985c6-15ea-f224-f960-0a5171232db9"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("8d7c02f7-ccae-acf6-54ea-76e4bf1a6e38"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("94736a4e-b0c9-a260-6aff-0d1c91b6ff44"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("9a013667-1ba8-d785-5b89-1a4c9f2054b1"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("a13d0c48-818e-0aca-5000-0bfc6af74e3d"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("a983b019-9d06-5dd2-e3df-31be4b878a59"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("aa717124-8dd1-8248-4064-5ff818d4e787"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("b6e03e18-0d83-ebe9-ca32-f65251e9351b"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("bf5751ec-85d3-43cf-798a-744ee0ae1e98"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("ca26676e-1a34-6d2e-5a4f-d46284b816e9"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("e1a6cdde-b019-0702-d3e9-6ef7e5b7186c"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("e76ac5c1-0960-aad9-3369-fff3350bc56e"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("e8d7879d-105e-ba9e-f9f7-47b5ad02ac5d"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("ec7b86ca-606d-85e1-1a10-36943ac21e03"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("f1bd8625-aa94-d9b1-caec-078a6d55c7d7"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("fbead29f-a97c-9b0f-ada9-4b754ea4d11c"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("fd694998-393b-3025-f04a-21d2b113d63c"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("fd710759-16d7-76e8-d17e-3aaa1a8507f0"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") }
                });

            migrationBuilder.InsertData(
                table: "TestCases",
                columns: new[] { "Id", "Bitrate", "FromResolution", "MediaTestFileId", "TestCaseType", "ToCodecId", "ToResolution" },
                values: new object[,]
                {
                    { new Guid("00e2c584-1a02-97af-e4c1-c9bb51fa3444"), 9616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("011ddff0-fe01-d11e-f939-59bc1d2c4980"), 3616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("0211351a-ffc6-bed6-56ab-84932548c34b"), 3616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("03c405e5-937c-4b50-1e5b-f1d2c2696e1c"), 3616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("048c2c55-8e64-7cd2-5f02-dd5946a8f41f"), 9616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("05019bf1-1c48-7be8-ec45-3f88d3120cff"), 9616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("0a8aa1c3-1773-b8ef-4919-e9ac227c5792"), 9616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("0ad46ac5-96b0-c871-70f0-5357eea8b03f"), 79616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("0fb2252b-a8db-e6ef-3838-9b1a2daf1ba8"), 79616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("14af0573-6550-60a6-9894-ecebf684b863"), 9616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("16a7ff1c-1ee4-99d0-87cb-5f50fb3258da"), 3616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("17212ead-c27e-e8d4-1596-cec87345267d"), 9616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("18004bee-b38d-a20c-164c-e65a5a82adfd"), 79616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("18fe6f6c-59a6-3542-66a2-5b2c55d32785"), 3616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("20d90f2d-6628-b163-a1a0-eea522f13ffa"), 3616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("22faf853-dc61-aa96-72ee-28591168084e"), 9616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("25a712c3-ebf9-f051-5d36-16b4ee865a4c"), 79616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("27787362-72db-c7e5-274f-b926d21f93bc"), 9616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("28a931fc-ac0a-2ff4-a4ba-81dfa0031c44"), 3616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("28caabc2-d912-4691-ef68-2b460339d373"), 79616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("2ac025e4-c750-2521-7b8b-6400ed0a38e1"), 3616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("2d69b9db-58f7-a5e2-030e-6e79598e8dbb"), 79616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("3349fea9-7ef9-3d09-d45c-b06b205fb506"), 3616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("39fe3138-3fb0-1d60-45ad-f99d1fa99871"), 79616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("3ac0be60-163e-9b40-84d8-1bf7947f5047"), 79616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("4151b685-7026-ca33-9b72-5fc42cffb445"), 79616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("4a181a4b-b478-3094-5885-89f0a13e271e"), 3616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("4a996f4f-6de6-ad87-423f-669ecb89ade3"), 79616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("4ae81d34-4c8f-2c7d-ba2e-bd7552831749"), 3616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("4da744ae-c3e7-ee70-ce5b-1cf9ac8b40c7"), 9616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("4f4cf1b1-36f1-27b7-eb13-40167e96e4e6"), 9616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("502e3b11-8635-a04c-f3ad-7ba5b2f7c481"), 9616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("51118aab-952b-406d-cf06-104f10262158"), 9616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("5b2b7843-4b60-6d5a-4548-ae2d2527502f"), 9616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("5e6d87ec-3f23-3514-a62f-0b1839f82c89"), 9616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("6bd014ec-8d7f-a8f8-8fd1-4fe0d15b822d"), 9616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("72690f7a-5d0f-eca1-4a49-9070dc89c6ed"), 3616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("7470feaa-8800-00cd-1cdd-aafd054be5cc"), 3616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("78fc8d1f-5046-56ab-e80c-7f5938b2df46"), 9616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("7eca0e6f-a075-121f-40cc-dae741d839a1"), 79616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("811ccbf2-bf8e-ea8e-10f1-8f0bbb25db07"), 3616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("83543e3f-5006-b471-729d-58a7c61e612e"), 79616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("8d506d05-c64d-e83d-ce92-d56e70405771"), 79616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("8ef545bb-a22c-fac5-2a59-e6aed0373752"), 3616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("8f88501c-a563-7d32-27ac-4ddad5649ae0"), 79616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("903a9f68-d44c-2d49-7653-53d68354d945"), 3616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("907e4bbf-9c26-7dae-e15e-7c16a4639408"), 9616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("9672ddc2-113e-cd73-eb4b-30fcfd7106b8"), 3616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("98dc75e7-0493-480f-a5db-108b03ca35e7"), 79616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("a0aca543-940c-9fd1-312a-bc30c8407fc4"), 79616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("a22e4fab-16c1-bc54-2dc4-5fb1489116b2"), 79616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("a5b1f1ff-3d08-b956-f18f-d89d5aad3073"), 9616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("a6255c1a-fe2b-b9e2-d8a9-68731d216703"), 79616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("b054c156-87ba-eee7-05cd-c38fb77f9e91"), 9616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("b3a5712e-4d23-ca79-f017-55c95fbad047"), 3616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("b61759ed-2f59-9842-1860-daca192625a2"), 79616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("c022f910-eb91-7f02-d927-02b567190d16"), 9616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("c43b698a-5154-f54b-a3d4-5192d1a0bb92"), 3616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("c69b266d-4c80-70de-b01c-12f474f33ec2"), 3616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("c6f49510-de99-27cf-2776-44f55b0951e7"), 3616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("c7e452ba-6dcb-e411-515e-51445b5017ae"), 79616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("c8a80036-8391-f374-6d23-ae1ecb3aa6af"), 79616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("ca743b31-6da0-8b4c-40e4-ff2c3272582d"), 9616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("ccad46f6-6766-f9d6-f266-1f78ff9d54ee"), 9616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("cfb78258-268c-3971-9ba9-98d0d5388804"), 3616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("e27fd0d0-15b3-61bf-9633-7c0e9089d80b"), 79616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("e2bdd7fb-4ae8-135e-c902-8183c304f632"), 3616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("e5eddfdd-10d6-d223-578b-b23c33e9bd17"), 9616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("e9abb805-de94-862b-7d64-9d0ba2651101"), 79616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("edfe64f7-6af7-8dea-fb86-7d036eb15352"), 79616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("f4f0ca2f-f353-04e4-d329-b76023fc2639"), 3616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("ffb17990-df2a-35d0-a570-882cc225eb6a"), 9616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" }
                });

            migrationBuilder.InsertData(
                table: "TestCaseArguments",
                columns: new[] { "Id", "FfmpegArgument", "FfmpegVersionGroupId", "FfmpegVersionId", "FromHardwareCodecId", "TestCaseArgumentDeviceType", "ToHardwareCodecId" },
                values: new object[,]
                {
                    { new Guid("055df778-99b4-b2df-453c-eb2e002e71d2"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("05c89e4b-f1dd-c375-1ca7-1b08991d9320"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v av1_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("05f9b581-4f10-f5e7-f191-72876039ea3c"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v av1_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("0b41be12-36ad-c239-8598-4c8ca33e7e8f"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("126e9186-772c-1a3f-6fa6-331187d8b774"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v av1_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v av1_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 3, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("194bc681-b060-d87f-4dae-208ee160dca6"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("3d26a2b3-08da-15ca-d51f-661833bdf0a3"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("3e05393c-7153-24b9-8557-61c6b4b00e33"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v av1_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("3fbc831f-71cf-9bdb-9c47-450650e96fc3"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v av1_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("419af307-3f52-b26f-e5af-6cfc7884f67a"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("442c216a-40a6-2751-43a8-cbb047284faf"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("514e94e3-5458-e9f0-6936-88a3b9fd19ec"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v av1_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("5689908d-ca45-f17b-f337-9b3f92e68a1b"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("5bfbb598-26a1-e488-c7f3-3a083bbc2008"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v av1_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("606ae1ab-0db2-ef96-8fd6-c32111e670d5"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("60ecdc52-4724-11f8-2c9e-766a6ea167d8"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("63a8609b-aff7-4f32-62f5-4a5e68f21ee7"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("66addcf3-5150-0d6b-6b4e-0f1f957f7a71"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("66b268c6-bcd2-2f9b-3b47-75f1bd332bf5"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("6b523570-76aa-b9d7-418d-a528ecc169ad"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("6c00c3d3-cd88-003a-d2d0-72230c77c457"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("79f41edb-b7d3-26ab-9a82-3d9d7bc0b303"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v av1_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("7df6e3ba-aaf9-31f1-36d1-1d45ac314f67"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("801a7283-9008-a1ad-6ad8-efc9f4f7beac"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("8b555241-8af2-4355-82fb-8753d2f44468"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("8bf004b5-8404-dbec-d275-cc0ac1a9869b"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("9205e113-1046-db8d-dc5d-e33cf49850b1"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("989fe027-5e1c-f11a-22c4-381cb24c712b"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("9b1ea278-49d6-725a-d175-249c6f0d9328"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("ad489985-ad40-0bb5-03d7-0099864b4c7f"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("b84c2dc5-a932-be59-b04b-4b5460d2ce1a"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("bf2fa85a-cc6d-6091-5a2a-3f2c314d630b"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v av1_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("c01ec356-c148-b435-bb3d-61a2f56bb0b4"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("c5858878-ea6f-eb37-0c64-8fb123de21d8"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("e1adfe0c-eb4c-92a4-3bd3-a4b80c1e23bd"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("e1fbe6c4-35d3-8e67-5fdc-bf0d87869ae1"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("e2308bd3-b628-811f-bf4e-fc5c769ad324"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("e28bd218-5c1f-f573-3546-c93ead4b5e51"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v av1_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("edbee688-e771-e40e-108b-fefca71a978e"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v av1_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("f5d7f0f8-b082-6a00-fc30-0797b3451eb4"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("055df778-99b4-b2df-453c-eb2e002e71d2"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("05c89e4b-f1dd-c375-1ca7-1b08991d9320"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("05f9b581-4f10-f5e7-f191-72876039ea3c"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("0b41be12-36ad-c239-8598-4c8ca33e7e8f"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("0c5576b4-b54c-e5fb-bf85-8d9c39701c2f"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("126e9186-772c-1a3f-6fa6-331187d8b774"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("194bc681-b060-d87f-4dae-208ee160dca6"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("22ea782b-8fa6-1f9c-015d-81c0c7c282af"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("276ec8e3-d3b8-8457-237b-a60619e5bb3f"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("2dde49e0-7c69-fdb0-1fad-f0ae2201b207"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("377f2b1b-f3ab-0e3e-fd88-cf867e10c340"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("3d26a2b3-08da-15ca-d51f-661833bdf0a3"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("3e05393c-7153-24b9-8557-61c6b4b00e33"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("3e673757-b030-3f62-79c3-84ccb52de154"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("3fbc831f-71cf-9bdb-9c47-450650e96fc3"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("419af307-3f52-b26f-e5af-6cfc7884f67a"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("442c216a-40a6-2751-43a8-cbb047284faf"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("514e94e3-5458-e9f0-6936-88a3b9fd19ec"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("5537564f-7fd9-1c5f-a89b-36356e846fbb"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("5689908d-ca45-f17b-f337-9b3f92e68a1b"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("5b0e2919-261e-e3c9-2758-d6be4efca895"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("5bfbb598-26a1-e488-c7f3-3a083bbc2008"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("606ae1ab-0db2-ef96-8fd6-c32111e670d5"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("60ecdc52-4724-11f8-2c9e-766a6ea167d8"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("60eed668-efcf-c5d8-b0f7-2b45b9cecbb2"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("633b5158-6583-1476-c608-ed67340f9a65"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("63a8609b-aff7-4f32-62f5-4a5e68f21ee7"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("66addcf3-5150-0d6b-6b4e-0f1f957f7a71"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("66b268c6-bcd2-2f9b-3b47-75f1bd332bf5"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("68d80cd6-d419-d3ba-1946-491d5ea485cb"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("6b523570-76aa-b9d7-418d-a528ecc169ad"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("6c00c3d3-cd88-003a-d2d0-72230c77c457"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("6c5d13f2-970f-cb21-f48c-68a57fa6f5ac"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("77bcbea6-2b15-0d89-a582-22c349b605d8"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("79f41edb-b7d3-26ab-9a82-3d9d7bc0b303"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("7ddc0e8d-3b17-8a03-7764-886ef2f15b25"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("7df6e3ba-aaf9-31f1-36d1-1d45ac314f67"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("801a7283-9008-a1ad-6ad8-efc9f4f7beac"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("826985c6-15ea-f224-f960-0a5171232db9"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("8b555241-8af2-4355-82fb-8753d2f44468"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("8bf004b5-8404-dbec-d275-cc0ac1a9869b"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("8d7c02f7-ccae-acf6-54ea-76e4bf1a6e38"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("9205e113-1046-db8d-dc5d-e33cf49850b1"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("94736a4e-b0c9-a260-6aff-0d1c91b6ff44"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("989fe027-5e1c-f11a-22c4-381cb24c712b"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("9a013667-1ba8-d785-5b89-1a4c9f2054b1"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("9b1ea278-49d6-725a-d175-249c6f0d9328"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("a13d0c48-818e-0aca-5000-0bfc6af74e3d"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("a983b019-9d06-5dd2-e3df-31be4b878a59"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("aa717124-8dd1-8248-4064-5ff818d4e787"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("ad489985-ad40-0bb5-03d7-0099864b4c7f"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("b6e03e18-0d83-ebe9-ca32-f65251e9351b"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("b84c2dc5-a932-be59-b04b-4b5460d2ce1a"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("bf2fa85a-cc6d-6091-5a2a-3f2c314d630b"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("bf5751ec-85d3-43cf-798a-744ee0ae1e98"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("c01ec356-c148-b435-bb3d-61a2f56bb0b4"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("c5858878-ea6f-eb37-0c64-8fb123de21d8"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("ca26676e-1a34-6d2e-5a4f-d46284b816e9"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("e1a6cdde-b019-0702-d3e9-6ef7e5b7186c"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("e1adfe0c-eb4c-92a4-3bd3-a4b80c1e23bd"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("e1fbe6c4-35d3-8e67-5fdc-bf0d87869ae1"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("e2308bd3-b628-811f-bf4e-fc5c769ad324"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("e28bd218-5c1f-f573-3546-c93ead4b5e51"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("e76ac5c1-0960-aad9-3369-fff3350bc56e"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("e8d7879d-105e-ba9e-f9f7-47b5ad02ac5d"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("ec7b86ca-606d-85e1-1a10-36943ac21e03"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("edbee688-e771-e40e-108b-fefca71a978e"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("f1bd8625-aa94-d9b1-caec-078a6d55c7d7"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("f5d7f0f8-b082-6a00-fc30-0797b3451eb4"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("fbead29f-a97c-9b0f-ada9-4b754ea4d11c"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("fd694998-393b-3025-f04a-21d2b113d63c"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("fd710759-16d7-76e8-d17e-3aaa1a8507f0"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("00e2c584-1a02-97af-e4c1-c9bb51fa3444"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("011ddff0-fe01-d11e-f939-59bc1d2c4980"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0211351a-ffc6-bed6-56ab-84932548c34b"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("03c405e5-937c-4b50-1e5b-f1d2c2696e1c"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("048c2c55-8e64-7cd2-5f02-dd5946a8f41f"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("05019bf1-1c48-7be8-ec45-3f88d3120cff"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0a8aa1c3-1773-b8ef-4919-e9ac227c5792"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0ad46ac5-96b0-c871-70f0-5357eea8b03f"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0fb2252b-a8db-e6ef-3838-9b1a2daf1ba8"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("14af0573-6550-60a6-9894-ecebf684b863"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("16a7ff1c-1ee4-99d0-87cb-5f50fb3258da"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("17212ead-c27e-e8d4-1596-cec87345267d"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("18004bee-b38d-a20c-164c-e65a5a82adfd"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("18fe6f6c-59a6-3542-66a2-5b2c55d32785"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("20d90f2d-6628-b163-a1a0-eea522f13ffa"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("22faf853-dc61-aa96-72ee-28591168084e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("25a712c3-ebf9-f051-5d36-16b4ee865a4c"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("27787362-72db-c7e5-274f-b926d21f93bc"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("28a931fc-ac0a-2ff4-a4ba-81dfa0031c44"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("28caabc2-d912-4691-ef68-2b460339d373"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("2ac025e4-c750-2521-7b8b-6400ed0a38e1"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("2d69b9db-58f7-a5e2-030e-6e79598e8dbb"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("3349fea9-7ef9-3d09-d45c-b06b205fb506"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("39fe3138-3fb0-1d60-45ad-f99d1fa99871"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("3ac0be60-163e-9b40-84d8-1bf7947f5047"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("4151b685-7026-ca33-9b72-5fc42cffb445"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("4a181a4b-b478-3094-5885-89f0a13e271e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("4a996f4f-6de6-ad87-423f-669ecb89ade3"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("4ae81d34-4c8f-2c7d-ba2e-bd7552831749"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("4da744ae-c3e7-ee70-ce5b-1cf9ac8b40c7"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("4f4cf1b1-36f1-27b7-eb13-40167e96e4e6"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("502e3b11-8635-a04c-f3ad-7ba5b2f7c481"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("51118aab-952b-406d-cf06-104f10262158"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("5b2b7843-4b60-6d5a-4548-ae2d2527502f"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("5e6d87ec-3f23-3514-a62f-0b1839f82c89"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("6bd014ec-8d7f-a8f8-8fd1-4fe0d15b822d"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("72690f7a-5d0f-eca1-4a49-9070dc89c6ed"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("7470feaa-8800-00cd-1cdd-aafd054be5cc"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("78fc8d1f-5046-56ab-e80c-7f5938b2df46"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("7eca0e6f-a075-121f-40cc-dae741d839a1"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("811ccbf2-bf8e-ea8e-10f1-8f0bbb25db07"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("83543e3f-5006-b471-729d-58a7c61e612e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("8d506d05-c64d-e83d-ce92-d56e70405771"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("8ef545bb-a22c-fac5-2a59-e6aed0373752"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("8f88501c-a563-7d32-27ac-4ddad5649ae0"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("903a9f68-d44c-2d49-7653-53d68354d945"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("907e4bbf-9c26-7dae-e15e-7c16a4639408"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("9672ddc2-113e-cd73-eb4b-30fcfd7106b8"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("98dc75e7-0493-480f-a5db-108b03ca35e7"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a0aca543-940c-9fd1-312a-bc30c8407fc4"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a22e4fab-16c1-bc54-2dc4-5fb1489116b2"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a5b1f1ff-3d08-b956-f18f-d89d5aad3073"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a6255c1a-fe2b-b9e2-d8a9-68731d216703"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("b054c156-87ba-eee7-05cd-c38fb77f9e91"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("b3a5712e-4d23-ca79-f017-55c95fbad047"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("b61759ed-2f59-9842-1860-daca192625a2"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c022f910-eb91-7f02-d927-02b567190d16"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c43b698a-5154-f54b-a3d4-5192d1a0bb92"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c69b266d-4c80-70de-b01c-12f474f33ec2"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c6f49510-de99-27cf-2776-44f55b0951e7"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c7e452ba-6dcb-e411-515e-51445b5017ae"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c8a80036-8391-f374-6d23-ae1ecb3aa6af"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ca743b31-6da0-8b4c-40e4-ff2c3272582d"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ccad46f6-6766-f9d6-f266-1f78ff9d54ee"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("cfb78258-268c-3971-9ba9-98d0d5388804"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("e27fd0d0-15b3-61bf-9633-7c0e9089d80b"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("e2bdd7fb-4ae8-135e-c902-8183c304f632"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("e5eddfdd-10d6-d223-578b-b23c33e9bd17"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("e9abb805-de94-862b-7d64-9d0ba2651101"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("edfe64f7-6af7-8dea-fb86-7d036eb15352"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f4f0ca2f-f353-04e4-d329-b76023fc2639"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ffb17990-df2a-35d0-a570-882cc225eb6a"));

            migrationBuilder.DeleteData(
                table: "HardwareCodecs",
                keyColumn: "Id",
                keyValue: new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"));

            migrationBuilder.InsertData(
                table: "TestCaseArguments",
                columns: new[] { "Id", "FfmpegArgument", "FfmpegVersionGroupId", "FfmpegVersionId", "FromHardwareCodecId", "TestCaseArgumentDeviceType", "ToHardwareCodecId" },
                values: new object[,]
                {
                    { new Guid("05f63ec9-068d-44e4-efe3-3f833ea2876f"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("0a1ba650-c8c9-1aa1-72dc-ff0cb2880881"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("35d0028e-139e-df9d-1d07-9f56b94975b3"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("469e1053-ae97-b1f9-ef24-5f1d95138715"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("4a2fe920-8a57-9723-b9a5-f81804414878"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("500e6440-c7fc-5d18-e7e1-82773b31aa03"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("561792ff-a20b-cfc7-9912-323acc900ddd"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("5bc22f30-b4bd-e51d-e6d5-6fc1c2709fb5"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("676daa76-8557-8b8a-bca2-1ce90cfe8e75"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("69d8cbca-6268-3967-f560-4bf6229858b3"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("6a5b0be0-66b3-9404-8cf9-5bc5afce61f9"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("71e277b0-267d-a5d5-69a7-9840b5970222"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("782482dd-1d13-1c1a-c51b-32b578d7e6ec"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("7d0a7a20-0d59-9eb7-a84e-a7fbcc505f68"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("7e8ff566-90c9-0fc6-3742-42545bc26cb5"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("8baddd33-a587-0996-4056-adaa81a5deb8"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("8e48eaea-724c-9b4c-1e4b-db47a07214c2"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -noautoscale -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("94031f12-1b7f-c30e-7e73-a080421e785d"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -noautoscale -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("96432aad-a8ae-bd50-d72c-1e67eaec0369"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("99a47908-f009-fc68-e033-c09b1f6e3af1"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("9c13eaf2-11ea-21b0-f8aa-a49c39f723f2"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("a44b626b-d79a-aade-b785-be3fe9b37e8a"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -noautoscale -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("ad833710-00e3-8fdf-acb3-0832656ba3c0"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("aee1af78-898f-8d48-3f25-1de6ddc40de8"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("c4d9cff7-1e10-1498-8555-3f32833b18a1"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("c6935287-0329-b052-9f0f-958485200cb9"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("cbea1bb6-d7f7-a7ea-bbcb-fbf4813fa1ed"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf scale_qsv=-1:{scale}:format=nv12 -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("ce1eacee-7d66-8d35-8267-77e93ec6837e"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("e15f4b0e-6ce9-277c-bf80-9bca957b774a"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -noautoscale -an -sn -vf scale_vaapi=-1:{scale}:format=nv12 -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("e2374439-3f63-4c45-077a-d27031779c3d"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("e78c26c4-68fa-3ced-64ba-ae3f19ae4251"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("f28df60c-8da7-90f6-4929-0b7f8e5395f9"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") }
                });

            migrationBuilder.InsertData(
                table: "TestCases",
                columns: new[] { "Id", "Bitrate", "FromResolution", "MediaTestFileId", "TestCaseType", "ToCodecId", "ToResolution" },
                values: new object[,]
                {
                    { new Guid("028fb801-8d30-61d7-dc07-5b504eb0d8ef"), 3616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("04005d73-f676-23f4-2eb5-9f40d37a3602"), 79616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("058d6227-9a3e-151a-ac00-5918d3a81c39"), 79616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("0940b20d-ab22-d1e6-82c9-830f503d4f17"), 9616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("0b6ae35d-7b27-4893-6b6c-0bf12a44265d"), 3616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("104d798f-42e5-c43a-4ceb-d2d1390138db"), 79616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("186d1538-5184-1edd-bccc-4158b39722ec"), 3616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("1aa729fd-0db1-ab27-e6f1-11b101175a93"), 3616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("237784b1-b14e-79ee-1149-8bb8823bb857"), 79616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("25d8d497-a8df-d043-cfaf-c82aa1b2f4bd"), 3616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("273e5834-df8f-8d86-740a-342cd8b4539b"), 79616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("287ae63b-67e7-86b3-65b3-f69012bbdde5"), 3616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("299ec5e3-24c7-48a7-b5e5-5ea61fee8e91"), 79616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("31266d7f-3c6a-059c-97f9-0c350a48cf9b"), 9616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("3eafe542-7078-cec9-1a46-d1592121a98d"), 9616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("3ef39e22-3637-e014-a100-e8e86304fe23"), 3616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("41b541bf-26ee-670f-904c-b5c4ffe6d9ca"), 3616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("4491f98d-fdfd-9fc5-85fe-fe02cdcbd702"), 9616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("45becaa0-1aeb-8eb2-a4ad-434d723bdb31"), 9616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("4922e1eb-3b73-6dcb-700c-5dafc9229f0d"), 3616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("4cd38095-40c9-e973-048a-e050a753723e"), 3616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("50500185-56a9-bb96-a5d8-a397323d3927"), 9616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("56d96104-770b-77fd-e092-d14de768287c"), 3616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("58e3e5dc-097f-de4a-0229-0ccb7c28c316"), 79616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("5d20e63b-3205-47e1-7cc1-af8a5fcb0866"), 9616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("61f4077a-0853-ccf5-338d-5541ab3fca89"), 9616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("65b4d34d-3e49-2493-9dc1-19c49735fad7"), 9616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("71479a7d-e7c1-8433-6687-c708251c67ed"), 3616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("73d58f04-30d6-caec-2e26-fb821289e00a"), 79616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("76f35ad1-93a3-89c2-9656-c35ea763d780"), 79616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("7ad6bd3f-dc74-34a3-309c-b9ca91d47bee"), 9616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("94505991-fad8-d5a8-b233-be8cee34035a"), 9616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("99f7c506-1843-1fb9-f75c-d1d17e04f4c3"), 3616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("9da57263-4c3e-4809-c956-5ab6dcce4614"), 9616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("a0629d1f-fd93-a896-76ec-075f58abe87e"), 9616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("a2d26f38-e087-af2c-caf5-e63552260524"), 79616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("a32a1387-0ace-a0b7-8a9f-10ddcd1456e5"), 3616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("a38de7a4-f2e1-9f7d-4f60-010e17334632"), 9616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("a4419a87-e4f1-b9ed-553a-315aae865e6c"), 3616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("a648145d-ed89-2600-fe1d-f0cb3bf5eeff"), 3616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("acb121d7-7d14-8fd1-3cd2-43619067470a"), 3616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("ae62cf76-bca6-3424-b4cc-d1e8afb101f2"), 9616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("b1a12f3e-9abe-ffaa-6bfd-2291cfc5737b"), 79616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("b1ca338e-f699-c55a-25f7-ad9cdb3e6fce"), 79616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("b824e20d-1ccf-2f8c-b5a5-ed3ec5e5f4b2"), 9616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("b932b237-7833-ed9d-6b0f-480ddabbec2e"), 9616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("b939b7ad-40c5-71f9-37b2-a30b8f472502"), 3616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("baad8de8-1a0c-c866-112a-a1ba7522ec7e"), 79616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("be92d513-ee64-11e8-bdfd-1e9f6a781719"), 79616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("c11c2319-d0ed-e6f8-3b3a-b5ccd09616fe"), 79616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("c247dafa-0a10-cae1-dc80-4f50835111c6"), 79616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("c2dd6534-108b-c68e-7006-e2a50ae79c9b"), 9616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("c785197c-4d91-e7a8-af7f-0dac07ab317e"), 9616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("cae5d47a-6d0f-08c2-0a36-2b2f4144e83f"), 9616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("d403dd5a-846c-a316-312a-ba6bacb6550c"), 9616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("d94a75b0-1545-44b2-dbaa-5c97c25a8af5"), 79616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("d9e632af-5f93-1f18-0f9c-f1b59c7edce1"), 79616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("da30a954-cbb9-50e8-c622-ffecfce769fe"), 3616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("db728ba4-1a2f-2382-acbe-5bda19a1b33f"), 9616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("dbe5100d-04db-d57c-7554-29fcd768bd24"), 79616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("dd1dc434-071b-7abe-ca70-3c3dcf905638"), 79616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("df699354-ed8a-882f-16d2-c7b531b94f5d"), 79616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("e0dc8fcb-2400-8ea7-3b8b-15dd5b12ae54"), 79616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("e2cd9414-20c6-2c1d-35cd-85dc9bd209ff"), 3616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("e5fb9e53-3bfd-9bd0-6488-219adb956c38"), 79616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("e7b5164d-233b-a614-ca78-0ad5e9b21ff2"), 79616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("efc6dc0b-d2e9-7072-fbea-cfe0c3711158"), 9616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("f344a948-2aad-b19b-bde1-94c6981ea8b6"), 3616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("f860694f-70ab-b0ff-81f2-aa8af23bf543"), 9616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("fa88abfc-836b-5423-506e-9b2cc188c843"), 3616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("fb547eaf-9fa5-6ad7-e54a-8c4ddce6505b"), 3616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("fe89439a-5602-f69e-ea5e-c5b9b310586d"), 3616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" }
                });
        }
    }
}
