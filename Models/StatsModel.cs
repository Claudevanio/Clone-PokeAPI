using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Clone_PokeAPI.Models
{
    public class StatsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int BaseStat { get; set; }

        [JsonIgnore]
        public PokemonModel Pokemon { get; set; }
        public int PokemonModelId { get; set; }
    }
}
