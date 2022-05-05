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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
              name  : "Language",
=======
                name: "Language",
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
                name: "Language",
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
=======
                name: "Language",
>>>>>>> f5255d0f872cdb79c9fd4f5200d26bed1ebeca9f
                table: "Book");
        }
    }
}
