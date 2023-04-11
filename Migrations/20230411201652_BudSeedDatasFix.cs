using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clone_PokeAPI.Migrations
{
    public partial class BudSeedDatasFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PokemonType",
                columns: new[] { "Id", "PokemonModelId", "TypeModelId" },
                values: new object[] { 26, 8, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PokemonType",
                keyColumn: "Id",
                keyValue: 26);
        }
    }
}
