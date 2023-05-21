using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clone_PokeAPI.Migrations
{
    public partial class AddDescriptionPokemon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Pokemons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Bulbasaur é um pequeno Pokémon com uma planta em suas costas que cresce conforme ele evolui. Ele é conhecido por absorver energia solar para alimentar seu crescimento e também pode lançar sementes venenosas em seus oponentes.");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Ivysaur é a evolução de Bulbasaur. Suas sementes nas costas crescem em tamanho e sua planta floresce. Ele é capaz de lançar pólen tóxico e tem uma força maior do que seu estágio anterior.");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "Venusaur é a forma final da linha evolutiva de Bulbasaur. Ele possui uma flor grande em suas costas que libera um aroma doce e poderoso. Venusaur é um Pokémon poderoso com habilidades de controle de plantas.");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "Charmander é um pequeno Pokémon com uma chama acesa na ponta da cauda. Ele é conhecido por sua natureza valente e por sua capacidade de evoluir para um dragão poderoso. Ele é um Pokémon popular entre os treinadores devido à sua aparência carismática.");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "Charmeleon é a evolução de Charmander. Ele possui uma aparência mais agressiva e uma chama mais intensa na cauda. Charmeleon é um Pokémon temperamental e orgulhoso, com habilidades de fogo cada vez mais poderosas.");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 6,
                column: "Description",
                value: "Charizard é a forma final da linha evolutiva de Charmander. Ele é um dragão voador com asas poderosas e pode lançar chamas intensas. Charizard é um dos Pokémon mais icônicos e temíveis, capaz de causar destruição com seu fogo.");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 7,
                column: "Description",
                value: "Squirtle é um Pokémon aquático com uma casca dura nas costas. Ele é conhecido por sua habilidade de disparar jatos de água pelos canhões em seu casco. Squirtle é um Pokémon amigável e leal, com uma natureza brincalhona.");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 8,
                column: "Description",
                value: "Wartortle é a evolução de Squirtle. Ele possui um casco maior e cauda com formato de hélice. Wartortle é um Pokémon ágil e habilidoso na água, capaz de nadar em alta velocidade. Ele também tem garras afiadas para ataques físicos.");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 9,
                column: "Description",
                value: "Blastoise é a forma final da linha evolutiva de Squirtle. Ele é um Pokémon robusto e poderoso, com dois canhões de água em seu casco que podem disparar jatos de alta pressão. Blastoise é conhecido por sua defesa sólida e habilidades ofensivas poderosas.");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 10,
                column: "Description",
                value: "Caterpie é um Pokémon larva que se alimenta de folhas. Ele possui uma antena em forma de chifre em sua cabeça que libera um odor desagradável para afastar predadores. Caterpie é fraco no combate, mas pode evoluir para uma forma mais forte.");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 11,
                column: "Description",
                value: "Metapod é a evolução de Caterpie. Ele tem uma casca dura como pedra que o protege enquanto ele se prepara para evoluir. Metapod é conhecido por sua capacidade de endurecer seu casulo e resistir a ataques, mas sua movimentação é limitada.");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 12,
                column: "Description",
                value: "Butterfree é a forma final da linha evolutiva de Caterpie. Ele é um Pokémon voador com asas grandes e coloridas. Butterfree é conhecido por sua beleza e por suas asas que produzem um pó brilhante. Ele é capaz de lançar pó sonífero em seus oponentes.");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 13,
                column: "Description",
                value: "Weedle é um pequeno Pokémon larva com um ferrão venenoso em sua cabeça. Ele é encontrado em áreas de floresta e é conhecido por seu apetite voraz por folhas. Weedle pode ser perigoso devido ao seu veneno, então é melhor manter distância.");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 14,
                column: "Description",
                value: "Kakuna é a evolução de Weedle. Ele tem uma casca dura e imóvel, enquanto se prepara para evoluir. Kakuna é bastante vulnerável nesse estágio e depende de sua defesa para se proteger.");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 15,
                column: "Description",
                value: "Beedrill é a forma final da linha evolutiva de Weedle. Ele é um Pokémon com um ferrão venenoso em sua cauda e asas afiadas. Beedrill é ágil e ataca ferozmente quando provocado. Seu ferrão venenoso pode causar dor e reações alérgicas.");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Pidgey é um pequeno Pokémon pássaro com uma habilidade de voo ágil. Ele é encontrado comumente em áreas urbanas e florestais. Pidgey tem um canto melodioso e é conhecido por suas habilidades de voo e visão aguçada.");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 17,
                column: "Description",
                value: "Pidgeotto é a evolução de Pidgey. Ele é um Pokémon com asas poderosas e garras afiadas. Pidgeotto é habilidoso em caçar presas pequenas e é capaz de voar em altas velocidades. Ele tem uma visão aguda que o ajuda a localizar suas presas.");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 18,
                column: "Description",
                value: "Pidgeot é a forma final da linha evolutiva de Pidgey. Ele é um Pokémon majestoso com asas amplas e poderosas. Pidgeot é conhecido por sua velocidade e habilidades de voo excepcionais. Ele pode voar a grandes altitudes e possui uma visão incrível.");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 19,
                column: "Description",
                value: "Rattata é um Pokémon roedor encontrado em áreas urbanas e florestais. Ele possui dentes afiados que crescem constantemente e precisa roer objetos para mantê-los sob controle. Rattata é ágil e tem uma capacidade de morder poderosa.");

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "Id",
                keyValue: 20,
                column: "Description",
                value: "Raticate é a evolução de Rattata. Ele é um Pokémon roedor maior e mais poderoso. Raticate possui presas afiadas e é conhecido por sua voracidade. Ele é territorial e protege ferozmente seu território.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Pokemons");
        }
    }
}
