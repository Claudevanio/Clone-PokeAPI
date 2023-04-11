using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clone_PokeAPI.Migrations
{
    public partial class AddSeedDatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

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
                name: "PokemonType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonModelId = table.Column<int>(type: "int", nullable: false),
                    TypeModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PokemonType_Pokemons_PokemonModelId",
                        column: x => x.PokemonModelId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonType_Types_TypeModelId",
                        column: x => x.TypeModelId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "bulbasaur" },
                    { 2, "ivysaur" },
                    { 3, "venusaur" },
                    { 4, "charmander" },
                    { 5, "charmeleon" },
                    { 6, "charizard" },
                    { 7, "squirtle" },
                    { 8, "wartortle" },
                    { 9, "blastoise" },
                    { 10, "caterpie" },
                    { 11, "metapod" },
                    { 12, "butterfree" },
                    { 13, "weedle" },
                    { 14, "kakuna" },
                    { 15, "beedrill" },
                    { 16, "pidgey" },
                    { 17, "pidgeotto" },
                    { 18, "pidgeot" },
                    { 19, "rattata" },
                    { 20, "raticate" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "Id", "TypeName" },
                values: new object[,]
                {
                    { 1, "grass" },
                    { 2, "poison" },
                    { 3, "fire" },
                    { 4, "water" },
                    { 5, "bug" },
                    { 6, "normal" },
                    { 7, "flying" },
                    { 8, "electric" }
                });

            migrationBuilder.InsertData(
                table: "PokemonType",
                columns: new[] { "Id", "PokemonModelId", "TypeModelId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 1 },
                    { 4, 2, 2 },
                    { 5, 3, 1 },
                    { 6, 3, 2 },
                    { 7, 4, 3 },
                    { 8, 5, 3 },
                    { 9, 6, 3 },
                    { 10, 6, 7 },
                    { 11, 7, 4 },
                    { 12, 9, 4 },
                    { 13, 10, 5 },
                    { 14, 11, 5 },
                    { 15, 12, 5 },
                    { 16, 12, 7 },
                    { 17, 13, 5 },
                    { 18, 13, 2 },
                    { 19, 14, 2 },
                    { 20, 15, 2 },
                    { 21, 16, 6 },
                    { 22, 17, 6 },
                    { 23, 18, 6 },
                    { 24, 19, 6 },
                    { 25, 20, 6 }
                });

            migrationBuilder.InsertData(
                table: "Sprites",
                columns: new[] { "Id", "FrontDefault", "OtherFrontDefault", "PokemonModelId" },
                values: new object[,]
                {
                    { 1, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/1.svg", 1 },
                    { 2, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/2.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/2.svg", 2 },
                    { 3, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/3.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/3.svg", 3 },
                    { 4, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/4.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/4.svg", 4 },
                    { 5, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/5.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/5.svg", 5 },
                    { 6, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/6.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/6.svg", 6 },
                    { 7, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/7.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/7.svg", 7 },
                    { 8, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/8.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/8.svg", 8 },
                    { 9, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/9.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/9.svg", 9 },
                    { 10, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/10.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/10.svg", 10 },
                    { 11, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/11.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/11.svg", 11 },
                    { 12, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/12.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/12.svg", 12 },
                    { 13, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/13.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/13.svg", 13 },
                    { 14, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/14.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/14.svg", 14 },
                    { 15, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/15.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/15.svg", 15 },
                    { 16, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/16.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/16.svg", 16 },
                    { 17, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/17.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/17.svg", 17 }
                });

            migrationBuilder.InsertData(
                table: "Sprites",
                columns: new[] { "Id", "FrontDefault", "OtherFrontDefault", "PokemonModelId" },
                values: new object[,]
                {
                    { 18, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/18.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/18.svg", 18 },
                    { 19, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/19.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/19.svg", 19 },
                    { 20, "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/20.png", "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/20.svg", 20 }
                });

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "Id", "BaseStat", "Name", "PokemonModelId" },
                values: new object[,]
                {
                    { 1, 49, "hp", 1 },
                    { 2, 49, "attack", 1 },
                    { 3, 49, "defense", 1 },
                    { 4, 49, "special-attack", 1 },
                    { 5, 49, "special-defense", 1 },
                    { 6, 45, "hp", 2 },
                    { 7, 49, "attack", 2 },
                    { 8, 49, "defense", 2 },
                    { 9, 65, "special-attack", 2 },
                    { 10, 65, "special-defense", 2 },
                    { 11, 45, "hp", 3 },
                    { 12, 49, "attack", 3 },
                    { 13, 49, "defense", 3 },
                    { 14, 65, "special-attack", 3 },
                    { 15, 65, "special-defense", 3 },
                    { 16, 45, "hp", 4 },
                    { 17, 49, "attack", 4 },
                    { 18, 49, "defense", 4 },
                    { 19, 65, "special-attack", 4 },
                    { 20, 65, "special-defense", 4 },
                    { 21, 45, "hp", 5 },
                    { 22, 49, "attack", 5 },
                    { 23, 49, "defense", 5 },
                    { 24, 65, "special-attack", 5 },
                    { 25, 65, "special-defense", 5 },
                    { 26, 45, "hp", 6 },
                    { 27, 49, "attack", 6 },
                    { 28, 49, "defense", 6 },
                    { 29, 65, "special-attack", 6 },
                    { 30, 65, "special-defense", 6 },
                    { 31, 45, "hp", 7 },
                    { 32, 49, "attack", 7 },
                    { 33, 49, "defense", 7 },
                    { 34, 65, "special-attack", 7 },
                    { 35, 65, "special-defense", 7 },
                    { 36, 45, "hp", 8 },
                    { 37, 49, "attack", 8 },
                    { 38, 49, "defense", 8 },
                    { 39, 65, "special-attack", 8 }
                });

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "Id", "BaseStat", "Name", "PokemonModelId" },
                values: new object[,]
                {
                    { 40, 65, "special-defense", 8 },
                    { 41, 45, "hp", 9 },
                    { 42, 49, "attack", 9 },
                    { 43, 49, "defense", 9 },
                    { 44, 65, "special-attack", 9 },
                    { 45, 65, "special-defense", 9 },
                    { 46, 45, "hp", 10 },
                    { 47, 49, "attack", 10 },
                    { 48, 49, "defense", 10 },
                    { 49, 65, "special-attack", 10 },
                    { 50, 65, "special-defense", 10 },
                    { 51, 45, "hp", 11 },
                    { 52, 49, "attack", 11 },
                    { 53, 49, "defense", 11 },
                    { 54, 65, "special-attack", 11 },
                    { 55, 65, "special-defense", 11 },
                    { 56, 45, "hp", 12 },
                    { 57, 49, "attack", 12 },
                    { 58, 49, "defense", 12 },
                    { 59, 65, "special-attack", 12 },
                    { 60, 65, "special-defense", 12 },
                    { 61, 45, "hp", 13 },
                    { 62, 49, "attack", 13 },
                    { 63, 49, "defense", 13 },
                    { 64, 65, "special-attack", 13 },
                    { 65, 65, "special-defense", 13 },
                    { 66, 45, "hp", 14 },
                    { 67, 49, "attack", 14 },
                    { 68, 49, "defense", 14 },
                    { 69, 65, "special-attack", 14 },
                    { 70, 65, "special-defense", 14 },
                    { 71, 45, "hp", 15 },
                    { 72, 49, "attack", 15 },
                    { 73, 49, "defense", 15 },
                    { 74, 65, "special-attack", 15 },
                    { 75, 65, "special-defense", 15 },
                    { 76, 45, "hp", 16 },
                    { 77, 49, "attack", 16 },
                    { 78, 49, "defense", 16 },
                    { 79, 65, "special-attack", 16 },
                    { 80, 65, "special-defense", 16 },
                    { 81, 45, "hp", 17 }
                });

            migrationBuilder.InsertData(
                table: "Stats",
                columns: new[] { "Id", "BaseStat", "Name", "PokemonModelId" },
                values: new object[,]
                {
                    { 82, 49, "attack", 17 },
                    { 83, 49, "defense", 17 },
                    { 84, 65, "special-attack", 17 },
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

            migrationBuilder.CreateIndex(
                name: "IX_PokemonType_PokemonModelId",
                table: "PokemonType",
                column: "PokemonModelId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonType_TypeModelId",
                table: "PokemonType",
                column: "TypeModelId");

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
                name: "PokemonType");

            migrationBuilder.DropTable(
                name: "Sprites");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}
