namespace Clone_PokeAPI.Models
{
    public class PokemonInfoModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string URLDescription { get; set; }

        public List<TypeModel> Type { get; set; }

        public List<StatsModel> Stat { get; set; }

        public SpritesModel Sprites { get; set; }

    }
}
