using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_ablack00.Migrations
{
    public partial class yetanother : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Films",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Films",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 1,
                columns: new[] { "Director", "Year" },
                values: new object[] { "Pete Docter", 2015 });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 2,
                columns: new[] { "Director", "Year" },
                values: new object[] { "Rian Johnson", 2019 });

            migrationBuilder.UpdateData(
                table: "Films",
                keyColumn: "FilmId",
                keyValue: 3,
                columns: new[] { "Director", "Year" },
                values: new object[] { "Ben Stiller", 2001 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Director",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Films");
        }
    }
}
