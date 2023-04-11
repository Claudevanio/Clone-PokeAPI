using System.ComponentModel.DataAnnotations.Schema;

namespace Clone_PokeAPI.Models
{
    [Table("PokemonType")]
    public class PokemonType
    {
        public int Id { get; set; }
        public int PokemonModelId { get; set; }
        public PokemonModel PokemonModel { get; set; }

        public int TypeModelId { get; set; }
        public TypeModel TypeModel { get; set; }
    }
}
