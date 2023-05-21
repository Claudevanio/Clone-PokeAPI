using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clone_PokeAPI.Migrations
{
    public partial class AlturaPesoPokemon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Height", "Weight" },
                values: new object[] { 7, 69 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Height", "Weight" },
                values: new object[] { 10, 130 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Height", "Weight" },
                values: new object[] { 20, 1000 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Height", "Weight" },
                values: new object[] { 6, 85 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Height", "Weight" },
                values: new object[] { 11, 190 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Height", "Weight" },
                values: new object[] { 17, 905 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Height", "Weight" },
                values: new object[] { 5, 90 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Height", "Weight" },
                values: new object[] { 10, 225 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Height", "Weight" },
                values: new object[] { 16, 855 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Height", "Weight" },
                values: new object[] { 3, 29 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Height", "Weight" },
                values: new object[] { 7, 99 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Height", "Weight" },
                values: new object[] { 11, 320 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Height", "Weight" },
                values: new object[] { 3, 32 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Height", "Weight" },
                values: new object[] { 6, 100 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Height", "Weight" },
                values: new object[] { 10, 295 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Height", "Weight" },
                values: new object[] { 3, 18 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Height", "Weight" },
                values: new object[] { 11, 300 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Height", "Weight" },
                values: new object[] { 15, 395 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Height", "Weight" },
                values: new object[] { 3, 35 });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Height", "Weight" },
                values: new object[] { 7, 185 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Height",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Pokemons");
        }
    }
}
