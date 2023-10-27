using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class SupportChatHistory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SupportChatMessagesHistory",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    SenderId = table.Column<string>(type: "text", nullable: false),
                    RoomId = table.Column<string>(type: "text", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: false),
                    IsOwner = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupportChatMessagesHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupportChatMessagesHistory_AspNetUsers_SenderId",
                        column: x => x.SenderId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "a62a829d-5519-4ac9-8d28-a75cb70a5b5b", "foo@bar.com", "20a9c7e5-0fd3-4e0b-a781-3f41b63e2769" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "5de47987-bcb0-46f6-b99d-c633ea80fb23", "bar@foo.com", "6de39e36-07ba-484d-95d4-c049422ad31c" });

            migrationBuilder.CreateIndex(
                name: "IX_SupportChatMessagesHistory_SenderId",
                table: "SupportChatMessagesHistory",
                column: "SenderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupportChatMessagesHistory");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "68dae4e5-9ce0-4c04-98bf-470da907c669", null, "0c10398e-6c81-4c49-b191-5b5f192e34ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityStamp" },
                values: new object[] { "a07a5915-761d-4c78-9264-ff4c1f871e20", null, "bd4f1d75-7df6-4441-b6aa-bbe60f086f0d" });
        }
    }
}
