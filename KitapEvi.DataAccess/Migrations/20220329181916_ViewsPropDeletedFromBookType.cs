using Microsoft.EntityFrameworkCore.Migrations;

namespace KitapEvi.DataAccess.Migrations
{
    public partial class ViewsPropDeletedFromBookType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Views",
                table: "BookTypes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Views",
                table: "BookTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
