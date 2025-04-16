using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentProgressTracker.Migrations
{
    /// <inheritdoc />
    public partial class FixEnrollmentSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3", null, "Viewer", "VIEWER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fee60489-7cd1-44be-a4a9-39dbcce2bcfc", "9d315d75-7621-4014-a944-e64377f30de7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dc45ecd1-9486-4451-8984-c1b192aeff85", "35273069-f6dc-405f-9ee5-21f3daf34f64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86f21403-0594-452a-a000-2961f778f75c", "71afc930-57e6-41d0-a37d-844b49a9f3eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "78c3b28b-b221-4133-92eb-9d436a3819eb", "9e67be4f-2d90-47e4-b1b2-48f183373b36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4653a4e1-cf39-49e2-9336-fe268e406280", "c0c99ee8-2910-41b6-bba1-07515109459b" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "FirstName", "LastName", "StudentId" },
                values: new object[] { 6, "Viewer", "Evans", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "IsAdmin", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "user-6", 0, "0170642c-55d3-4b79-b7c3-6372733d2f47", "ApplicationUser", "alice1@domain.com", true, false, false, null, "ALICE1@DOMAIN.COM", "ALICE1@DOMAIN.COM", "1e9a6b9afd56cf274a1b46367cad2ff478fb6f0e29e5766195848b1482d2", 6, null, false, "acabec57-2f5f-4d7e-a836-3196e14d7cf8", false, "alice1@domain.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-6");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Name", "NormalizedName" },
                values: new object[] { "Viewer", "VIEWER" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b6b8835-d46d-4ef3-bd8e-e8f83233b666", "bbee5bda-0ad0-48df-9f7e-7c7c644d0c9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8ee318d1-2b2e-45ca-9ea3-fb3a07d1fd84", "437fb9d8-7c90-4da9-b0c3-a000fc8f73a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8a2eb9cf-12e7-465e-abde-b433f6cd0aa2", "b290f6ba-403f-4b3f-b76d-6d1593f1f740" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "431cf1eb-f2f8-434c-8e1a-7b1fb251d613", "a0e1aef7-56dc-499e-a173-62d94a95fb33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "45181178-272a-4bdd-a04a-a497fc5b720a", "141dbf73-e86c-48a8-a282-b7d431c1da4f" });
        }
    }
}
