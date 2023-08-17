using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CircuitCalendarApi.Migrations
{
    public partial class ChangeDataBaseStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "CalendarEvents");

            migrationBuilder.DropColumn(
                name: "Month",
                table: "CalendarEvents");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CalendarEvents");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "CalendarEvents");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "CalendarEvents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Month",
                table: "CalendarEvents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "CalendarEvents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "CalendarEvents",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
