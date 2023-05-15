using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class refactoredUserTrack : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTrack",
                table: "UserTrack");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "UserTrack",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTrack",
                table: "UserTrack",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "230199c4-e660-4dc9-89d7-250f8386d603", "6ac8ca64-ed86-4d82-ae62-d933f5247299" });

            migrationBuilder.CreateIndex(
                name: "IX_UserTrack_TrackId",
                table: "UserTrack",
                column: "TrackId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTrack",
                table: "UserTrack");

            migrationBuilder.DropIndex(
                name: "IX_UserTrack_TrackId",
                table: "UserTrack");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserTrack");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTrack",
                table: "UserTrack",
                columns: new[] { "TrackId", "UserId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "55c23b15-0a4f-4621-ace2-7c1739570e7f", "4eceb18b-9258-47eb-ae52-2e6c3e622a2b" });
        }
    }
}
