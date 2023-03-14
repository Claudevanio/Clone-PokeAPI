using Clone_PokeAPI.Data;
using Clone_PokeAPI.Models;
using Clone_PokeAPI.Repositories.Interfaces;

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

        public Task<PokemonModel> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<PokemonModel>> ListPokemons(int offset, int limit)
        {
            throw new NotImplementedException();
        }
    }
}
