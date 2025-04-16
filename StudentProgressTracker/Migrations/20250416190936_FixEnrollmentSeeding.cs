using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentProgressTracker.Migrations
{
    /// <inheritdoc />
    public partial class FixEnrollmentSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3", "user-6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "50a24237-35c7-4844-b193-c770af5a1ebe", "e37f6fe3-7bf0-44d8-9f5b-8f6447567c7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ed2ea571-36da-424c-827b-3c3c2a30b2cf", "b53afcb8-2801-4082-8c65-2192544493f4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1c8059c4-2422-46ad-b70a-f04b81f72577", "7bdaee24-ca80-409d-9c05-fc155f17bdb4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3d927a4b-0e35-4d61-bf11-298827db9a76", "7934951b-8307-4027-918b-cac5d8a6a63b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4de73d10-1f51-4d0d-a97d-4717f5b50168", "fb1de074-d5ef-4568-81c1-9d9020547432" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "152153b5-72d3-49e1-8114-17e3609233b9", "c6ae8884-e922-4408-ab72-3a5cfbe8987e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "user-6" });

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0170642c-55d3-4b79-b7c3-6372733d2f47", "acabec57-2f5f-4d7e-a836-3196e14d7cf8" });
        }
    }
}
