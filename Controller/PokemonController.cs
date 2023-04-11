using Clone_PokeAPI.Models;
using Clone_PokeAPI.Models.PokemonsDetail;
using Clone_PokeAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clone_PokeAPI.Controller
{
    [Route("pokemon")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonRepository _repository;
        public PokemonController(IPokemonRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<PokemonList>>> FetchPokemons(int limit = 20, int offset = 0)
        {
            List<PokemonList> pokemons = await _repository.ListPokemons(offset, limit);

            int totalPokemons = await _repository.CountPokemons();

            if(offset >= totalPokemons) return NoContent();

            var response = new
            {
                count = totalPokemons,
                next = offset + limit < totalPokemons ? $"{Request.Scheme}://{Request.Host}/pokemon?offset={offset + limit}&limit={limit}" : null,
                previous = offset - limit >= 0 ? $"{Request.Scheme}://{Request.Host}/pokemon?offset={offset - limit}&limit={limit}" : null,
                results = pokemons
            };


            return Ok (response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PokemonApiDto>> SearchById(int id)
        {
            PokemonApiDto pokemon = await _repository.GetById(id);

            return Ok(pokemon);
        }
    }
}
