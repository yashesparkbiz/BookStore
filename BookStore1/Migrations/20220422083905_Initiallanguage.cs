using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore1.Migrations
{
    public partial class Initiallanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Book",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(

              name  : "Language",

                table: "Book");
        }
    }
}
