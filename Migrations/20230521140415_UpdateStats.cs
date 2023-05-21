using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clone_PokeAPI.Migrations
{
    public partial class UpdateStats : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 1,
                column: "BaseStat",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 2,
                column: "BaseStat",
                value: 62);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 3,
                column: "BaseStat",
                value: 63);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BaseStat", "Name" },
                values: new object[] { 63, "speed" });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 45, "hp", 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BaseStat", "Name" },
                values: new object[] { 49, "attack" });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "defense");

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BaseStat", "Name" },
                values: new object[] { 45, "speed" });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 39, "hp", 3 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 52, "attack", 3 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BaseStat", "Name" },
                values: new object[] { 43, "defense" });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BaseStat", "Name" },
                values: new object[] { 65, "speed" });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 58, "hp", 4 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 64, "attack", 4 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 58, "defense", 4 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BaseStat", "Name" },
                values: new object[] { 80, "speed" });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 44, "hp", 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 48, "attack", 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "PokemonModelId" },
                values: new object[] { "defense", 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 43, "speed", 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BaseStat", "PokemonModelId" },
                values: new object[] { 59, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BaseStat", "PokemonModelId" },
                values: new object[] { 63, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BaseStat", "PokemonModelId" },
                values: new object[] { 80, 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 58, "speed", 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 79, "hp", 7 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 83, "attack", 7 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 100, "defense", 7 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 78, "speed", 7 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 45, "hp", 8 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 30, "attack", 8 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 35, "defense", 8 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 45, "speed", 8 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 60, "hp", 9 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 60, "attack", 9 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 70, "defense", 9 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 40, "speed", 9 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 40, "hp", 10 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 45, "attack", 10 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 40, "defense", 10 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 56, "speed", 10 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 41,
                column: "PokemonModelId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BaseStat", "PokemonModelId" },
                values: new object[] { 50, 11 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BaseStat", "PokemonModelId" },
                values: new object[] { 55, 11 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 30, "speed", 11 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 60, "hp", 12 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 62, "attack", 12 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 63, "defense", 12 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 60, "speed", 12 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 50, "hp", 13 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 52, "attack", 13 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 48, "defense", 13 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 55, "speed", 13 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 80, "hp", 14 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 82, "attack", 14 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 78, "defense", 14 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 80, "speed", 14 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 40, "hp", 15 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 45, "attack", 15 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 35, "defense", 15 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 55, "speed", 15 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BaseStat", "PokemonModelId" },
                values: new object[] { 65, 16 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BaseStat", "PokemonModelId" },
                values: new object[] { 70, 16 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BaseStat", "PokemonModelId" },
                values: new object[] { 60, 16 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Name", "PokemonModelId" },
                values: new object[] { "speed", 16 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Name", "PokemonModelId" },
                values: new object[] { "hp", 17 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 75, "attack", 17 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 70, "defense", 17 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 90, "speed", 17 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 35, "hp", 18 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 70, "attack", 18 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 55, "defense", 18 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 25, "speed", 18 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 70, "hp", 19 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 85, "attack", 19 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Name", "PokemonModelId" },
                values: new object[] { "defense", 19 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 90, "speed", 19 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 55, "hp", 20 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 40, "attack", 20 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 40, "defense", 20 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 90, "speed", 20 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 1,
                column: "BaseStat",
                value: 49);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 2,
                column: "BaseStat",
                value: 49);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 3,
                column: "BaseStat",
                value: 49);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BaseStat", "Name" },
                values: new object[] { 49, "special-attack" });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "special-defense", 1 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BaseStat", "Name" },
                values: new object[] { 45, "hp" });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "attack");

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BaseStat", "Name" },
                values: new object[] { 49, "defense" });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-attack", 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-defense", 2 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BaseStat", "Name" },
                values: new object[] { 45, "hp" });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BaseStat", "Name" },
                values: new object[] { 49, "attack" });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "defense", 3 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-attack", 3 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-defense", 3 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BaseStat", "Name" },
                values: new object[] { 45, "hp" });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "attack", 4 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "defense", 4 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "PokemonModelId" },
                values: new object[] { "special-attack", 4 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-defense", 4 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BaseStat", "PokemonModelId" },
                values: new object[] { 45, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BaseStat", "PokemonModelId" },
                values: new object[] { 49, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BaseStat", "PokemonModelId" },
                values: new object[] { 49, 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-attack", 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-defense", 5 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 45, "hp", 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "attack", 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "defense", 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-attack", 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-defense", 6 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 45, "hp", 7 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "attack", 7 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "defense", 7 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-attack", 7 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-defense", 7 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 45, "hp", 8 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "attack", 8 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "defense", 8 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-attack", 8 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-defense", 8 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 41,
                column: "PokemonModelId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "BaseStat", "PokemonModelId" },
                values: new object[] { 49, 9 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "BaseStat", "PokemonModelId" },
                values: new object[] { 49, 9 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-attack", 9 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-defense", 9 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 45, "hp", 10 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "attack", 10 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "defense", 10 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-attack", 10 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-defense", 10 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 45, "hp", 11 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "attack", 11 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "defense", 11 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-attack", 11 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-defense", 11 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 45, "hp", 12 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "attack", 12 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "defense", 12 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-attack", 12 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-defense", 12 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "BaseStat", "PokemonModelId" },
                values: new object[] { 45, 13 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "BaseStat", "PokemonModelId" },
                values: new object[] { 49, 13 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "BaseStat", "PokemonModelId" },
                values: new object[] { 49, 13 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Name", "PokemonModelId" },
                values: new object[] { "special-attack", 13 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Name", "PokemonModelId" },
                values: new object[] { "special-defense", 13 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 45, "hp", 14 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "attack", 14 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "defense", 14 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-attack", 14 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-defense", 14 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 45, "hp", 15 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "attack", 15 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "defense", 15 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-attack", 15 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Name", "PokemonModelId" },
                values: new object[] { "special-defense", 15 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 45, "hp", 16 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "attack", 16 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 49, "defense", 16 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-attack", 16 });

            migrationBuilder.UpdateData(
                table: "Stats",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BaseStat", "Name", "PokemonModelId" },
                values: new object[] { 65, "special-defense", 16 });

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "Id", "BaseStat", "Name", "PokemonModelId" },
                values: new object[,]
                {
                    { 81, 45, "hp", 17 },
                    { 82, 49, "attack", 17 },
                    { 83, 49, "defense", 17 },
                    { 84, 65, "special-attack", 17 }
                });

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "Id", "BaseStat", "Name", "PokemonModelId" },
                values: new object[,]
                {
                    { 85, 65, "special-defense", 17 },
                    { 86, 45, "hp", 18 },
                    { 87, 49, "attack", 18 },
                    { 88, 49, "defense", 18 },
                    { 89, 65, "special-attack", 18 },
                    { 90, 65, "special-defense", 18 },
                    { 91, 45, "hp", 19 },
                    { 92, 49, "attack", 19 },
                    { 93, 49, "defense", 19 },
                    { 94, 65, "special-attack", 19 },
                    { 95, 65, "special-defense", 19 },
                    { 96, 45, "hp", 20 },
                    { 97, 49, "attack", 20 },
                    { 98, 49, "defense", 20 },
                    { 99, 65, "special-attack", 20 },
                    { 100, 65, "special-defense", 20 }
                });
        }
    }
}
