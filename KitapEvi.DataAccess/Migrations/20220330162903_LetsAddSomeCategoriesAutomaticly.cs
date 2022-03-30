using Microsoft.EntityFrameworkCore.Migrations;

namespace KitapEvi.DataAccess.Migrations
{
    public partial class LetsAddSomeCategoriesAutomaticly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories VALUES ('Roman')");
            migrationBuilder.Sql("INSERT INTO Categories VALUES ('Şiir')");
            migrationBuilder.Sql("INSERT INTO Categories VALUES ('Bilim')");
            migrationBuilder.Sql("INSERT INTO Categories VALUES ('Spor')");
            migrationBuilder.Sql("INSERT INTO Categories VALUES ('Yabancı Dil')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
