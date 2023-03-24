using Clone_PokeAPI.Models;
using Clone_PokeAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clone_PokeAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonRepository _repository;
        public PokemonController(IPokemonRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<PokemonList>>> FetchPokemons(int offset = 0, int limit = 20)
        {
            List<PokemonList> pokemons = await _repository.ListPokemons(offset, limit);

            return Ok(pokemons);
        }
    }
}
