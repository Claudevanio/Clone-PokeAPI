using System.ComponentModel.DataAnnotations.Schema;

namespace Clone_PokeAPI.Models
{
    [Table("Pokemons")]
    public class PokemonModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public List<TypeModel> Type { get; set; }

        public List<PokemonType> PokemonTypes { get; set; }

        public List<StatsModel> Stat { get; set; }

        public SpritesModel Sprites { get; set; }

    }
}
