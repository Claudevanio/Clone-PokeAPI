using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clone_PokeAPI.Migrations
{
    public partial class TestImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sprites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FrontDefault", "OtherFrontDefault" },
                values: new object[] { "http://localhost:7066/Gifs/bulbassaur-card.gif", "http://localhost:7066/Gifs/bulbassaur-details.gif" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sprites",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FrontDefault", "OtherFrontDefault" },
                values: new object[] { "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/1.svg" });
        }
    }
}
