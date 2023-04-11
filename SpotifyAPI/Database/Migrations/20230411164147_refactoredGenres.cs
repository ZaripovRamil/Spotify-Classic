using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class refactoredGenres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenreTrack_Genres_GenresId",
                table: "GenreTrack");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreTrack_Tracks_TracksId",
                table: "GenreTrack");

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

            migrationBuilder.RenameColumn(
                name: "TracksId",
                table: "GenreTrack",
                newName: "TrackId");

            migrationBuilder.RenameColumn(
                name: "GenresId",
                table: "GenreTrack",
                newName: "GenreId");

            migrationBuilder.RenameIndex(
                name: "IX_GenreTrack_TracksId",
                table: "GenreTrack",
                newName: "IX_GenreTrack_TrackId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_GenreTrack_Genres_GenreId",
                table: "GenreTrack",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreTrack_Tracks_TrackId",
                table: "GenreTrack",
                column: "TrackId",
                principalTable: "Tracks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GenreTrack_Genres_GenreId",
                table: "GenreTrack");

            migrationBuilder.DropForeignKey(
                name: "FK_GenreTrack_Tracks_TrackId",
                table: "GenreTrack");

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

            migrationBuilder.RenameColumn(
                name: "TrackId",
                table: "GenreTrack",
                newName: "TracksId");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "GenreTrack",
                newName: "GenresId");

            migrationBuilder.RenameIndex(
                name: "IX_GenreTrack_TrackId",
                table: "GenreTrack",
                newName: "IX_GenreTrack_TracksId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_GenreTrack_Genres_GenresId",
                table: "GenreTrack",
                column: "GenresId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GenreTrack_Tracks_TracksId",
                table: "GenreTrack",
                column: "TracksId",
                principalTable: "Tracks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
