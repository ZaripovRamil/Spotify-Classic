using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    /// <inheritdoc />
    public partial class SubsriptionsUserTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "68dae4e5-9ce0-4c04-98bf-470da907c669", "0c10398e-6c81-4c49-b191-5b5f192e34ec" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicId", "Role", "SecurityStamp", "SubscriptionExpire", "SubscriptionId", "TwoFactorEnabled", "UserName" },
                values: new object[] { "user2", 0, "a07a5915-761d-4c78-9264-ff4c1f871e20", null, false, false, null, "Jane Doe", null, null, null, null, false, "default_pfp", 0, "bd4f1d75-7df6-4441-b6aa-bbe60f086f0d", null, "Premium", false, "subscriptionTestUser" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e90e7a5c-786b-4559-a959-151ae7076294", "d32025fc-6a96-4929-bd07-5ac4dbc51363" });
        }
    }
}
