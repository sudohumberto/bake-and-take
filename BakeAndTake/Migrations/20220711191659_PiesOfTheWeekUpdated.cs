using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeAndTake.Migrations
{
    public partial class PiesOfTheWeekUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsPieOfTheWeek",
                value: true);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsPieOfTheWeek",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsPieOfTheWeek",
                value: false);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsPieOfTheWeek",
                value: false);
        }
    }
}
