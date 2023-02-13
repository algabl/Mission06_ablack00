using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_ablack00.Migrations
{
    public partial class Another : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 2,
                columns: new[] { "Category", "LentTo", "Notes", "Rating", "Title" },
                values: new object[] { "Murder Mystery", "Benoit Blanc", "You did this!", "PG-13", "Knives Out" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 2,
                columns: new[] { "Category", "LentTo", "Notes", "Rating", "Title" },
                values: new object[] { "Horror", "Stephen King", "Don't watch at midnight", "R", "It" });
        }
    }
}
