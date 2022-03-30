using Microsoft.EntityFrameworkCore.Migrations;

namespace KitapEvi.DataAccess.Migrations
{
    public partial class addedFluentApiOneToOneBetweenBookwithBookDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookDetailId",
                table: "FluentApi_Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FluentApi_Books_BookDetailId",
                table: "FluentApi_Books",
                column: "BookDetailId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FluentApi_Books_FluentApi_BookDetails_BookDetailId",
                table: "FluentApi_Books",
                column: "BookDetailId",
                principalTable: "FluentApi_BookDetails",
                principalColumn: "BookDetailId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FluentApi_Books_FluentApi_BookDetails_BookDetailId",
                table: "FluentApi_Books");

            migrationBuilder.DropIndex(
                name: "IX_FluentApi_Books_BookDetailId",
                table: "FluentApi_Books");

            migrationBuilder.DropColumn(
                name: "BookDetailId",
                table: "FluentApi_Books");
        }
    }
}
