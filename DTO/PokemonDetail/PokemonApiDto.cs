using Clone_PokeAPI.Models.PokemonDetail.Stats;
using Clone_PokeAPI.Models.PokemonDetail.Types;
using Clone_PokeAPI.Models.PokemonsDetail.Sprites;

namespace Clone_PokeAPI.Models.PokemonsDetail
{
    public class PokemonApiDto
    {
        public int id { get; set; }
        public string name { get; set; }

        public string description { get; set; }

        public int height { get; set; }

        public int weight { get; set; }

        public SpritesDto? sprites { get; set; }

        public List<StatsDto?> stats { get; set;}

        public List<TypesDto?> types { get; set;}
    }
}
