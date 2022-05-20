using Microsoft.EntityFrameworkCore.Migrations;

namespace WpfTilt.Migrations
{
    public partial class FixedPropsDriver : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Drivers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Drivers");
        }
    }
}
