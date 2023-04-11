using Clone_PokeAPI.Models;
using Clone_PokeAPI.Models.PokemonsDetail;

namespace Clone_PokeAPI.Repositories.Interfaces
{
    public interface IPokemonRepository
    {
        Task<List<PokemonList>> ListPokemons(int offset, int limit);

        Task<PokemonApiDto> GetById(int id);

        Task<int> CountPokemons();
    }
}
