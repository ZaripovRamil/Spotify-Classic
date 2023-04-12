using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class ChangedEmailAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "0f30a194-86d7-47c8-a7cf-83bef6b737da");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "396d4f0d-61c0-4494-ae00-8ab50bff9676");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "4f0f5fe9-4ef7-406e-b997-a9927667747b");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "b1068876-5947-491a-ab1f-0bf0b054f8fd");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "b590dc80-2688-4806-903a-6601946b5dc0");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "19231971-f420-4030-a381-7ddb1727dc9d");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "315b4ab3-958e-436b-a15f-66b7af0bc463");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "420e72cd-1449-4fa3-96f2-8a6d64992fb0");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "5a76c8c7-2270-405d-ad38-019144a2c4f4");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "6b217297-8bae-4d6c-a6f9-cf11034f32f2");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "8209bfde-10c2-42e0-8dfd-19becf702fbc");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "90f4ab91-bbe0-4cfd-a6f8-cf0119ebcbde");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "9619dc9f-c0c3-4204-b822-dd935ab22716");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "9bfccb22-d485-412c-a532-105e56fe6dc4");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "a6596364-933b-4cec-ac27-de4045b86e6e");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "a90c2516-9c7e-4bd5-a293-b8fe3e523e8f");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "c116f80e-d76a-490f-a7dd-ce079e76933d");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "d73aeb8d-2948-4243-a510-5f82e02eda1a");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "eac0deb6-2ec2-40de-b954-ff070ede4350");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "ee801004-ebe5-4fc1-b5d0-cf05f9dcb5db");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "ef10bfc5-d207-4630-8cd5-285131120d62");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "039d0f44-c45b-4522-8d36-d96e8d6f17d0");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "0caadb6f-9337-4fb9-a4c4-93c27b698007");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "12fb43f1-6cdc-4150-ac2c-6a0d6d6c5b6b");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "288d33b3-ce1d-4d49-88a4-f1611266723e");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "64bff82a-b7ac-4070-9df4-e8aad7910df3");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "6941dc78-efaf-4d4f-8a3f-a3922a8bbabd");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "69fef71d-e08d-44b0-b580-98193c1dd29b");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "8c38ddd0-fd23-49f1-a2e7-544e259083f6");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "9a66b187-007a-4fa9-b4db-e12eff7aa8c8");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "c5f43b24-9d15-42df-bff8-1c18ae19ef70");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "d832b8ba-149d-4a77-bae1-fd9ec7fe73f7");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "e00cd5b9-d4d1-4e2a-98e3-7e25def2fe19");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "e06e3970-3100-4b54-9868-27bca967ac90");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "f750ea06-1e45-4ea5-867c-98560f921b63");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "f7f19a51-7047-470f-82e2-5e999058706e");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "01f79e12-c164-4c41-bea4-3b0259b1a7da");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "1baf1e60-600e-4e57-b1fd-c7fa62999bf7");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "1df68c86-9584-4932-8009-1c18e23a54bb");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "4b7a1ddd-ff79-4b0d-a66b-12faa20d9f06");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "5d29f8bc-b6cc-4104-aafe-989049646d69");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "6b53ce6c-7cf4-4764-a292-84959f72d351");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "947e15de-fcfa-4781-ba9c-7060b7252750");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "a04ffa80-e908-450b-bb76-a3468306c22c");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "a57ec277-ad4a-4e9b-b024-c7b016aae366");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "ae765207-d991-4f58-991c-c052550a6dd8");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "b5b664c1-60a5-4fce-9cdf-6cadb1ec573b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04fa4b46-acf9-4c30-937d-6d13f2ab7b13");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicId", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7da8b7c1-175d-4fb4-bf5e-5886e5fc8e3f", 0, "9bf03597-3336-4d3f-8b2f-ec0e9e3759fa", null, false, false, null, "John Doe", null, null, null, null, false, "default_pfp", 0, "b80e8eec-ef35-4ee1-a619-0caef685f161", false, "defaultUser" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "238c45f5-c2a7-4317-882f-7b07fca05790", "New Age" },
                    { "72811315-294c-42b0-bd40-1eed587d97ad", "Jazz" },
                    { "a0b124e5-055c-43a4-80f7-7f773a3b0a2a", "Classic" },
                    { "a2832e5c-6da3-444a-97d8-ff899a304fd2", "Pop" },
                    { "ad153fd0-dd2c-43a1-b6d2-327f99536750", "Instrumental" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[,]
                {
                    { "05eb4e6b-d0df-41bf-bfa6-4456a69048e8", "John Doe", "7da8b7c1-175d-4fb4-bf5e-5886e5fc8e3f" },
                    { "397f6b08-cb1e-48c4-a0ab-6cf5ecab159c", "John Doe", "7da8b7c1-175d-4fb4-bf5e-5886e5fc8e3f" },
                    { "3a2b8ebc-ab4b-4b96-864c-75e007b7ef7d", "John Doe", "7da8b7c1-175d-4fb4-bf5e-5886e5fc8e3f" },
                    { "4fda97b7-0388-41a5-bb2e-d35071768e43", "John Doe", "7da8b7c1-175d-4fb4-bf5e-5886e5fc8e3f" },
                    { "62984273-d8d2-4c82-a137-9d532044af4c", "John Doe", "7da8b7c1-175d-4fb4-bf5e-5886e5fc8e3f" },
                    { "71f6794c-ffe7-45d2-ad1b-0d289fbb7178", "John Doe", "7da8b7c1-175d-4fb4-bf5e-5886e5fc8e3f" },
                    { "7d912fa8-9124-4200-be12-4df303afa6de", "John Doe", "7da8b7c1-175d-4fb4-bf5e-5886e5fc8e3f" },
                    { "88d01fa8-da8c-4edc-bf38-f83dbee33102", "John Doe", "7da8b7c1-175d-4fb4-bf5e-5886e5fc8e3f" },
                    { "a8108ac5-094f-46c8-905d-2e2ff500184c", "John Doe", "7da8b7c1-175d-4fb4-bf5e-5886e5fc8e3f" },
                    { "cb1f955e-5c52-4819-8f1c-7db37beb246a", "John Doe", "7da8b7c1-175d-4fb4-bf5e-5886e5fc8e3f" },
                    { "efbe3c8f-a898-4c20-9510-7c0a1aceba0e", "John Doe", "7da8b7c1-175d-4fb4-bf5e-5886e5fc8e3f" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AuthorId", "Name", "PreviewId", "ReleaseYear", "Type" },
                values: new object[,]
                {
                    { "1beb18cb-442c-482e-aad5-226a7c78ca35", "397f6b08-cb1e-48c4-a0ab-6cf5ecab159c", "Requiem", "9d0a67df-6fb4-4fac-b670-49a5f590beb7", 1791, 0 },
                    { "2d059957-f392-43ed-87d1-4705e26a8936", "88d01fa8-da8c-4edc-bf38-f83dbee33102", "Valse-Scherzo", "36febf49-1c49-4b69-8084-73ebce69040a", 1877, 0 },
                    { "307e5d2d-28c3-407a-b3c2-adf6ac4f749b", "efbe3c8f-a898-4c20-9510-7c0a1aceba0e", "Whenever you need somebody", "572cc6a2-a5ba-47f5-8819-8330770cf8b5", 1987, 0 },
                    { "50744713-e72c-4511-b9dd-c86b421be9e2", "cb1f955e-5c52-4819-8f1c-7db37beb246a", "Liebestraum", "44f268c1-3e94-4d05-8ccb-17c2e77b538d", 1850, 0 },
                    { "7aedcc25-471f-48a6-b6f2-16236e5a747c", "4fda97b7-0388-41a5-bb2e-d35071768e43", "Fantaisie-Impromptu", "4180556e-5365-4b9c-aa72-a47241346855", 1834, 1 },
                    { "8cc58b47-eb12-45b3-a8a9-f8408299160b", "71f6794c-ffe7-45d2-ad1b-0d289fbb7178", "Lettre à ma mère", "5a9ba216-9883-471d-9c0f-4c3d37e4ec34", 1979, 0 },
                    { "9263e9f4-1949-42e6-b805-d4b5da445c84", "7d912fa8-9124-4200-be12-4df303afa6de", "The Four Seasons", "7c561b1e-3070-4e83-b71a-2fd7a69fa040", 1725, 0 },
                    { "9a24cbf0-48b7-472a-944a-dd9b77ca8ea9", "cb1f955e-5c52-4819-8f1c-7db37beb246a", "Grandes études de Paganini", "864239f6-65c5-440f-8326-213b3b25693f", 1851, 0 },
                    { "ae5da170-2f1e-4954-bf36-77510fd03e00", "05eb4e6b-d0df-41bf-bfa6-4456a69048e8", "Violin Concerto No. 2", "493afb2c-eb2a-4eab-9e4e-6585eb9924ae", 1826, 0 },
                    { "bfbbdc08-1b2e-4931-94c1-a4d63183ba73", "3a2b8ebc-ab4b-4b96-864c-75e007b7ef7d", "Moonlight Sonata", "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb", 1802, 1 },
                    { "c6881cf2-830c-4108-80f1-098df2e8fe7f", "397f6b08-cb1e-48c4-a0ab-6cf5ecab159c", "The marriage of Figaro", "15fa89e4-7777-4330-b32e-62172cd398c0", 1786, 0 },
                    { "cce2ab42-5359-4623-a454-8414e6da9c4a", "62984273-d8d2-4c82-a137-9d532044af4c", "The Tale of Tsar Saltan", "cdbc9b43-ee1b-4a64-8b2d-d579522ea84f", 1900, 0 },
                    { "d26a31ad-293c-4e04-9b7d-3d609e70043a", "cb1f955e-5c52-4819-8f1c-7db37beb246a", "Hungarian Rhapsodies", "0a8c3ca2-56ca-4534-a426-648854e61821", 1885, 0 },
                    { "db9d14cd-a42b-4603-88c0-e1be2aeb6a7a", "397f6b08-cb1e-48c4-a0ab-6cf5ecab159c", "Piano Sonata No. 11", "b26e8131-28bf-4ae9-842b-33b3d639b08e", 1784, 0 },
                    { "f59dba60-7834-450c-8683-23c0cb9489f1", "a8108ac5-094f-46c8-905d-2e2ff500184c", "Waltz No. 2", "29ad8ca9-c791-4482-8a44-15776862b282", 1938, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "FileId", "Name" },
                values: new object[,]
                {
                    { "0317764d-0cb6-4421-aab4-00bdb3bedc1a", "d26a31ad-293c-4e04-9b7d-3d609e70043a", "2d47fb0d-971c-44e5-9d76-8b5589f0cbbb", "Hungarian Rhapsody No. 2" },
                    { "0ce909ba-a79d-4ee2-9c8c-e3790a9b795a", "2d059957-f392-43ed-87d1-4705e26a8936", "36febf49-1c49-4b69-8084-73ebce69040a", "Valse Sentimental" },
                    { "37f89c6a-4b0e-49e5-8a7f-65b27f521fe9", "ae5da170-2f1e-4954-bf36-77510fd03e00", "493afb2c-eb2a-4eab-9e4e-6585eb9924ae", "La Campanella" },
                    { "3a073972-cbed-48d0-9c96-3996288293df", "50744713-e72c-4511-b9dd-c86b421be9e2", "44f268c1-3e94-4d05-8ccb-17c2e77b538d", "Love Dream" },
                    { "3b67f3bc-7968-490f-8b04-9722d3a48460", "307e5d2d-28c3-407a-b3c2-adf6ac4f749b", "572cc6a2-a5ba-47f5-8819-8330770cf8b5", "Never gonna give you up" },
                    { "3f021a7a-59c3-4a6f-b40c-2a7a36fd7bc5", "f59dba60-7834-450c-8683-23c0cb9489f1", "29ad8ca9-c791-4482-8a44-15776862b282", "Waltz No. 2" },
                    { "4ac50eb6-dd9f-4ad2-bdb4-8504c6c77728", "bfbbdc08-1b2e-4931-94c1-a4d63183ba73", "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb", "Moonlight Sonata" },
                    { "53d43842-ac99-4d46-b8b6-1953f1b23d28", "db9d14cd-a42b-4603-88c0-e1be2aeb6a7a", "b26e8131-28bf-4ae9-842b-33b3d639b08e", "Turkish March" },
                    { "599e575c-4236-4fd4-8860-4ead50d09a69", "9263e9f4-1949-42e6-b805-d4b5da445c84", "9f1d7cfd-53c6-478f-82e2-db737d1b9ecf", "Spring" },
                    { "853bcdf0-c731-4844-8344-f5623e8d6f15", "1beb18cb-442c-482e-aad5-226a7c78ca35", "9d0a67df-6fb4-4fac-b670-49a5f590beb7", "Lacrimosa" },
                    { "8bac0058-8da2-4278-bf98-3adddff28914", "cce2ab42-5359-4623-a454-8414e6da9c4a", "cdbc9b43-ee1b-4a64-8b2d-d579522ea84f", "Flight of the Bumblebee" },
                    { "9f71550b-31bb-4078-835b-24fa2e60cb63", "c6881cf2-830c-4108-80f1-098df2e8fe7f", "15fa89e4-7777-4330-b32e-62172cd398c0", "Marriage of Figaro - Overture" },
                    { "cb68239b-c1ce-41b5-801f-d4d275bf6356", "9a24cbf0-48b7-472a-944a-dd9b77ca8ea9", "864239f6-65c5-440f-8326-213b3b25693f", "La Campanella" },
                    { "e8446f18-d1f4-424f-86d9-a6974929e6f9", "8cc58b47-eb12-45b3-a8a9-f8408299160b", "5a9ba216-9883-471d-9c0f-4c3d37e4ec34", "Marriage d'Amour" },
                    { "eb775cc6-5798-421b-9081-ab54bb24cfc4", "7aedcc25-471f-48a6-b6f2-16236e5a747c", "4180556e-5365-4b9c-aa72-a47241346855", "Fantaisie Impromptu" },
                    { "f0345d2c-5008-4287-96b4-1a334d3bb5a2", "9263e9f4-1949-42e6-b805-d4b5da445c84", "7c561b1e-3070-4e83-b71a-2fd7a69fa040", "Summer - Storm" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "238c45f5-c2a7-4317-882f-7b07fca05790");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "72811315-294c-42b0-bd40-1eed587d97ad");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "a0b124e5-055c-43a4-80f7-7f773a3b0a2a");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "a2832e5c-6da3-444a-97d8-ff899a304fd2");

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: "ad153fd0-dd2c-43a1-b6d2-327f99536750");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "0317764d-0cb6-4421-aab4-00bdb3bedc1a");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "0ce909ba-a79d-4ee2-9c8c-e3790a9b795a");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "37f89c6a-4b0e-49e5-8a7f-65b27f521fe9");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "3a073972-cbed-48d0-9c96-3996288293df");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "3b67f3bc-7968-490f-8b04-9722d3a48460");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "3f021a7a-59c3-4a6f-b40c-2a7a36fd7bc5");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "4ac50eb6-dd9f-4ad2-bdb4-8504c6c77728");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "53d43842-ac99-4d46-b8b6-1953f1b23d28");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "599e575c-4236-4fd4-8860-4ead50d09a69");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "853bcdf0-c731-4844-8344-f5623e8d6f15");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "8bac0058-8da2-4278-bf98-3adddff28914");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "9f71550b-31bb-4078-835b-24fa2e60cb63");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "cb68239b-c1ce-41b5-801f-d4d275bf6356");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "e8446f18-d1f4-424f-86d9-a6974929e6f9");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "eb775cc6-5798-421b-9081-ab54bb24cfc4");

            migrationBuilder.DeleteData(
                table: "Tracks",
                keyColumn: "Id",
                keyValue: "f0345d2c-5008-4287-96b4-1a334d3bb5a2");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "1beb18cb-442c-482e-aad5-226a7c78ca35");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "2d059957-f392-43ed-87d1-4705e26a8936");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "307e5d2d-28c3-407a-b3c2-adf6ac4f749b");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "50744713-e72c-4511-b9dd-c86b421be9e2");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "7aedcc25-471f-48a6-b6f2-16236e5a747c");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "8cc58b47-eb12-45b3-a8a9-f8408299160b");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "9263e9f4-1949-42e6-b805-d4b5da445c84");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "9a24cbf0-48b7-472a-944a-dd9b77ca8ea9");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "ae5da170-2f1e-4954-bf36-77510fd03e00");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "bfbbdc08-1b2e-4931-94c1-a4d63183ba73");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "c6881cf2-830c-4108-80f1-098df2e8fe7f");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "cce2ab42-5359-4623-a454-8414e6da9c4a");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "d26a31ad-293c-4e04-9b7d-3d609e70043a");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "db9d14cd-a42b-4603-88c0-e1be2aeb6a7a");

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: "f59dba60-7834-450c-8683-23c0cb9489f1");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "05eb4e6b-d0df-41bf-bfa6-4456a69048e8");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "397f6b08-cb1e-48c4-a0ab-6cf5ecab159c");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "3a2b8ebc-ab4b-4b96-864c-75e007b7ef7d");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "4fda97b7-0388-41a5-bb2e-d35071768e43");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "62984273-d8d2-4c82-a137-9d532044af4c");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "71f6794c-ffe7-45d2-ad1b-0d289fbb7178");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "7d912fa8-9124-4200-be12-4df303afa6de");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "88d01fa8-da8c-4edc-bf38-f83dbee33102");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "a8108ac5-094f-46c8-905d-2e2ff500184c");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "cb1f955e-5c52-4819-8f1c-7db37beb246a");

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: "efbe3c8f-a898-4c20-9510-7c0a1aceba0e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7da8b7c1-175d-4fb4-bf5e-5886e5fc8e3f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicId", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "04fa4b46-acf9-4c30-937d-6d13f2ab7b13", 0, "37f903bc-315f-4354-8312-4fa72285f9fc", "default@user.com", false, false, null, "John Doe", null, null, null, null, false, "default_pfp", 0, "1a3e5027-11d0-4942-a2e8-402944f7031f", false, "defaultUser" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "0f30a194-86d7-47c8-a7cf-83bef6b737da", "Classic" },
                    { "396d4f0d-61c0-4494-ae00-8ab50bff9676", "Jazz" },
                    { "4f0f5fe9-4ef7-406e-b997-a9927667747b", "New Age" },
                    { "b1068876-5947-491a-ab1f-0bf0b054f8fd", "Instrumental" },
                    { "b590dc80-2688-4806-903a-6601946b5dc0", "Pop" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[,]
                {
                    { "01f79e12-c164-4c41-bea4-3b0259b1a7da", "John Doe", "04fa4b46-acf9-4c30-937d-6d13f2ab7b13" },
                    { "1baf1e60-600e-4e57-b1fd-c7fa62999bf7", "John Doe", "04fa4b46-acf9-4c30-937d-6d13f2ab7b13" },
                    { "1df68c86-9584-4932-8009-1c18e23a54bb", "John Doe", "04fa4b46-acf9-4c30-937d-6d13f2ab7b13" },
                    { "4b7a1ddd-ff79-4b0d-a66b-12faa20d9f06", "John Doe", "04fa4b46-acf9-4c30-937d-6d13f2ab7b13" },
                    { "5d29f8bc-b6cc-4104-aafe-989049646d69", "John Doe", "04fa4b46-acf9-4c30-937d-6d13f2ab7b13" },
                    { "6b53ce6c-7cf4-4764-a292-84959f72d351", "John Doe", "04fa4b46-acf9-4c30-937d-6d13f2ab7b13" },
                    { "947e15de-fcfa-4781-ba9c-7060b7252750", "John Doe", "04fa4b46-acf9-4c30-937d-6d13f2ab7b13" },
                    { "a04ffa80-e908-450b-bb76-a3468306c22c", "John Doe", "04fa4b46-acf9-4c30-937d-6d13f2ab7b13" },
                    { "a57ec277-ad4a-4e9b-b024-c7b016aae366", "John Doe", "04fa4b46-acf9-4c30-937d-6d13f2ab7b13" },
                    { "ae765207-d991-4f58-991c-c052550a6dd8", "John Doe", "04fa4b46-acf9-4c30-937d-6d13f2ab7b13" },
                    { "b5b664c1-60a5-4fce-9cdf-6cadb1ec573b", "John Doe", "04fa4b46-acf9-4c30-937d-6d13f2ab7b13" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AuthorId", "Name", "PreviewId", "ReleaseYear", "Type" },
                values: new object[,]
                {
                    { "039d0f44-c45b-4522-8d36-d96e8d6f17d0", "947e15de-fcfa-4781-ba9c-7060b7252750", "Liebestraum", "44f268c1-3e94-4d05-8ccb-17c2e77b538d", 1850, 0 },
                    { "0caadb6f-9337-4fb9-a4c4-93c27b698007", "ae765207-d991-4f58-991c-c052550a6dd8", "Valse-Scherzo", "36febf49-1c49-4b69-8084-73ebce69040a", 1877, 0 },
                    { "12fb43f1-6cdc-4150-ac2c-6a0d6d6c5b6b", "1baf1e60-600e-4e57-b1fd-c7fa62999bf7", "Requiem", "9d0a67df-6fb4-4fac-b670-49a5f590beb7", 1791, 0 },
                    { "288d33b3-ce1d-4d49-88a4-f1611266723e", "1baf1e60-600e-4e57-b1fd-c7fa62999bf7", "Piano Sonata No. 11", "b26e8131-28bf-4ae9-842b-33b3d639b08e", 1784, 0 },
                    { "64bff82a-b7ac-4070-9df4-e8aad7910df3", "5d29f8bc-b6cc-4104-aafe-989049646d69", "The Tale of Tsar Saltan", "cdbc9b43-ee1b-4a64-8b2d-d579522ea84f", 1900, 0 },
                    { "6941dc78-efaf-4d4f-8a3f-a3922a8bbabd", "4b7a1ddd-ff79-4b0d-a66b-12faa20d9f06", "Whenever you need somebody", "572cc6a2-a5ba-47f5-8819-8330770cf8b5", 1987, 0 },
                    { "69fef71d-e08d-44b0-b580-98193c1dd29b", "b5b664c1-60a5-4fce-9cdf-6cadb1ec573b", "The Four Seasons", "7c561b1e-3070-4e83-b71a-2fd7a69fa040", 1725, 0 },
                    { "8c38ddd0-fd23-49f1-a2e7-544e259083f6", "947e15de-fcfa-4781-ba9c-7060b7252750", "Grandes études de Paganini", "864239f6-65c5-440f-8326-213b3b25693f", 1851, 0 },
                    { "9a66b187-007a-4fa9-b4db-e12eff7aa8c8", "947e15de-fcfa-4781-ba9c-7060b7252750", "Hungarian Rhapsodies", "0a8c3ca2-56ca-4534-a426-648854e61821", 1885, 0 },
                    { "c5f43b24-9d15-42df-bff8-1c18ae19ef70", "a04ffa80-e908-450b-bb76-a3468306c22c", "Lettre à ma mère", "5a9ba216-9883-471d-9c0f-4c3d37e4ec34", 1979, 0 },
                    { "d832b8ba-149d-4a77-bae1-fd9ec7fe73f7", "a57ec277-ad4a-4e9b-b024-c7b016aae366", "Violin Concerto No. 2", "493afb2c-eb2a-4eab-9e4e-6585eb9924ae", 1826, 0 },
                    { "e00cd5b9-d4d1-4e2a-98e3-7e25def2fe19", "1baf1e60-600e-4e57-b1fd-c7fa62999bf7", "The marriage of Figaro", "15fa89e4-7777-4330-b32e-62172cd398c0", 1786, 0 },
                    { "e06e3970-3100-4b54-9868-27bca967ac90", "1df68c86-9584-4932-8009-1c18e23a54bb", "Fantaisie-Impromptu", "4180556e-5365-4b9c-aa72-a47241346855", 1834, 1 },
                    { "f750ea06-1e45-4ea5-867c-98560f921b63", "6b53ce6c-7cf4-4764-a292-84959f72d351", "Moonlight Sonata", "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb", 1802, 1 },
                    { "f7f19a51-7047-470f-82e2-5e999058706e", "01f79e12-c164-4c41-bea4-3b0259b1a7da", "Waltz No. 2", "29ad8ca9-c791-4482-8a44-15776862b282", 1938, 1 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "FileId", "Name" },
                values: new object[,]
                {
                    { "19231971-f420-4030-a381-7ddb1727dc9d", "288d33b3-ce1d-4d49-88a4-f1611266723e", "b26e8131-28bf-4ae9-842b-33b3d639b08e", "Turkish March" },
                    { "315b4ab3-958e-436b-a15f-66b7af0bc463", "69fef71d-e08d-44b0-b580-98193c1dd29b", "9f1d7cfd-53c6-478f-82e2-db737d1b9ecf", "Spring" },
                    { "420e72cd-1449-4fa3-96f2-8a6d64992fb0", "9a66b187-007a-4fa9-b4db-e12eff7aa8c8", "2d47fb0d-971c-44e5-9d76-8b5589f0cbbb", "Hungarian Rhapsody No. 2" },
                    { "5a76c8c7-2270-405d-ad38-019144a2c4f4", "8c38ddd0-fd23-49f1-a2e7-544e259083f6", "864239f6-65c5-440f-8326-213b3b25693f", "La Campanella" },
                    { "6b217297-8bae-4d6c-a6f9-cf11034f32f2", "64bff82a-b7ac-4070-9df4-e8aad7910df3", "cdbc9b43-ee1b-4a64-8b2d-d579522ea84f", "Flight of the Bumblebee" },
                    { "8209bfde-10c2-42e0-8dfd-19becf702fbc", "69fef71d-e08d-44b0-b580-98193c1dd29b", "7c561b1e-3070-4e83-b71a-2fd7a69fa040", "Summer - Storm" },
                    { "90f4ab91-bbe0-4cfd-a6f8-cf0119ebcbde", "6941dc78-efaf-4d4f-8a3f-a3922a8bbabd", "572cc6a2-a5ba-47f5-8819-8330770cf8b5", "Never gonna give you up" },
                    { "9619dc9f-c0c3-4204-b822-dd935ab22716", "f7f19a51-7047-470f-82e2-5e999058706e", "29ad8ca9-c791-4482-8a44-15776862b282", "Waltz No. 2" },
                    { "9bfccb22-d485-412c-a532-105e56fe6dc4", "0caadb6f-9337-4fb9-a4c4-93c27b698007", "36febf49-1c49-4b69-8084-73ebce69040a", "Valse Sentimental" },
                    { "a6596364-933b-4cec-ac27-de4045b86e6e", "e06e3970-3100-4b54-9868-27bca967ac90", "4180556e-5365-4b9c-aa72-a47241346855", "Fantaisie Impromptu" },
                    { "a90c2516-9c7e-4bd5-a293-b8fe3e523e8f", "039d0f44-c45b-4522-8d36-d96e8d6f17d0", "44f268c1-3e94-4d05-8ccb-17c2e77b538d", "Love Dream" },
                    { "c116f80e-d76a-490f-a7dd-ce079e76933d", "f750ea06-1e45-4ea5-867c-98560f921b63", "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb", "Moonlight Sonata" },
                    { "d73aeb8d-2948-4243-a510-5f82e02eda1a", "c5f43b24-9d15-42df-bff8-1c18ae19ef70", "5a9ba216-9883-471d-9c0f-4c3d37e4ec34", "Marriage d'Amour" },
                    { "eac0deb6-2ec2-40de-b954-ff070ede4350", "e00cd5b9-d4d1-4e2a-98e3-7e25def2fe19", "15fa89e4-7777-4330-b32e-62172cd398c0", "Marriage of Figaro - Overture" },
                    { "ee801004-ebe5-4fc1-b5d0-cf05f9dcb5db", "12fb43f1-6cdc-4150-ac2c-6a0d6d6c5b6b", "9d0a67df-6fb4-4fac-b670-49a5f590beb7", "Lacrimosa" },
                    { "ef10bfc5-d207-4630-8cd5-285131120d62", "d832b8ba-149d-4a77-bae1-fd9ec7fe73f7", "493afb2c-eb2a-4eab-9e4e-6585eb9924ae", "La Campanella" }
                });
        }
    }
}
