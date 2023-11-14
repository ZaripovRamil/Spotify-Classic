using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class PlaylistTrackJoint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_AspNetUsers_OwnerId",
                table: "Playlists");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Playlists",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "PlaylistTracks",
                columns: table => new
                {
                    PlaylistId = table.Column<string>(type: "text", nullable: false),
                    TrackId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistTracks", x => new { x.PlaylistId, x.TrackId });
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "72f90829-e988-408b-ba43-adae9614b40c", "5b27870a-2b16-425f-8334-0a799ebdece6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6546a9e5-05c1-43c1-be60-3b2108b3bd4c", "17e2e095-f39f-49d3-ace4-57aece0ab14e" });

            migrationBuilder.AddForeignKey(
                name: "FK_Playlists_AspNetUsers_OwnerId",
                table: "Playlists",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_AspNetUsers_OwnerId",
                table: "Playlists");

            migrationBuilder.DropTable(
                name: "PlaylistTracks");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Playlists",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a62a829d-5519-4ac9-8d28-a75cb70a5b5b", "20a9c7e5-0fd3-4e0b-a781-3f41b63e2769" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5de47987-bcb0-46f6-b99d-c633ea80fb23", "6de39e36-07ba-484d-95d4-c049422ad31c" });

            migrationBuilder.AddForeignKey(
                name: "FK_Playlists_AspNetUsers_OwnerId",
                table: "Playlists",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
