using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore1.Migrations
{
    public partial class Addednewfk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookGallery_Book_BooksId",
                table: "BookGallery");

            migrationBuilder.DropIndex(
                name: "IX_BookGallery_BooksId",
                table: "BookGallery");

            migrationBuilder.DropColumn(
                name: "BooksId",
                table: "BookGallery");

            migrationBuilder.CreateIndex(
                name: "IX_BookGallery_BookId",
                table: "BookGallery",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookGallery_Book_BookId",
                table: "BookGallery",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookGallery_Book_BookId",
                table: "BookGallery");

            migrationBuilder.DropIndex(
                name: "IX_BookGallery_BookId",
                table: "BookGallery");

            migrationBuilder.AddColumn<int>(
                name: "BooksId",
                table: "BookGallery",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookGallery_BooksId",
                table: "BookGallery",
                column: "BooksId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookGallery_Book_BooksId",
                table: "BookGallery",
                column: "BooksId",
                principalTable: "Book",
                principalColumn: "Id");
        }
    }
}
