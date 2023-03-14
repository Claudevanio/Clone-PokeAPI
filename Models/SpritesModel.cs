namespace Clone_PokeAPI.Models
{
    public class SpritesModel
    {
        public int Id { get; set; }
        public string FrontDefault { get; set; }

        public string OtherFrontDefault { get; set; }

        public PokemonModel Pokemon { get; set; }   

        public int PokemonModelId { get; set; }
    }
}
