using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class ReturnedTracks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "033252b5-b552-48cc-bf5b-d6b78f4c71b6");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "0d39cad4-43f8-4c2f-bd82-7e97ecf42fb8");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "12fdb2a4-4431-4cdd-a0f9-8b630dc73092");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "2240f5ad-7074-4756-b27e-ae6d53093748");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "5c852bb6-5aa0-41b0-946c-d4ae234dfc71");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "68e1d886-f75d-48b9-99d2-7ce226a49431");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "99deaecf-da9a-4dfd-a52c-84248c8b9466");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "a75dea3e-f574-47c3-bd57-2f0952b960a4");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "b5c23776-2166-46a4-8a76-31883bbe13da");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "c5cfb64c-c670-4c48-9cf2-e3e085e72831");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "ca4ffc77-a648-4514-b7c5-c3ca17ef60f8");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "d9e59b26-7e49-4b7b-91ef-4ae000e82310");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "dd68b4b0-81d5-42ad-b971-160c94877251");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "f273511c-5982-4327-90fd-76c8e3da42e7");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "fd7faef4-acaf-48cc-a971-5a0a02a2be13");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "7d1a3c18-e3ce-4ae4-a8ac-7f776563fdfb");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "ac04d579-63f2-4814-96ce-c2ed90c502d7");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "af8444ff-e874-4167-ad04-132c9ff89054");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "b36d757d-6ccf-4f38-991d-88edd4278ce9");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "dfcf7bd3-9f88-421d-ae11-f1c1b376a101");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "0112b7d1-1a93-4995-b6be-7d5c375e3c7c");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "09f413ea-12fb-43c7-b249-314be1874f23");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "103b2583-9e00-4238-820f-5589b575d8d5");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "26206096-8ce8-49ca-98f9-900e58e62709");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "5e6586df-8c26-44cd-9c27-29f704419eeb");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "5fe5fd0f-cee2-4cd3-ad9b-93c106715b3d");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "75240b99-b1e9-4cf4-bd2e-1543af089999");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "7d102e68-f2c6-4ee5-b288-2bdbba1ec145");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "baf3a3d1-6bcf-492f-aa49-8aa6411f11d9");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "ca5417cf-8b4b-4c93-9f06-147b3fda9d96");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "fb408405-ba23-4958-8378-164fddee75d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0337ed8c-bc86-4f77-8113-dc38e39bbf07");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2484a579-b940-47e8-a7c5-d6b3da63328b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e1fdf28-2de8-461a-8fe2-bfa8a62cb3e3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42002238-02b8-4372-bc7e-4b7a5f5987eb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45f45032-49e6-4731-8ff2-fe906d2de6c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a7202f7-0b97-4e18-8654-62fef8634331");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "760cb97a-5057-4b2b-a2cd-fd59ae1aeb3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0b0382d-bafe-482e-8f97-2ad87849d8b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a28c3c3a-461c-48a2-8cb7-d42dc399a481");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8160d81-d4a8-4742-b47c-50812ab1b7f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dcb31b4d-b8db-4d85-a9dc-fc900fbd9e09");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0337ed8c-bc86-4f77-8113-dc38e39bbf07", 0, "2da50d79-5cb8-4e08-97a3-fed708ce8b91", "", false, false, null, "Ludwig van Beethoven", null, null, null, null, false, 0, "d9a806fc-b3d8-4cbe-87b9-a03a1d716341", false, "beethoven" },
                    { "2484a579-b940-47e8-a7c5-d6b3da63328b", 0, "f6edd93c-5cd7-468a-be9c-8422a4d4df6e", "", false, false, null, "Nikolai Rimsky-Korsakov", null, null, null, null, false, 0, "b591dd4a-057a-45ce-bfe2-a90ab6299b9d", false, "rimsky-korsakov" },
                    { "3e1fdf28-2de8-461a-8fe2-bfa8a62cb3e3", 0, "81230e31-685f-4063-9735-b629fcd7b1ad", "", false, false, null, "Franz Liszt", null, null, null, null, false, 0, "714f3246-1f0f-4477-aae7-f6b7714c0118", false, "liszt" },
                    { "42002238-02b8-4372-bc7e-4b7a5f5987eb", 0, "ea464273-137b-42fc-a85e-c72fa8c62d1c", "", false, false, null, "Dmitri Shostakovich", null, null, null, null, false, 0, "478c1498-4977-49c9-975a-4fc34033fc54", false, "shostakovich" },
                    { "45f45032-49e6-4731-8ff2-fe906d2de6c7", 0, "630dd9ca-6c1e-490b-90cf-cf61605cb0f8", "", false, false, null, "Rick Astley", null, null, null, null, false, 0, "b90777f4-0e79-4712-aadf-f8d8e4177236", false, "astley" },
                    { "6a7202f7-0b97-4e18-8654-62fef8634331", 0, "5a1aefe7-f17c-4ec9-b022-67098ae02173", "", false, false, null, "Wolfgang Amadeus Mozart", null, null, null, null, false, 0, "da90bd61-a930-490b-adfb-1d364875c14a", false, "mozart" },
                    { "760cb97a-5057-4b2b-a2cd-fd59ae1aeb3e", 0, "39578c9b-4a5d-49ad-bd0e-7c3a6480d331", "", false, false, null, "Pyotr Tchaikovsky", null, null, null, null, false, 0, "723a5a81-6373-427f-b4f2-8a1d452d5452", false, "tchaikovsky" },
                    { "a0b0382d-bafe-482e-8f97-2ad87849d8b4", 0, "52275665-a705-4989-b1db-00de152bf4bf", "", false, false, null, "Paul de Senneville", null, null, null, null, false, 0, "b42e69a1-b20f-4b21-b997-618108599210", false, "senneville" },
                    { "a28c3c3a-461c-48a2-8cb7-d42dc399a481", 0, "667e2b3b-1d1c-4cdd-b20c-42e3ddcb0e28", "", false, false, null, "Niccolò Paganini", null, null, null, null, false, 0, "4919c7db-4dc4-4bf1-a988-cd3fe08a01d3", false, "paganini" },
                    { "b8160d81-d4a8-4742-b47c-50812ab1b7f2", 0, "6f2e219e-500f-4ad1-b6b9-e7dad1a16d79", "", false, false, null, "Antonio Lucio Vivaldi", null, null, null, null, false, 0, "b74c3bfb-2511-4994-9bcc-e77a77c1dd3e", false, "vivaldi" },
                    { "dcb31b4d-b8db-4d85-a9dc-fc900fbd9e09", 0, "b7495544-00bc-4fb7-9252-d03e8581cd4a", "", false, false, null, "Frédéric Chopin", null, null, null, null, false, 0, "0ae4254d-e84d-465c-a50c-07e1f228b94e", false, "chopin" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "7d1a3c18-e3ce-4ae4-a8ac-7f776563fdfb", "New Age" },
                    { "ac04d579-63f2-4814-96ce-c2ed90c502d7", "Pop" },
                    { "af8444ff-e874-4167-ad04-132c9ff89054", "Jazz" },
                    { "b36d757d-6ccf-4f38-991d-88edd4278ce9", "Instrumental" },
                    { "dfcf7bd3-9f88-421d-ae11-f1c1b376a101", "Classic" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[,]
                {
                    { "0112b7d1-1a93-4995-b6be-7d5c375e3c7c", "Pyotr Tchaikovsky", "760cb97a-5057-4b2b-a2cd-fd59ae1aeb3e" },
                    { "09f413ea-12fb-43c7-b249-314be1874f23", "Niccolò Paganini", "a28c3c3a-461c-48a2-8cb7-d42dc399a481" },
                    { "103b2583-9e00-4238-820f-5589b575d8d5", "Ludwig van Beethoven", "0337ed8c-bc86-4f77-8113-dc38e39bbf07" },
                    { "26206096-8ce8-49ca-98f9-900e58e62709", "Franz Liszt", "3e1fdf28-2de8-461a-8fe2-bfa8a62cb3e3" },
                    { "5e6586df-8c26-44cd-9c27-29f704419eeb", "Paul de Senneville", "a0b0382d-bafe-482e-8f97-2ad87849d8b4" },
                    { "5fe5fd0f-cee2-4cd3-ad9b-93c106715b3d", "Frédéric Chopin", "dcb31b4d-b8db-4d85-a9dc-fc900fbd9e09" },
                    { "75240b99-b1e9-4cf4-bd2e-1543af089999", "Dmitri Shostakovich", "42002238-02b8-4372-bc7e-4b7a5f5987eb" },
                    { "7d102e68-f2c6-4ee5-b288-2bdbba1ec145", "Nikolai Rimsky-Korsakov", "2484a579-b940-47e8-a7c5-d6b3da63328b" },
                    { "baf3a3d1-6bcf-492f-aa49-8aa6411f11d9", "Antonio Lucio Vivaldi", "b8160d81-d4a8-4742-b47c-50812ab1b7f2" },
                    { "ca5417cf-8b4b-4c93-9f06-147b3fda9d96", "Wolfgang Amadeus Mozart", "6a7202f7-0b97-4e18-8654-62fef8634331" },
                    { "fb408405-ba23-4958-8378-164fddee75d0", "Rick Astley", "45f45032-49e6-4731-8ff2-fe906d2de6c7" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AuthorId", "Name", "PreviewId", "ReleaseYear", "Type" },
                values: new object[,]
                {
                    { "033252b5-b552-48cc-bf5b-d6b78f4c71b6", "ca5417cf-8b4b-4c93-9f06-147b3fda9d96", "The marriage of Figaro", "15fa89e4-7777-4330-b32e-62172cd398c0", 1786, 0 },
                    { "0d39cad4-43f8-4c2f-bd82-7e97ecf42fb8", "0112b7d1-1a93-4995-b6be-7d5c375e3c7c", "Valse-Scherzo", "36febf49-1c49-4b69-8084-73ebce69040a", 1877, 0 },
                    { "12fdb2a4-4431-4cdd-a0f9-8b630dc73092", "75240b99-b1e9-4cf4-bd2e-1543af089999", "Waltz No. 2", "29ad8ca9-c791-4482-8a44-15776862b282", 1938, 1 },
                    { "2240f5ad-7074-4756-b27e-ae6d53093748", "5fe5fd0f-cee2-4cd3-ad9b-93c106715b3d", "Fantaisie-Impromptu", "4180556e-5365-4b9c-aa72-a47241346855", 1834, 1 },
                    { "5c852bb6-5aa0-41b0-946c-d4ae234dfc71", "26206096-8ce8-49ca-98f9-900e58e62709", "Hungarian Rhapsodies", "0a8c3ca2-56ca-4534-a426-648854e61821", 1885, 0 },
                    { "68e1d886-f75d-48b9-99d2-7ce226a49431", "103b2583-9e00-4238-820f-5589b575d8d5", "Moonlight Sonata", "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb", 1802, 1 },
                    { "99deaecf-da9a-4dfd-a52c-84248c8b9466", "ca5417cf-8b4b-4c93-9f06-147b3fda9d96", "Piano Sonata No. 11", "b26e8131-28bf-4ae9-842b-33b3d639b08e", 1784, 0 },
                    { "a75dea3e-f574-47c3-bd57-2f0952b960a4", "7d102e68-f2c6-4ee5-b288-2bdbba1ec145", "The Tale of Tsar Saltan", "cdbc9b43-ee1b-4a64-8b2d-d579522ea84f", 1900, 0 },
                    { "b5c23776-2166-46a4-8a76-31883bbe13da", "26206096-8ce8-49ca-98f9-900e58e62709", "Liebestraum", "44f268c1-3e94-4d05-8ccb-17c2e77b538d", 1850, 0 },
                    { "c5cfb64c-c670-4c48-9cf2-e3e085e72831", "baf3a3d1-6bcf-492f-aa49-8aa6411f11d9", "The Four Seasons", "7c561b1e-3070-4e83-b71a-2fd7a69fa040", 1725, 0 },
                    { "ca4ffc77-a648-4514-b7c5-c3ca17ef60f8", "09f413ea-12fb-43c7-b249-314be1874f23", "Violin Concerto No. 2", "493afb2c-eb2a-4eab-9e4e-6585eb9924ae", 1826, 0 },
                    { "d9e59b26-7e49-4b7b-91ef-4ae000e82310", "26206096-8ce8-49ca-98f9-900e58e62709", "Grandes études de Paganini", "864239f6-65c5-440f-8326-213b3b25693f", 1851, 0 },
                    { "dd68b4b0-81d5-42ad-b971-160c94877251", "5e6586df-8c26-44cd-9c27-29f704419eeb", "Lettre à ma mère", "5a9ba216-9883-471d-9c0f-4c3d37e4ec34", 1979, 0 },
                    { "f273511c-5982-4327-90fd-76c8e3da42e7", "fb408405-ba23-4958-8378-164fddee75d0", "Whenever you need somebody", "572cc6a2-a5ba-47f5-8819-8330770cf8b5", 1987, 0 },
                    { "fd7faef4-acaf-48cc-a971-5a0a02a2be13", "ca5417cf-8b4b-4c93-9f06-147b3fda9d96", "Requiem", "9d0a67df-6fb4-4fac-b670-49a5f590beb7", 1791, 0 }
                });
        }
    }
}
