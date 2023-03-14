using Microsoft.EntityFrameworkCore;

namespace Clone_PokeAPI.Models
{
    public class TypeModel
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public List<PokemonModel> Pokemons { get; set; }

        public string? URL { get; set; }
        
    }
}
