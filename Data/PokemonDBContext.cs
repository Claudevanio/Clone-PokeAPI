using Clone_PokeAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Clone_PokeAPI.Data
{
    public class PokemonDBContext : DbContext
    {
        public PokemonDBContext(DbContextOptions<PokemonDBContext> options) : base(options)
        {

        }

        public DbSet<PokemonModel> Pokemons { get; set; }

        public DbSet<SpritesModel> Sprites { get; set; }

        public DbSet<StatsModel> Stats { get; set; }

        public DbSet<TypeModel> Types { get; set; }

        public DbSet<PokemonType> PokemonTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

    }
}
