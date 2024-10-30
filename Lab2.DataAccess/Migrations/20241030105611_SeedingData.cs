using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab2.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "JoinedOn", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, new DateOnly(2001, 7, 7), "Instruktors 1", "aaaaaaaaaaa" },
                    { 2, new DateOnly(2010, 12, 1), "Instruktors 2", "bbbbbbbbbbbbbbb" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "EndingAt", "InstructorId", "StartingAt", "Topic" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 1, 30, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "why 2 + 2 != 4" },
                    { 2, new DateTime(2024, 10, 30, 14, 26, 11, 352, DateTimeKind.Local).AddTicks(4337), 1, new DateTime(2024, 10, 30, 12, 56, 11, 352, DateTimeKind.Local).AddTicks(4296), "why 2 + 2 != 4" },
                    { 3, new DateTime(2024, 10, 31, 14, 56, 11, 352, DateTimeKind.Local).AddTicks(4342), 1, new DateTime(2024, 10, 31, 12, 56, 11, 352, DateTimeKind.Local).AddTicks(4339), "Introduction to Quantum Mechanics" },
                    { 4, new DateTime(2024, 11, 1, 14, 26, 11, 352, DateTimeKind.Local).AddTicks(4346), 1, new DateTime(2024, 11, 1, 12, 56, 11, 352, DateTimeKind.Local).AddTicks(4344), "Advanced Mathematics" },
                    { 5, new DateTime(2024, 11, 2, 14, 56, 11, 352, DateTimeKind.Local).AddTicks(4350), 2, new DateTime(2024, 11, 2, 12, 56, 11, 352, DateTimeKind.Local).AddTicks(4348), "Philosophy of Science" },
                    { 6, new DateTime(2024, 11, 3, 14, 26, 11, 352, DateTimeKind.Local).AddTicks(4353), 2, new DateTime(2024, 11, 3, 12, 56, 11, 352, DateTimeKind.Local).AddTicks(4352), "History of Art" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
