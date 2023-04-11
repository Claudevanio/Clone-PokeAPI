using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Clone_PokeAPI.Models
{
    public class SpritesModel
    {
        public int Id { get; set; }
        public string FrontDefault { get; set; }

        public string OtherFrontDefault { get; set; }

        [JsonIgnore]
        public PokemonModel Pokemon { get; set; }   

        public int PokemonModelId { get; set; }
    }
}
