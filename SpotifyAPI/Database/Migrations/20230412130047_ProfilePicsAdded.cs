using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class ProfilePicsAdded : Migration
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

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicId",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicId", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1880763a-2829-425e-a02d-4ed0fef8a788", 0, "5d0d9bbb-675b-409a-b925-7a6097fb3b35", "", false, false, null, "Dmitri Shostakovich", null, null, null, null, false, "default_pfp", 0, "0cef2d91-9135-48c7-b878-3afc4c44585a", false, "shostakovich" },
                    { "2da0d299-4e55-4746-b66b-c2e26f47aa94", 0, "f7cc2dfa-5ea2-4635-8571-2b79a3b9062b", "", false, false, null, "Franz Liszt", null, null, null, null, false, "default_pfp", 0, "50654880-1364-40c1-9d8b-421ebde12083", false, "liszt" },
                    { "5d0936e3-f479-4381-9524-fde404fa23ac", 0, "22b1067b-7e02-4cc0-8726-639deb4a619e", "", false, false, null, "Antonio Lucio Vivaldi", null, null, null, null, false, "default_pfp", 0, "6174d652-08bb-462c-bde8-e395e434dad4", false, "vivaldi" },
                    { "64eb492b-71b0-4567-b1f2-f1e3b25f94c4", 0, "d418b796-feff-4e7c-a210-ee987f732ee0", "", false, false, null, "Rick Astley", null, null, null, null, false, "default_pfp", 0, "f1d9dda2-822e-4fc6-9621-a059af3674b1", false, "astley" },
                    { "68b683a7-9acb-45af-b386-fd1416192d97", 0, "68f0d876-dc9d-4b54-9d35-c23c607d096c", "", false, false, null, "Paul de Senneville", null, null, null, null, false, "default_pfp", 0, "e97036fe-ae78-490c-81e5-0f8fb9aa9a02", false, "senneville" },
                    { "6d14c9ea-8df6-4213-a079-ab53195c380c", 0, "a6711e38-9b73-4e1a-a455-6b78a2751edc", "", false, false, null, "Pyotr Tchaikovsky", null, null, null, null, false, "default_pfp", 0, "818ec5ff-28a6-4622-8220-0273a61299bd", false, "tchaikovsky" },
                    { "6ea2dcb6-a34b-4bbb-9c4f-062f0c98c9b9", 0, "3bd264e9-8a21-4b16-acc7-1f4098994544", "", false, false, null, "Frédéric Chopin", null, null, null, null, false, "default_pfp", 0, "08414116-b85b-4c28-aec5-7d607acd37a6", false, "chopin" },
                    { "91ab359a-12a6-4c97-91c3-f1b9f45a7b06", 0, "4208adef-a700-4d24-b25b-ba7d52ecec38", "", false, false, null, "Niccolò Paganini", null, null, null, null, false, "default_pfp", 0, "6b9bc0aa-aa4f-4159-ab14-061c3a19bf44", false, "paganini" },
                    { "a0defce2-92df-41d9-9df8-dfe2c79022ca", 0, "497a34db-e04f-41d6-a99a-46f5fc386670", "", false, false, null, "Ludwig van Beethoven", null, null, null, null, false, "default_pfp", 0, "4b17f017-e9f5-4e4c-a174-b8a17742bce9", false, "beethoven" },
                    { "b923c8f1-422e-44ea-bef6-c75879cb4142", 0, "bb893fb5-fcfc-4a9a-8186-1f7b05d7aeb5", "", false, false, null, "Wolfgang Amadeus Mozart", null, null, null, null, false, "default_pfp", 0, "c0fa5d10-c503-420d-b486-fce182f75406", false, "mozart" },
                    { "ff3fd46f-dab4-4f23-8a8a-fac15dd0a779", 0, "923cf06a-233f-49d5-ba78-a8f702b1e43a", "", false, false, null, "Nikolai Rimsky-Korsakov", null, null, null, null, false, "default_pfp", 0, "6dfa1417-88a6-4809-9915-d611cd9fa827", false, "rimsky-korsakov" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "7106a65f-46cf-41dc-b4df-5e9a39752c7b", "Pop" },
                    { "71504d8e-98d1-47c1-92db-fe851d6a0f9f", "Instrumental" },
                    { "81de8569-13df-4e14-a534-db8178342f5b", "Classic" },
                    { "900e8a88-3365-45b9-8c1a-c535dd0cb886", "Jazz" },
                    { "e531c274-4c7c-41f2-8ed5-fe984b9a2e60", "New Age" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[,]
                {
                    { "0353aab0-c78f-42c3-8f1f-cf00211da4bb", "Ludwig van Beethoven", "a0defce2-92df-41d9-9df8-dfe2c79022ca" },
                    { "18877864-9400-4846-b3c2-dd99fbb220fb", "Paul de Senneville", "68b683a7-9acb-45af-b386-fd1416192d97" },
                    { "2af0cb3a-72aa-4653-b607-851b1eb537e0", "Dmitri Shostakovich", "1880763a-2829-425e-a02d-4ed0fef8a788" },
                    { "3b636bcf-ab10-4508-a3e1-5c48063e76a3", "Franz Liszt", "2da0d299-4e55-4746-b66b-c2e26f47aa94" },
                    { "4f81f13d-378e-4e11-9401-93f8afe08467", "Rick Astley", "64eb492b-71b0-4567-b1f2-f1e3b25f94c4" },
                    { "79f5f34c-0e89-4a35-a659-ad883e15944c", "Niccolò Paganini", "91ab359a-12a6-4c97-91c3-f1b9f45a7b06" },
                    { "a62ffa31-0930-444e-9910-4184cfe29ae4", "Nikolai Rimsky-Korsakov", "ff3fd46f-dab4-4f23-8a8a-fac15dd0a779" },
                    { "a9f53135-4374-4d8c-9742-f4b1e56f2f84", "Frédéric Chopin", "6ea2dcb6-a34b-4bbb-9c4f-062f0c98c9b9" },
                    { "adf06400-566b-4f1b-aa80-f3d74340a0fb", "Wolfgang Amadeus Mozart", "b923c8f1-422e-44ea-bef6-c75879cb4142" },
                    { "b89ec648-10fa-47e8-83ab-0f16a86ded9e", "Pyotr Tchaikovsky", "6d14c9ea-8df6-4213-a079-ab53195c380c" },
                    { "fb36e586-76a9-480c-805a-a96aed0d72e1", "Antonio Lucio Vivaldi", "5d0936e3-f479-4381-9524-fde404fa23ac" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AuthorId", "Name", "PreviewId", "ReleaseYear", "Type" },
                values: new object[,]
                {
                    { "0806ddf0-ffe0-4717-9c9b-fc4faa2b524a", "3b636bcf-ab10-4508-a3e1-5c48063e76a3", "Liebestraum", "44f268c1-3e94-4d05-8ccb-17c2e77b538d", 1850, 0 },
                    { "1797ad7d-3f65-4e00-b5e0-b704eb7f43ce", "18877864-9400-4846-b3c2-dd99fbb220fb", "Lettre à ma mère", "5a9ba216-9883-471d-9c0f-4c3d37e4ec34", 1979, 0 },
                    { "23f6eb04-deca-4c71-9e1f-82de55dd57f1", "adf06400-566b-4f1b-aa80-f3d74340a0fb", "Piano Sonata No. 11", "b26e8131-28bf-4ae9-842b-33b3d639b08e", 1784, 0 },
                    { "24c76a13-438e-4b21-b2d9-776784a22fbc", "3b636bcf-ab10-4508-a3e1-5c48063e76a3", "Grandes études de Paganini", "864239f6-65c5-440f-8326-213b3b25693f", 1851, 0 },
                    { "2f8a15e5-436c-46ef-af21-0338e8cbd02e", "3b636bcf-ab10-4508-a3e1-5c48063e76a3", "Hungarian Rhapsodies", "0a8c3ca2-56ca-4534-a426-648854e61821", 1885, 0 },
                    { "42d7c793-9724-4f3a-b808-fb51dfca1407", "a62ffa31-0930-444e-9910-4184cfe29ae4", "The Tale of Tsar Saltan", "cdbc9b43-ee1b-4a64-8b2d-d579522ea84f", 1900, 0 },
                    { "81bb29c1-c944-4891-87cc-f75317fded51", "b89ec648-10fa-47e8-83ab-0f16a86ded9e", "Valse-Scherzo", "36febf49-1c49-4b69-8084-73ebce69040a", 1877, 0 },
                    { "832845d6-006a-4fb3-8f1f-30141492d17d", "2af0cb3a-72aa-4653-b607-851b1eb537e0", "Waltz No. 2", "29ad8ca9-c791-4482-8a44-15776862b282", 1938, 1 },
                    { "ad09ebdc-635d-4942-abf5-e79f5c2adfee", "a9f53135-4374-4d8c-9742-f4b1e56f2f84", "Fantaisie-Impromptu", "4180556e-5365-4b9c-aa72-a47241346855", 1834, 1 },
                    { "c156958e-bcb6-42ff-b23c-562832b55f7d", "adf06400-566b-4f1b-aa80-f3d74340a0fb", "The marriage of Figaro", "15fa89e4-7777-4330-b32e-62172cd398c0", 1786, 0 },
                    { "c262fd55-fb58-4877-af85-64872e19cab3", "0353aab0-c78f-42c3-8f1f-cf00211da4bb", "Moonlight Sonata", "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb", 1802, 1 },
                    { "d2af7455-bac3-40a4-be8e-fdef468d093e", "fb36e586-76a9-480c-805a-a96aed0d72e1", "The Four Seasons", "7c561b1e-3070-4e83-b71a-2fd7a69fa040", 1725, 0 },
                    { "d2d23683-a6ad-48b2-8537-126498b205c6", "4f81f13d-378e-4e11-9401-93f8afe08467", "Whenever you need somebody", "572cc6a2-a5ba-47f5-8819-8330770cf8b5", 1987, 0 },
                    { "d4c44d95-a9be-413e-b983-1520e91aaef5", "adf06400-566b-4f1b-aa80-f3d74340a0fb", "Requiem", "9d0a67df-6fb4-4fac-b670-49a5f590beb7", 1791, 0 },
                    { "db6a26c7-6750-4a87-add7-6a3cc8fc4a18", "79f5f34c-0e89-4a35-a659-ad883e15944c", "Violin Concerto No. 2", "493afb2c-eb2a-4eab-9e4e-6585eb9924ae", 1826, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "FileId", "Name" },
                values: new object[,]
                {
                    { "3d7a5068-0e1a-48c7-8c8d-498a922ac2c8", "db6a26c7-6750-4a87-add7-6a3cc8fc4a18", "493afb2c-eb2a-4eab-9e4e-6585eb9924ae", "La Campanella" },
                    { "45a6d370-82d4-46d1-bcfb-e6abf7b6df5a", "81bb29c1-c944-4891-87cc-f75317fded51", "36febf49-1c49-4b69-8084-73ebce69040a", "Valse Sentimental" },
                    { "4e2640fa-d62e-408e-96f2-b0da56a72669", "42d7c793-9724-4f3a-b808-fb51dfca1407", "cdbc9b43-ee1b-4a64-8b2d-d579522ea84f", "Flight of the Bumblebee" },
                    { "51d21548-49fc-4c13-8284-df4b5bfa075a", "ad09ebdc-635d-4942-abf5-e79f5c2adfee", "4180556e-5365-4b9c-aa72-a47241346855", "Fantaisie Impromptu" },
                    { "544dfc24-d878-460f-929e-136bdc7dd378", "d2af7455-bac3-40a4-be8e-fdef468d093e", "7c561b1e-3070-4e83-b71a-2fd7a69fa040", "Summer - Storm" },
                    { "6ec0e688-2b4b-41a0-ba50-3a59f70335ed", "d4c44d95-a9be-413e-b983-1520e91aaef5", "9d0a67df-6fb4-4fac-b670-49a5f590beb7", "Lacrimosa" },
                    { "7c9a7b0c-2b3e-44dd-9433-9f7701175466", "c262fd55-fb58-4877-af85-64872e19cab3", "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb", "Moonlight Sonata" },
                    { "87279897-4580-4db7-b9fb-07ff2bcbafaa", "c156958e-bcb6-42ff-b23c-562832b55f7d", "15fa89e4-7777-4330-b32e-62172cd398c0", "Marriage of Figaro - Overture" },
                    { "b2b97ad3-1e97-4ba5-889e-73d29260b1f5", "2f8a15e5-436c-46ef-af21-0338e8cbd02e", "2d47fb0d-971c-44e5-9d76-8b5589f0cbbb", "Hungarian Rhapsody No. 2" },
                    { "b3069557-8756-4922-bb14-436e7c8db11a", "832845d6-006a-4fb3-8f1f-30141492d17d", "29ad8ca9-c791-4482-8a44-15776862b282", "Waltz No. 2" },
                    { "b664b93d-8a44-4628-89eb-65134c5b0dbe", "d2af7455-bac3-40a4-be8e-fdef468d093e", "9f1d7cfd-53c6-478f-82e2-db737d1b9ecf", "Spring" },
                    { "b9ed32e7-87aa-4fce-bcbc-c56874be004c", "0806ddf0-ffe0-4717-9c9b-fc4faa2b524a", "44f268c1-3e94-4d05-8ccb-17c2e77b538d", "Love Dream" },
                    { "db842542-8950-445f-8d11-11e500f62efb", "1797ad7d-3f65-4e00-b5e0-b704eb7f43ce", "5a9ba216-9883-471d-9c0f-4c3d37e4ec34", "Marriage d'Amour" },
                    { "dba9d72f-0b1a-4321-8bd0-bc0582c0dabf", "d2d23683-a6ad-48b2-8537-126498b205c6", "572cc6a2-a5ba-47f5-8819-8330770cf8b5", "Never gonna give you up" },
                    { "f09e0d97-8e26-43bf-8011-a68c7ffb2979", "24c76a13-438e-4b21-b2d9-776784a22fbc", "864239f6-65c5-440f-8326-213b3b25693f", "La Campanella" },
                    { "f37e0dcd-bd25-4dac-902e-2382047e9e71", "23f6eb04-deca-4c71-9e1f-82de55dd57f1", "b26e8131-28bf-4ae9-842b-33b3d639b08e", "Turkish March" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "7106a65f-46cf-41dc-b4df-5e9a39752c7b");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "71504d8e-98d1-47c1-92db-fe851d6a0f9f");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "81de8569-13df-4e14-a534-db8178342f5b");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "900e8a88-3365-45b9-8c1a-c535dd0cb886");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "e531c274-4c7c-41f2-8ed5-fe984b9a2e60");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "3d7a5068-0e1a-48c7-8c8d-498a922ac2c8");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "45a6d370-82d4-46d1-bcfb-e6abf7b6df5a");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "4e2640fa-d62e-408e-96f2-b0da56a72669");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "51d21548-49fc-4c13-8284-df4b5bfa075a");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "544dfc24-d878-460f-929e-136bdc7dd378");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "6ec0e688-2b4b-41a0-ba50-3a59f70335ed");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "7c9a7b0c-2b3e-44dd-9433-9f7701175466");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "87279897-4580-4db7-b9fb-07ff2bcbafaa");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "b2b97ad3-1e97-4ba5-889e-73d29260b1f5");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "b3069557-8756-4922-bb14-436e7c8db11a");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "b664b93d-8a44-4628-89eb-65134c5b0dbe");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "b9ed32e7-87aa-4fce-bcbc-c56874be004c");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "db842542-8950-445f-8d11-11e500f62efb");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "dba9d72f-0b1a-4321-8bd0-bc0582c0dabf");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "f09e0d97-8e26-43bf-8011-a68c7ffb2979");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "f37e0dcd-bd25-4dac-902e-2382047e9e71");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "0806ddf0-ffe0-4717-9c9b-fc4faa2b524a");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "1797ad7d-3f65-4e00-b5e0-b704eb7f43ce");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "23f6eb04-deca-4c71-9e1f-82de55dd57f1");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "24c76a13-438e-4b21-b2d9-776784a22fbc");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "2f8a15e5-436c-46ef-af21-0338e8cbd02e");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "42d7c793-9724-4f3a-b808-fb51dfca1407");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "81bb29c1-c944-4891-87cc-f75317fded51");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "832845d6-006a-4fb3-8f1f-30141492d17d");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "ad09ebdc-635d-4942-abf5-e79f5c2adfee");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "c156958e-bcb6-42ff-b23c-562832b55f7d");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "c262fd55-fb58-4877-af85-64872e19cab3");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "d2af7455-bac3-40a4-be8e-fdef468d093e");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "d2d23683-a6ad-48b2-8537-126498b205c6");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "d4c44d95-a9be-413e-b983-1520e91aaef5");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "db6a26c7-6750-4a87-add7-6a3cc8fc4a18");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "0353aab0-c78f-42c3-8f1f-cf00211da4bb");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "18877864-9400-4846-b3c2-dd99fbb220fb");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "2af0cb3a-72aa-4653-b607-851b1eb537e0");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "3b636bcf-ab10-4508-a3e1-5c48063e76a3");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "4f81f13d-378e-4e11-9401-93f8afe08467");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "79f5f34c-0e89-4a35-a659-ad883e15944c");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "a62ffa31-0930-444e-9910-4184cfe29ae4");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "a9f53135-4374-4d8c-9742-f4b1e56f2f84");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "adf06400-566b-4f1b-aa80-f3d74340a0fb");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "b89ec648-10fa-47e8-83ab-0f16a86ded9e");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "fb36e586-76a9-480c-805a-a96aed0d72e1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1880763a-2829-425e-a02d-4ed0fef8a788");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2da0d299-4e55-4746-b66b-c2e26f47aa94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d0936e3-f479-4381-9524-fde404fa23ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64eb492b-71b0-4567-b1f2-f1e3b25f94c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68b683a7-9acb-45af-b386-fd1416192d97");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d14c9ea-8df6-4213-a079-ab53195c380c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ea2dcb6-a34b-4bbb-9c4f-062f0c98c9b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91ab359a-12a6-4c97-91c3-f1b9f45a7b06");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0defce2-92df-41d9-9df8-dfe2c79022ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b923c8f1-422e-44ea-bef6-c75879cb4142");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff3fd46f-dab4-4f23-8a8a-fac15dd0a779");

            migrationBuilder.DropColumn(
                name: "ProfilePicId",
                table: "AspNetUsers");

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
