using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class profilePicsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "304121dd-cfa2-4e74-bac9-adc5c83f03a6", "e98f5c49-32c4-4943-876b-5d360fd9a1e5" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "5adb6826-1452-454f-af12-c030eb18c978", "01dec976-5a96-44cc-98d6-0fb96c0d4172" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "5adb6826-1452-454f-af12-c030eb18c978", "0823c8ce-8c46-49ad-930f-434637f66987" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "5adb6826-1452-454f-af12-c030eb18c978", "16a383aa-bbe2-4b3a-8f2d-422882e285ee" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "5adb6826-1452-454f-af12-c030eb18c978", "2185956f-cd1b-4891-9f3b-82a818be8962" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "5adb6826-1452-454f-af12-c030eb18c978", "21944a9f-3faf-4c13-841e-ef963886ac38" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "5adb6826-1452-454f-af12-c030eb18c978", "55b94c05-65cb-42c2-b67c-5876a6b6ed48" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "5adb6826-1452-454f-af12-c030eb18c978", "69de43c6-876c-4c70-bedf-f0efcc978efa" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "5adb6826-1452-454f-af12-c030eb18c978", "868f5429-36af-4d4c-a0f3-321283864b34" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "5adb6826-1452-454f-af12-c030eb18c978", "9e004990-ec0f-4117-8bda-7343b5a5896d" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "5adb6826-1452-454f-af12-c030eb18c978", "a0df6545-7c52-45b1-a439-4b4ea8428aee" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "5adb6826-1452-454f-af12-c030eb18c978", "b0a6131b-febd-4b19-b9f0-ae80fbb1c176" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "5adb6826-1452-454f-af12-c030eb18c978", "e138d221-050f-40bc-b8d8-8a7f5961eb86" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "5adb6826-1452-454f-af12-c030eb18c978", "eaebfb1e-dc1c-4c30-9acf-a2124790b422" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "01dec976-5a96-44cc-98d6-0fb96c0d4172" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "0823c8ce-8c46-49ad-930f-434637f66987" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "16a383aa-bbe2-4b3a-8f2d-422882e285ee" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "2185956f-cd1b-4891-9f3b-82a818be8962" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "21944a9f-3faf-4c13-841e-ef963886ac38" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "55b94c05-65cb-42c2-b67c-5876a6b6ed48" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "868f5429-36af-4d4c-a0f3-321283864b34" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "9e004990-ec0f-4117-8bda-7343b5a5896d" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "a0df6545-7c52-45b1-a439-4b4ea8428aee" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "b0a6131b-febd-4b19-b9f0-ae80fbb1c176" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "e0f4d900-50b8-4952-882a-ada94466a96f" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "e138d221-050f-40bc-b8d8-8a7f5961eb86" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "e98f5c49-32c4-4943-876b-5d360fd9a1e5" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "eaebfb1e-dc1c-4c30-9acf-a2124790b422" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "a12d49f1-58d3-46ed-9995-a5aa2f31b5eb", "69de43c6-876c-4c70-bedf-f0efcc978efa" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "e4fe0b0d-56cb-428b-bc88-155e92664a31", "211612d4-b5da-48e2-aa18-60e36a829fda" });

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "304121dd-cfa2-4e74-bac9-adc5c83f03a6");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "5adb6826-1452-454f-af12-c030eb18c978");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "7e4b4524-0514-4c80-bb6e-3c07c03bbf76");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "a12d49f1-58d3-46ed-9995-a5aa2f31b5eb");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "e4fe0b0d-56cb-428b-bc88-155e92664a31");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "01dec976-5a96-44cc-98d6-0fb96c0d4172");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "0823c8ce-8c46-49ad-930f-434637f66987");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "16a383aa-bbe2-4b3a-8f2d-422882e285ee");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "211612d4-b5da-48e2-aa18-60e36a829fda");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "2185956f-cd1b-4891-9f3b-82a818be8962");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "21944a9f-3faf-4c13-841e-ef963886ac38");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "55b94c05-65cb-42c2-b67c-5876a6b6ed48");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "69de43c6-876c-4c70-bedf-f0efcc978efa");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "868f5429-36af-4d4c-a0f3-321283864b34");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "9e004990-ec0f-4117-8bda-7343b5a5896d");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "a0df6545-7c52-45b1-a439-4b4ea8428aee");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "b0a6131b-febd-4b19-b9f0-ae80fbb1c176");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "e0f4d900-50b8-4952-882a-ada94466a96f");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "e138d221-050f-40bc-b8d8-8a7f5961eb86");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "e98f5c49-32c4-4943-876b-5d360fd9a1e5");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "eaebfb1e-dc1c-4c30-9acf-a2124790b422");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "0cd5cf91-7699-45ac-bf7f-808f24abb076");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "17409b22-0079-4b29-b79b-d5e99718e249");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "1c7577da-ae0d-47c5-9709-e40b479b6561");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "1e97c905-b865-4592-932a-4d5b3c627ed3");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "32896a09-b2eb-45a4-9c3e-ef4ed45a424b");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "483ce399-4688-41e2-8a09-075a638769c7");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "8227072d-d879-4755-aea1-5a9f5dd8881a");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "9c15ca9a-40ff-4e59-aae3-09f947f74f7f");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "9f2b9022-54f8-4baf-ba42-877a73a73961");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "a184871f-858c-4c9a-b8cf-99c314373c21");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "cdace994-a952-4190-a520-c77b77be7bca");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "d638c3e6-a394-4f9b-aa74-5c3e1af30c03");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "db762ffd-8186-44ce-99b7-61ce6c41759c");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "e1bc65d8-2d67-41c5-ab87-f15efa687d29");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "e1d72bbc-b61f-41f6-af18-d719682fa428");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "050c7a4c-5c24-42c4-b13d-387799596d6f");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "13e94b58-46d9-4dd2-b3ab-5e69cd0d66b8");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "95e20169-19ab-4ecd-ad0e-25d80028852c");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "97d0e58e-e9a1-46d2-93a0-39a2f4517e7c");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "98c18ea1-1470-489b-90a9-0c3a7104ad19");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "9edece38-8e1d-4a05-a4a3-8ced7f913100");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "9f78fe69-e03b-40e2-b8bd-24428bff14e3");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "a3a39902-91ba-4f18-b1ad-174a0abeb819");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "aabbbcbd-81c4-400b-94ce-22c28c5010a9");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "db88345d-d07e-4701-bd80-dee0f0ab2da9");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "f7a377de-06df-4328-8660-540de961010c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d808c08-d40a-4a5c-9449-f4454494f5f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59649289-fbad-4895-a46a-dbc05fdde565");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5da5079f-9ab9-47bf-ba32-7cb60c085fbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "614b3f26-c84f-4ba5-8209-e1fe2a3d2c95");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6547fbbb-8c5b-4ced-9c94-55783a785887");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6aa10996-a41b-4ae2-84e4-cb682c353aaa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9836aa61-f61f-4f53-9d81-fd11398a962f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5dd5c01-8bc0-441c-ab5c-9ce175430558");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ccf573c7-5090-4a70-b509-b15f4b50e2df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d15f062a-b4a6-4e76-9767-d67c3313d5d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b1e578-72a6-4942-b459-bec8e9a0189e");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicId",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicId", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d37d9abf-6baa-41d7-80a5-8da1b6762503", 0, "42ffb7a6-d9e5-4675-b465-28b77328e33c", null, false, false, null, "John Doe", null, null, null, null, false, "default_pfp", 0, "027d0780-df4f-43eb-9d38-55f4f497e90a", false, "defaultUser" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "1d3e2467-a861-4f4e-abf6-9ababd4dd951", "New Age" },
                    { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "Classic" },
                    { "814e198b-4d1b-4c0f-9396-da55fa052c02", "Instrumental" },
                    { "a63b0ecb-2407-4fd8-8ccc-235529819aa0", "Jazz" },
                    { "b88ca48c-2135-4e58-8b7c-b2e83b290f3d", "Pop" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[,]
                {
                    { "0067ae0e-06a5-4036-b13f-a07682bf3a04", "John Doe", "d37d9abf-6baa-41d7-80a5-8da1b6762503" },
                    { "191a45d2-5f4a-4b2b-9816-1b14a506072e", "John Doe", "d37d9abf-6baa-41d7-80a5-8da1b6762503" },
                    { "1c8ee002-63c6-4dfe-8c58-c92df3e5d67e", "John Doe", "d37d9abf-6baa-41d7-80a5-8da1b6762503" },
                    { "48f02063-882a-4e4a-af54-22eaada1adfd", "John Doe", "d37d9abf-6baa-41d7-80a5-8da1b6762503" },
                    { "61693545-84f0-41ce-b3d8-7562fe4de8f7", "John Doe", "d37d9abf-6baa-41d7-80a5-8da1b6762503" },
                    { "6b8ac9e7-e518-437f-9880-70e9007cf281", "John Doe", "d37d9abf-6baa-41d7-80a5-8da1b6762503" },
                    { "bfac7890-8a82-4faf-85ff-451b2bc1d3ad", "John Doe", "d37d9abf-6baa-41d7-80a5-8da1b6762503" },
                    { "c7018b20-0748-424d-9fcd-7b0c23ff50ac", "John Doe", "d37d9abf-6baa-41d7-80a5-8da1b6762503" },
                    { "d01efc76-b603-4307-a7e7-be4b81e37c4f", "John Doe", "d37d9abf-6baa-41d7-80a5-8da1b6762503" },
                    { "d1528e38-8bfa-4ee1-90ed-45c06ad5f4c5", "John Doe", "d37d9abf-6baa-41d7-80a5-8da1b6762503" },
                    { "d87434a7-8b30-419a-84f3-dbd1836450cc", "John Doe", "d37d9abf-6baa-41d7-80a5-8da1b6762503" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AuthorId", "Name", "PreviewId", "ReleaseYear", "Type" },
                values: new object[,]
                {
                    { "04d3f296-d52d-4df4-8875-5a4e33a85120", "c7018b20-0748-424d-9fcd-7b0c23ff50ac", "Requiem", "9d0a67df-6fb4-4fac-b670-49a5f590beb7", 1791, 0 },
                    { "059ed910-1764-40d4-8536-cd01b9bbcdd9", "1c8ee002-63c6-4dfe-8c58-c92df3e5d67e", "Moonlight Sonata", "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb", 1802, 1 },
                    { "2ce80427-9778-4488-bcba-33c26a4dcb1b", "d87434a7-8b30-419a-84f3-dbd1836450cc", "Liebestraum", "44f268c1-3e94-4d05-8ccb-17c2e77b538d", 1850, 0 },
                    { "37b62582-a8f5-411c-952b-e0bd12dea75d", "48f02063-882a-4e4a-af54-22eaada1adfd", "The Tale of Tsar Saltan", "cdbc9b43-ee1b-4a64-8b2d-d579522ea84f", 1900, 0 },
                    { "7a70fc4a-eb8d-4288-aab3-63a71e811d96", "bfac7890-8a82-4faf-85ff-451b2bc1d3ad", "Valse-Scherzo", "36febf49-1c49-4b69-8084-73ebce69040a", 1877, 0 },
                    { "8a6237dc-6cb0-4e50-b12a-34fc151f0443", "d87434a7-8b30-419a-84f3-dbd1836450cc", "Grandes études de Paganini", "864239f6-65c5-440f-8326-213b3b25693f", 1851, 0 },
                    { "9e4e4346-f9ca-4d33-ae5c-d6f7d9467301", "191a45d2-5f4a-4b2b-9816-1b14a506072e", "The Four Seasons", "7c561b1e-3070-4e83-b71a-2fd7a69fa040", 1725, 0 },
                    { "a8deb544-c6c9-41f5-a079-102eb80da678", "c7018b20-0748-424d-9fcd-7b0c23ff50ac", "The marriage of Figaro", "15fa89e4-7777-4330-b32e-62172cd398c0", 1786, 0 },
                    { "b522f0c5-ef57-44c4-b05e-7072f9b36323", "c7018b20-0748-424d-9fcd-7b0c23ff50ac", "Piano Sonata No. 11", "b26e8131-28bf-4ae9-842b-33b3d639b08e", 1784, 0 },
                    { "bbda1520-5eb0-49d8-98c7-2b9387600de2", "61693545-84f0-41ce-b3d8-7562fe4de8f7", "Fantaisie-Impromptu", "4180556e-5365-4b9c-aa72-a47241346855", 1834, 1 },
                    { "ce80f674-430c-47fc-aabb-b7929a2e3cc0", "0067ae0e-06a5-4036-b13f-a07682bf3a04", "Waltz No. 2", "29ad8ca9-c791-4482-8a44-15776862b282", 1938, 1 },
                    { "e2493a17-9faf-494f-9392-68004084b141", "d01efc76-b603-4307-a7e7-be4b81e37c4f", "Whenever you need somebody", "572cc6a2-a5ba-47f5-8819-8330770cf8b5", 1987, 0 },
                    { "e96988d4-3ab3-4e15-88d4-7f64834d4ba0", "6b8ac9e7-e518-437f-9880-70e9007cf281", "Violin Concerto No. 2", "493afb2c-eb2a-4eab-9e4e-6585eb9924ae", 1826, 0 },
                    { "f989bf37-c91c-4a70-bff3-21a67573dbb9", "d87434a7-8b30-419a-84f3-dbd1836450cc", "Hungarian Rhapsodies", "0a8c3ca2-56ca-4534-a426-648854e61821", 1885, 0 },
                    { "fe0889ec-318f-4636-9c6d-5881fa65bc4b", "d1528e38-8bfa-4ee1-90ed-45c06ad5f4c5", "Lettre à ma mère", "5a9ba216-9883-471d-9c0f-4c3d37e4ec34", 1979, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "FileId", "Name" },
                values: new object[,]
                {
                    { "089b84f9-06e5-4cfe-bd48-6f89cbb46cbe", "ce80f674-430c-47fc-aabb-b7929a2e3cc0", "29ad8ca9-c791-4482-8a44-15776862b282", "Waltz No. 2" },
                    { "0cc8d498-84e9-41d8-bb28-8d54b650cf9e", "fe0889ec-318f-4636-9c6d-5881fa65bc4b", "5a9ba216-9883-471d-9c0f-4c3d37e4ec34", "Marriage d'Amour" },
                    { "22c7eb55-819a-4f19-89a2-83288d3321dc", "b522f0c5-ef57-44c4-b05e-7072f9b36323", "b26e8131-28bf-4ae9-842b-33b3d639b08e", "Turkish March" },
                    { "2a5396f3-6a6a-4161-8f64-82a568538fcc", "37b62582-a8f5-411c-952b-e0bd12dea75d", "cdbc9b43-ee1b-4a64-8b2d-d579522ea84f", "Flight of the Bumblebee" },
                    { "3505cd3d-7faf-4d49-99e8-22a0d2a5f879", "bbda1520-5eb0-49d8-98c7-2b9387600de2", "4180556e-5365-4b9c-aa72-a47241346855", "Fantaisie Impromptu" },
                    { "440b9281-7b71-4090-b0bb-69fb2acc665b", "04d3f296-d52d-4df4-8875-5a4e33a85120", "9d0a67df-6fb4-4fac-b670-49a5f590beb7", "Lacrimosa" },
                    { "44efe64a-21de-487f-b1f5-f011128857a1", "e96988d4-3ab3-4e15-88d4-7f64834d4ba0", "493afb2c-eb2a-4eab-9e4e-6585eb9924ae", "La Campanella" },
                    { "54a7fb6a-0127-41b7-8f99-6bcb5bbbc194", "f989bf37-c91c-4a70-bff3-21a67573dbb9", "2d47fb0d-971c-44e5-9d76-8b5589f0cbbb", "Hungarian Rhapsody No. 2" },
                    { "5f364585-7df5-4f72-8f1b-da8811f8ecd0", "2ce80427-9778-4488-bcba-33c26a4dcb1b", "44f268c1-3e94-4d05-8ccb-17c2e77b538d", "Love Dream" },
                    { "73f1d33e-29dd-49a4-b56d-acb28db29d83", "8a6237dc-6cb0-4e50-b12a-34fc151f0443", "864239f6-65c5-440f-8326-213b3b25693f", "La Campanella" },
                    { "7c3b74d3-9092-46db-914a-33ec6cb0ac8f", "059ed910-1764-40d4-8536-cd01b9bbcdd9", "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb", "Moonlight Sonata" },
                    { "7d351573-204c-4942-9ded-930dff51621c", "e2493a17-9faf-494f-9392-68004084b141", "572cc6a2-a5ba-47f5-8819-8330770cf8b5", "Never gonna give you up" },
                    { "868fc562-80f3-4f7a-be2c-cdd144bd6aa4", "a8deb544-c6c9-41f5-a079-102eb80da678", "15fa89e4-7777-4330-b32e-62172cd398c0", "Marriage of Figaro - Overture" },
                    { "97bce19c-1551-4ee0-a78e-b6e0f30dd7dc", "7a70fc4a-eb8d-4288-aab3-63a71e811d96", "36febf49-1c49-4b69-8084-73ebce69040a", "Valse Sentimental" },
                    { "a0b2a925-1a13-4e5a-ab64-002986975e46", "9e4e4346-f9ca-4d33-ae5c-d6f7d9467301", "9f1d7cfd-53c6-478f-82e2-db737d1b9ecf", "Spring" },
                    { "d6a67528-63d4-4d9f-84c2-a6fc20ab3453", "9e4e4346-f9ca-4d33-ae5c-d6f7d9467301", "7c561b1e-3070-4e83-b71a-2fd7a69fa040", "Summer - Storm" }
                });

            migrationBuilder.InsertData(
                table: "GenreTrack",
                columns: new[] { "GenreId", "TrackId" },
                values: new object[,]
                {
                    { "1d3e2467-a861-4f4e-abf6-9ababd4dd951", "0cc8d498-84e9-41d8-bb28-8d54b650cf9e" },
                    { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "089b84f9-06e5-4cfe-bd48-6f89cbb46cbe" },
                    { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "22c7eb55-819a-4f19-89a2-83288d3321dc" },
                    { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "2a5396f3-6a6a-4161-8f64-82a568538fcc" },
                    { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "3505cd3d-7faf-4d49-99e8-22a0d2a5f879" },
                    { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "440b9281-7b71-4090-b0bb-69fb2acc665b" },
                    { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "44efe64a-21de-487f-b1f5-f011128857a1" },
                    { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "54a7fb6a-0127-41b7-8f99-6bcb5bbbc194" },
                    { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "5f364585-7df5-4f72-8f1b-da8811f8ecd0" },
                    { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "73f1d33e-29dd-49a4-b56d-acb28db29d83" },
                    { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "7c3b74d3-9092-46db-914a-33ec6cb0ac8f" },
                    { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "868fc562-80f3-4f7a-be2c-cdd144bd6aa4" },
                    { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "97bce19c-1551-4ee0-a78e-b6e0f30dd7dc" },
                    { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "a0b2a925-1a13-4e5a-ab64-002986975e46" },
                    { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "d6a67528-63d4-4d9f-84c2-a6fc20ab3453" },
                    { "814e198b-4d1b-4c0f-9396-da55fa052c02", "0cc8d498-84e9-41d8-bb28-8d54b650cf9e" },
                    { "814e198b-4d1b-4c0f-9396-da55fa052c02", "22c7eb55-819a-4f19-89a2-83288d3321dc" },
                    { "814e198b-4d1b-4c0f-9396-da55fa052c02", "2a5396f3-6a6a-4161-8f64-82a568538fcc" },
                    { "814e198b-4d1b-4c0f-9396-da55fa052c02", "3505cd3d-7faf-4d49-99e8-22a0d2a5f879" },
                    { "814e198b-4d1b-4c0f-9396-da55fa052c02", "44efe64a-21de-487f-b1f5-f011128857a1" },
                    { "814e198b-4d1b-4c0f-9396-da55fa052c02", "54a7fb6a-0127-41b7-8f99-6bcb5bbbc194" },
                    { "814e198b-4d1b-4c0f-9396-da55fa052c02", "5f364585-7df5-4f72-8f1b-da8811f8ecd0" },
                    { "814e198b-4d1b-4c0f-9396-da55fa052c02", "73f1d33e-29dd-49a4-b56d-acb28db29d83" },
                    { "814e198b-4d1b-4c0f-9396-da55fa052c02", "7c3b74d3-9092-46db-914a-33ec6cb0ac8f" },
                    { "814e198b-4d1b-4c0f-9396-da55fa052c02", "868fc562-80f3-4f7a-be2c-cdd144bd6aa4" },
                    { "814e198b-4d1b-4c0f-9396-da55fa052c02", "97bce19c-1551-4ee0-a78e-b6e0f30dd7dc" },
                    { "814e198b-4d1b-4c0f-9396-da55fa052c02", "a0b2a925-1a13-4e5a-ab64-002986975e46" },
                    { "814e198b-4d1b-4c0f-9396-da55fa052c02", "d6a67528-63d4-4d9f-84c2-a6fc20ab3453" },
                    { "a63b0ecb-2407-4fd8-8ccc-235529819aa0", "089b84f9-06e5-4cfe-bd48-6f89cbb46cbe" },
                    { "b88ca48c-2135-4e58-8b7c-b2e83b290f3d", "7d351573-204c-4942-9ded-930dff51621c" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "1d3e2467-a861-4f4e-abf6-9ababd4dd951", "0cc8d498-84e9-41d8-bb28-8d54b650cf9e" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "089b84f9-06e5-4cfe-bd48-6f89cbb46cbe" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "22c7eb55-819a-4f19-89a2-83288d3321dc" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "2a5396f3-6a6a-4161-8f64-82a568538fcc" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "3505cd3d-7faf-4d49-99e8-22a0d2a5f879" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "440b9281-7b71-4090-b0bb-69fb2acc665b" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "44efe64a-21de-487f-b1f5-f011128857a1" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "54a7fb6a-0127-41b7-8f99-6bcb5bbbc194" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "5f364585-7df5-4f72-8f1b-da8811f8ecd0" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "73f1d33e-29dd-49a4-b56d-acb28db29d83" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "7c3b74d3-9092-46db-914a-33ec6cb0ac8f" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "868fc562-80f3-4f7a-be2c-cdd144bd6aa4" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "97bce19c-1551-4ee0-a78e-b6e0f30dd7dc" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "a0b2a925-1a13-4e5a-ab64-002986975e46" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "41274e7b-5940-4368-8f51-5ac9c2a35c36", "d6a67528-63d4-4d9f-84c2-a6fc20ab3453" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "814e198b-4d1b-4c0f-9396-da55fa052c02", "0cc8d498-84e9-41d8-bb28-8d54b650cf9e" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "814e198b-4d1b-4c0f-9396-da55fa052c02", "22c7eb55-819a-4f19-89a2-83288d3321dc" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "814e198b-4d1b-4c0f-9396-da55fa052c02", "2a5396f3-6a6a-4161-8f64-82a568538fcc" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "814e198b-4d1b-4c0f-9396-da55fa052c02", "3505cd3d-7faf-4d49-99e8-22a0d2a5f879" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "814e198b-4d1b-4c0f-9396-da55fa052c02", "44efe64a-21de-487f-b1f5-f011128857a1" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "814e198b-4d1b-4c0f-9396-da55fa052c02", "54a7fb6a-0127-41b7-8f99-6bcb5bbbc194" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "814e198b-4d1b-4c0f-9396-da55fa052c02", "5f364585-7df5-4f72-8f1b-da8811f8ecd0" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "814e198b-4d1b-4c0f-9396-da55fa052c02", "73f1d33e-29dd-49a4-b56d-acb28db29d83" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "814e198b-4d1b-4c0f-9396-da55fa052c02", "7c3b74d3-9092-46db-914a-33ec6cb0ac8f" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "814e198b-4d1b-4c0f-9396-da55fa052c02", "868fc562-80f3-4f7a-be2c-cdd144bd6aa4" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "814e198b-4d1b-4c0f-9396-da55fa052c02", "97bce19c-1551-4ee0-a78e-b6e0f30dd7dc" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "814e198b-4d1b-4c0f-9396-da55fa052c02", "a0b2a925-1a13-4e5a-ab64-002986975e46" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "814e198b-4d1b-4c0f-9396-da55fa052c02", "d6a67528-63d4-4d9f-84c2-a6fc20ab3453" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "a63b0ecb-2407-4fd8-8ccc-235529819aa0", "089b84f9-06e5-4cfe-bd48-6f89cbb46cbe" });

            migrationBuilder.DeleteData(
                table: "GenreTrack",
                keyColumns: new[] { "GenreId", "TrackId" },
                keyValues: new object[] { "b88ca48c-2135-4e58-8b7c-b2e83b290f3d", "7d351573-204c-4942-9ded-930dff51621c" });

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "1d3e2467-a861-4f4e-abf6-9ababd4dd951");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "41274e7b-5940-4368-8f51-5ac9c2a35c36");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "814e198b-4d1b-4c0f-9396-da55fa052c02");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "a63b0ecb-2407-4fd8-8ccc-235529819aa0");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "b88ca48c-2135-4e58-8b7c-b2e83b290f3d");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "089b84f9-06e5-4cfe-bd48-6f89cbb46cbe");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "0cc8d498-84e9-41d8-bb28-8d54b650cf9e");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "22c7eb55-819a-4f19-89a2-83288d3321dc");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "2a5396f3-6a6a-4161-8f64-82a568538fcc");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "3505cd3d-7faf-4d49-99e8-22a0d2a5f879");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "440b9281-7b71-4090-b0bb-69fb2acc665b");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "44efe64a-21de-487f-b1f5-f011128857a1");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "54a7fb6a-0127-41b7-8f99-6bcb5bbbc194");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "5f364585-7df5-4f72-8f1b-da8811f8ecd0");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "73f1d33e-29dd-49a4-b56d-acb28db29d83");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "7c3b74d3-9092-46db-914a-33ec6cb0ac8f");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "7d351573-204c-4942-9ded-930dff51621c");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "868fc562-80f3-4f7a-be2c-cdd144bd6aa4");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "97bce19c-1551-4ee0-a78e-b6e0f30dd7dc");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "a0b2a925-1a13-4e5a-ab64-002986975e46");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "d6a67528-63d4-4d9f-84c2-a6fc20ab3453");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "04d3f296-d52d-4df4-8875-5a4e33a85120");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "059ed910-1764-40d4-8536-cd01b9bbcdd9");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "2ce80427-9778-4488-bcba-33c26a4dcb1b");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "37b62582-a8f5-411c-952b-e0bd12dea75d");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "7a70fc4a-eb8d-4288-aab3-63a71e811d96");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "8a6237dc-6cb0-4e50-b12a-34fc151f0443");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "9e4e4346-f9ca-4d33-ae5c-d6f7d9467301");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "a8deb544-c6c9-41f5-a079-102eb80da678");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "b522f0c5-ef57-44c4-b05e-7072f9b36323");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "bbda1520-5eb0-49d8-98c7-2b9387600de2");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "ce80f674-430c-47fc-aabb-b7929a2e3cc0");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "e2493a17-9faf-494f-9392-68004084b141");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "e96988d4-3ab3-4e15-88d4-7f64834d4ba0");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "f989bf37-c91c-4a70-bff3-21a67573dbb9");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "fe0889ec-318f-4636-9c6d-5881fa65bc4b");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "0067ae0e-06a5-4036-b13f-a07682bf3a04");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "191a45d2-5f4a-4b2b-9816-1b14a506072e");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "1c8ee002-63c6-4dfe-8c58-c92df3e5d67e");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "48f02063-882a-4e4a-af54-22eaada1adfd");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "61693545-84f0-41ce-b3d8-7562fe4de8f7");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "6b8ac9e7-e518-437f-9880-70e9007cf281");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "bfac7890-8a82-4faf-85ff-451b2bc1d3ad");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "c7018b20-0748-424d-9fcd-7b0c23ff50ac");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "d01efc76-b603-4307-a7e7-be4b81e37c4f");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "d1528e38-8bfa-4ee1-90ed-45c06ad5f4c5");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "d87434a7-8b30-419a-84f3-dbd1836450cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d37d9abf-6baa-41d7-80a5-8da1b6762503");

            migrationBuilder.DropColumn(
                name: "ProfilePicId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0d808c08-d40a-4a5c-9449-f4454494f5f3", 0, "a050608c-a917-4cf7-b3e3-b22fdd17116c", "", false, false, null, "Frédéric Chopin", null, null, null, null, false, 0, "24c3f965-d839-4f2e-848c-33a2839363fe", false, "chopin" },
                    { "59649289-fbad-4895-a46a-dbc05fdde565", 0, "61ba8229-b4f6-4b4f-bcbf-796f11cd9a41", "", false, false, null, "Franz Liszt", null, null, null, null, false, 0, "8074c86b-ccdb-4fd6-8f8b-58a34f4bf16e", false, "liszt" },
                    { "5da5079f-9ab9-47bf-ba32-7cb60c085fbf", 0, "a589202e-a87f-4fa2-8ea0-3f6fe16abf29", "", false, false, null, "Paul de Senneville", null, null, null, null, false, 0, "9775441b-e420-4803-997c-1491b2a54593", false, "senneville" },
                    { "614b3f26-c84f-4ba5-8209-e1fe2a3d2c95", 0, "90a2f955-6011-457f-be20-18b30e8e597d", "", false, false, null, "Ludwig van Beethoven", null, null, null, null, false, 0, "4e44284e-a863-486e-b45e-2639affb17d4", false, "beethoven" },
                    { "6547fbbb-8c5b-4ced-9c94-55783a785887", 0, "c646efc1-b33c-477c-9563-be5447e4a02f", "", false, false, null, "Nikolai Rimsky-Korsakov", null, null, null, null, false, 0, "30be22c1-36e9-421c-b6a1-c04e2b6e4b42", false, "rimsky-korsakov" },
                    { "6aa10996-a41b-4ae2-84e4-cb682c353aaa", 0, "814e4ca6-c059-4859-93d5-9d1ef805e1e7", "", false, false, null, "Antonio Lucio Vivaldi", null, null, null, null, false, 0, "9924df6a-ba87-49bc-adc4-79252c9caf8e", false, "vivaldi" },
                    { "9836aa61-f61f-4f53-9d81-fd11398a962f", 0, "69513caf-2537-469d-b176-a4a612fe8280", "", false, false, null, "Wolfgang Amadeus Mozart", null, null, null, null, false, 0, "bc9bff83-bc9c-4580-96e4-7b676cbd0da9", false, "mozart" },
                    { "c5dd5c01-8bc0-441c-ab5c-9ce175430558", 0, "08d2e096-6003-405e-85e7-f0f8965a15eb", "", false, false, null, "Dmitri Shostakovich", null, null, null, null, false, 0, "bb636ce0-b98f-471e-ae3b-22f525d5ce3c", false, "shostakovich" },
                    { "ccf573c7-5090-4a70-b509-b15f4b50e2df", 0, "3b03e9d6-67d7-4caf-acaf-b236cbe7888c", "", false, false, null, "Niccolò Paganini", null, null, null, null, false, 0, "ff97071a-f233-4134-861c-438f91ebad17", false, "paganini" },
                    { "d15f062a-b4a6-4e76-9767-d67c3313d5d3", 0, "21b61ba7-3328-4359-8147-8a2e2f01c437", "", false, false, null, "Rick Astley", null, null, null, null, false, 0, "356e4a6d-76ae-4dee-a00b-7e78663341d9", false, "astley" },
                    { "e9b1e578-72a6-4942-b459-bec8e9a0189e", 0, "cc4f4cdd-10b8-4061-adac-0bfd596abf6c", "", false, false, null, "Pyotr Tchaikovsky", null, null, null, null, false, 0, "760abf63-df4b-4316-9f25-64e13dbe22d4", false, "tchaikovsky" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "304121dd-cfa2-4e74-bac9-adc5c83f03a6", "Jazz" },
                    { "5adb6826-1452-454f-af12-c030eb18c978", "Instrumental" },
                    { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "Classic" },
                    { "a12d49f1-58d3-46ed-9995-a5aa2f31b5eb", "New Age" },
                    { "e4fe0b0d-56cb-428b-bc88-155e92664a31", "Pop" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[,]
                {
                    { "050c7a4c-5c24-42c4-b13d-387799596d6f", "Paul de Senneville", "5da5079f-9ab9-47bf-ba32-7cb60c085fbf" },
                    { "13e94b58-46d9-4dd2-b3ab-5e69cd0d66b8", "Nikolai Rimsky-Korsakov", "6547fbbb-8c5b-4ced-9c94-55783a785887" },
                    { "95e20169-19ab-4ecd-ad0e-25d80028852c", "Wolfgang Amadeus Mozart", "9836aa61-f61f-4f53-9d81-fd11398a962f" },
                    { "97d0e58e-e9a1-46d2-93a0-39a2f4517e7c", "Rick Astley", "d15f062a-b4a6-4e76-9767-d67c3313d5d3" },
                    { "98c18ea1-1470-489b-90a9-0c3a7104ad19", "Ludwig van Beethoven", "614b3f26-c84f-4ba5-8209-e1fe2a3d2c95" },
                    { "9edece38-8e1d-4a05-a4a3-8ced7f913100", "Frédéric Chopin", "0d808c08-d40a-4a5c-9449-f4454494f5f3" },
                    { "9f78fe69-e03b-40e2-b8bd-24428bff14e3", "Niccolò Paganini", "ccf573c7-5090-4a70-b509-b15f4b50e2df" },
                    { "a3a39902-91ba-4f18-b1ad-174a0abeb819", "Pyotr Tchaikovsky", "e9b1e578-72a6-4942-b459-bec8e9a0189e" },
                    { "aabbbcbd-81c4-400b-94ce-22c28c5010a9", "Antonio Lucio Vivaldi", "6aa10996-a41b-4ae2-84e4-cb682c353aaa" },
                    { "db88345d-d07e-4701-bd80-dee0f0ab2da9", "Franz Liszt", "59649289-fbad-4895-a46a-dbc05fdde565" },
                    { "f7a377de-06df-4328-8660-540de961010c", "Dmitri Shostakovich", "c5dd5c01-8bc0-441c-ab5c-9ce175430558" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AuthorId", "Name", "PreviewId", "ReleaseYear", "Type" },
                values: new object[,]
                {
                    { "0cd5cf91-7699-45ac-bf7f-808f24abb076", "97d0e58e-e9a1-46d2-93a0-39a2f4517e7c", "Whenever you need somebody", "572cc6a2-a5ba-47f5-8819-8330770cf8b5", 1987, 0 },
                    { "17409b22-0079-4b29-b79b-d5e99718e249", "aabbbcbd-81c4-400b-94ce-22c28c5010a9", "The Four Seasons", "7c561b1e-3070-4e83-b71a-2fd7a69fa040", 1725, 0 },
                    { "1c7577da-ae0d-47c5-9709-e40b479b6561", "13e94b58-46d9-4dd2-b3ab-5e69cd0d66b8", "The Tale of Tsar Saltan", "cdbc9b43-ee1b-4a64-8b2d-d579522ea84f", 1900, 0 },
                    { "1e97c905-b865-4592-932a-4d5b3c627ed3", "050c7a4c-5c24-42c4-b13d-387799596d6f", "Lettre à ma mère", "5a9ba216-9883-471d-9c0f-4c3d37e4ec34", 1979, 0 },
                    { "32896a09-b2eb-45a4-9c3e-ef4ed45a424b", "db88345d-d07e-4701-bd80-dee0f0ab2da9", "Grandes études de Paganini", "864239f6-65c5-440f-8326-213b3b25693f", 1851, 0 },
                    { "483ce399-4688-41e2-8a09-075a638769c7", "db88345d-d07e-4701-bd80-dee0f0ab2da9", "Liebestraum", "44f268c1-3e94-4d05-8ccb-17c2e77b538d", 1850, 0 },
                    { "8227072d-d879-4755-aea1-5a9f5dd8881a", "95e20169-19ab-4ecd-ad0e-25d80028852c", "The marriage of Figaro", "15fa89e4-7777-4330-b32e-62172cd398c0", 1786, 0 },
                    { "9c15ca9a-40ff-4e59-aae3-09f947f74f7f", "9f78fe69-e03b-40e2-b8bd-24428bff14e3", "Violin Concerto No. 2", "493afb2c-eb2a-4eab-9e4e-6585eb9924ae", 1826, 0 },
                    { "9f2b9022-54f8-4baf-ba42-877a73a73961", "95e20169-19ab-4ecd-ad0e-25d80028852c", "Piano Sonata No. 11", "b26e8131-28bf-4ae9-842b-33b3d639b08e", 1784, 0 },
                    { "a184871f-858c-4c9a-b8cf-99c314373c21", "98c18ea1-1470-489b-90a9-0c3a7104ad19", "Moonlight Sonata", "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb", 1802, 1 },
                    { "cdace994-a952-4190-a520-c77b77be7bca", "db88345d-d07e-4701-bd80-dee0f0ab2da9", "Hungarian Rhapsodies", "0a8c3ca2-56ca-4534-a426-648854e61821", 1885, 0 },
                    { "d638c3e6-a394-4f9b-aa74-5c3e1af30c03", "9edece38-8e1d-4a05-a4a3-8ced7f913100", "Fantaisie-Impromptu", "4180556e-5365-4b9c-aa72-a47241346855", 1834, 1 },
                    { "db762ffd-8186-44ce-99b7-61ce6c41759c", "f7a377de-06df-4328-8660-540de961010c", "Waltz No. 2", "29ad8ca9-c791-4482-8a44-15776862b282", 1938, 1 },
                    { "e1bc65d8-2d67-41c5-ab87-f15efa687d29", "95e20169-19ab-4ecd-ad0e-25d80028852c", "Requiem", "9d0a67df-6fb4-4fac-b670-49a5f590beb7", 1791, 0 },
                    { "e1d72bbc-b61f-41f6-af18-d719682fa428", "a3a39902-91ba-4f18-b1ad-174a0abeb819", "Valse-Scherzo", "36febf49-1c49-4b69-8084-73ebce69040a", 1877, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "FileId", "Name" },
                values: new object[,]
                {
                    { "01dec976-5a96-44cc-98d6-0fb96c0d4172", "17409b22-0079-4b29-b79b-d5e99718e249", "9f1d7cfd-53c6-478f-82e2-db737d1b9ecf", "Spring" },
                    { "0823c8ce-8c46-49ad-930f-434637f66987", "8227072d-d879-4755-aea1-5a9f5dd8881a", "15fa89e4-7777-4330-b32e-62172cd398c0", "Marriage of Figaro - Overture" },
                    { "16a383aa-bbe2-4b3a-8f2d-422882e285ee", "cdace994-a952-4190-a520-c77b77be7bca", "2d47fb0d-971c-44e5-9d76-8b5589f0cbbb", "Hungarian Rhapsody No. 2" },
                    { "211612d4-b5da-48e2-aa18-60e36a829fda", "0cd5cf91-7699-45ac-bf7f-808f24abb076", "572cc6a2-a5ba-47f5-8819-8330770cf8b5", "Never gonna give you up" },
                    { "2185956f-cd1b-4891-9f3b-82a818be8962", "1c7577da-ae0d-47c5-9709-e40b479b6561", "4180556e-5365-4b9c-aa72-a47241346855", "Flight of the Bumblebee" },
                    { "21944a9f-3faf-4c13-841e-ef963886ac38", "9f2b9022-54f8-4baf-ba42-877a73a73961", "b26e8131-28bf-4ae9-842b-33b3d639b08e", "Turkish March" },
                    { "55b94c05-65cb-42c2-b67c-5876a6b6ed48", "a184871f-858c-4c9a-b8cf-99c314373c21", "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb", "Moonlight Sonata" },
                    { "69de43c6-876c-4c70-bedf-f0efcc978efa", "1e97c905-b865-4592-932a-4d5b3c627ed3", "15fa89e4-7777-4330-b32e-62172cd398c0", "Marriage d'Amour" },
                    { "868f5429-36af-4d4c-a0f3-321283864b34", "d638c3e6-a394-4f9b-aa74-5c3e1af30c03", "4180556e-5365-4b9c-aa72-a47241346855", "Fantaisie Impromptu" },
                    { "9e004990-ec0f-4117-8bda-7343b5a5896d", "9c15ca9a-40ff-4e59-aae3-09f947f74f7f", "493afb2c-eb2a-4eab-9e4e-6585eb9924ae", "La Campanella" },
                    { "a0df6545-7c52-45b1-a439-4b4ea8428aee", "483ce399-4688-41e2-8a09-075a638769c7", "44f268c1-3e94-4d05-8ccb-17c2e77b538d", "Love Dream" },
                    { "b0a6131b-febd-4b19-b9f0-ae80fbb1c176", "e1d72bbc-b61f-41f6-af18-d719682fa428", "36febf49-1c49-4b69-8084-73ebce69040a", "Valse Sentimental" },
                    { "e0f4d900-50b8-4952-882a-ada94466a96f", "e1bc65d8-2d67-41c5-ab87-f15efa687d29", "9d0a67df-6fb4-4fac-b670-49a5f590beb7", "Lacrimosa" },
                    { "e138d221-050f-40bc-b8d8-8a7f5961eb86", "32896a09-b2eb-45a4-9c3e-ef4ed45a424b", "864239f6-65c5-440f-8326-213b3b25693f", "La Campanella" },
                    { "e98f5c49-32c4-4943-876b-5d360fd9a1e5", "db762ffd-8186-44ce-99b7-61ce6c41759c", "29ad8ca9-c791-4482-8a44-15776862b282", "Waltz No. 2" },
                    { "eaebfb1e-dc1c-4c30-9acf-a2124790b422", "17409b22-0079-4b29-b79b-d5e99718e249", "7c561b1e-3070-4e83-b71a-2fd7a69fa040", "Summer - Storm" }
                });

            migrationBuilder.InsertData(
                table: "GenreTrack",
                columns: new[] { "GenreId", "TrackId" },
                values: new object[,]
                {
                    { "304121dd-cfa2-4e74-bac9-adc5c83f03a6", "e98f5c49-32c4-4943-876b-5d360fd9a1e5" },
                    { "5adb6826-1452-454f-af12-c030eb18c978", "01dec976-5a96-44cc-98d6-0fb96c0d4172" },
                    { "5adb6826-1452-454f-af12-c030eb18c978", "0823c8ce-8c46-49ad-930f-434637f66987" },
                    { "5adb6826-1452-454f-af12-c030eb18c978", "16a383aa-bbe2-4b3a-8f2d-422882e285ee" },
                    { "5adb6826-1452-454f-af12-c030eb18c978", "2185956f-cd1b-4891-9f3b-82a818be8962" },
                    { "5adb6826-1452-454f-af12-c030eb18c978", "21944a9f-3faf-4c13-841e-ef963886ac38" },
                    { "5adb6826-1452-454f-af12-c030eb18c978", "55b94c05-65cb-42c2-b67c-5876a6b6ed48" },
                    { "5adb6826-1452-454f-af12-c030eb18c978", "69de43c6-876c-4c70-bedf-f0efcc978efa" },
                    { "5adb6826-1452-454f-af12-c030eb18c978", "868f5429-36af-4d4c-a0f3-321283864b34" },
                    { "5adb6826-1452-454f-af12-c030eb18c978", "9e004990-ec0f-4117-8bda-7343b5a5896d" },
                    { "5adb6826-1452-454f-af12-c030eb18c978", "a0df6545-7c52-45b1-a439-4b4ea8428aee" },
                    { "5adb6826-1452-454f-af12-c030eb18c978", "b0a6131b-febd-4b19-b9f0-ae80fbb1c176" },
                    { "5adb6826-1452-454f-af12-c030eb18c978", "e138d221-050f-40bc-b8d8-8a7f5961eb86" },
                    { "5adb6826-1452-454f-af12-c030eb18c978", "eaebfb1e-dc1c-4c30-9acf-a2124790b422" },
                    { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "01dec976-5a96-44cc-98d6-0fb96c0d4172" },
                    { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "0823c8ce-8c46-49ad-930f-434637f66987" },
                    { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "16a383aa-bbe2-4b3a-8f2d-422882e285ee" },
                    { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "2185956f-cd1b-4891-9f3b-82a818be8962" },
                    { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "21944a9f-3faf-4c13-841e-ef963886ac38" },
                    { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "55b94c05-65cb-42c2-b67c-5876a6b6ed48" },
                    { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "868f5429-36af-4d4c-a0f3-321283864b34" },
                    { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "9e004990-ec0f-4117-8bda-7343b5a5896d" },
                    { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "a0df6545-7c52-45b1-a439-4b4ea8428aee" },
                    { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "b0a6131b-febd-4b19-b9f0-ae80fbb1c176" },
                    { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "e0f4d900-50b8-4952-882a-ada94466a96f" },
                    { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "e138d221-050f-40bc-b8d8-8a7f5961eb86" },
                    { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "e98f5c49-32c4-4943-876b-5d360fd9a1e5" },
                    { "7e4b4524-0514-4c80-bb6e-3c07c03bbf76", "eaebfb1e-dc1c-4c30-9acf-a2124790b422" },
                    { "a12d49f1-58d3-46ed-9995-a5aa2f31b5eb", "69de43c6-876c-4c70-bedf-f0efcc978efa" },
                    { "e4fe0b0d-56cb-428b-bc88-155e92664a31", "211612d4-b5da-48e2-aa18-60e36a829fda" }
                });
        }
    }
}
