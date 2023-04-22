using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class initialConstIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ProfilePicId = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Authors_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    PreviewId = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    OwnerId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Playlists_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    PreviewId = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    AuthorId = table.Column<string>(type: "text", nullable: false),
                    ReleaseYear = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tracks",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    FileId = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    AlbumId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tracks_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreTrack",
                columns: table => new
                {
                    GenreId = table.Column<string>(type: "text", nullable: false),
                    TrackId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreTrack", x => new { x.GenreId, x.TrackId });
                    table.ForeignKey(
                        name: "FK_GenreTrack_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreTrack_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlaylistTrack",
                columns: table => new
                {
                    InPlaylistsId = table.Column<string>(type: "text", nullable: false),
                    TracksId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistTrack", x => new { x.InPlaylistsId, x.TracksId });
                    table.ForeignKey(
                        name: "FK_PlaylistTrack_Playlists_InPlaylistsId",
                        column: x => x.InPlaylistsId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaylistTrack_Tracks_TracksId",
                        column: x => x.TracksId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrackUser",
                columns: table => new
                {
                    HistoryId = table.Column<string>(type: "text", nullable: false),
                    HistoryId1 = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackUser", x => new { x.HistoryId, x.HistoryId1 });
                    table.ForeignKey(
                        name: "FK_TrackUser_AspNetUsers_HistoryId1",
                        column: x => x.HistoryId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrackUser_Tracks_HistoryId",
                        column: x => x.HistoryId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicId", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "user1", 0, "fdc9b7a8-074f-4c4c-959f-42ce5c9149ff", null, false, false, null, "John Doe", null, null, null, null, false, "default_pfp", 0, "49c8fd09-2127-4afd-869b-c22773479b09", false, "defaultUser" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "genre1", "Classic" },
                    { "genre2", "Instrumental" },
                    { "genre3", "Jazz" },
                    { "genre4", "New Age" },
                    { "genre5", "Pop" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[,]
                {
                    { "author1", "Wolfgang Amadeus Mozart", "user1" },
                    { "author10", "Rick Astley", "user1" },
                    { "author11", "Pyotr Tchaikovsky", "user1" },
                    { "author2", "Antonio Lucio Vivaldi", "user1" },
                    { "author3", "Ludwig van Beethoven", "user1" },
                    { "author4", "Dmitri Shostakovich", "user1" },
                    { "author5", "Frédéric Chopin", "user1" },
                    { "author6", "Nikolai Rimsky-Korsakov", "user1" },
                    { "author7", "Franz Liszt", "user1" },
                    { "author8", "Paul de Senneville", "user1" },
                    { "author9", "Niccolò Paganini", "user1" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "AuthorId", "Name", "PreviewId", "ReleaseYear", "Type" },
                values: new object[,]
                {
                    { "album", "author2", "The Four Seasons", "7c561b1e-3070-4e83-b71a-2fd7a69fa040", 1725, 0 },
                    { "album1", "author3", "Moonlight Sonata", "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb", 1802, 1 },
                    { "album10", "author9", "Violin Concerto No. 2", "493afb2c-eb2a-4eab-9e4e-6585eb9924ae", 1826, 0 },
                    { "album11", "author10", "Whenever you need somebody", "572cc6a2-a5ba-47f5-8819-8330770cf8b5", 1987, 0 },
                    { "album12", "author11", "Valse-Scherzo", "36febf49-1c49-4b69-8084-73ebce69040a", 1877, 0 },
                    { "album13", "author1", "Piano Sonata No. 11", "b26e8131-28bf-4ae9-842b-33b3d639b08e", 1784, 0 },
                    { "album14", "author7", "Hungarian Rhapsodies", "0a8c3ca2-56ca-4534-a426-648854e61821", 1885, 0 },
                    { "album2", "author4", "Waltz No. 2", "29ad8ca9-c791-4482-8a44-15776862b282", 1938, 1 },
                    { "album3", "author5", "Fantaisie-Impromptu", "4180556e-5365-4b9c-aa72-a47241346855", 1834, 1 },
                    { "album4", "author6", "The Tale of Tsar Saltan", "cdbc9b43-ee1b-4a64-8b2d-d579522ea84f", 1900, 0 },
                    { "album5", "author7", "Liebestraum", "44f268c1-3e94-4d05-8ccb-17c2e77b538d", 1850, 0 },
                    { "album6", "author7", "Grandes études de Paganini", "864239f6-65c5-440f-8326-213b3b25693f", 1851, 0 },
                    { "album7", "author8", "Lettre à ma mère", "5a9ba216-9883-471d-9c0f-4c3d37e4ec34", 1979, 0 },
                    { "album8", "author1", "Requiem", "9d0a67df-6fb4-4fac-b670-49a5f590beb7", 1791, 0 },
                    { "album9", "author1", "The marriage of Figaro", "15fa89e4-7777-4330-b32e-62172cd398c0", 1786, 0 }
                });

            migrationBuilder.InsertData(
                table: "Tracks",
                columns: new[] { "Id", "AlbumId", "FileId", "Name" },
                values: new object[,]
                {
                    { "track1", "album", "7c561b1e-3070-4e83-b71a-2fd7a69fa040", "Summer - Storm" },
                    { "track10", "album8", "9d0a67df-6fb4-4fac-b670-49a5f590beb7", "Lacrimosa" },
                    { "track11", "album9", "15fa89e4-7777-4330-b32e-62172cd398c0", "Marriage of Figaro - Overture" },
                    { "track12", "album10", "493afb2c-eb2a-4eab-9e4e-6585eb9924ae", "La Campanella" },
                    { "track13", "album11", "572cc6a2-a5ba-47f5-8819-8330770cf8b5", "Never gonna give you up" },
                    { "track14", "album12", "36febf49-1c49-4b69-8084-73ebce69040a", "Valse Sentimental" },
                    { "track15", "album13", "b26e8131-28bf-4ae9-842b-33b3d639b08e", "Turkish March" },
                    { "track16", "album14", "2d47fb0d-971c-44e5-9d76-8b5589f0cbbb", "Hungarian Rhapsody No. 2" },
                    { "track2", "album", "9f1d7cfd-53c6-478f-82e2-db737d1b9ecf", "Spring" },
                    { "track3", "album1", "e6a51aae-2ee3-4253-8b9c-1e88e65f0efb", "Moonlight Sonata" },
                    { "track4", "album2", "29ad8ca9-c791-4482-8a44-15776862b282", "Waltz No. 2" },
                    { "track5", "album3", "4180556e-5365-4b9c-aa72-a47241346855", "Fantaisie Impromptu" },
                    { "track6", "album4", "cdbc9b43-ee1b-4a64-8b2d-d579522ea84f", "Flight of the Bumblebee" },
                    { "track7", "album6", "864239f6-65c5-440f-8326-213b3b25693f", "La Campanella" },
                    { "track8", "album5", "44f268c1-3e94-4d05-8ccb-17c2e77b538d", "Love Dream" },
                    { "track9", "album7", "5a9ba216-9883-471d-9c0f-4c3d37e4ec34", "Marriage d'Amour" }
                });

            migrationBuilder.InsertData(
                table: "GenreTrack",
                columns: new[] { "GenreId", "TrackId" },
                values: new object[,]
                {
                    { "genre1", "track1" },
                    { "genre1", "track10" },
                    { "genre1", "track11" },
                    { "genre1", "track12" },
                    { "genre1", "track14" },
                    { "genre1", "track15" },
                    { "genre1", "track16" },
                    { "genre1", "track2" },
                    { "genre1", "track3" },
                    { "genre1", "track4" },
                    { "genre1", "track5" },
                    { "genre1", "track6" },
                    { "genre1", "track7" },
                    { "genre1", "track8" },
                    { "genre2", "track1" },
                    { "genre2", "track11" },
                    { "genre2", "track12" },
                    { "genre2", "track14" },
                    { "genre2", "track15" },
                    { "genre2", "track16" },
                    { "genre2", "track2" },
                    { "genre2", "track3" },
                    { "genre2", "track5" },
                    { "genre2", "track6" },
                    { "genre2", "track7" },
                    { "genre2", "track8" },
                    { "genre2", "track9" },
                    { "genre3", "track4" },
                    { "genre4", "track9" },
                    { "genre5", "track13" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_AuthorId",
                table: "Albums",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserName_Email",
                table: "AspNetUsers",
                columns: new[] { "UserName", "Email" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Authors_UserId",
                table: "Authors",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Genres_Name",
                table: "Genres",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GenreTrack_TrackId",
                table: "GenreTrack",
                column: "TrackId");

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_OwnerId",
                table: "Playlists",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistTrack_TracksId",
                table: "PlaylistTrack",
                column: "TracksId");

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_AlbumId",
                table: "Tracks",
                column: "AlbumId");

            migrationBuilder.CreateIndex(
                name: "IX_TrackUser_HistoryId1",
                table: "TrackUser",
                column: "HistoryId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "GenreTrack");

            migrationBuilder.DropTable(
                name: "PlaylistTrack");

            migrationBuilder.DropTable(
                name: "TrackUser");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Playlists");

            migrationBuilder.DropTable(
                name: "Tracks");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
