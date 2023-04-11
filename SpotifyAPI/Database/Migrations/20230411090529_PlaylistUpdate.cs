using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class PlaylistUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "07d61508-81ed-407f-bad4-f174d5bd6c6b");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "3f77186e-d17a-494f-9d09-97800bd4bf13");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "eacfbc05-916a-40bd-8dcd-cde617809889");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "f17d84ce-6469-4aa8-be38-af5824e20251");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "f8bef1e2-f319-42b5-add2-74bac63cc8d8");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "1424871f-5288-44c8-9f8c-23a37eb30a08");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "2a9d0aef-72a9-476b-a205-576dfd8d22e5");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "2cd900d8-247c-43a4-9785-71ff8233dc36");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "41ec0bc5-0e18-4d29-bad5-c0ed1bab2b5a");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "50d69e0c-d42b-41a9-9190-2db74a045310");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "55eddeb2-08b2-4ec0-bdb6-e7dd8ed6894d");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "670ee60d-6d82-49dd-96c1-91fe952e838d");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "6ffbfa47-bd61-4119-a795-7c57abb8da38");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "7b48fb6a-72bd-4879-ade4-f6bcc49122be");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "83fd9d41-cef3-4525-8b8b-79e4a747ae49");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "84c27b56-8acc-4a7b-8393-425f7a176f5e");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "baa8ad77-a427-4167-b833-f83743cfa509");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "dc897690-3cb4-4d8b-b9e5-d38f2280f977");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "ee324949-8fd7-45c3-9671-621285745083");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "f03c8e7c-9810-4d7f-ba5c-0f56f988692d");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "fd2efa06-8bbe-4347-b37c-daaf274030c8");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "024e54cc-ea66-46bc-8a72-543e876c4b0e");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "1f860290-a43c-4259-af14-cade2803ecc5");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "25097b5e-b6c9-43a7-b414-ee1f3b34c967");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "31285c3e-faa9-4102-95f6-ba7ea0c73499");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "4bd78fad-e877-4eb5-af51-7ad51cba7cf4");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "6004f73f-24f3-4ee2-891f-c273fec9a7fb");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "640c8d09-e490-4168-b583-f8b7a0371a14");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "6c71ddc7-99bd-4f52-927f-a7fe484b81f4");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "707bbd8c-e1b2-46d5-b26f-e159f4cbadd1");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "90dae04f-ebb7-4b10-99c5-b128d3892db1");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "a67c3903-49d4-45eb-ae48-da70bff46750");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "bbbc51c3-86fe-4ba5-b832-e54488b44031");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "c451ab41-143c-4264-bdd9-5f36b2d9cb2c");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "c8eabf33-6683-44c9-b650-fc91c65cd5a5");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "e601298e-b442-44c1-8db2-edee0a3d88ee");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "0fbecaf3-2ffc-4764-bcae-673a9ce80728");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "5bc871d2-a0cb-4ef2-b277-a75907efbad7");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "6ab5f033-6eda-45e9-a889-17094797a6b4");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "7c2f4604-c265-469f-9233-daa5f2144291");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "a4e4d550-8d6d-41c3-83f6-30b7b733db2f");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "a7a62662-bcd7-4139-9583-1d7bd01c2817");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "b47db1d1-ffc4-4fe6-8b72-b23566fec5f3");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "ddf5c16d-dbc9-484a-a2ca-d5e57ec9651a");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "e86f359c-cdcb-4c79-91b0-b1946a80725e");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "eee983b0-d055-4ee0-876e-3c5ddf07a3af");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "fdccb59b-5fd7-4681-b512-2562c1c45ed9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "024e188a-0973-46b8-beb4-9ef04c4308c9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2863173a-a2c0-431b-b1fa-46215c4499b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "289a34e5-3cc1-4778-9497-373faa01cb26");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d3d3acf-89ee-4aec-b93c-d85e4023b576");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46e5bb17-b9ca-4ff0-8933-caef9293bbd0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5035e219-ff1e-4c59-a0d8-4402c070f3cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53b6e292-6a58-4fec-bfd8-eab933e8c765");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "738c53fb-48b6-4e0b-8095-1dce9b922e43");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "892aeaf4-133e-4f22-afa7-e7e7c7ae2a8c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aefbbdf1-0a14-4fd2-b166-58adcc3ef163");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce704991-4644-41c8-9ec4-1a3a4707972f");

            migrationBuilder.AddColumn<string>(
                name: "PreviewId",
                table: "Playlists",
                type: "text",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "PreviewId",
                table: "Playlists");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "024e188a-0973-46b8-beb4-9ef04c4308c9", 0, "d1ea8c40-13a9-47f4-aed5-09608dba6917", "", false, false, null, "Frédéric Chopin", null, null, null, null, false, 0, "5d58440f-2c9c-4406-82c3-9c715931c0ca", false, "chopin" },
                    { "2863173a-a2c0-431b-b1fa-46215c4499b1", 0, "79ea96fe-4333-44aa-9081-2d3c5c33e4d1", "", false, false, null, "Nikolai Rimsky-Korsakov", null, null, null, null, false, 0, "bced2c4e-4a70-42e3-8d39-b84a2b3b5b5d", false, "rimsky-korsakov" },
                    { "289a34e5-3cc1-4778-9497-373faa01cb26", 0, "ac68d594-6236-44b7-9c0c-5f752dafa9c2", "", false, false, null, "Niccolò Paganini", null, null, null, null, false, 0, "ce9ac26b-4d19-4f94-9372-142b57975fa9", false, "paganini" },
                    { "2d3d3acf-89ee-4aec-b93c-d85e4023b576", 0, "a5813d93-e05f-4996-82b2-41d8d2170258", "", false, false, null, "Ludwig van Beethoven", null, null, null, null, false, 0, "18defe03-7ff5-48b0-9548-74d6202f3305", false, "beethoven" },
                    { "46e5bb17-b9ca-4ff0-8933-caef9293bbd0", 0, "8bae5fd9-8273-4c60-934b-d1aec5ced422", "", false, false, null, "Rick Astley", null, null, null, null, false, 0, "c89ccad2-dd62-4ecf-90f4-0b546dbc9835", false, "astley" },
                    { "5035e219-ff1e-4c59-a0d8-4402c070f3cd", 0, "fd8e5958-55de-4eca-8c9a-7b062b390a91", "", false, false, null, "Antonio Lucio Vivaldi", null, null, null, null, false, 0, "daf611a7-8fb6-479e-93bc-6c868b40f25e", false, "vivaldi" },
                    { "53b6e292-6a58-4fec-bfd8-eab933e8c765", 0, "b7755c69-d694-4610-8421-63c1c13ec7b1", "", false, false, null, "Pyotr Tchaikovsky", null, null, null, null, false, 0, "88a8a550-25e9-4ada-be7c-56e9317b7313", false, "tchaikovsky" },
                    { "738c53fb-48b6-4e0b-8095-1dce9b922e43", 0, "46d2643a-c5ed-47e9-b8db-a349efde2c30", "", false, false, null, "Wolfgang Amadeus Mozart", null, null, null, null, false, 0, "92d4de25-b01a-4c20-b684-fb2751b0d69f", false, "mozart" },
                    { "892aeaf4-133e-4f22-afa7-e7e7c7ae2a8c", 0, "834b2e27-f66a-47f8-bc49-0496b95465e0", "", false, false, null, "Paul de Senneville", null, null, null, null, false, 0, "6e5835ea-a282-4687-a95b-660f1df77c15", false, "senneville" },
                    { "aefbbdf1-0a14-4fd2-b166-58adcc3ef163", 0, "d2a22672-f0e6-43ff-9967-fed75fdfd751", "", false, false, null, "Dmitri Shostakovich", null, null, null, null, false, 0, "b0e36524-eb1f-4641-be54-3caf0035e426", false, "shostakovich" },
                    { "ce704991-4644-41c8-9ec4-1a3a4707972f", 0, "66ad81dd-c195-4362-b934-efcfdf36264c", "", false, false, null, "Franz Liszt", null, null, null, null, false, 0, "216c4fcf-9b35-476e-b99e-a34a981241ba", false, "liszt" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "07d61508-81ed-407f-bad4-f174d5bd6c6b", "Pop" },
                    { "3f77186e-d17a-494f-9d09-97800bd4bf13", "New Age" },
                    { "eacfbc05-916a-40bd-8dcd-cde617809889", "Jazz" },
                    { "f17d84ce-6469-4aa8-be38-af5824e20251", "Classic" },
                    { "f8bef1e2-f319-42b5-add2-74bac63cc8d8", "Instrumental" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[,]
                {
                    { "0fbecaf3-2ffc-4764-bcae-673a9ce80728", "Dmitri Shostakovich", "aefbbdf1-0a14-4fd2-b166-58adcc3ef163" },
                    { "5bc871d2-a0cb-4ef2-b277-a75907efbad7", "Franz Liszt", "ce704991-4644-41c8-9ec4-1a3a4707972f" },
                    { "6ab5f033-6eda-45e9-a889-17094797a6b4", "Frédéric Chopin", "024e188a-0973-46b8-beb4-9ef04c4308c9" },
                    { "7c2f4604-c265-469f-9233-daa5f2144291", "Antonio Lucio Vivaldi", "5035e219-ff1e-4c59-a0d8-4402c070f3cd" },
                    { "a4e4d550-8d6d-41c3-83f6-30b7b733db2f", "Ludwig van Beethoven", "2d3d3acf-89ee-4aec-b93c-d85e4023b576" },
                    { "a7a62662-bcd7-4139-9583-1d7bd01c2817", "Rick Astley", "46e5bb17-b9ca-4ff0-8933-caef9293bbd0" },
                    { "b47db1d1-ffc4-4fe6-8b72-b23566fec5f3", "Wolfgang Amadeus Mozart", "738c53fb-48b6-4e0b-8095-1dce9b922e43" },
                    { "ddf5c16d-dbc9-484a-a2ca-d5e57ec9651a", "Pyotr Tchaikovsky", "53b6e292-6a58-4fec-bfd8-eab933e8c765" },
                    { "e86f359c-cdcb-4c79-91b0-b1946a80725e", "Paul de Senneville", "892aeaf4-133e-4f22-afa7-e7e7c7ae2a8c" },
                    { "eee983b0-d055-4ee0-876e-3c5ddf07a3af", "Niccolò Paganini", "289a34e5-3cc1-4778-9497-373faa01cb26" },
                    { "fdccb59b-5fd7-4681-b512-2562c1c45ed9", "Nikolai Rimsky-Korsakov", "2863173a-a2c0-431b-b1fa-46215c4499b1" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AuthorId", "Name", "PreviewId", "ReleaseYear", "Type" },
                values: new object[,]
                {
                    { "024e54cc-ea66-46bc-8a72-543e876c4b0e", "fdccb59b-5fd7-4681-b512-2562c1c45ed9", "The Tale of Tsar Saltan", "cdbc9b43-ee1b-4a64-8b2d-d579522ea84f", 1900, 0 },
                    { "1f860290-a43c-4259-af14-cade2803ecc5", "b47db1d1-ffc4-4fe6-8b72-b23566fec5f3", "Piano Sonata No. 11", "b26e8131-28bf-4ae9-842b-33b3d639b08e", 1784, 0 },
                    { "25097b5e-b6c9-43a7-b414-ee1f3b34c967", "b47db1d1-ffc4-4fe6-8b72-b23566fec5f3", "The marriage of Figaro", "15fa89e4-7777-4330-b32e-62172cd398c0", 1786, 0 },
                    { "31285c3e-faa9-4102-95f6-ba7ea0c73499", "ddf5c16d-dbc9-484a-a2ca-d5e57ec9651a", "Valse-Scherzo", "36febf49-1c49-4b69-8084-73ebce69040a", 1877, 0 },
                    { "4bd78fad-e877-4eb5-af51-7ad51cba7cf4", "0fbecaf3-2ffc-4764-bcae-673a9ce80728", "Waltz No. 2", "29ad8ca9-c791-4482-8a44-15776862b282", 1938, 1 },
                    { "6004f73f-24f3-4ee2-891f-c273fec9a7fb", "7c2f4604-c265-469f-9233-daa5f2144291", "The Four Seasons", "7c561b1e-3070-4e83-b71a-2fd7a69fa040", 1725, 0 },
                    { "640c8d09-e490-4168-b583-f8b7a0371a14", "5bc871d2-a0cb-4ef2-b277-a75907efbad7", "Grandes études de Paganini", "864239f6-65c5-440f-8326-213b3b25693f", 1851, 0 },
                    { "6c71ddc7-99bd-4f52-927f-a7fe484b81f4", "a4e4d550-8d6d-41c3-83f6-30b7b733db2f", "Moonlight Sonata", "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb", 1802, 1 },
                    { "707bbd8c-e1b2-46d5-b26f-e159f4cbadd1", "5bc871d2-a0cb-4ef2-b277-a75907efbad7", "Hungarian Rhapsodies", "0a8c3ca2-56ca-4534-a426-648854e61821", 1885, 0 },
                    { "90dae04f-ebb7-4b10-99c5-b128d3892db1", "eee983b0-d055-4ee0-876e-3c5ddf07a3af", "Violin Concerto No. 2", "493afb2c-eb2a-4eab-9e4e-6585eb9924ae", 1826, 0 },
                    { "a67c3903-49d4-45eb-ae48-da70bff46750", "5bc871d2-a0cb-4ef2-b277-a75907efbad7", "Liebestraum", "44f268c1-3e94-4d05-8ccb-17c2e77b538d", 1850, 0 },
                    { "bbbc51c3-86fe-4ba5-b832-e54488b44031", "e86f359c-cdcb-4c79-91b0-b1946a80725e", "Lettre à ma mère", "5a9ba216-9883-471d-9c0f-4c3d37e4ec34", 1979, 0 },
                    { "c451ab41-143c-4264-bdd9-5f36b2d9cb2c", "a7a62662-bcd7-4139-9583-1d7bd01c2817", "Whenever you need somebody", "572cc6a2-a5ba-47f5-8819-8330770cf8b5", 1987, 0 },
                    { "c8eabf33-6683-44c9-b650-fc91c65cd5a5", "b47db1d1-ffc4-4fe6-8b72-b23566fec5f3", "Requiem", "9d0a67df-6fb4-4fac-b670-49a5f590beb7", 1791, 0 },
                    { "e601298e-b442-44c1-8db2-edee0a3d88ee", "6ab5f033-6eda-45e9-a889-17094797a6b4", "Fantaisie-Impromptu", "4180556e-5365-4b9c-aa72-a47241346855", 1834, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "FileId", "Name" },
                values: new object[,]
                {
                    { "1424871f-5288-44c8-9f8c-23a37eb30a08", "6004f73f-24f3-4ee2-891f-c273fec9a7fb", "9f1d7cfd-53c6-478f-82e2-db737d1b9ecf", "Spring" },
                    { "2a9d0aef-72a9-476b-a205-576dfd8d22e5", "bbbc51c3-86fe-4ba5-b832-e54488b44031", "15fa89e4-7777-4330-b32e-62172cd398c0", "Marriage d'Amour" },
                    { "2cd900d8-247c-43a4-9785-71ff8233dc36", "6c71ddc7-99bd-4f52-927f-a7fe484b81f4", "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb", "Moonlight Sonata" },
                    { "41ec0bc5-0e18-4d29-bad5-c0ed1bab2b5a", "4bd78fad-e877-4eb5-af51-7ad51cba7cf4", "29ad8ca9-c791-4482-8a44-15776862b282", "Waltz No. 2" },
                    { "50d69e0c-d42b-41a9-9190-2db74a045310", "25097b5e-b6c9-43a7-b414-ee1f3b34c967", "15fa89e4-7777-4330-b32e-62172cd398c0", "Marriage of Figaro - Overture" },
                    { "55eddeb2-08b2-4ec0-bdb6-e7dd8ed6894d", "707bbd8c-e1b2-46d5-b26f-e159f4cbadd1", "2d47fb0d-971c-44e5-9d76-8b5589f0cbbb", "Hungarian Rhapsody No. 2" },
                    { "670ee60d-6d82-49dd-96c1-91fe952e838d", "c8eabf33-6683-44c9-b650-fc91c65cd5a5", "9d0a67df-6fb4-4fac-b670-49a5f590beb7", "Lacrimosa" },
                    { "6ffbfa47-bd61-4119-a795-7c57abb8da38", "640c8d09-e490-4168-b583-f8b7a0371a14", "864239f6-65c5-440f-8326-213b3b25693f", "La Campanella" },
                    { "7b48fb6a-72bd-4879-ade4-f6bcc49122be", "31285c3e-faa9-4102-95f6-ba7ea0c73499", "36febf49-1c49-4b69-8084-73ebce69040a", "Valse Sentimental" },
                    { "83fd9d41-cef3-4525-8b8b-79e4a747ae49", "a67c3903-49d4-45eb-ae48-da70bff46750", "44f268c1-3e94-4d05-8ccb-17c2e77b538d", "Love Dream" },
                    { "84c27b56-8acc-4a7b-8393-425f7a176f5e", "024e54cc-ea66-46bc-8a72-543e876c4b0e", "4180556e-5365-4b9c-aa72-a47241346855", "Flight of the Bumblebee" },
                    { "baa8ad77-a427-4167-b833-f83743cfa509", "1f860290-a43c-4259-af14-cade2803ecc5", "b26e8131-28bf-4ae9-842b-33b3d639b08e", "Turkish March" },
                    { "dc897690-3cb4-4d8b-b9e5-d38f2280f977", "6004f73f-24f3-4ee2-891f-c273fec9a7fb", "7c561b1e-3070-4e83-b71a-2fd7a69fa040", "Summer - Storm" },
                    { "ee324949-8fd7-45c3-9671-621285745083", "c451ab41-143c-4264-bdd9-5f36b2d9cb2c", "572cc6a2-a5ba-47f5-8819-8330770cf8b5", "Never gonna give you up" },
                    { "f03c8e7c-9810-4d7f-ba5c-0f56f988692d", "90dae04f-ebb7-4b10-99c5-b128d3892db1", "493afb2c-eb2a-4eab-9e4e-6585eb9924ae", "La Campanella" },
                    { "fd2efa06-8bbe-4347-b37c-daaf274030c8", "e601298e-b442-44c1-8db2-edee0a3d88ee", "4180556e-5365-4b9c-aa72-a47241346855", "Fantaisie Impromptu" }
                });
        }
    }
}
