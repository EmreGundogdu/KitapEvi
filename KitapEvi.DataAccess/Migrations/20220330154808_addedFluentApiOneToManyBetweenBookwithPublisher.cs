using Microsoft.EntityFrameworkCore.Migrations;

namespace KitapEvi.DataAccess.Migrations
{
    public partial class addedFluentApiOneToManyBetweenBookwithPublisher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "FluentApi_Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FluentApi_Books_PublisherId",
                table: "FluentApi_Books",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_FluentApi_Books_FluentApi_Publishers_PublisherId",
                table: "FluentApi_Books",
                column: "PublisherId",
                principalTable: "FluentApi_Publishers",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FluentApi_Books_FluentApi_Publishers_PublisherId",
                table: "FluentApi_Books");

            migrationBuilder.DropIndex(
                name: "IX_FluentApi_Books_PublisherId",
                table: "FluentApi_Books");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "FluentApi_Books");
        }
    }
}
