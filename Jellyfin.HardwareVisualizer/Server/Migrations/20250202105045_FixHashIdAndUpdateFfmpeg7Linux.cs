using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Jellyfin.HardwareVisualizer.Server.Migrations
{
    /// <inheritdoc />
    public partial class FixHashIdAndUpdateFfmpeg7Linux : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("01ac7c84-29a3-b38e-bd86-2e6bdc472c96"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("048e1c9b-06be-3bb4-99ec-a3892f04f372"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("0528bcfd-878f-9897-ab7c-4ed86145d6df"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("059f7916-ccf3-7415-e82f-055f5818904e"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("08fcaa98-bbb1-0437-ab28-8c5828f6a306"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("0a81ef18-ab36-7db7-de47-06a167173e49"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("0b1d6b3e-1828-1649-e2a7-698a3a8989db"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("0d84c99c-6f1d-39c3-4563-03c5833fdbcb"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("117b1e4d-f0df-df5c-46bd-755647329bd1"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("147513cb-3444-c905-dbfb-7708a1d25cdb"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("152c7de8-6775-f127-9395-71f1b89e3c2e"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("1957761c-44e3-bc89-4dbe-5bccbf572947"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("1ebb20b5-1884-b8b3-8374-57f1512d6e03"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("2632ffa5-8eb1-27f5-04c5-3edb42933f5a"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("29fa0bf5-3b03-8f38-0f85-9cafa3c82526"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("2ac84667-d996-0c55-8156-e6db69468f2c"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("2bbbae34-f4eb-ce72-2387-b45b619d7c5f"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("2c49acbb-779a-4a87-6318-e6b91df1cc39"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("2d22e767-c2c2-d8ad-3162-9e366865581d"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("2eb5c3f1-f8f8-96eb-b677-e4ab58bc11da"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("328d78e7-018e-6dc5-a7fd-80a946847e5e"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("35a1012d-cec2-2653-c2d3-b862bc2a6122"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("410a1371-3337-b57c-2e29-4f615c653dee"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("44a550b2-565f-3cf7-4d69-61bff007d983"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("49535f0e-eca0-6c7e-e2c7-c6a9c78883b1"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("4b16cc4b-3e49-671a-8758-a9f77b9a46cc"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("4c5124ff-f035-c216-0aa3-5dd0a86ed733"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("4eb28789-e528-744d-7b6c-66978ed1e2b5"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("4ec23a32-c6e9-7bc9-a692-dc9ae48e35a6"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("4fbf8e3f-19fc-a093-5f1a-1ef407b09254"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("500cd13c-60ba-1e87-26dd-0ca372601c78"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("55ae773f-a60d-9568-30f3-3dd4b707c75d"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("55d32bc1-9829-9f39-d0e7-1f5dc89e9684"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("58c85eb1-ef52-d094-e1f5-8431257f9c38"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("62f506b2-1f52-2461-371b-37a92b8f9b43"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("6e4d7781-d02b-3a2d-c9c2-774ae018c7cd"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("74af004c-962d-f0c4-25fe-f6f0a20c5472"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("7579c36b-3b44-5c90-b383-85956f868e88"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("78932cf9-d4b1-2cd8-2968-b6bf33f8672b"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("797d392d-6f63-58c9-b3cd-b28380fe235c"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("7b85bed3-059a-cdba-64e3-83fcdbafd02f"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("7c64e69a-68b0-db74-78f7-0c59869bcb62"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("8135bb9e-e8cd-f0e1-4d14-307fc961afd0"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("81c9d73e-f2e7-93b0-8c6d-299ea68abb30"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("876d0a12-3a6c-a4af-2894-2b7f115fd513"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("88e6a760-1efd-25e5-8c4f-7b5597682175"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("89ce6dae-dbee-9a51-f471-9e8ee61b9336"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("8ef438c9-1b3a-6d36-6095-733fcc4f7453"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("996395b0-7f8a-524f-8832-7596e2642e82"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("a3c4566f-5518-4e6d-75af-6cc05d8b8741"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("a62ea616-631d-3e36-2877-8106eacaa787"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("a6aff48f-13ee-1325-10dc-d75c8ec537a2"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("a73c3f16-f341-9fb4-f4a9-847e7ff546df"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("ab85f6ef-874e-db84-7756-281826e48d00"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("ac3a3425-ed5a-07f4-3737-41714870545b"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("ace74565-5b31-0f01-638e-956eefc942cf"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("ad72eb8f-3d5c-6a6f-831c-495e6f5c81f7"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("adb83bf7-bfbe-e26d-8555-983e7fe3d5d4"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("b21cae2a-5fdb-9768-5f6d-7d5ed36677d5"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("b6fafd2e-ef9d-b04e-d5fc-2c10861bd7ad"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("bbcd5f5d-aa05-19b8-a90f-71c47dd7f4ee"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("c5eafda1-1a71-fc61-c0fe-9ea5dd4ba84b"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("c709cc8d-9ef3-c5c0-8442-23a4c6fb44c7"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("c8231720-c899-8a6c-6c52-cc59019600e8"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("c9015dc9-f1da-9094-a6fe-c3b20f3e7861"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("cc23a711-6feb-9eee-aa71-c88128f5e63c"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("cc87feca-3c43-f1b4-efbb-62b4a2fdb31d"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("cdbf0b96-12c9-d7d3-1aa6-b54a1c1ad842"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("cec9ddd1-74a6-fcc2-8def-a71efafee121"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("d068ce06-8625-9403-37cd-da31c30d5a1c"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("d24d3828-ae39-3a6b-265b-6d76f9dcab25"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("d7aa10e0-a3d2-08c7-15e6-abf22af85f0c"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("d7e88415-b586-0370-044d-986a3fa01615"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("daa033ef-ad70-60d6-37b5-4d150a5e67e9"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("e5985e2a-f2da-48e4-98fc-9249f7350c4a"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("ec1f41c5-ca64-7a41-2ade-19474dcfdf4b"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("eea1a41c-d44f-f65b-ae8e-f837aedc0fda"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("eefb71f2-e757-d5e9-dfa6-3303dc18e4dd"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("ef78a4dc-a924-03ec-1422-7d6dcbeb22d8"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("fe0cd927-b3ea-d2c8-9b1e-636bbafc5e90"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("fe2a0c26-be43-f489-7765-ed0697f72508"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0244052a-452d-2db7-3f98-05494002f657"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("03266b05-8822-7a0e-dc33-212206873afa"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("046f3625-981d-0dc8-9a7f-c6ddccd9ce67"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("09737fe6-4e65-4bb7-e7d8-85c2bba6360a"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0a4ec8b0-691d-e1cb-3204-b33f86db05bf"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0bfdb4e0-4be3-4a08-5a67-585024741c31"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0e574e7d-0fa5-ebd6-8fef-c9306e06117c"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0ea35dd1-8ed1-dfd3-b63d-06a34558389e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("10057971-c127-797a-acf5-7eae599d4880"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("1bc8138f-b929-22ab-4695-e61371f8f1a2"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("1c9281c2-0b47-71f7-dee1-3e7e85270f78"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("217e1616-fc3c-fb9f-c56d-e648810e507e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("220896f2-9209-4cf8-39ff-5f30bac0ccf0"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("25f24cb1-4c54-b83c-9328-000a34ccde3f"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("2e66d24d-b954-af35-632c-72ca6cb4694a"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("339b2f3d-2946-a6e7-1fd9-5260bd73ed93"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("3d2bc7d5-035b-548a-8e7e-37115b4d7893"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("44473c61-4a67-913b-7dbb-86e27045f593"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("46cbbc03-0bce-2d90-1f42-e72081139a36"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("4a0053c9-7f66-afca-ab47-bff02c50029c"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("5839fcf7-54b8-a7bd-c986-6e76e948f3b6"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("59cccb69-1fdd-cf72-b2da-90cc2e7e3cc2"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("5da70774-8acd-41a7-4306-6c73c42f1ebf"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("604d9292-115c-cb42-179f-aa075384f9cd"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("63f10678-51c6-3ce9-810e-ee48b9da239d"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("65a3acda-4e4f-016c-2b29-ff5a6f101bc5"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("69fb6787-3ab5-bd97-204a-6c120fca2a52"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("6aa220a3-db85-0a0d-9e9a-40509950b816"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("6b8f3d02-4aba-f0e7-8401-df8ba1ffb174"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("6d78c8f0-eb77-2cc4-90a1-dc6e83673278"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("71d6d86c-b7a1-855c-cef4-7fa778d4add1"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("74078ac5-3c16-41ad-53b4-28fe9dc23f0b"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("77f1fd29-4639-8ce2-e75c-061e3ed28090"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("78f0d186-1329-225d-f9ec-10731cf8b8ba"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("7b86cf07-dbae-f0e2-91a9-1d12cb235de7"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("7e989914-87be-2f91-7bf3-649262a7b5c1"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("84f92737-ebc0-58c9-f880-c9c02cdec9ac"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("8905cc28-1b80-1d6e-dad0-7dd40231abd1"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("8a893353-5875-d1c9-33ac-157994b2e0eb"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("8b2e7b88-8b24-e79a-7ba9-340608539156"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("927bdcde-2f8a-53c9-697f-f1062dad7c9e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("96a4ca8d-6d7c-35e0-d6f9-0a03b076eb58"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("97b69e5a-f54e-0635-141e-f4d2e5b39e2e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("9ad98f0a-7cca-9a57-41d2-cb285a29994c"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("9f28afa9-180d-eca5-ef32-228f43593f8a"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a366922d-506a-65c9-1d7f-35fb42fc8a06"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a3820862-6d23-4b95-def6-3d1c88471e8f"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a4a6d5a4-012e-2903-82df-ffadc9fcd24c"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ab5d5c29-5b42-9c73-a5d3-a2d9267b764c"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ad1a9ba3-dc39-7338-2424-0aeefdc9fe44"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ade9cbab-a0d1-9a95-a7ff-97870d58d389"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("adf2b8f1-c394-2426-3928-bd290cc4e555"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("b24efd0f-ea5a-ba45-6490-4c270b267ff0"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("bcc05687-8cb7-73d1-37d6-e3faccb1415b"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("bf567cd5-e77c-7290-98ed-142d21fd13f5"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c0bcc210-7789-a0ef-3173-273d4842eaa1"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c895c596-0af0-6ed6-3048-b2d501762b0e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("cefc56ab-b08d-f140-9d13-3f0a168a45fb"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("d45e83c8-2ad1-a5b9-7f2f-5f337f80f976"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("d4d73265-c11f-3e59-13f8-e71a944aa822"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("d57126cc-7539-b770-b84f-b18f6a76d478"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("d88ac6d4-d5f0-beb6-7752-ed0857183cf7"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("d8add6bd-fb22-fe10-379a-c7c031c74ed4"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("dbe95fff-2e87-3e7e-40b0-82e3cf924a25"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("e196dab2-ec63-0a7a-f912-57b6ac3b93d2"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ee4e2299-a178-1b30-7b53-69e7e0cfa43d"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f78c933e-3d98-9904-79ab-f86fdca91d35"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f7c19e20-62a6-b5b3-7272-2bc22b0b0359"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f87f6d28-885d-3966-f182-8373b731cd48"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f8fe5422-d111-8ecb-522d-9f26239c765d"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("fa336f5c-1d5f-61f3-c1a0-87533509c639"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("fffd7354-ba30-0b2f-9a5a-1f5ba75bd30f"));

            migrationBuilder.UpdateData(
                table: "FfmpegVersions",
                keyColumn: "Id",
                keyValue: new Guid("2c720157-f8fb-48c9-8686-d4dfe7daae9a"),
                columns: new[] { "HashMd5", "HashSha256", "Source" },
                values: new object[] { "369BE12F07E0A61739CFBD4E57AA2AB6", "BA4D7B028C5C6B61813CF92AB1B05376AE545E29C5EC65373FED4E93A45CC160", "https://repo.jellyfin.org/files/ffmpeg/linux/7.x/7.0.2-3/amd64/jellyfin-ffmpeg_7.0.2-3_portable_linux64-gpl.tar.xz" });

            migrationBuilder.UpdateData(
                table: "FfmpegVersions",
                keyColumn: "Id",
                keyValue: new Guid("501d7e27-8410-40af-b48d-1e7ce0002173"),
                columns: new[] { "HashMd5", "HashSha256", "Source" },
                values: new object[] { "369BE12F07E0A61739CFBD4E57AA2AB6", "BA4D7B028C5C6B61813CF92AB1B05376AE545E29C5EC65373FED4E93A45CC160", "https://repo.jellyfin.org/files/ffmpeg/linux/7.x/7.0.2-3/amd64/jellyfin-ffmpeg_7.0.2-3_portable_linux64-gpl.tar.xz" });

            migrationBuilder.InsertData(
                table: "TestCaseArguments",
                columns: new[] { "Id", "FfmpegArgument", "FfmpegVersionGroupId", "FfmpegVersionId", "FromHardwareCodecId", "TestCaseArgumentDeviceType", "ToHardwareCodecId" },
                values: new object[,]
                {
                    { new Guid("157f0cf6-672d-88f4-b4ee-c0e23f415036"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("16c162cd-a80a-60fd-5200-8a3a4bcfbe25"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v av1_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v av1_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 3, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("16d68e5f-c1ba-d7ce-077f-7239057323b6"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("19b7573e-a49e-6685-25bd-36c564696281"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("1c323048-e83f-8ff9-a454-070417d0fcd0"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("1c5cf92f-4ee8-4b17-eff6-08762e558a9f"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("1f75776a-1873-d367-b209-561300ac0248"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("2664d9bb-c8aa-9cbb-74bc-ed264c7734cd"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("28b9fea3-d73a-c8db-3977-d314645c2113"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("2ca2dd6d-10fe-3497-a3b7-cc53f668d8f1"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("2edfd8ce-2dda-f2ba-73e5-d78a6c39241c"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v av1_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("308d9541-b7c1-3a9d-23f0-eedddce20a86"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v av1_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("31d5143e-2551-3f80-7e55-13e66a29f36d"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("347ddf68-b6e2-44c2-1406-4b2179433d7e"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("355b09c1-1ef5-762c-3027-ed7dfd31b9aa"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("373f41d1-0bbc-1636-7978-3a7aac04e6e9"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("38c1ca7e-4c2a-b3c5-45a0-6c68dbe49cec"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("42d24fa0-f4b5-92c8-1496-b5c10ace5470"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("42e2178d-7d9f-43bc-c24b-3bb90b174bb9"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("43a27d46-db94-acae-fe65-8234d1947315"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("43ab37bc-59ef-23cd-a449-9fd6d7fa4f39"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("462c8dbb-c521-54dd-ccca-5ff20380d0ee"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("4970baca-731e-7d9f-175e-2629f17aab49"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("5453f03f-c7e7-ffd2-5596-e5fad4fa3c1a"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("55829d95-e48d-4c31-c1d9-fd6cd57332fb"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("64982695-84e0-c90a-274c-2e2dfcb2ac01"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("66c8bd4e-71b7-0330-b175-62343fd78194"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("6719a959-0026-241b-8420-ac9de06932d2"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v av1_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("67387ef3-df9a-6657-a2e6-7bfc6cdd2ab5"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("69675e15-ed30-e683-3624-fcb73f5921d3"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("70412efd-b134-73b7-8953-54927bac64fe"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v av1_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("713ae734-130e-ce12-0292-c29187f8c942"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("7258ce0d-5db4-5563-27bc-b3610509ace2"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v av1_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("74112a4e-dd4d-aa9d-2653-001ff5486f59"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("767e3324-1d7f-1ef0-8d38-afe537304f95"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("7985b193-a7c6-723a-302e-0aabfd734826"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("7cbdc427-cf08-c2ae-159e-4aef7d666e60"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("7eb1697c-c894-7a9e-8714-d039ea023116"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("823c47f8-eeb5-df57-87d1-da966615efe1"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("82459dac-b10d-2610-b2aa-1eeb3d21fe16"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("8272ff2c-afc2-b90f-d10e-fe091c8b57c2"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("834b1be1-5e52-dcc5-9174-ae7edc37b44c"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v av1_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("8370a0d8-00ee-83df-c442-81e3d4d917d6"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("89370be0-a506-205d-e40b-f4838d7c25fd"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("89e370db-cffc-aa42-1f1b-9797a7798378"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("91f88d27-6dfd-2b25-cb9f-66a05f5982a0"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("9620cb34-f52f-bdf3-e7c0-6b071477d64c"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v av1_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("970ee7fb-afaf-75bb-6897-0359a97b22b9"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("9889785b-8c5b-3414-f300-719e1c963d3c"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v av1_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("9c887f66-62d5-87cb-a711-beeeb2535137"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("a1e60d44-843b-3629-8a0a-5501871ef247"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v av1_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v av1_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 3, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("a38537c2-62ea-be74-d05a-728864486d37"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v av1_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("a43b2807-6e2f-f57d-674c-103c65de2694"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v av1_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("a538ea4e-4761-56bb-52d2-2d2186071c45"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("a7a92bb3-7a39-2f10-446a-36c8e9e592b9"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("a85401ad-715e-9d28-e98c-3b0a0082c692"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("aea68114-5402-ac41-ddd9-a5f30283f6f3"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("af22b5bf-89ab-a060-717e-d2e576bfa26d"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("b14fc2d7-f9a5-43c9-0e73-79bebafa70c3"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v av1_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("b6e02566-f54a-2920-2d04-cc022e629103"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("bf0c4da8-7031-4b70-ee5e-946fbe707d84"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v av1_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("bfaed98c-90d1-5f55-5b27-be45034199c6"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("c1bd918a-110d-6a2b-147a-ffd8d2c9ab96"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("c5e2237f-dc17-09b8-9c4b-137cee69837a"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v av1_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("d129cf56-a15a-7466-fe91-a643b382b45b"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("d4f70ac2-41e6-6e7f-c640-2551395c7a7c"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("d6a774cc-d691-36ee-2552-a87a0cff5154"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("d75a16a5-e709-d8c5-94ff-be50e457f092"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("dc0f0ee0-c3c8-352c-7c8c-d7319de0e9f3"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("dd2baeb0-125d-2267-a59f-29ab169fe757"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("e372f1f0-1a8f-c339-ce2f-f8cbfcd9494f"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v av1_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("e761372c-06d6-9873-9173-719feeb5e156"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("ead90cb9-3d31-b5e6-4f40-e4a13e258de0"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("f046dad9-f9e6-1970-db8e-ed7cc3cdac19"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("f06f902a-bc1e-8342-e52a-90af1c15818c"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("f0d388e7-e83d-e024-d403-1c36e175e773"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("f21e1651-5c1c-042c-b564-685397fe5f4e"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("f3b5aded-ad48-2301-07f4-1cdbec21e634"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("f55acd4b-5791-0031-d8f4-7fe63c449372"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("f6ac7eb9-1f0d-d83c-e65e-23741f10bbf0"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("f77c165c-94e1-fe04-c5c8-cbca664718b7"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") }
                });

            migrationBuilder.InsertData(
                table: "TestCases",
                columns: new[] { "Id", "Bitrate", "FromResolution", "MediaTestFileId", "TestCaseType", "ToCodecId", "ToResolution" },
                values: new object[,]
                {
                    { new Guid("042f4944-e183-f79c-a964-f47d85cf1a87"), 9616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("06b0cfb7-5110-49ab-f868-4c895e2fa46b"), 3616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("0955f6fe-426b-bfc2-cfa6-18c56210a24f"), 79616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("0b9d2f26-cbb0-ea47-59c5-e9a68c40bff2"), 3616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("0bcc1e48-3738-4338-c465-923bde607ed1"), 9616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("0d10a500-4d1b-d5f7-8a42-4c362a7103a4"), 9616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("0e5a3bfe-386e-3b73-697d-aaaf168ee787"), 3616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("104820f8-575a-c82f-4633-676c2ae1ff55"), 79616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("12649d4c-4e3a-b52e-58ee-47dd20788e80"), 3616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("1606c069-1453-c647-2495-48e1abfb57ae"), 3616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("1964fffd-c8df-8b1b-25b0-5c5112840825"), 79616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("1dc553d9-98e2-68e1-e3cc-88fdd3b0bcd3"), 9616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("24096ed4-32f6-fe87-cb5f-4248eae66d44"), 9616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("26e486d1-7bf3-7563-2640-ed9e150c8c20"), 3616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("35127d52-132d-ccc3-c956-37bd7754a0a9"), 9616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("3a9b74ff-4493-fe81-b3fc-3929baf6a2f7"), 9616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("3aa13caf-c009-b359-b893-42b995d47dba"), 9616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("3b4ee84e-97ef-db5e-0f39-f06148d85004"), 9616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("446732b1-3bf4-c4a3-8644-6e449d7632a0"), 3616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("46c0bd6e-0cca-277f-026e-4cc63119949b"), 79616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("4a12cba1-3e16-b897-b46b-42ad637a8691"), 79616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("4a496390-ef51-5a58-748a-c48444548048"), 79616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("4aaa6a51-f785-93b4-92be-eff963871618"), 79616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("539331e2-5d7a-b75b-f2d5-ad5494b4c3c0"), 79616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("5c302bb7-2da2-2ad6-75b9-03d114fb02e7"), 79616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("6296cc91-a047-7fb8-7ac9-ddbe468e1298"), 3616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("63266fa0-29ab-3a5e-2696-313f2f47c38e"), 9616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("687cce10-935d-39fb-954d-05c039555737"), 79616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("6b237233-d15a-2d45-06bd-e7416bf757b3"), 79616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("77cfac1f-731c-63a3-c76c-d585bc4a3a12"), 79616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("7a1a61c8-a5d4-d446-3788-c78147edbbe3"), 9616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("7b31cdb1-e186-b7d5-c991-2fffad1db1d0"), 9616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("86c47dae-dae7-b1c2-c64d-a492c400f393"), 9616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("874b642d-f361-362b-444b-3193b5ac2965"), 79616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("8853cbe5-6bfa-9900-efc2-36da9143f782"), 79616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("888d6062-7ca4-72ea-31b3-a139e01cb7a0"), 3616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("89725e21-823e-994e-bc34-a391d793bf4c"), 3616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("8a4a240b-18e0-325c-e9c9-679cac7261e2"), 3616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("91e03792-1cfb-3b4a-54a4-2fe1d51cca86"), 9616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("926b6d7b-3acf-a133-6472-26c3369a58d6"), 79616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("95937555-09b8-5fc1-d394-5093dda01c71"), 79616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("9ad67fcd-071b-82f8-4250-f3e2c3b1226d"), 9616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("9f79cbeb-592e-5461-bd6e-b04058fcf160"), 3616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("a27638b7-f478-51f7-6233-ed046616b2d2"), 79616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("a493d24a-b58c-2bf4-77a4-c8269646ca75"), 9616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("a4e6e8c6-489e-37d0-6f3a-2ea5e3ed427f"), 9616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("a64eb052-3bf2-8b24-90c6-a4d61bb4fe2f"), 3616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("a7a6677d-2be1-324b-36f3-6400eb9b5677"), 3616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("ab0f04fa-c4b2-7c3f-908b-1cb2e60006ac"), 9616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("abfe0bac-8fcc-83d6-1647-b6bd9f33a53f"), 9616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("ac6193e0-bd5b-8021-38ee-662a5497dffb"), 3616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("b66a6747-8314-53a2-420f-52d6f9a7bac7"), 79616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("bc86271d-df45-443b-a5d5-4185d5764949"), 9616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("bccac77a-d107-1c5b-ba1f-c91010fa6ae6"), 3616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("bdc5a853-77cd-8d1a-28e1-60e6583b42c1"), 3616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("bf053775-7882-2224-2694-0d7fdabc2424"), 9616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("bf561e14-475d-7365-b922-c6eb4ce28210"), 3616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("c3e8f217-da95-c621-44a1-366ea9508bd2"), 3616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("d4efb984-605d-3711-7c69-a3c497b66cda"), 3616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("d6debecf-5209-5d7a-cd84-1a9bd492ed72"), 79616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("de109e51-6dd3-fefb-86cc-a97434c6f1f2"), 3616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("e5ec04b4-1e46-8ab2-65b9-070e3a17cf56"), 9616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("e668e036-e096-eacd-d3ed-3402198d4656"), 3616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("e71f54c8-b291-d82c-82d6-a06eeead7e9e"), 79616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("e9b79cf0-a64b-cf09-b27a-8fc58f896551"), 3616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("ec32a7e8-e712-bb18-8513-756c6b281330"), 9616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("ee92b18b-71ce-b644-7950-b13126ab5126"), 79616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("f61ead2a-ea25-dcba-e440-8e6494f43eeb"), 79616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("f65d5c3e-3b99-75c6-c155-5679874afaf0"), 3616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("f740bd29-812c-6d1b-e6d3-9f596797188d"), 9616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("fd02944a-0db5-7d91-b77d-6565e6477d7f"), 79616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("ff0e5d38-2f1a-85f0-f8d1-37f4a036bf1b"), 79616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("157f0cf6-672d-88f4-b4ee-c0e23f415036"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("16c162cd-a80a-60fd-5200-8a3a4bcfbe25"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("16d68e5f-c1ba-d7ce-077f-7239057323b6"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("19b7573e-a49e-6685-25bd-36c564696281"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("1c323048-e83f-8ff9-a454-070417d0fcd0"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("1c5cf92f-4ee8-4b17-eff6-08762e558a9f"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("1f75776a-1873-d367-b209-561300ac0248"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("2664d9bb-c8aa-9cbb-74bc-ed264c7734cd"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("28b9fea3-d73a-c8db-3977-d314645c2113"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("2ca2dd6d-10fe-3497-a3b7-cc53f668d8f1"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("2edfd8ce-2dda-f2ba-73e5-d78a6c39241c"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("308d9541-b7c1-3a9d-23f0-eedddce20a86"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("31d5143e-2551-3f80-7e55-13e66a29f36d"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("347ddf68-b6e2-44c2-1406-4b2179433d7e"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("355b09c1-1ef5-762c-3027-ed7dfd31b9aa"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("373f41d1-0bbc-1636-7978-3a7aac04e6e9"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("38c1ca7e-4c2a-b3c5-45a0-6c68dbe49cec"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("42d24fa0-f4b5-92c8-1496-b5c10ace5470"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("42e2178d-7d9f-43bc-c24b-3bb90b174bb9"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("43a27d46-db94-acae-fe65-8234d1947315"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("43ab37bc-59ef-23cd-a449-9fd6d7fa4f39"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("462c8dbb-c521-54dd-ccca-5ff20380d0ee"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("4970baca-731e-7d9f-175e-2629f17aab49"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("5453f03f-c7e7-ffd2-5596-e5fad4fa3c1a"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("55829d95-e48d-4c31-c1d9-fd6cd57332fb"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("64982695-84e0-c90a-274c-2e2dfcb2ac01"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("66c8bd4e-71b7-0330-b175-62343fd78194"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("6719a959-0026-241b-8420-ac9de06932d2"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("67387ef3-df9a-6657-a2e6-7bfc6cdd2ab5"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("69675e15-ed30-e683-3624-fcb73f5921d3"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("70412efd-b134-73b7-8953-54927bac64fe"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("713ae734-130e-ce12-0292-c29187f8c942"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("7258ce0d-5db4-5563-27bc-b3610509ace2"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("74112a4e-dd4d-aa9d-2653-001ff5486f59"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("767e3324-1d7f-1ef0-8d38-afe537304f95"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("7985b193-a7c6-723a-302e-0aabfd734826"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("7cbdc427-cf08-c2ae-159e-4aef7d666e60"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("7eb1697c-c894-7a9e-8714-d039ea023116"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("823c47f8-eeb5-df57-87d1-da966615efe1"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("82459dac-b10d-2610-b2aa-1eeb3d21fe16"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("8272ff2c-afc2-b90f-d10e-fe091c8b57c2"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("834b1be1-5e52-dcc5-9174-ae7edc37b44c"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("8370a0d8-00ee-83df-c442-81e3d4d917d6"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("89370be0-a506-205d-e40b-f4838d7c25fd"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("89e370db-cffc-aa42-1f1b-9797a7798378"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("91f88d27-6dfd-2b25-cb9f-66a05f5982a0"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("9620cb34-f52f-bdf3-e7c0-6b071477d64c"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("970ee7fb-afaf-75bb-6897-0359a97b22b9"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("9889785b-8c5b-3414-f300-719e1c963d3c"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("9c887f66-62d5-87cb-a711-beeeb2535137"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("a1e60d44-843b-3629-8a0a-5501871ef247"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("a38537c2-62ea-be74-d05a-728864486d37"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("a43b2807-6e2f-f57d-674c-103c65de2694"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("a538ea4e-4761-56bb-52d2-2d2186071c45"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("a7a92bb3-7a39-2f10-446a-36c8e9e592b9"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("a85401ad-715e-9d28-e98c-3b0a0082c692"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("aea68114-5402-ac41-ddd9-a5f30283f6f3"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("af22b5bf-89ab-a060-717e-d2e576bfa26d"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("b14fc2d7-f9a5-43c9-0e73-79bebafa70c3"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("b6e02566-f54a-2920-2d04-cc022e629103"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("bf0c4da8-7031-4b70-ee5e-946fbe707d84"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("bfaed98c-90d1-5f55-5b27-be45034199c6"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("c1bd918a-110d-6a2b-147a-ffd8d2c9ab96"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("c5e2237f-dc17-09b8-9c4b-137cee69837a"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("d129cf56-a15a-7466-fe91-a643b382b45b"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("d4f70ac2-41e6-6e7f-c640-2551395c7a7c"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("d6a774cc-d691-36ee-2552-a87a0cff5154"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("d75a16a5-e709-d8c5-94ff-be50e457f092"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("dc0f0ee0-c3c8-352c-7c8c-d7319de0e9f3"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("dd2baeb0-125d-2267-a59f-29ab169fe757"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("e372f1f0-1a8f-c339-ce2f-f8cbfcd9494f"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("e761372c-06d6-9873-9173-719feeb5e156"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("ead90cb9-3d31-b5e6-4f40-e4a13e258de0"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("f046dad9-f9e6-1970-db8e-ed7cc3cdac19"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("f06f902a-bc1e-8342-e52a-90af1c15818c"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("f0d388e7-e83d-e024-d403-1c36e175e773"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("f21e1651-5c1c-042c-b564-685397fe5f4e"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("f3b5aded-ad48-2301-07f4-1cdbec21e634"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("f55acd4b-5791-0031-d8f4-7fe63c449372"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("f6ac7eb9-1f0d-d83c-e65e-23741f10bbf0"));

            migrationBuilder.DeleteData(
                table: "TestCaseArguments",
                keyColumn: "Id",
                keyValue: new Guid("f77c165c-94e1-fe04-c5c8-cbca664718b7"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("042f4944-e183-f79c-a964-f47d85cf1a87"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("06b0cfb7-5110-49ab-f868-4c895e2fa46b"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0955f6fe-426b-bfc2-cfa6-18c56210a24f"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0b9d2f26-cbb0-ea47-59c5-e9a68c40bff2"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0bcc1e48-3738-4338-c465-923bde607ed1"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0d10a500-4d1b-d5f7-8a42-4c362a7103a4"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("0e5a3bfe-386e-3b73-697d-aaaf168ee787"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("104820f8-575a-c82f-4633-676c2ae1ff55"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("12649d4c-4e3a-b52e-58ee-47dd20788e80"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("1606c069-1453-c647-2495-48e1abfb57ae"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("1964fffd-c8df-8b1b-25b0-5c5112840825"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("1dc553d9-98e2-68e1-e3cc-88fdd3b0bcd3"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("24096ed4-32f6-fe87-cb5f-4248eae66d44"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("26e486d1-7bf3-7563-2640-ed9e150c8c20"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("35127d52-132d-ccc3-c956-37bd7754a0a9"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("3a9b74ff-4493-fe81-b3fc-3929baf6a2f7"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("3aa13caf-c009-b359-b893-42b995d47dba"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("3b4ee84e-97ef-db5e-0f39-f06148d85004"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("446732b1-3bf4-c4a3-8644-6e449d7632a0"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("46c0bd6e-0cca-277f-026e-4cc63119949b"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("4a12cba1-3e16-b897-b46b-42ad637a8691"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("4a496390-ef51-5a58-748a-c48444548048"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("4aaa6a51-f785-93b4-92be-eff963871618"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("539331e2-5d7a-b75b-f2d5-ad5494b4c3c0"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("5c302bb7-2da2-2ad6-75b9-03d114fb02e7"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("6296cc91-a047-7fb8-7ac9-ddbe468e1298"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("63266fa0-29ab-3a5e-2696-313f2f47c38e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("687cce10-935d-39fb-954d-05c039555737"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("6b237233-d15a-2d45-06bd-e7416bf757b3"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("77cfac1f-731c-63a3-c76c-d585bc4a3a12"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("7a1a61c8-a5d4-d446-3788-c78147edbbe3"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("7b31cdb1-e186-b7d5-c991-2fffad1db1d0"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("86c47dae-dae7-b1c2-c64d-a492c400f393"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("874b642d-f361-362b-444b-3193b5ac2965"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("8853cbe5-6bfa-9900-efc2-36da9143f782"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("888d6062-7ca4-72ea-31b3-a139e01cb7a0"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("89725e21-823e-994e-bc34-a391d793bf4c"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("8a4a240b-18e0-325c-e9c9-679cac7261e2"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("91e03792-1cfb-3b4a-54a4-2fe1d51cca86"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("926b6d7b-3acf-a133-6472-26c3369a58d6"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("95937555-09b8-5fc1-d394-5093dda01c71"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("9ad67fcd-071b-82f8-4250-f3e2c3b1226d"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("9f79cbeb-592e-5461-bd6e-b04058fcf160"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a27638b7-f478-51f7-6233-ed046616b2d2"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a493d24a-b58c-2bf4-77a4-c8269646ca75"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a4e6e8c6-489e-37d0-6f3a-2ea5e3ed427f"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a64eb052-3bf2-8b24-90c6-a4d61bb4fe2f"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("a7a6677d-2be1-324b-36f3-6400eb9b5677"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ab0f04fa-c4b2-7c3f-908b-1cb2e60006ac"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("abfe0bac-8fcc-83d6-1647-b6bd9f33a53f"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ac6193e0-bd5b-8021-38ee-662a5497dffb"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("b66a6747-8314-53a2-420f-52d6f9a7bac7"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("bc86271d-df45-443b-a5d5-4185d5764949"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("bccac77a-d107-1c5b-ba1f-c91010fa6ae6"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("bdc5a853-77cd-8d1a-28e1-60e6583b42c1"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("bf053775-7882-2224-2694-0d7fdabc2424"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("bf561e14-475d-7365-b922-c6eb4ce28210"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("c3e8f217-da95-c621-44a1-366ea9508bd2"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("d4efb984-605d-3711-7c69-a3c497b66cda"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("d6debecf-5209-5d7a-cd84-1a9bd492ed72"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("de109e51-6dd3-fefb-86cc-a97434c6f1f2"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("e5ec04b4-1e46-8ab2-65b9-070e3a17cf56"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("e668e036-e096-eacd-d3ed-3402198d4656"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("e71f54c8-b291-d82c-82d6-a06eeead7e9e"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("e9b79cf0-a64b-cf09-b27a-8fc58f896551"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ec32a7e8-e712-bb18-8513-756c6b281330"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ee92b18b-71ce-b644-7950-b13126ab5126"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f61ead2a-ea25-dcba-e440-8e6494f43eeb"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f65d5c3e-3b99-75c6-c155-5679874afaf0"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("f740bd29-812c-6d1b-e6d3-9f596797188d"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("fd02944a-0db5-7d91-b77d-6565e6477d7f"));

            migrationBuilder.DeleteData(
                table: "TestCases",
                keyColumn: "Id",
                keyValue: new Guid("ff0e5d38-2f1a-85f0-f8d1-37f4a036bf1b"));

            migrationBuilder.UpdateData(
                table: "FfmpegVersions",
                keyColumn: "Id",
                keyValue: new Guid("2c720157-f8fb-48c9-8686-d4dfe7daae9a"),
                columns: new[] { "HashMd5", "HashSha256", "Source" },
                values: new object[] { "61493050969F95E4D069BA01833834ED", "FA960A6A36CFF9FB9DF215DED55B57A1AC3285147849EF6BE1D8EA63552FFC17", "https://repo.jellyfin.org/files/ffmpeg/linux/6.x/6.0.1-7/amd64/jellyfin-ffmpeg_6.0.1-7_portable_linux64-gpl.tar.xz" });

            migrationBuilder.UpdateData(
                table: "FfmpegVersions",
                keyColumn: "Id",
                keyValue: new Guid("501d7e27-8410-40af-b48d-1e7ce0002173"),
                columns: new[] { "HashMd5", "HashSha256", "Source" },
                values: new object[] { "61493050969F95E4D069BA01833834ED", "FA960A6A36CFF9FB9DF215DED55B57A1AC3285147849EF6BE1D8EA63552FFC17", "https://repo.jellyfin.org/files/ffmpeg/linux/6.x/6.0.1-7/amd64/jellyfin-ffmpeg_6.0.1-7_portable_linux64-gpl.tar.xz" });

            migrationBuilder.InsertData(
                table: "TestCaseArguments",
                columns: new[] { "Id", "FfmpegArgument", "FfmpegVersionGroupId", "FfmpegVersionId", "FromHardwareCodecId", "TestCaseArgumentDeviceType", "ToHardwareCodecId" },
                values: new object[,]
                {
                    { new Guid("01ac7c84-29a3-b38e-bd86-2e6bdc472c96"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("048e1c9b-06be-3bb4-99ec-a3892f04f372"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("0528bcfd-878f-9897-ab7c-4ed86145d6df"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("059f7916-ccf3-7415-e82f-055f5818904e"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("08fcaa98-bbb1-0437-ab28-8c5828f6a306"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("0a81ef18-ab36-7db7-de47-06a167173e49"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("0b1d6b3e-1828-1649-e2a7-698a3a8989db"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("0d84c99c-6f1d-39c3-4563-03c5833fdbcb"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v av1_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("117b1e4d-f0df-df5c-46bd-755647329bd1"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("147513cb-3444-c905-dbfb-7708a1d25cdb"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("152c7de8-6775-f127-9395-71f1b89e3c2e"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v av1_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("1957761c-44e3-bc89-4dbe-5bccbf572947"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("1ebb20b5-1884-b8b3-8374-57f1512d6e03"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("2632ffa5-8eb1-27f5-04c5-3edb42933f5a"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("29fa0bf5-3b03-8f38-0f85-9cafa3c82526"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("2ac84667-d996-0c55-8156-e6db69468f2c"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v av1_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("2bbbae34-f4eb-ce72-2387-b45b619d7c5f"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("2c49acbb-779a-4a87-6318-e6b91df1cc39"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("2d22e767-c2c2-d8ad-3162-9e366865581d"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v av1_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("2eb5c3f1-f8f8-96eb-b677-e4ab58bc11da"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("328d78e7-018e-6dc5-a7fd-80a946847e5e"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("35a1012d-cec2-2653-c2d3-b862bc2a6122"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v av1_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("410a1371-3337-b57c-2e29-4f615c653dee"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("44a550b2-565f-3cf7-4d69-61bff007d983"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("49535f0e-eca0-6c7e-e2c7-c6a9c78883b1"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v av1_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("4b16cc4b-3e49-671a-8758-a9f77b9a46cc"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("4c5124ff-f035-c216-0aa3-5dd0a86ed733"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("4eb28789-e528-744d-7b6c-66978ed1e2b5"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("4ec23a32-c6e9-7bc9-a692-dc9ae48e35a6"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("4fbf8e3f-19fc-a093-5f1a-1ef407b09254"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v av1_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("500cd13c-60ba-1e87-26dd-0ca372601c78"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("55ae773f-a60d-9568-30f3-3dd4b707c75d"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v av1_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("55d32bc1-9829-9f39-d0e7-1f5dc89e9684"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("58c85eb1-ef52-d094-e1f5-8431257f9c38"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("62f506b2-1f52-2461-371b-37a92b8f9b43"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v av1_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("6e4d7781-d02b-3a2d-c9c2-774ae018c7cd"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("74af004c-962d-f0c4-25fe-f6f0a20c5472"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v av1_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("7579c36b-3b44-5c90-b383-85956f868e88"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v av1_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("78932cf9-d4b1-2cd8-2968-b6bf33f8672b"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("797d392d-6f63-58c9-b3cd-b28380fe235c"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("7b85bed3-059a-cdba-64e3-83fcdbafd02f"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v av1_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v av1_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 3, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("7c64e69a-68b0-db74-78f7-0c59869bcb62"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("8135bb9e-e8cd-f0e1-4d14-307fc961afd0"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("81c9d73e-f2e7-93b0-8c6d-299ea68abb30"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("876d0a12-3a6c-a4af-2894-2b7f115fd513"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("88e6a760-1efd-25e5-8c4f-7b5597682175"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("89ce6dae-dbee-9a51-f471-9e8ee61b9336"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("8ef438c9-1b3a-6d36-6095-733fcc4f7453"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v hevc_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("996395b0-7f8a-524f-8832-7596e2642e82"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("a3c4566f-5518-4e6d-75af-6cc05d8b8741"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v av1_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("a62ea616-631d-3e36-2877-8106eacaa787"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v av1_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v av1_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 3, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("a6aff48f-13ee-1325-10dc-d75c8ec537a2"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("a73c3f16-f341-9fb4-f4a9-847e7ff546df"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("ab85f6ef-874e-db84-7756-281826e48d00"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v av1_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("ac3a3425-ed5a-07f4-3737-41714870545b"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("ace74565-5b31-0f01-638e-956eefc942cf"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("ad72eb8f-3d5c-6a6f-831c-495e6f5c81f7"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v av1_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("adb83bf7-bfbe-e26d-8555-983e7fe3d5d4"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("b21cae2a-5fdb-9768-5f6d-7d5ed36677d5"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("b6fafd2e-ef9d-b04e-d5fc-2c10861bd7ad"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("bbcd5f5d-aa05-19b8-a90f-71c47dd7f4ee"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("c5eafda1-1a71-fc61-c0fe-9ea5dd4ba84b"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("c709cc8d-9ef3-c5c0-8442-23a4c6fb44c7"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("c8231720-c899-8a6c-6c52-cc59019600e8"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v hevc_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("c9015dc9-f1da-9094-a6fe-c3b20f3e7861"), "-init_hw_device d3d11va:{gpu} -hwaccel d3d11va -hwaccel_output_format d3d11 -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=-1:{scale}:format=nv12\" -c:v h264_amf -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("cc23a711-6feb-9eee-aa71-c88128f5e63c"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v av1_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v av1_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 1, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("cc87feca-3c43-f1b4-efbb-62b4a2fdb31d"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("cdbf0b96-12c9-d7d3-1aa6-b54a1c1ad842"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx265 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3504c0a3-19b6-418d-995e-c8731c9789a5"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("cec9ddd1-74a6-fcc2-8def-a71efafee121"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v h264_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v hevc_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 1, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("d068ce06-8625-9403-37cd-da31c30d5a1c"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("d24d3828-ae39-3a6b-265b-6d76f9dcab25"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("d7aa10e0-a3d2-08c7-15e6-abf22af85f0c"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("d7e88415-b586-0370-044d-986a3fa01615"), "-init_hw_device cuda=cu:{gpu} -hwaccel cuda -hwaccel_output_format cuda -c:v hevc_cuvid -i {video_file} -noautoscale -an -sn -vf \"scale_cuda=-1:{scale}:yuv420p\" -c:v h264_nvenc -preset p1 -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 1, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("daa033ef-ad70-60d6-37b5-4d150a5e67e9"), "-c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v libx264 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("e5985e2a-f2da-48e4-98fc-9249f7350c4a"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("ec1f41c5-ca64-7a41-2ade-19474dcfdf4b"), "-init_hw_device d3d11va:{gpu} -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \\\"scale_qsv=-1:{scale}:format=nv12\\\" -c:v h264_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("eea1a41c-d44f-f65b-ae8e-f837aedc0fda"), "-c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("eefb71f2-e757-d5e9-dfa6-3303dc18e4dd"), "-c:v h264 -i {video_file} -noautoscale -an -sn -vf \"scale=trunc(min(max(iw\\,ih*a)\\,{scale})/2)*2:trunc(ow/a/2)*2,format=yuv420p\" -c:v svt-av1 -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("3b20be6a-7c32-41a0-a6ca-259937e69512"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 0, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8") },
                    { new Guid("ef78a4dc-a924-03ec-1422-7d6dcbeb22d8"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v hevc -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v h264_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), 2, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c") },
                    { new Guid("fe0cd927-b3ea-d2c8-9b1e-636bbafc5e90"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -init_hw_device qsv=qs@va -hwaccel qsv -hwaccel_output_format qsv -c:v h264_qsv -i {video_file} -noautoscale -an -sn -vf \"scale_qsv=-1:{scale}:format=nv12\" -c:v hevc_qsv -preset veryfast -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), 3, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") },
                    { new Guid("fe2a0c26-be43-f489-7765-ed0697f72508"), "-init_hw_device vaapi=va:/dev/dri/by-path/{gpu}-render -hwaccel vaapi -hwaccel_output_format vaapi -c:v dav1d -i {video_file} -noautoscale -an -sn -vf \"scale_vaapi=-1:{scale}:format=nv12\" -c:v hevc_vaapi -b:v {bitrate} -maxrate {bitrate} -f null - -benchmark", new Guid("9f9565f1-4661-484b-8c80-433bc909e70f"), null, new Guid("dae90106-7f5a-4de0-9628-0b9071c4eff8"), 2, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4") }
                });

            migrationBuilder.InsertData(
                table: "TestCases",
                columns: new[] { "Id", "Bitrate", "FromResolution", "MediaTestFileId", "TestCaseType", "ToCodecId", "ToResolution" },
                values: new object[,]
                {
                    { new Guid("0244052a-452d-2db7-3f98-05494002f657"), 9616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("03266b05-8822-7a0e-dc33-212206873afa"), 9616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("046f3625-981d-0dc8-9a7f-c6ddccd9ce67"), 9616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("09737fe6-4e65-4bb7-e7d8-85c2bba6360a"), 79616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("0a4ec8b0-691d-e1cb-3204-b33f86db05bf"), 3616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("0bfdb4e0-4be3-4a08-5a67-585024741c31"), 9616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("0e574e7d-0fa5-ebd6-8fef-c9306e06117c"), 79616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("0ea35dd1-8ed1-dfd3-b63d-06a34558389e"), 3616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("10057971-c127-797a-acf5-7eae599d4880"), 79616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("1bc8138f-b929-22ab-4695-e61371f8f1a2"), 9616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("1c9281c2-0b47-71f7-dee1-3e7e85270f78"), 79616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("217e1616-fc3c-fb9f-c56d-e648810e507e"), 79616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("220896f2-9209-4cf8-39ff-5f30bac0ccf0"), 9616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("25f24cb1-4c54-b83c-9328-000a34ccde3f"), 3616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("2e66d24d-b954-af35-632c-72ca6cb4694a"), 9616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("339b2f3d-2946-a6e7-1fd9-5260bd73ed93"), 9616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("3d2bc7d5-035b-548a-8e7e-37115b4d7893"), 9616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("44473c61-4a67-913b-7dbb-86e27045f593"), 79616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("46cbbc03-0bce-2d90-1f42-e72081139a36"), 79616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("4a0053c9-7f66-afca-ab47-bff02c50029c"), 3616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("5839fcf7-54b8-a7bd-c986-6e76e948f3b6"), 3616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("59cccb69-1fdd-cf72-b2da-90cc2e7e3cc2"), 79616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("5da70774-8acd-41a7-4306-6c73c42f1ebf"), 79616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("604d9292-115c-cb42-179f-aa075384f9cd"), 79616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("63f10678-51c6-3ce9-810e-ee48b9da239d"), 79616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("65a3acda-4e4f-016c-2b29-ff5a6f101bc5"), 9616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("69fb6787-3ab5-bd97-204a-6c120fca2a52"), 3616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("6aa220a3-db85-0a0d-9e9a-40509950b816"), 9616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("6b8f3d02-4aba-f0e7-8401-df8ba1ffb174"), 9616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("6d78c8f0-eb77-2cc4-90a1-dc6e83673278"), 9616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("71d6d86c-b7a1-855c-cef4-7fa778d4add1"), 9616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("74078ac5-3c16-41ad-53b4-28fe9dc23f0b"), 9616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("77f1fd29-4639-8ce2-e75c-061e3ed28090"), 3616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("78f0d186-1329-225d-f9ec-10731cf8b8ba"), 3616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("7b86cf07-dbae-f0e2-91a9-1d12cb235de7"), 3616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("7e989914-87be-2f91-7bf3-649262a7b5c1"), 3616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("84f92737-ebc0-58c9-f880-c9c02cdec9ac"), 9616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("8905cc28-1b80-1d6e-dad0-7dd40231abd1"), 3616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("8a893353-5875-d1c9-33ac-157994b2e0eb"), 79616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("8b2e7b88-8b24-e79a-7ba9-340608539156"), 9616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("927bdcde-2f8a-53c9-697f-f1062dad7c9e"), 9616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("96a4ca8d-6d7c-35e0-d6f9-0a03b076eb58"), 3616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("97b69e5a-f54e-0635-141e-f4d2e5b39e2e"), 3616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("9ad98f0a-7cca-9a57-41d2-cb285a29994c"), 3616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("9f28afa9-180d-eca5-ef32-228f43593f8a"), 9616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("a366922d-506a-65c9-1d7f-35fb42fc8a06"), 3616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("a3820862-6d23-4b95-def6-3d1c88471e8f"), 79616000L, "1080p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("a4a6d5a4-012e-2903-82df-ffadc9fcd24c"), 9616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("ab5d5c29-5b42-9c73-a5d3-a2d9267b764c"), 3616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("ad1a9ba3-dc39-7338-2424-0aeefdc9fe44"), 3616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("ade9cbab-a0d1-9a95-a7ff-97870d58d389"), 3616000L, "720p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("adf2b8f1-c394-2426-3928-bd290cc4e555"), 79616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("b24efd0f-ea5a-ba45-6490-4c270b267ff0"), 9616000L, "2160p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("bcc05687-8cb7-73d1-37d6-e3faccb1415b"), 3616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("bf567cd5-e77c-7290-98ed-142d21fd13f5"), 3616000L, "2160p", new Guid("e1e58b15-6664-454c-868a-20442db30557"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("c0bcc210-7789-a0ef-3173-273d4842eaa1"), 9616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "1080p" },
                    { new Guid("c895c596-0af0-6ed6-3048-b2d501762b0e"), 79616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("cefc56ab-b08d-f140-9d13-3f0a168a45fb"), 3616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "720p" },
                    { new Guid("d45e83c8-2ad1-a5b9-7f2f-5f337f80f976"), 79616000L, "720p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("d4d73265-c11f-3e59-13f8-e71a944aa822"), 9616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" },
                    { new Guid("d57126cc-7539-b770-b84f-b18f6a76d478"), 79616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("d88ac6d4-d5f0-beb6-7752-ed0857183cf7"), 79616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("d8add6bd-fb22-fe10-379a-c7c031c74ed4"), 3616000L, "2160p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("dbe95fff-2e87-3e7e-40b0-82e3cf924a25"), 79616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("e196dab2-ec63-0a7a-f912-57b6ac3b93d2"), 79616000L, "1080p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("ee4e2299-a178-1b30-7b53-69e7e0cfa43d"), 79616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("bf2065dc-9b03-48b8-9a30-206a12a6319c"), "2160p" },
                    { new Guid("f78c933e-3d98-9904-79ab-f86fdca91d35"), 79616000L, "720p", new Guid("e8a75e65-a3f3-4d92-a45b-84e71a13efab"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("f7c19e20-62a6-b5b3-7272-2bc22b0b0359"), 3616000L, "2160p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("f87f6d28-885d-3966-f182-8373b731cd48"), 79616000L, "1080p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("f8fe5422-d111-8ecb-522d-9f26239c765d"), 3616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "720p" },
                    { new Guid("fa336f5c-1d5f-61f3-c1a0-87533509c639"), 79616000L, "1080p", new Guid("1d943d13-586d-4562-a968-eb1d0ffae947"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "2160p" },
                    { new Guid("fffd7354-ba30-0b2f-9a5a-1f5ba75bd30f"), 9616000L, "720p", new Guid("70daebe7-c9fc-4e02-a524-2fc825a49355"), 0, new Guid("104537db-e1e2-4490-a82a-afaede9a8fd4"), "1080p" }
                });
        }
    }
}
