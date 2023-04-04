using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class PopulateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "23cab148-5e32-404b-8eca-6ecde96fc6c4", 0, "f53c12f0-618f-4798-a15b-841a60f3f191", "", false, false, null, "Niccolò Paganini", null, null, null, null, false, 0, "3f3767ad-c671-4e74-99df-ed421cce809f", false, "paganini" },
                    { "3f804b49-86aa-4a51-823c-ee9a09ab9992", 0, "f3300647-b8c1-4a5f-9454-2af54444b185", "", false, false, null, "Franz Liszt", null, null, null, null, false, 0, "6ffd1e99-4c52-4f0b-b3e9-0244eb5bc3d4", false, "liszt" },
                    { "5977475a-8a6c-468f-a3c3-040428f631f3", 0, "254e8011-c12a-4fa8-a844-36a3d8de8648", "", false, false, null, "Wolfgang Amadeus Mozart", null, null, null, null, false, 0, "5bc3ca6b-f981-4bcb-aba1-d51719af87f8", false, "mozart" },
                    { "8e5e2a33-bc9b-4693-9e66-582547ce8a16", 0, "d9a40c59-cd93-42bb-9db0-723b72241f74", "", false, false, null, "Nikolai Rimsky-Korsakov", null, null, null, null, false, 0, "2af566ff-8021-411c-b4d7-4c41acde2641", false, "rimsky-korsakov" },
                    { "acc6d832-3c00-4be9-9a89-0b96348703a5", 0, "865cb953-7d03-464c-abbc-ec7b8f2abeab", "", false, false, null, "Dmitri Shostakovich", null, null, null, null, false, 0, "bc4ff5fa-a000-4f8a-a0e7-027cc8ed57ce", false, "shostakovich" },
                    { "b4263da1-7fda-468f-a62f-757d2a60eb2a", 0, "818c4dc5-2a97-439d-8ebd-1f83e90e6892", "", false, false, null, "Antonio Lucio Vivaldi", null, null, null, null, false, 0, "7fad14f9-043f-47c9-bf83-9f49ee00be14", false, "vivaldi" },
                    { "b5712030-bd71-46c9-894f-3a41b49efb8c", 0, "a583b855-5513-4022-99e9-5c15d2b0d837", "", false, false, null, "Paul de Senneville", null, null, null, null, false, 0, "38694c72-34d2-44ad-9d65-c8a3d3a6d7b3", false, "senneville" },
                    { "e20fc526-7a91-45af-8386-48124f55dd57", 0, "6cbd9bcc-fa01-49e8-845b-c148e5415784", "", false, false, null, "Pyotr Tchaikovsky", null, null, null, null, false, 0, "4224fc97-4f9f-4aa4-9631-d4c2fd0f063b", false, "tchaikovsky" },
                    { "e9b5b45d-a3d0-46e3-b316-050026bc6a8b", 0, "76d6953f-a27f-4bcf-83ed-3b6243ba7041", "", false, false, null, "Rick Astley", null, null, null, null, false, 0, "82a58ed3-7780-421c-b8af-55728362940a", false, "astley" },
                    { "f2a9777e-7d49-4cd6-956d-93a5cc861dcc", 0, "986c157f-db8b-4915-b333-0dd71290076d", "", false, false, null, "Ludwig van Beethoven", null, null, null, null, false, 0, "7b94ad8f-b8c7-4e52-a533-abb20bd2be49", false, "beethoven" },
                    { "f682d5e4-bbad-4bb9-a82e-a4a0eb58c64c", 0, "14b59e8f-bf91-4a9f-97c7-bde0d2ba09df", "", false, false, null, "Frédéric Chopin", null, null, null, null, false, 0, "9b9a3872-9cc2-41bb-be73-984fcf983e9b", false, "chopin" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[,]
                {
                    { "0484f25a-98d7-43ae-9363-b90e83bcbba1", "Frédéric Chopin", "f682d5e4-bbad-4bb9-a82e-a4a0eb58c64c" },
                    { "0cbe483b-13fb-43b6-8261-b0a1fab9a545", "Wolfgang Amadeus Mozart", "5977475a-8a6c-468f-a3c3-040428f631f3" },
                    { "3eb97e13-00df-408c-b394-2b38d08ebb0e", "Niccolò Paganini", "23cab148-5e32-404b-8eca-6ecde96fc6c4" },
                    { "41d65bd8-9403-49ee-b914-dd92bf8e3cdd", "Paul de Senneville", "b5712030-bd71-46c9-894f-3a41b49efb8c" },
                    { "52e15ef8-6477-42ed-954b-f202ac1e41cc", "Ludwig van Beethoven", "f2a9777e-7d49-4cd6-956d-93a5cc861dcc" },
                    { "9e0ac14d-b7ab-4ee2-b371-1bb5c1539f73", "Nikolai Rimsky-Korsakov", "8e5e2a33-bc9b-4693-9e66-582547ce8a16" },
                    { "a0b14480-4bba-4c11-be48-374dc69de041", "Rick Astley", "e9b5b45d-a3d0-46e3-b316-050026bc6a8b" },
                    { "a852dcb1-7a96-4b41-8c36-48a69b30f97a", "Pyotr Tchaikovsky", "e20fc526-7a91-45af-8386-48124f55dd57" },
                    { "b81ee10a-ff45-4692-aed5-b35a43650c08", "Franz Liszt", "3f804b49-86aa-4a51-823c-ee9a09ab9992" },
                    { "e791ac96-58fe-4e51-9a6d-248cbb6a1043", "Dmitri Shostakovich", "acc6d832-3c00-4be9-9a89-0b96348703a5" },
                    { "ed0a84cc-a98c-4923-945a-e2e24e7b3c07", "Antonio Lucio Vivaldi", "b4263da1-7fda-468f-a62f-757d2a60eb2a" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "59f65d80-4788-4bc4-8da3-956072f8177f", "Pop" },
                    { "6db57706-b3be-47b8-b405-dabca15e0f1c", "New Age" },
                    { "7a057825-f164-4532-b401-30f01265b23b", "Jazz" },
                    { "8a81f851-a8c9-4799-b927-bc7a9f24e422", "Instrumental" },
                    { "f041db83-ac07-4d6a-b9e0-7dcf6a9dcebe", "Classic" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AuthorId", "Name", "ReleaseYear", "Type" },
                values: new object[,]
                {
                    { "0a8c3ca2-56ca-4534-a426-648854e61821", "b81ee10a-ff45-4692-aed5-b35a43650c08", "Hungarian Rhapsodies", 1885, 0 },
                    { "48058f74-21b7-4cb1-868d-42d6e60d84bf", "b81ee10a-ff45-4692-aed5-b35a43650c08", "Grandes études de Paganini", 1851, 0 },
                    { "4ad605b9-42a2-450e-a7a7-0e531ae4f856", "3eb97e13-00df-408c-b394-2b38d08ebb0e", "Violin Concerto No. 2", 1826, 0 },
                    { "70b37649-acbb-4160-838c-cb3622f469f6", "b81ee10a-ff45-4692-aed5-b35a43650c08", "Liebestraum", 1850, 0 },
                    { "7283457b-a8e2-4375-b059-8f9832507ab3", "0484f25a-98d7-43ae-9363-b90e83bcbba1", "Fantaisie-Impromptu", 1834, 1 },
                    { "857e8dea-a4e3-431e-92d5-c50c515c3126", "e791ac96-58fe-4e51-9a6d-248cbb6a1043", "Waltz No. 2", 1938, 1 },
                    { "9fe66611-e9ee-46fc-8c7f-4157c779ca0b", "a0b14480-4bba-4c11-be48-374dc69de041", "Whenever you need somebody", 1987, 0 },
                    { "aa22cc97-a3ec-4629-8554-a36ce2e5112f", "0cbe483b-13fb-43b6-8261-b0a1fab9a545", "Requiem", 1791, 0 },
                    { "af0dd673-69f7-410f-95da-1b225eb0281d", "9e0ac14d-b7ab-4ee2-b371-1bb5c1539f73", "The Tale of Tsar Saltan", 1900, 0 },
                    { "b919ce49-cfce-46df-8835-be2bc6da79ec", "52e15ef8-6477-42ed-954b-f202ac1e41cc", "Moonlight Sonata", 1802, 1 },
                    { "c92d956f-10a9-48cd-be27-bcd04daa17a0", "0cbe483b-13fb-43b6-8261-b0a1fab9a545", "The marriage of Figaro", 1786, 0 },
                    { "dad299c1-d656-494b-920e-025249927d9f", "0cbe483b-13fb-43b6-8261-b0a1fab9a545", "Piano Sonata No. 11", 1784, 0 },
                    { "e4edb6f1-f1c6-4c71-bf18-9993abdd3ff7", "41d65bd8-9403-49ee-b914-dd92bf8e3cdd", "Lettre à ma mère", 1979, 0 },
                    { "ed59b7ce-03a8-4ec1-9e2b-d1c53285eeaa", "ed0a84cc-a98c-4923-945a-e2e24e7b3c07", "The Four Seasons", 1725, 0 },
                    { "f5e45467-3840-4a38-933d-e1edfa835789", "a852dcb1-7a96-4b41-8c36-48a69b30f97a", "Valse-Scherzo", 1877, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "Name" },
                values: new object[,]
                {
                    { "15fa89e4-7777-4330-b32e-62172cd398c0", "c92d956f-10a9-48cd-be27-bcd04daa17a0", "Marriage of Figaro - Overture" },
                    { "29ad8ca9-c791-4482-8a44-15776862b282", "857e8dea-a4e3-431e-92d5-c50c515c3126", "Waltz No. 2" },
                    { "2d47fb0d-971c-44e5-9d76-8b5589f0cbbb", "0a8c3ca2-56ca-4534-a426-648854e61821", "Hungarian Rhapsody No. 2" },
                    { "36febf49-1c49-4b69-8084-73ebce69040a", "f5e45467-3840-4a38-933d-e1edfa835789", "Valse Sentimental" },
                    { "4180556e-5365-4b9c-aa72-a47241346855", "7283457b-a8e2-4375-b059-8f9832507ab3", "Fantaisie Impromptu" },
                    { "44f268c1-3e94-4d05-8ccb-17c2e77b538d", "70b37649-acbb-4160-838c-cb3622f469f6", "Love Dream" },
                    { "493afb2c-eb2a-4eab-9e4e-6585eb9924ae", "4ad605b9-42a2-450e-a7a7-0e531ae4f856", "La Campanella" },
                    { "572cc6a2-a5ba-47f5-8819-8330770cf8b5", "9fe66611-e9ee-46fc-8c7f-4157c779ca0b", "Never gonna give you up" },
                    { "5a9ba216-9883-471d-9c0f-4c3d37e4ec34", "e4edb6f1-f1c6-4c71-bf18-9993abdd3ff7", "Marriage d'Amour" },
                    { "7c561b1e-3070-4e83-b71a-2fd7a69fa040", "ed59b7ce-03a8-4ec1-9e2b-d1c53285eeaa", "Summer - Storm" },
                    { "864239f6-65c5-440f-8326-213b3b25693f", "48058f74-21b7-4cb1-868d-42d6e60d84bf", "La Campanella" },
                    { "9d0a67df-6fb4-4fac-b670-49a5f590beb7", "aa22cc97-a3ec-4629-8554-a36ce2e5112f", "Lacrimosa" },
                    { "9f1d7cfd-53c6-478f-82e2-db737d1b9ecf", "ed59b7ce-03a8-4ec1-9e2b-d1c53285eeaa", "Spring" },
                    { "b26e8131-28bf-4ae9-842b-33b3d639b08e", "dad299c1-d656-494b-920e-025249927d9f", "Turkish March" },
                    { "cdbc9b43-ee1b-4a64-8b2d-d579522ea84f", "af0dd673-69f7-410f-95da-1b225eb0281d", "Flight of the Bumblebee" },
                    { "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb", "b919ce49-cfce-46df-8835-be2bc6da79ec", "Moonlight Sonata" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23cab148-5e32-404b-8eca-6ecde96fc6c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f804b49-86aa-4a51-823c-ee9a09ab9992");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5977475a-8a6c-468f-a3c3-040428f631f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e5e2a33-bc9b-4693-9e66-582547ce8a16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acc6d832-3c00-4be9-9a89-0b96348703a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4263da1-7fda-468f-a62f-757d2a60eb2a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5712030-bd71-46c9-894f-3a41b49efb8c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e20fc526-7a91-45af-8386-48124f55dd57");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9b5b45d-a3d0-46e3-b316-050026bc6a8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2a9777e-7d49-4cd6-956d-93a5cc861dcc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f682d5e4-bbad-4bb9-a82e-a4a0eb58c64c");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "59f65d80-4788-4bc4-8da3-956072f8177f");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "6db57706-b3be-47b8-b405-dabca15e0f1c");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "7a057825-f164-4532-b401-30f01265b23b");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "8a81f851-a8c9-4799-b927-bc7a9f24e422");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "f041db83-ac07-4d6a-b9e0-7dcf6a9dcebe");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "15fa89e4-7777-4330-b32e-62172cd398c0");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "29ad8ca9-c791-4482-8a44-15776862b282");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "2d47fb0d-971c-44e5-9d76-8b5589f0cbbb");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "36febf49-1c49-4b69-8084-73ebce69040a");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "4180556e-5365-4b9c-aa72-a47241346855");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "44f268c1-3e94-4d05-8ccb-17c2e77b538d");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "493afb2c-eb2a-4eab-9e4e-6585eb9924ae");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "572cc6a2-a5ba-47f5-8819-8330770cf8b5");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "5a9ba216-9883-471d-9c0f-4c3d37e4ec34");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "7c561b1e-3070-4e83-b71a-2fd7a69fa040");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "864239f6-65c5-440f-8326-213b3b25693f");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "9d0a67df-6fb4-4fac-b670-49a5f590beb7");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "9f1d7cfd-53c6-478f-82e2-db737d1b9ecf");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "b26e8131-28bf-4ae9-842b-33b3d639b08e");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "cdbc9b43-ee1b-4a64-8b2d-d579522ea84f");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "0a8c3ca2-56ca-4534-a426-648854e61821");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "48058f74-21b7-4cb1-868d-42d6e60d84bf");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "4ad605b9-42a2-450e-a7a7-0e531ae4f856");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "70b37649-acbb-4160-838c-cb3622f469f6");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "7283457b-a8e2-4375-b059-8f9832507ab3");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "857e8dea-a4e3-431e-92d5-c50c515c3126");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "9fe66611-e9ee-46fc-8c7f-4157c779ca0b");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "aa22cc97-a3ec-4629-8554-a36ce2e5112f");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "af0dd673-69f7-410f-95da-1b225eb0281d");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "b919ce49-cfce-46df-8835-be2bc6da79ec");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "c92d956f-10a9-48cd-be27-bcd04daa17a0");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "dad299c1-d656-494b-920e-025249927d9f");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "e4edb6f1-f1c6-4c71-bf18-9993abdd3ff7");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "ed59b7ce-03a8-4ec1-9e2b-d1c53285eeaa");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "f5e45467-3840-4a38-933d-e1edfa835789");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "0484f25a-98d7-43ae-9363-b90e83bcbba1");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "0cbe483b-13fb-43b6-8261-b0a1fab9a545");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "3eb97e13-00df-408c-b394-2b38d08ebb0e");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "41d65bd8-9403-49ee-b914-dd92bf8e3cdd");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "52e15ef8-6477-42ed-954b-f202ac1e41cc");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "9e0ac14d-b7ab-4ee2-b371-1bb5c1539f73");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "a0b14480-4bba-4c11-be48-374dc69de041");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "a852dcb1-7a96-4b41-8c36-48a69b30f97a");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "b81ee10a-ff45-4692-aed5-b35a43650c08");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "e791ac96-58fe-4e51-9a6d-248cbb6a1043");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "ed0a84cc-a98c-4923-945a-e2e24e7b3c07");
        }
    }
}
