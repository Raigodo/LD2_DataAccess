using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab2.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class IncrementIdOnAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndingAt", "StartingAt" },
                values: new object[] { new DateTime(2024, 10, 30, 14, 26, 11, 352, DateTimeKind.Local).AddTicks(4337), new DateTime(2024, 10, 30, 12, 56, 11, 352, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndingAt", "StartingAt" },
                values: new object[] { new DateTime(2024, 10, 31, 14, 56, 11, 352, DateTimeKind.Local).AddTicks(4342), new DateTime(2024, 10, 31, 12, 56, 11, 352, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndingAt", "StartingAt" },
                values: new object[] { new DateTime(2024, 11, 1, 14, 26, 11, 352, DateTimeKind.Local).AddTicks(4346), new DateTime(2024, 11, 1, 12, 56, 11, 352, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndingAt", "StartingAt" },
                values: new object[] { new DateTime(2024, 11, 2, 14, 56, 11, 352, DateTimeKind.Local).AddTicks(4350), new DateTime(2024, 11, 2, 12, 56, 11, 352, DateTimeKind.Local).AddTicks(4348) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndingAt", "StartingAt" },
                values: new object[] { new DateTime(2024, 11, 3, 14, 26, 11, 352, DateTimeKind.Local).AddTicks(4353), new DateTime(2024, 11, 3, 12, 56, 11, 352, DateTimeKind.Local).AddTicks(4352) });
        }
    }
}
