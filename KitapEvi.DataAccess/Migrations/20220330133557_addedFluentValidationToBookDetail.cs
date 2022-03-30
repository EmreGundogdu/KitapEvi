using Microsoft.EntityFrameworkCore.Migrations;

namespace KitapEvi.DataAccess.Migrations
{
    public partial class addedFluentValidationToBookDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FluentApi_BookDetails",
                columns: table => new
                {
                    BookDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberOfEpisodes = table.Column<int>(type: "int", nullable: false),
                    BookPage = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentApi_BookDetails", x => x.BookDetailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FluentApi_BookDetails");
        }
    }
}
