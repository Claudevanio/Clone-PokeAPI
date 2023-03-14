namespace Clone_PokeAPI.Models
{
    public class StatsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int BaseStat { get; set; }

        public PokemonModel Pokemon { get; set; }
        public int PokemonModelId { get; set; }
    }
}
