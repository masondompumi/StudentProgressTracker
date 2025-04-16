using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentProgressTracker.Migrations
{
    /// <inheritdoc />
    public partial class FixEnrollmentSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentFK",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_StudentFK",
                table: "Enrollments");

            migrationBuilder.DropColumn(
                name: "StudentFK",
                table: "Enrollments");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "Viewer", "VIEWER" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "IdNumber", "Name", "ProfileImage" },
                values: new object[,]
                {
                    { 1, 101, "Alice A", null },
                    { 2, 102, "Bob B", null },
                    { 3, 103, "Charlie C", null },
                    { 4, 104, "Diana D", null },
                    { 5, 105, "Evan E", null }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "AverageToDate", "EnrolmentDate", "Institution", "Qualification", "QualificationType", "StudentId" },
                values: new object[,]
                {
                    { 1, 72.5f, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "University 1A", "Degree A1", 1, 1 },
                    { 2, 81.3f, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "University 1B", "Degree B1", 2, 1 },
                    { 3, 72.5f, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "University 2A", "Degree A2", 1, 2 },
                    { 4, 81.3f, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "University 2B", "Degree B2", 2, 2 },
                    { 5, 72.5f, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "University 3A", "Degree A3", 1, 3 },
                    { 6, 81.3f, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "University 3B", "Degree B3", 2, 3 },
                    { 7, 72.5f, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "University 4A", "Degree A4", 1, 4 },
                    { 8, 81.3f, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "University 4B", "Degree B4", 2, 4 },
                    { 9, 72.5f, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "University 5A", "Degree A5", 1, 5 },
                    { 10, 81.3f, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "University 5B", "Degree B5", 2, 5 }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "FirstName", "LastName", "StudentId" },
                values: new object[,]
                {
                    { 1, "Alice", "Admin", 1 },
                    { 2, "Bob", "Brown", 2 },
                    { 3, "Charlie", "Clark", 3 },
                    { 4, "Diana", "Doe", 4 },
                    { 5, "Evan", "Evans", 5 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "IsAdmin", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonId", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "user-1", 0, "7b6b8835-d46d-4ef3-bd8e-e8f83233b666", "ApplicationUser", "alice@domain.com", true, true, false, null, "ALICE@DOMAIN.COM", "ALICE@DOMAIN.COM", "1e9a6b9afd56cf274a1b46367cad2ff478fb6f0e29e5766195848b1482d2", 1, null, false, "bbee5bda-0ad0-48df-9f7e-7c7c644d0c9e", false, "alice@domain.com" },
                    { "user-2", 0, "8ee318d1-2b2e-45ca-9ea3-fb3a07d1fd84", "ApplicationUser", "bob@domain.com", true, false, false, null, "BOB@DOMAIN.COM", "BOB@DOMAIN.COM", "cd92953692442115e21ca8c5daefaffe2b3d8737769700667cb8ca864ae1", 2, null, false, "437fb9d8-7c90-4da9-b0c3-a000fc8f73a9", false, "bob@domain.com" },
                    { "user-3", 0, "8a2eb9cf-12e7-465e-abde-b433f6cd0aa2", "ApplicationUser", "charlie@domain.com", true, false, false, null, "CHARLIE@DOMAIN.COM", "CHARLIE@DOMAIN.COM", "8821f0b783db3f50973e537d6c60e6d11b9f54e468f7ad3310d33a7ce5bd", 3, null, false, "b290f6ba-403f-4b3f-b76d-6d1593f1f740", false, "charlie@domain.com" },
                    { "user-4", 0, "431cf1eb-f2f8-434c-8e1a-7b1fb251d613", "ApplicationUser", "diana@domain.com", true, false, false, null, "DIANA@DOMAIN.COM", "DIANA@DOMAIN.COM", "7d2a607c01865556ee0b41989327f79cf4611f64ad6395b70c8dabce265a", 4, null, false, "a0e1aef7-56dc-499e-a173-62d94a95fb33", false, "diana@domain.com" },
                    { "user-5", 0, "45181178-272a-4bdd-a04a-a497fc5b720a", "ApplicationUser", "evan@domain.com", true, false, false, null, "EVAN@DOMAIN.COM", "EVAN@DOMAIN.COM", "1d822bf156637662c4dea432bf14e9a91395f395c81695069253c512665f", 5, null, false, "141dbf73-e86c-48a8-a282-b7d431c1da4f", false, "evan@domain.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "user-1" },
                    { "2", "user-2" },
                    { "2", "user-3" },
                    { "2", "user-4" },
                    { "2", "user-5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentId",
                table: "Enrollments",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentId",
                table: "Enrollments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollments_Students_StudentId",
                table: "Enrollments");

            migrationBuilder.DropIndex(
                name: "IX_Enrollments_StudentId",
                table: "Enrollments");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "user-1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "user-2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "user-3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "user-4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "user-5" });

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-5");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AddColumn<int>(
                name: "StudentFK",
                table: "Enrollments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentFK",
                table: "Enrollments",
                column: "StudentFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollments_Students_StudentFK",
                table: "Enrollments",
                column: "StudentFK",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
