﻿using Clone_PokeAPI.Models;

namespace Clone_PokeAPI.Repositories.Interfaces
{
    public interface IPokemonRepository
    {
        Task<List<PokemonList>> ListPokemons(int offset, int limit);

        Task<PokemonModel> GetById(int id);
    }
}