using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentProgressTracker.Migrations
{
    /// <inheritdoc />
    public partial class FixEnrollments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "LastName");

            migrationBuilder.AlterColumn<byte[]>(
                name: "ProfileImage",
                table: "Students",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "QualificationType",
                table: "Enrollments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-1",
                columns: new[] { "ConcurrencyStamp", "PersonId", "SecurityStamp" },
                values: new object[] { "3cd29249-56d4-4e14-9dad-4335bb49fe5d", null, "27c8a96c-c072-498b-b604-34880bd411d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "276c051b-bfd3-4f76-8247-c29abbe3f237", "6fee441f-9466-468d-83ce-3b281ce25100" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ca5ed90-1cb4-4d30-bb84-ea6b02cce80e", "f602e062-ab06-4809-9ad0-a05f700f4f10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9162278b-ffb6-4f90-be38-1bb5df191b21", "37378ff1-9403-47b8-a871-c0dc23c49e40" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d85e66d3-1ab5-4d4e-a759-e7245ae52d30", "0505044d-45e2-4054-b2ff-2d3d10514496" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5889e8bc-0cdf-4e83-9167-ffd5afb86a7a", "fbc89031-007a-4442-bb92-55be85a5b191" });

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 1,
                column: "QualificationType",
                value: "PostGraduation");

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 2,
                column: "QualificationType",
                value: "Honors");

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 3,
                column: "QualificationType",
                value: "PostGraduation");

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 4,
                column: "QualificationType",
                value: "Honors");

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 5,
                column: "QualificationType",
                value: "PostGraduation");

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 6,
                column: "QualificationType",
                value: "Honors");

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 7,
                column: "QualificationType",
                value: "PostGraduation");

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 8,
                column: "QualificationType",
                value: "Honors");

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 9,
                column: "QualificationType",
                value: "PostGraduation");

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 10,
                column: "QualificationType",
                value: "Honors");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Email", "FirstName", "LastName", "ProfileImage" },
                values: new object[] { "alice@domain.com", "Alice", "A", null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Email", "FirstName", "LastName", "ProfileImage" },
                values: new object[] { "bob@domain.com", "Bob", " B", null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Email", "FirstName", "LastName", "ProfileImage" },
                values: new object[] { "bob@domain.com", "Charlie", "C", null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Email", "FirstName", "LastName", "ProfileImage" },
                values: new object[] { "charlie@domain.com", "Diana", "D", null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Email", "FirstName", "LastName", "ProfileImage" },
                values: new object[] { "diana@domain.com", "Evan", "E", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Students",
                newName: "Name");

            migrationBuilder.AlterColumn<byte>(
                name: "ProfileImage",
                table: "Students",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QualificationType",
                table: "Enrollments",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user-1",
                columns: new[] { "ConcurrencyStamp", "PersonId", "SecurityStamp" },
                values: new object[] { "50a24237-35c7-4844-b193-c770af5a1ebe", 1, "e37f6fe3-7bf0-44d8-9f5b-8f6447567c7d" });

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

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 1,
                column: "QualificationType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 2,
                column: "QualificationType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 3,
                column: "QualificationType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 4,
                column: "QualificationType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 5,
                column: "QualificationType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 6,
                column: "QualificationType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 7,
                column: "QualificationType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 8,
                column: "QualificationType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 9,
                column: "QualificationType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: 10,
                column: "QualificationType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "ProfileImage" },
                values: new object[] { "Alice A", null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "ProfileImage" },
                values: new object[] { "Bob B", null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "ProfileImage" },
                values: new object[] { "Charlie C", null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "ProfileImage" },
                values: new object[] { "Diana D", null });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "ProfileImage" },
                values: new object[] { "Evan E", null });
        }
    }
}
