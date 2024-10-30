using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab2.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddingStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.CoursesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_CourseStudent_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndingAt", "StartingAt" },
                values: new object[] { new DateTime(2024, 10, 30, 15, 6, 40, 379, DateTimeKind.Local).AddTicks(2881), new DateTime(2024, 10, 30, 13, 36, 40, 379, DateTimeKind.Local).AddTicks(2844) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndingAt", "StartingAt" },
                values: new object[] { new DateTime(2024, 10, 31, 15, 36, 40, 379, DateTimeKind.Local).AddTicks(2886), new DateTime(2024, 10, 31, 13, 36, 40, 379, DateTimeKind.Local).AddTicks(2884) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndingAt", "StartingAt" },
                values: new object[] { new DateTime(2024, 11, 1, 15, 6, 40, 379, DateTimeKind.Local).AddTicks(2891), new DateTime(2024, 11, 1, 13, 36, 40, 379, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndingAt", "StartingAt" },
                values: new object[] { new DateTime(2024, 11, 2, 15, 36, 40, 379, DateTimeKind.Local).AddTicks(2895), new DateTime(2024, 11, 2, 13, 36, 40, 379, DateTimeKind.Local).AddTicks(2893) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndingAt", "StartingAt" },
                values: new object[] { new DateTime(2024, 11, 3, 15, 6, 40, 379, DateTimeKind.Local).AddTicks(2899), new DateTime(2024, 11, 3, 13, 36, 40, 379, DateTimeKind.Local).AddTicks(2897) });

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_StudentsId",
                table: "CourseStudent",
                column: "StudentsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudent");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndingAt", "StartingAt" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 34, 6, 69, DateTimeKind.Local).AddTicks(9386), new DateTime(2024, 10, 30, 13, 4, 6, 69, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndingAt", "StartingAt" },
                values: new object[] { new DateTime(2024, 10, 31, 15, 4, 6, 69, DateTimeKind.Local).AddTicks(9392), new DateTime(2024, 10, 31, 13, 4, 6, 69, DateTimeKind.Local).AddTicks(9389) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndingAt", "StartingAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 34, 6, 69, DateTimeKind.Local).AddTicks(9396), new DateTime(2024, 11, 1, 13, 4, 6, 69, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndingAt", "StartingAt" },
                values: new object[] { new DateTime(2024, 11, 2, 15, 4, 6, 69, DateTimeKind.Local).AddTicks(9400), new DateTime(2024, 11, 2, 13, 4, 6, 69, DateTimeKind.Local).AddTicks(9398) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndingAt", "StartingAt" },
                values: new object[] { new DateTime(2024, 11, 3, 14, 34, 6, 69, DateTimeKind.Local).AddTicks(9403), new DateTime(2024, 11, 3, 13, 4, 6, 69, DateTimeKind.Local).AddTicks(9402) });
        }
    }
}
