using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_ablack00.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "Category", "Edited", "LentTo", "Notes", "Rating", "Title" },
                values: new object[] { 1, "Animation", false, "Robert Parr", "Literally the best movie ever", "PG", "Inside Out" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "Category", "Edited", "LentTo", "Notes", "Rating", "Title" },
                values: new object[] { 2, "Horror", false, "Stephen King", "Don't watch at midnight", "R", "It" });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "FilmId", "Category", "Edited", "LentTo", "Notes", "Rating", "Title" },
                values: new object[] { 3, "Comedy", false, "Owen Wilson", "Wow.", "PG-13", "Zoolander" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 3);
        }
    }
}
