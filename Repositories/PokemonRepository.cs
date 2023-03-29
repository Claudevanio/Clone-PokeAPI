using Clone_PokeAPI.Data;
using Clone_PokeAPI.Models;
using Clone_PokeAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Clone_PokeAPI.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly PokemonDBContext _dbContext;

        public PokemonRepository(PokemonDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<PokemonModel> GetById(int id)
        {
            throw new NotImplementedException();
        }


        public async Task<List<PokemonList>> ListPokemons(int offset, int limit)
        {
            var pokemons = await _dbContext.Pokemons
                .Skip(offset)
                .Take(limit)
                .Select(p => new PokemonList
                {
                    name = p.Name,
                    url = $"https://localhost:7066/{p.URLDescription}"
                })
                .ToListAsync();

            return pokemons.ToList();
        }
    }
}
