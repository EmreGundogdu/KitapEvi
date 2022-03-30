using Microsoft.EntityFrameworkCore.Migrations;

namespace KitapEvi.DataAccess.Migrations
{
    public partial class ManyToManyRelationOnBookWriter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FluentApi_BookWriter",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    WriterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentApi_BookWriter", x => new { x.WriterId, x.BookId });
                    table.ForeignKey(
                        name: "FK_FluentApi_BookWriter_FluentApi_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "FluentApi_Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FluentApi_BookWriter_FluentApi_Writers_WriterId",
                        column: x => x.WriterId,
                        principalTable: "FluentApi_Writers",
                        principalColumn: "WriterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FluentApi_BookWriter_BookId",
                table: "FluentApi_BookWriter",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FluentApi_BookWriter");
        }
    }
}
