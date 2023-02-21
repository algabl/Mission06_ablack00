using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_ablack00.Migrations
{
    public partial class YetAnother2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 1,
                column: "Notes",
                value: "Will make you cry");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 1,
                column: "Notes",
                value: "Literally the best movie ever");
        }
    }
}
