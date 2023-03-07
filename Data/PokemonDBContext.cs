using Clone_PokeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Clone_PokeAPI.Data
{
    public class PokemonDBContext : DbContext
    {
        public PokemonDBContext(DbContextOptions<PokemonDBContext> options) : base(options)
        {
        }

        public DbSet<PokemonInfoModel> Pokemons { get; set; }
    }
}
