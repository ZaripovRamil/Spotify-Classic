using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class returnedGenres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "046b8651-b7d2-4201-a867-4c8599da8180");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "46c47b5c-fbca-4b84-8797-d19c376dfdd9");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "95392dc3-7240-46cb-b565-f44efe81069d");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "9f78eadf-f234-4852-a196-6c26c75110fc");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "b75549f2-9226-455b-9a6c-3832a582b944");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "33e8f315-5c48-45ee-a7b3-9081702d35e2");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "3be1a0c7-ce95-4d87-b2e2-655372a07b19");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "6689e3a6-0564-4505-ba0d-a490162d7286");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "6dbe1fcf-8707-4a4f-b807-a5e9467e668f");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "7140b053-2540-448f-994c-7642fee5074a");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "88e47cf7-8a3e-4ea1-be87-4aa491dcca5d");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "9b2c6266-b7cf-4753-9d34-8d6e19ae7b4d");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "a974a77a-2fff-4efa-acbc-faa27c329a59");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "af8788c1-b041-497f-9c3c-388d56a96f3c");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "b38a088f-96a9-4cf2-b23c-fc2d8987b787");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "bed643d4-8323-4ecd-bec9-d20a1fdf20e1");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "cf896c1f-577f-4408-ada3-cb8988b5dc17");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "f22d90df-b5b4-49f9-986d-da3b168ce00e");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "f60ac6a5-d96a-487c-b989-1cf581740be6");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "f7781ad9-532e-4724-ae80-60f340b81a28");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "fcf0eb6e-3432-4827-bb55-ce62d5815083");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "16d30176-62cf-4adc-8326-d21ceb357f83");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "19cdb547-aa3c-4cc1-aa74-c0b78080f9a4");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "239a237a-e8a9-49af-b54b-3d5a67b96a0f");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "46ba9a91-d55e-41cd-a0fa-28b03875e228");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "4aa4a09b-5c6e-4671-9d8e-3a37aae64e86");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "59024c6d-f7c6-4a50-8759-d9828b24bcff");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "59486912-6136-4854-815f-b41d32118b68");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "5b565a0a-200a-4512-a9bd-641a139b57be");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "70367f69-9f2b-43ed-b474-caa66b315496");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "aa7cdf89-f17e-498c-bd57-aca88eb2dc15");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "b995419f-77ee-464c-9337-1256f1b1308f");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "baddddc9-2836-42b0-bda7-5af383d69b7d");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "c4bf9a82-7d3a-427c-ad1a-f3467810eb0d");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "da972e20-bead-4684-8a2e-2dc856ef3b63");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "e13b330a-8550-4856-9f2c-750a716f001a");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "092cfbee-eaea-4535-b532-32e277a663ac");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "0cefd1bc-75e0-4c31-b2af-d024f3038116");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "19f36b25-181d-4b1f-9669-efee805b14af");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "811baf1d-17a0-4ebf-b56f-86cd840740bc");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "826a0449-2e0f-4efd-8100-5e8f7507289d");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "91440e02-1405-46d3-85d4-2bfbe7c815f2");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "b8f103a1-f080-496b-b94d-4ff8e0fa5387");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "c2b13e92-03f2-4b6c-9f23-e5ff3ff160a8");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "cf87b627-49f7-4950-92cc-35bc0e6f2f30");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "e1c6cdaf-804e-4d68-942c-b9bd2ebc7ebc");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "f628a58c-8c61-43f9-ad82-c67111aabb3d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11b59229-3476-4583-8ea2-f2e87add103d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73267a2e-0679-44fa-99ea-05a728fd48de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "748163e5-fc61-4b48-a0f2-da4e2bd9045d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "784a06fb-f7e9-4f6a-9509-858b329d5f89");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a56cedd-8ee6-40e0-b821-965fc1597805");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80bf3d52-1d8f-49e0-a0ea-ca9b32fb66e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84eda8c2-e662-4818-8f78-906da314e229");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1444438-d3a0-46ac-a9f0-3b011c059f8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba77df09-85c5-4a6d-bf2d-00a984b6a5e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc56ddae-71fd-4857-a7f3-36c81cac2d7b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea1bc22e-c88d-4b19-93f8-596f014f3eea");

            migrationBuilder.AddColumn<List<string>>(
                name: "GenreIds",
                table: "Tracks",
                type: "text[]",
                nullable: false);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1b735957-adbc-4a8e-945c-4c4cd60548a4", 0, "0d0d0843-3233-47ea-8685-6d3df360608f", "", false, false, null, "Antonio Lucio Vivaldi", null, null, null, null, false, 0, "d80a7852-2c7b-46dd-a3ba-600fc9c67d8a", false, "vivaldi" },
                    { "1f857633-e653-4834-80f8-f032153bf42a", 0, "482f5707-bd07-47a3-84d8-abad8dfd361f", "", false, false, null, "Franz Liszt", null, null, null, null, false, 0, "03a4942d-dc06-4d89-9443-965d9b8fef78", false, "liszt" },
                    { "1fc91802-e1b7-4b07-8ffb-9a4609dca83d", 0, "e66e8cf9-570e-4856-977b-14c522aa17af", "", false, false, null, "Pyotr Tchaikovsky", null, null, null, null, false, 0, "4103975c-53ce-4158-883c-7c749e983d94", false, "tchaikovsky" },
                    { "281e5b90-9649-4e66-bf01-8c80e5bb2d01", 0, "25288032-368f-4e9e-80ec-f9cbc564c29b", "", false, false, null, "Niccolò Paganini", null, null, null, null, false, 0, "147d93d6-e9ae-451b-8307-26e4cf6a5ed9", false, "paganini" },
                    { "2ca180d5-f153-41a3-a1c6-c80bf4a77830", 0, "6ffe3a01-cc31-4a71-891d-aa64766af013", "", false, false, null, "Frédéric Chopin", null, null, null, null, false, 0, "aa54f185-16e1-4083-ae6f-3a8e0bf5ce9b", false, "chopin" },
                    { "3498a7c1-d79f-46a9-bedc-0bb5adde22e6", 0, "440092e6-23a1-40a8-8989-4d5a5b00f477", "", false, false, null, "Dmitri Shostakovich", null, null, null, null, false, 0, "53716b38-8055-4f5c-9ab1-aee3a75c2069", false, "shostakovich" },
                    { "52880029-38d5-4967-a1ca-bb16439b887f", 0, "5091b36b-aa2f-4795-8348-df1359d1615c", "", false, false, null, "Wolfgang Amadeus Mozart", null, null, null, null, false, 0, "6c1cb145-8146-4d00-8c6c-52f2e02681c9", false, "mozart" },
                    { "7f1166ab-1d18-4243-806c-da8c296c5306", 0, "1a60d36b-3cfc-4850-b3f4-40e93c693434", "", false, false, null, "Ludwig van Beethoven", null, null, null, null, false, 0, "f07544c9-8be6-463a-9414-3b33f61ca2a7", false, "beethoven" },
                    { "94df1be8-7ef4-4029-93b3-2f7ce724981c", 0, "79fcb1da-7c35-43de-8494-66f2f584e48a", "", false, false, null, "Paul de Senneville", null, null, null, null, false, 0, "14f8a72c-b93e-4565-a24f-8ae209d36495", false, "senneville" },
                    { "ac593f00-1e1f-41d5-941c-1164620effe2", 0, "ed152ed7-a4d9-40be-ba44-ce1860afeba0", "", false, false, null, "Rick Astley", null, null, null, null, false, 0, "b8d8f2e8-c272-4079-af5c-f9349861e6dd", false, "astley" },
                    { "d454763e-9d83-4772-bcb3-731e39c09e14", 0, "be8de764-056d-4b4d-8220-9d3b329fbafd", "", false, false, null, "Nikolai Rimsky-Korsakov", null, null, null, null, false, 0, "95712b7c-229b-4b78-b348-3285b15280c4", false, "rimsky-korsakov" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "472fe29a-7aef-4ecb-9cee-57e044c0bca6", "Jazz" },
                    { "76500db7-3eef-424b-a7f4-aac2e2ecaabb", "Pop" },
                    { "90778305-ccce-45eb-bc58-ee3bb35a104a", "Instrumental" },
                    { "c25c23de-0df1-4eff-af77-e05447b585bd", "Classic" },
                    { "f19d2442-1868-4e2b-a1f8-5b015e778f5b", "New Age" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[,]
                {
                    { "2a47bc3f-d0a9-484f-a6a9-c5ad50cfae4b", "Dmitri Shostakovich", "3498a7c1-d79f-46a9-bedc-0bb5adde22e6" },
                    { "2b9f02ca-1333-4541-96a0-8ffc8eef999a", "Paul de Senneville", "94df1be8-7ef4-4029-93b3-2f7ce724981c" },
                    { "866a3a04-9b5b-42b6-84fe-2fbc6c29dfe0", "Nikolai Rimsky-Korsakov", "d454763e-9d83-4772-bcb3-731e39c09e14" },
                    { "8f015e90-2ee1-4c16-9ecc-d0b0e92e9eed", "Niccolò Paganini", "281e5b90-9649-4e66-bf01-8c80e5bb2d01" },
                    { "94cb5113-f1e5-455c-a2e6-08f585d67d8a", "Ludwig van Beethoven", "7f1166ab-1d18-4243-806c-da8c296c5306" },
                    { "98be3aee-202c-47c6-817d-4178ba0623f5", "Antonio Lucio Vivaldi", "1b735957-adbc-4a8e-945c-4c4cd60548a4" },
                    { "b24e0d80-4cf1-4f25-b4fc-efe6359b52cc", "Pyotr Tchaikovsky", "1fc91802-e1b7-4b07-8ffb-9a4609dca83d" },
                    { "ba2e98ce-28ab-4c0a-9424-09e824c4eeca", "Frédéric Chopin", "2ca180d5-f153-41a3-a1c6-c80bf4a77830" },
                    { "bc974f7a-f548-41a3-88fe-4e9fdc342e37", "Rick Astley", "ac593f00-1e1f-41d5-941c-1164620effe2" },
                    { "ec81dc60-7de8-4dbe-bab3-6210ba36274a", "Wolfgang Amadeus Mozart", "52880029-38d5-4967-a1ca-bb16439b887f" },
                    { "f6b2b8e8-0bc0-4fc7-a12a-43f88d935fad", "Franz Liszt", "1f857633-e653-4834-80f8-f032153bf42a" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AuthorId", "Name", "PreviewId", "ReleaseYear", "Type" },
                values: new object[,]
                {
                    { "1808b0a6-3449-4b89-8b9b-984352b2d531", "ba2e98ce-28ab-4c0a-9424-09e824c4eeca", "Fantaisie-Impromptu", "4180556e-5365-4b9c-aa72-a47241346855", 1834, 1 },
                    { "1adb2fa3-7e9c-4f2a-aec7-459de571b845", "bc974f7a-f548-41a3-88fe-4e9fdc342e37", "Whenever you need somebody", "572cc6a2-a5ba-47f5-8819-8330770cf8b5", 1987, 0 },
                    { "2c9afde7-00a2-47c7-9f89-21e81d2059a2", "2b9f02ca-1333-4541-96a0-8ffc8eef999a", "Lettre à ma mère", "5a9ba216-9883-471d-9c0f-4c3d37e4ec34", 1979, 0 },
                    { "4525ec0d-82ae-421f-a397-080d54fe12a9", "ec81dc60-7de8-4dbe-bab3-6210ba36274a", "Requiem", "9d0a67df-6fb4-4fac-b670-49a5f590beb7", 1791, 0 },
                    { "51b01e4a-f2d1-4310-9b87-e319d4220810", "94cb5113-f1e5-455c-a2e6-08f585d67d8a", "Moonlight Sonata", "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb", 1802, 1 },
                    { "5b75529c-33ad-4ede-8dfd-229c6118a0d7", "ec81dc60-7de8-4dbe-bab3-6210ba36274a", "Piano Sonata No. 11", "b26e8131-28bf-4ae9-842b-33b3d639b08e", 1784, 0 },
                    { "657b04d7-3d14-4c75-a972-acb7fb985179", "866a3a04-9b5b-42b6-84fe-2fbc6c29dfe0", "The Tale of Tsar Saltan", "cdbc9b43-ee1b-4a64-8b2d-d579522ea84f", 1900, 0 },
                    { "841f37bb-28b8-46f4-84c5-b298202cf181", "ec81dc60-7de8-4dbe-bab3-6210ba36274a", "The marriage of Figaro", "15fa89e4-7777-4330-b32e-62172cd398c0", 1786, 0 },
                    { "9b3eb542-b5a0-4e97-aab5-36f21b7b5bfa", "f6b2b8e8-0bc0-4fc7-a12a-43f88d935fad", "Grandes études de Paganini", "864239f6-65c5-440f-8326-213b3b25693f", 1851, 0 },
                    { "9f154aa2-2a48-4694-858e-963c63d21d07", "2a47bc3f-d0a9-484f-a6a9-c5ad50cfae4b", "Waltz No. 2", "29ad8ca9-c791-4482-8a44-15776862b282", 1938, 1 },
                    { "aa2eb3f8-e71e-46a4-8aa0-fa1424b0016a", "8f015e90-2ee1-4c16-9ecc-d0b0e92e9eed", "Violin Concerto No. 2", "493afb2c-eb2a-4eab-9e4e-6585eb9924ae", 1826, 0 },
                    { "b1be80cc-74b2-4607-ad1f-1b767c651db5", "b24e0d80-4cf1-4f25-b4fc-efe6359b52cc", "Valse-Scherzo", "36febf49-1c49-4b69-8084-73ebce69040a", 1877, 0 },
                    { "ce4263ad-20f4-42f1-9d69-7decfb2a783c", "98be3aee-202c-47c6-817d-4178ba0623f5", "The Four Seasons", "7c561b1e-3070-4e83-b71a-2fd7a69fa040", 1725, 0 },
                    { "d57502b0-b0be-471c-8068-c96886ae5e33", "f6b2b8e8-0bc0-4fc7-a12a-43f88d935fad", "Hungarian Rhapsodies", "0a8c3ca2-56ca-4534-a426-648854e61821", 1885, 0 },
                    { "de41e37a-2859-4113-8624-c09bd0ef3fb2", "f6b2b8e8-0bc0-4fc7-a12a-43f88d935fad", "Liebestraum", "44f268c1-3e94-4d05-8ccb-17c2e77b538d", 1850, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "FileId", "GenreIds", "Name" },
                values: new object[,]
                {
                    { "26996074-f474-4fe9-9058-b9fe492018f1", "aa2eb3f8-e71e-46a4-8aa0-fa1424b0016a", "493afb2c-eb2a-4eab-9e4e-6585eb9924ae", new List<string> { "c25c23de-0df1-4eff-af77-e05447b585bd", "90778305-ccce-45eb-bc58-ee3bb35a104a" }, "La Campanella" },
                    { "26b9aaba-780e-4078-b995-c67353fdefb3", "b1be80cc-74b2-4607-ad1f-1b767c651db5", "36febf49-1c49-4b69-8084-73ebce69040a", new List<string> { "c25c23de-0df1-4eff-af77-e05447b585bd", "90778305-ccce-45eb-bc58-ee3bb35a104a" }, "Valse Sentimental" },
                    { "2cd36eb6-6239-4e12-a56d-c63f648c9220", "1adb2fa3-7e9c-4f2a-aec7-459de571b845", "572cc6a2-a5ba-47f5-8819-8330770cf8b5", new List<string> { "76500db7-3eef-424b-a7f4-aac2e2ecaabb" }, "Never gonna give you up" },
                    { "3a5857a8-49d6-4854-942d-736d917e8f25", "1808b0a6-3449-4b89-8b9b-984352b2d531", "4180556e-5365-4b9c-aa72-a47241346855", new List<string> { "c25c23de-0df1-4eff-af77-e05447b585bd", "90778305-ccce-45eb-bc58-ee3bb35a104a" }, "Fantaisie Impromptu" },
                    { "519a3206-33cd-41fb-8f98-5542159f0f4b", "657b04d7-3d14-4c75-a972-acb7fb985179", "4180556e-5365-4b9c-aa72-a47241346855", new List<string> { "c25c23de-0df1-4eff-af77-e05447b585bd", "90778305-ccce-45eb-bc58-ee3bb35a104a" }, "Flight of the Bumblebee" },
                    { "5cf44909-9895-4602-8f21-1b8de5fe99b5", "5b75529c-33ad-4ede-8dfd-229c6118a0d7", "b26e8131-28bf-4ae9-842b-33b3d639b08e", new List<string> { "c25c23de-0df1-4eff-af77-e05447b585bd", "90778305-ccce-45eb-bc58-ee3bb35a104a" }, "Turkish March" },
                    { "6b057b64-211d-4af5-bf12-a200f3bbfdcf", "d57502b0-b0be-471c-8068-c96886ae5e33", "2d47fb0d-971c-44e5-9d76-8b5589f0cbbb", new List<string> { "c25c23de-0df1-4eff-af77-e05447b585bd", "90778305-ccce-45eb-bc58-ee3bb35a104a" }, "Hungarian Rhapsody No. 2" },
                    { "77c4846d-e16d-47a9-ac29-7d6c3b23d6a6", "9f154aa2-2a48-4694-858e-963c63d21d07", "29ad8ca9-c791-4482-8a44-15776862b282", new List<string> { "c25c23de-0df1-4eff-af77-e05447b585bd", "472fe29a-7aef-4ecb-9cee-57e044c0bca6" }, "Waltz No. 2" },
                    { "78db65d8-4176-4e6c-a588-e97ca15dc532", "51b01e4a-f2d1-4310-9b87-e319d4220810", "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb", new List<string> { "c25c23de-0df1-4eff-af77-e05447b585bd", "90778305-ccce-45eb-bc58-ee3bb35a104a" }, "Moonlight Sonata" },
                    { "9bdd1b97-4d63-4b06-a36e-10ba276bf34d", "2c9afde7-00a2-47c7-9f89-21e81d2059a2", "15fa89e4-7777-4330-b32e-62172cd398c0", new List<string> { "f19d2442-1868-4e2b-a1f8-5b015e778f5b", "90778305-ccce-45eb-bc58-ee3bb35a104a" }, "Marriage d'Amour" },
                    { "a0c4cf5e-67ec-45b1-8e65-d5399b5c6629", "de41e37a-2859-4113-8624-c09bd0ef3fb2", "44f268c1-3e94-4d05-8ccb-17c2e77b538d", new List<string> { "c25c23de-0df1-4eff-af77-e05447b585bd", "90778305-ccce-45eb-bc58-ee3bb35a104a" }, "Love Dream" },
                    { "abda8157-5448-42b6-858f-4e4d8acdb9e3", "841f37bb-28b8-46f4-84c5-b298202cf181", "15fa89e4-7777-4330-b32e-62172cd398c0", new List<string> { "c25c23de-0df1-4eff-af77-e05447b585bd", "90778305-ccce-45eb-bc58-ee3bb35a104a" }, "Marriage of Figaro - Overture" },
                    { "bf17dffa-46a4-4a9b-a7b3-2992eb83039a", "9b3eb542-b5a0-4e97-aab5-36f21b7b5bfa", "864239f6-65c5-440f-8326-213b3b25693f", new List<string> { "c25c23de-0df1-4eff-af77-e05447b585bd", "90778305-ccce-45eb-bc58-ee3bb35a104a" }, "La Campanella" },
                    { "d331ee95-fdce-4402-a829-53a66394f456", "4525ec0d-82ae-421f-a397-080d54fe12a9", "9d0a67df-6fb4-4fac-b670-49a5f590beb7", new List<string> { "c25c23de-0df1-4eff-af77-e05447b585bd" }, "Lacrimosa" },
                    { "dee1941f-52aa-4637-92e0-5c5cc10f2576", "ce4263ad-20f4-42f1-9d69-7decfb2a783c", "7c561b1e-3070-4e83-b71a-2fd7a69fa040", new List<string> { "c25c23de-0df1-4eff-af77-e05447b585bd", "90778305-ccce-45eb-bc58-ee3bb35a104a" }, "Summer - Storm" },
                    { "f0c6893d-8aa3-4def-aba8-9f760a466ce7", "ce4263ad-20f4-42f1-9d69-7decfb2a783c", "9f1d7cfd-53c6-478f-82e2-db737d1b9ecf", new List<string> { "c25c23de-0df1-4eff-af77-e05447b585bd", "90778305-ccce-45eb-bc58-ee3bb35a104a" }, "Spring" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "472fe29a-7aef-4ecb-9cee-57e044c0bca6");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "76500db7-3eef-424b-a7f4-aac2e2ecaabb");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "90778305-ccce-45eb-bc58-ee3bb35a104a");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "c25c23de-0df1-4eff-af77-e05447b585bd");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "f19d2442-1868-4e2b-a1f8-5b015e778f5b");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "26996074-f474-4fe9-9058-b9fe492018f1");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "26b9aaba-780e-4078-b995-c67353fdefb3");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "2cd36eb6-6239-4e12-a56d-c63f648c9220");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "3a5857a8-49d6-4854-942d-736d917e8f25");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "519a3206-33cd-41fb-8f98-5542159f0f4b");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "5cf44909-9895-4602-8f21-1b8de5fe99b5");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "6b057b64-211d-4af5-bf12-a200f3bbfdcf");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "77c4846d-e16d-47a9-ac29-7d6c3b23d6a6");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "78db65d8-4176-4e6c-a588-e97ca15dc532");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "9bdd1b97-4d63-4b06-a36e-10ba276bf34d");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "a0c4cf5e-67ec-45b1-8e65-d5399b5c6629");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "abda8157-5448-42b6-858f-4e4d8acdb9e3");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "bf17dffa-46a4-4a9b-a7b3-2992eb83039a");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "d331ee95-fdce-4402-a829-53a66394f456");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "dee1941f-52aa-4637-92e0-5c5cc10f2576");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "f0c6893d-8aa3-4def-aba8-9f760a466ce7");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "1808b0a6-3449-4b89-8b9b-984352b2d531");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "1adb2fa3-7e9c-4f2a-aec7-459de571b845");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "2c9afde7-00a2-47c7-9f89-21e81d2059a2");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "4525ec0d-82ae-421f-a397-080d54fe12a9");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "51b01e4a-f2d1-4310-9b87-e319d4220810");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "5b75529c-33ad-4ede-8dfd-229c6118a0d7");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "657b04d7-3d14-4c75-a972-acb7fb985179");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "841f37bb-28b8-46f4-84c5-b298202cf181");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "9b3eb542-b5a0-4e97-aab5-36f21b7b5bfa");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "9f154aa2-2a48-4694-858e-963c63d21d07");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "aa2eb3f8-e71e-46a4-8aa0-fa1424b0016a");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "b1be80cc-74b2-4607-ad1f-1b767c651db5");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "ce4263ad-20f4-42f1-9d69-7decfb2a783c");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "d57502b0-b0be-471c-8068-c96886ae5e33");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "de41e37a-2859-4113-8624-c09bd0ef3fb2");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "2a47bc3f-d0a9-484f-a6a9-c5ad50cfae4b");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "2b9f02ca-1333-4541-96a0-8ffc8eef999a");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "866a3a04-9b5b-42b6-84fe-2fbc6c29dfe0");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "8f015e90-2ee1-4c16-9ecc-d0b0e92e9eed");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "94cb5113-f1e5-455c-a2e6-08f585d67d8a");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "98be3aee-202c-47c6-817d-4178ba0623f5");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "b24e0d80-4cf1-4f25-b4fc-efe6359b52cc");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "ba2e98ce-28ab-4c0a-9424-09e824c4eeca");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "bc974f7a-f548-41a3-88fe-4e9fdc342e37");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "ec81dc60-7de8-4dbe-bab3-6210ba36274a");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "f6b2b8e8-0bc0-4fc7-a12a-43f88d935fad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b735957-adbc-4a8e-945c-4c4cd60548a4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f857633-e653-4834-80f8-f032153bf42a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1fc91802-e1b7-4b07-8ffb-9a4609dca83d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "281e5b90-9649-4e66-bf01-8c80e5bb2d01");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ca180d5-f153-41a3-a1c6-c80bf4a77830");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3498a7c1-d79f-46a9-bedc-0bb5adde22e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52880029-38d5-4967-a1ca-bb16439b887f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f1166ab-1d18-4243-806c-da8c296c5306");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94df1be8-7ef4-4029-93b3-2f7ce724981c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac593f00-1e1f-41d5-941c-1164620effe2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d454763e-9d83-4772-bcb3-731e39c09e14");

            migrationBuilder.DropColumn(
                name: "GenreIds",
                table: "Tracks");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "11b59229-3476-4583-8ea2-f2e87add103d", 0, "fa392474-1498-46bc-b66d-4ad7ca6b5576", "", false, false, null, "Wolfgang Amadeus Mozart", null, null, null, null, false, 0, "79bae437-cb62-4358-8a80-77faf7ecba76", false, "mozart" },
                    { "73267a2e-0679-44fa-99ea-05a728fd48de", 0, "163a3073-4aa4-420d-8e2e-d7e77b87d96f", "", false, false, null, "Antonio Lucio Vivaldi", null, null, null, null, false, 0, "9188a1f2-d77f-4052-aeb3-e726e3a5e51f", false, "vivaldi" },
                    { "748163e5-fc61-4b48-a0f2-da4e2bd9045d", 0, "a0cfb751-e15b-4d0c-b5bc-b8fe4d5bb553", "", false, false, null, "Pyotr Tchaikovsky", null, null, null, null, false, 0, "fcad1a71-7f4c-4b4c-956a-bee7ffba5961", false, "tchaikovsky" },
                    { "784a06fb-f7e9-4f6a-9509-858b329d5f89", 0, "cea63bba-31ed-469a-8573-9094012cc495", "", false, false, null, "Franz Liszt", null, null, null, null, false, 0, "0382a7d5-cc3f-4b5c-a172-b8b8c89e4b03", false, "liszt" },
                    { "7a56cedd-8ee6-40e0-b821-965fc1597805", 0, "d8da9002-4efa-4204-a967-55a748d628de", "", false, false, null, "Paul de Senneville", null, null, null, null, false, 0, "19944d90-5ea4-4bc3-a109-81e2e01748e5", false, "senneville" },
                    { "80bf3d52-1d8f-49e0-a0ea-ca9b32fb66e4", 0, "f332eb42-e557-4594-a48e-d75ed5daf3d7", "", false, false, null, "Ludwig van Beethoven", null, null, null, null, false, 0, "265c77da-6e50-4847-8e14-39194f70d9f4", false, "beethoven" },
                    { "84eda8c2-e662-4818-8f78-906da314e229", 0, "93a9f503-76c7-411f-8828-fb321270548b", "", false, false, null, "Dmitri Shostakovich", null, null, null, null, false, 0, "5a3b048a-95aa-4788-899f-3d7e28b3c876", false, "shostakovich" },
                    { "b1444438-d3a0-46ac-a9f0-3b011c059f8b", 0, "0c5b9dcd-1586-4242-91cc-501857d0a17a", "", false, false, null, "Nikolai Rimsky-Korsakov", null, null, null, null, false, 0, "142f47a4-ad84-40d6-830c-dea0dad22e89", false, "rimsky-korsakov" },
                    { "ba77df09-85c5-4a6d-bf2d-00a984b6a5e6", 0, "9d8d4969-3e29-4bea-8077-4899c2cb33ee", "", false, false, null, "Niccolò Paganini", null, null, null, null, false, 0, "4def6d4c-70d1-4734-9cd1-348fe5ec81ab", false, "paganini" },
                    { "dc56ddae-71fd-4857-a7f3-36c81cac2d7b", 0, "58745179-6ee1-4739-9d2c-ddf7016b78d9", "", false, false, null, "Frédéric Chopin", null, null, null, null, false, 0, "edb739d3-8bec-442b-86c2-da9e170fbb2e", false, "chopin" },
                    { "ea1bc22e-c88d-4b19-93f8-596f014f3eea", 0, "9d7bc84b-edf2-4444-8536-12cf410dc56d", "", false, false, null, "Rick Astley", null, null, null, null, false, 0, "6692d726-5dc2-4ad6-83b5-04f7a918336f", false, "astley" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "046b8651-b7d2-4201-a867-4c8599da8180", "New Age" },
                    { "46c47b5c-fbca-4b84-8797-d19c376dfdd9", "Pop" },
                    { "95392dc3-7240-46cb-b565-f44efe81069d", "Jazz" },
                    { "9f78eadf-f234-4852-a196-6c26c75110fc", "Classic" },
                    { "b75549f2-9226-455b-9a6c-3832a582b944", "Instrumental" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[,]
                {
                    { "092cfbee-eaea-4535-b532-32e277a663ac", "Wolfgang Amadeus Mozart", "11b59229-3476-4583-8ea2-f2e87add103d" },
                    { "0cefd1bc-75e0-4c31-b2af-d024f3038116", "Frédéric Chopin", "dc56ddae-71fd-4857-a7f3-36c81cac2d7b" },
                    { "19f36b25-181d-4b1f-9669-efee805b14af", "Antonio Lucio Vivaldi", "73267a2e-0679-44fa-99ea-05a728fd48de" },
                    { "811baf1d-17a0-4ebf-b56f-86cd840740bc", "Franz Liszt", "784a06fb-f7e9-4f6a-9509-858b329d5f89" },
                    { "826a0449-2e0f-4efd-8100-5e8f7507289d", "Pyotr Tchaikovsky", "748163e5-fc61-4b48-a0f2-da4e2bd9045d" },
                    { "91440e02-1405-46d3-85d4-2bfbe7c815f2", "Nikolai Rimsky-Korsakov", "b1444438-d3a0-46ac-a9f0-3b011c059f8b" },
                    { "b8f103a1-f080-496b-b94d-4ff8e0fa5387", "Rick Astley", "ea1bc22e-c88d-4b19-93f8-596f014f3eea" },
                    { "c2b13e92-03f2-4b6c-9f23-e5ff3ff160a8", "Paul de Senneville", "7a56cedd-8ee6-40e0-b821-965fc1597805" },
                    { "cf87b627-49f7-4950-92cc-35bc0e6f2f30", "Niccolò Paganini", "ba77df09-85c5-4a6d-bf2d-00a984b6a5e6" },
                    { "e1c6cdaf-804e-4d68-942c-b9bd2ebc7ebc", "Ludwig van Beethoven", "80bf3d52-1d8f-49e0-a0ea-ca9b32fb66e4" },
                    { "f628a58c-8c61-43f9-ad82-c67111aabb3d", "Dmitri Shostakovich", "84eda8c2-e662-4818-8f78-906da314e229" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AuthorId", "Name", "PreviewId", "ReleaseYear", "Type" },
                values: new object[,]
                {
                    { "16d30176-62cf-4adc-8326-d21ceb357f83", "811baf1d-17a0-4ebf-b56f-86cd840740bc", "Liebestraum", "44f268c1-3e94-4d05-8ccb-17c2e77b538d", 1850, 0 },
                    { "19cdb547-aa3c-4cc1-aa74-c0b78080f9a4", "092cfbee-eaea-4535-b532-32e277a663ac", "Piano Sonata No. 11", "b26e8131-28bf-4ae9-842b-33b3d639b08e", 1784, 0 },
                    { "239a237a-e8a9-49af-b54b-3d5a67b96a0f", "91440e02-1405-46d3-85d4-2bfbe7c815f2", "The Tale of Tsar Saltan", "cdbc9b43-ee1b-4a64-8b2d-d579522ea84f", 1900, 0 },
                    { "46ba9a91-d55e-41cd-a0fa-28b03875e228", "cf87b627-49f7-4950-92cc-35bc0e6f2f30", "Violin Concerto No. 2", "493afb2c-eb2a-4eab-9e4e-6585eb9924ae", 1826, 0 },
                    { "4aa4a09b-5c6e-4671-9d8e-3a37aae64e86", "092cfbee-eaea-4535-b532-32e277a663ac", "The marriage of Figaro", "15fa89e4-7777-4330-b32e-62172cd398c0", 1786, 0 },
                    { "59024c6d-f7c6-4a50-8759-d9828b24bcff", "826a0449-2e0f-4efd-8100-5e8f7507289d", "Valse-Scherzo", "36febf49-1c49-4b69-8084-73ebce69040a", 1877, 0 },
                    { "59486912-6136-4854-815f-b41d32118b68", "811baf1d-17a0-4ebf-b56f-86cd840740bc", "Grandes études de Paganini", "864239f6-65c5-440f-8326-213b3b25693f", 1851, 0 },
                    { "5b565a0a-200a-4512-a9bd-641a139b57be", "092cfbee-eaea-4535-b532-32e277a663ac", "Requiem", "9d0a67df-6fb4-4fac-b670-49a5f590beb7", 1791, 0 },
                    { "70367f69-9f2b-43ed-b474-caa66b315496", "c2b13e92-03f2-4b6c-9f23-e5ff3ff160a8", "Lettre à ma mère", "5a9ba216-9883-471d-9c0f-4c3d37e4ec34", 1979, 0 },
                    { "aa7cdf89-f17e-498c-bd57-aca88eb2dc15", "e1c6cdaf-804e-4d68-942c-b9bd2ebc7ebc", "Moonlight Sonata", "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb", 1802, 1 },
                    { "b995419f-77ee-464c-9337-1256f1b1308f", "19f36b25-181d-4b1f-9669-efee805b14af", "The Four Seasons", "7c561b1e-3070-4e83-b71a-2fd7a69fa040", 1725, 0 },
                    { "baddddc9-2836-42b0-bda7-5af383d69b7d", "b8f103a1-f080-496b-b94d-4ff8e0fa5387", "Whenever you need somebody", "572cc6a2-a5ba-47f5-8819-8330770cf8b5", 1987, 0 },
                    { "c4bf9a82-7d3a-427c-ad1a-f3467810eb0d", "0cefd1bc-75e0-4c31-b2af-d024f3038116", "Fantaisie-Impromptu", "4180556e-5365-4b9c-aa72-a47241346855", 1834, 1 },
                    { "da972e20-bead-4684-8a2e-2dc856ef3b63", "811baf1d-17a0-4ebf-b56f-86cd840740bc", "Hungarian Rhapsodies", "0a8c3ca2-56ca-4534-a426-648854e61821", 1885, 0 },
                    { "e13b330a-8550-4856-9f2c-750a716f001a", "f628a58c-8c61-43f9-ad82-c67111aabb3d", "Waltz No. 2", "29ad8ca9-c791-4482-8a44-15776862b282", 1938, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "FileId", "Name" },
                values: new object[,]
                {
                    { "33e8f315-5c48-45ee-a7b3-9081702d35e2", "e13b330a-8550-4856-9f2c-750a716f001a", "29ad8ca9-c791-4482-8a44-15776862b282", "Waltz No. 2" },
                    { "3be1a0c7-ce95-4d87-b2e2-655372a07b19", "16d30176-62cf-4adc-8326-d21ceb357f83", "44f268c1-3e94-4d05-8ccb-17c2e77b538d", "Love Dream" },
                    { "6689e3a6-0564-4505-ba0d-a490162d7286", "b995419f-77ee-464c-9337-1256f1b1308f", "7c561b1e-3070-4e83-b71a-2fd7a69fa040", "Summer - Storm" },
                    { "6dbe1fcf-8707-4a4f-b807-a5e9467e668f", "aa7cdf89-f17e-498c-bd57-aca88eb2dc15", "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb", "Moonlight Sonata" },
                    { "7140b053-2540-448f-994c-7642fee5074a", "239a237a-e8a9-49af-b54b-3d5a67b96a0f", "4180556e-5365-4b9c-aa72-a47241346855", "Flight of the Bumblebee" },
                    { "88e47cf7-8a3e-4ea1-be87-4aa491dcca5d", "5b565a0a-200a-4512-a9bd-641a139b57be", "9d0a67df-6fb4-4fac-b670-49a5f590beb7", "Lacrimosa" },
                    { "9b2c6266-b7cf-4753-9d34-8d6e19ae7b4d", "46ba9a91-d55e-41cd-a0fa-28b03875e228", "493afb2c-eb2a-4eab-9e4e-6585eb9924ae", "La Campanella" },
                    { "a974a77a-2fff-4efa-acbc-faa27c329a59", "59486912-6136-4854-815f-b41d32118b68", "864239f6-65c5-440f-8326-213b3b25693f", "La Campanella" },
                    { "af8788c1-b041-497f-9c3c-388d56a96f3c", "4aa4a09b-5c6e-4671-9d8e-3a37aae64e86", "15fa89e4-7777-4330-b32e-62172cd398c0", "Marriage of Figaro - Overture" },
                    { "b38a088f-96a9-4cf2-b23c-fc2d8987b787", "70367f69-9f2b-43ed-b474-caa66b315496", "15fa89e4-7777-4330-b32e-62172cd398c0", "Marriage d'Amour" },
                    { "bed643d4-8323-4ecd-bec9-d20a1fdf20e1", "59024c6d-f7c6-4a50-8759-d9828b24bcff", "36febf49-1c49-4b69-8084-73ebce69040a", "Valse Sentimental" },
                    { "cf896c1f-577f-4408-ada3-cb8988b5dc17", "c4bf9a82-7d3a-427c-ad1a-f3467810eb0d", "4180556e-5365-4b9c-aa72-a47241346855", "Fantaisie Impromptu" },
                    { "f22d90df-b5b4-49f9-986d-da3b168ce00e", "19cdb547-aa3c-4cc1-aa74-c0b78080f9a4", "b26e8131-28bf-4ae9-842b-33b3d639b08e", "Turkish March" },
                    { "f60ac6a5-d96a-487c-b989-1cf581740be6", "baddddc9-2836-42b0-bda7-5af383d69b7d", "572cc6a2-a5ba-47f5-8819-8330770cf8b5", "Never gonna give you up" },
                    { "f7781ad9-532e-4724-ae80-60f340b81a28", "b995419f-77ee-464c-9337-1256f1b1308f", "9f1d7cfd-53c6-478f-82e2-db737d1b9ecf", "Spring" },
                    { "fcf0eb6e-3432-4827-bb55-ce62d5815083", "da972e20-bead-4684-8a2e-2dc856ef3b63", "2d47fb0d-971c-44e5-9d76-8b5589f0cbbb", "Hungarian Rhapsody No. 2" }
                });
        }
    }
}
