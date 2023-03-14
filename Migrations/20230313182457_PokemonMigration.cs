using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clone_PokeAPI.Migrations
{
    public partial class PokemonMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Pokemons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    URLDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stat_Capacity = table.Column<int>(type: "int", nullable: false),
                    StatValue = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    StatName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    StatURL = table.Column<string>(type: "nvarchar(350)", nullable: true),
                    Sprites_FrontDefault = table.Column<string>(type: "nvarchar(400)", nullable: false),
                    Sprites_Other_OtherFrontDefault = table.Column<string>(type: "nvarchar(400)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.Id);
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DreamWorld");

            migrationBuilder.DropTable(
                name: "TypesPokemon");

            migrationBuilder.DropTable(
                name: "Pokemons");
        }
    }
}
