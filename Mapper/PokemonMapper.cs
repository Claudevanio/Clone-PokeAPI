using Clone_PokeAPI.Models;
using Clone_PokeAPI.Models.PokemonDetail.Sprites;
using Clone_PokeAPI.Models.PokemonDetail.Stats;
using Clone_PokeAPI.Models.PokemonDetail.Types;
using Clone_PokeAPI.Models.PokemonsDetail;
using Clone_PokeAPI.Models.PokemonsDetail.Sprites;

namespace Clone_PokeAPI.Mapper
{
    public static class PokemonMapper
    {
        public static PokemonApiDto ToApiDTO(this PokemonModel pokemon)
        {
            var apiDTO = new PokemonApiDto
            {
                id = pokemon.Id,
                name = pokemon.Name,
                weight = pokemon.Weight,
                height = pokemon.Height,
                sprites = new SpritesDto
                {
                    front_default = pokemon.Sprites.FrontDefault,
                    other = new OtherDto
                    {
                        dream_world = new DreamWorldDto
                        { front_default = pokemon.Sprites.OtherFrontDefault, }
                    }
                },
                stats = new List<StatsDto>(),
                types = new List<TypesDto>()
            };

            foreach (var stat in pokemon.Stat)
            {
                apiDTO.stats.Add(new StatsDto
                {
                    base_stat = stat.BaseStat,
                    stat = new StatDto
                    {
                        name = stat.Name,
                    }
                });
            }

            foreach (var type in pokemon.PokemonTypes)
            {
                apiDTO.types.Add(new TypesDto
                {
                    type = new TypeDto
                    {
                        name = type.TypeModel.TypeName,
                    }
                });
            }

            return apiDTO;
        }
    }
}
