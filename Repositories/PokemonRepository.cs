using Clone_PokeAPI.Data;
using Clone_PokeAPI.Mapper;
using Clone_PokeAPI.Models;
using Clone_PokeAPI.Models.PokemonsDetail;
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

        public async Task<PokemonApiDto> GetById(int id)
        {
            PokemonModel pokemon = await _dbContext.Pokemons
                .Include(x => x.PokemonTypes)
                    .ThenInclude(x => x.TypeModel)
                .Include(x => x.Stat)
                .Include(x => x.Sprites)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (pokemon == null) throw new Exception($"Pokemon para o ID: {id} não foi encontrado no banco de dados!");

            PokemonApiDto pokemonDto = pokemon.ToApiDTO();

            return pokemonDto;
        }


        public async Task<List<PokemonList>> ListPokemons(int offset, int limit)
        {
            var pokemons = await _dbContext.Pokemons
                .Skip(offset)
                .Take(limit)
                .Select(p => new PokemonList
                {
                    name = p.Name,
                    url = $"https://localhost:7066/Pokemon/{p.Id}"
                })
                .ToListAsync();

            return pokemons;
        }
    }
}
