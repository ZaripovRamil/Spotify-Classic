using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class refactoredHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrackUser");

            migrationBuilder.CreateTable(
                name: "UserTrack",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    TrackId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTrack", x => new { x.TrackId, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserTrack_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserTrack_Tracks_TrackId",
                        column: x => x.TrackId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "55c23b15-0a4f-4621-ace2-7c1739570e7f", "4eceb18b-9258-47eb-ae52-2e6c3e622a2b" });

            migrationBuilder.CreateIndex(
                name: "IX_UserTrack_UserId",
                table: "UserTrack",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserTrack");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fdc9b7a8-074f-4c4c-959f-42ce5c9149ff", "49c8fd09-2127-4afd-869b-c22773479b09" });

            migrationBuilder.CreateIndex(
                name: "IX_TrackUser_HistoryId1",
                table: "TrackUser",
                column: "HistoryId1");
        }
    }
}
