using Microsoft.EntityFrameworkCore.Migrations;

namespace WpfTilt.Migrations
{
    public partial class RenameTableMouses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Mice",
                table: "Mice");

            migrationBuilder.RenameTable(
                name: "Mice",
                newName: "Mouses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mouses",
                table: "Mouses",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Mouses",
                table: "Mouses");

            migrationBuilder.RenameTable(
                name: "Mouses",
                newName: "Mice");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mice",
                table: "Mice",
                column: "Id");
        }
    }
}
