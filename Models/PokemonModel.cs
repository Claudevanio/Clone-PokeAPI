using System.ComponentModel.DataAnnotations.Schema;

namespace Clone_PokeAPI.Models
{
    [Table("Pokemons")]
    public class PokemonModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<TypeModel> Type { get; set; }

        public List<PokemonType> PokemonTypes { get; set; }

        public List<StatsModel> Stat { get; set; }

        public SpritesModel Sprites { get; set; }

    }
}
