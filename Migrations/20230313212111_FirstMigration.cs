using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clone_PokeAPI.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DreamWorld");

            migrationBuilder.DropTable(
                name: "TypesPokemon");

            migrationBuilder.DropColumn(
                name: "Sprites_FrontDefault",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Sprites_Other_OtherFrontDefault",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "StatName",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "StatURL",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "StatValue",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Stat_Capacity",
                table: "Pokemons");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pokemons",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.CreateTable(
                name: "Sprites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FrontDefault = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherFrontDefault = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PokemonModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sprites_Pokemons_PokemonModelId",
                        column: x => x.PokemonModelId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BaseStat = table.Column<int>(type: "int", nullable: false),
                    PokemonModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stats_Pokemons_PokemonModelId",
                        column: x => x.PokemonModelId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PokemonModelTypeModel",
                columns: table => new
                {
                    PokemonsId = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonModelTypeModel", x => new { x.PokemonsId, x.TypeId });
                    table.ForeignKey(
                        name: "FK_PokemonModelTypeModel_Pokemons_PokemonsId",
                        column: x => x.PokemonsId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonModelTypeModel_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PokemonModelTypeModel_TypeId",
                table: "PokemonModelTypeModel",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sprites_PokemonModelId",
                table: "Sprites",
                column: "PokemonModelId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stats_PokemonModelId",
                table: "Stats",
                column: "PokemonModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonModelTypeModel");

            migrationBuilder.DropTable(
                name: "Sprites");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pokemons",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Sprites_FrontDefault",
                table: "Pokemons",
                type: "nvarchar(400)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sprites_Other_OtherFrontDefault",
                table: "Pokemons",
                type: "nvarchar(400)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StatName",
                table: "Pokemons",
                type: "nvarchar(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StatURL",
                table: "Pokemons",
                type: "nvarchar(350)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatValue",
                table: "Pokemons",
                type: "nvarchar(10)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Stat_Capacity",
                table: "Pokemons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DreamWorld",
                columns: table => new
                {
                    FrontDefault = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TypesPokemon",
                columns: table => new
                {
                    PokemonInfoModelId = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TypeURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesPokemon", x => x.PokemonInfoModelId);
                    table.ForeignKey(
                        name: "FK_TypesPokemon_Pokemons_PokemonInfoModelId",
                        column: x => x.PokemonInfoModelId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }
    }
}
