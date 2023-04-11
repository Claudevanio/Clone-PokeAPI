using Clone_PokeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Clone_PokeAPI.Data
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TypeModel>().HasData(
                    new TypeModel { Id = 1, TypeName = "grass" },
                    new TypeModel { Id = 2, TypeName = "poison" },
                    new TypeModel { Id = 3, TypeName = "fire" },
                    new TypeModel { Id = 4, TypeName = "water" },
                    new TypeModel { Id = 5, TypeName = "bug" },
                    new TypeModel { Id = 6, TypeName = "normal" },
                    new TypeModel { Id = 7, TypeName = "flying" },
                    new TypeModel { Id = 8, TypeName = "electric" }
                );

            modelBuilder.Entity<PokemonModel>().HasData(
                new PokemonModel
                {
                    Id = 1,
                    Name = "bulbasaur"
                },
                   new PokemonModel
                   {
                       Id = 2,
                       Name = "ivysaur"
                   },
                   new PokemonModel
                   {
                       Id = 3,
                       Name = "venusaur"
                   },
                   new PokemonModel
                   {
                       Id = 4,
                       Name = "charmander"
                   },
                   new PokemonModel
                   {
                       Id = 5,
                       Name = "charmeleon"
                   },
                   new PokemonModel
                   {
                       Id = 6,
                       Name = "charizard"
                   },
                   new PokemonModel
                   {
                       Id = 7,
                       Name = "squirtle"
                   },
                   new PokemonModel
                   {
                       Id = 8,
                       Name = "wartortle"
                   },
                   new PokemonModel
                   {
                       Id = 9,
                       Name = "blastoise"
                   },
                   new PokemonModel
                   {
                       Id = 10,
                       Name = "caterpie"
                   },
                   new PokemonModel
                   {
                       Id = 11,
                       Name = "metapod"
                   },
                   new PokemonModel
                   {
                       Id = 12,
                       Name = "butterfree"
                   },
                   new PokemonModel
                   {
                       Id = 13,
                       Name = "weedle"
                   },
                    new PokemonModel
                    {
                        Id = 14,
                        Name = "kakuna"
                    },
                    new PokemonModel
                    {
                        Id = 15,
                        Name = "beedrill"
                    },
                    new PokemonModel
                    {
                        Id = 16,
                        Name = "pidgey"
                    },
                    new PokemonModel
                    {
                        Id = 17,
                        Name = "pidgeotto"
                    },
                    new PokemonModel
                    {
                        Id = 18,
                        Name = "pidgeot"
                    },
                    new PokemonModel
                    {
                        Id = 19,
                        Name = "rattata"
                    },
                    new PokemonModel
                    {
                        Id = 20,
                        Name = "raticate"
                    }
                  );

            modelBuilder.Entity<SpritesModel>().HasData(
                   new SpritesModel
                    {
                        Id = 1,
                        FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/1.png",
                        OtherFrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/1.svg",
                        PokemonModelId = 1
                    },
                   new SpritesModel
                   {
                       Id = 2,
                       FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/2.png",
                       OtherFrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/2.svg",
                       PokemonModelId = 2
                   },
                   new SpritesModel
                   {
                       Id=3,
                       FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/3.png",
                       OtherFrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/3.svg",
                       PokemonModelId = 3
                   },
                   new SpritesModel
                   {
                       Id = 4,
                       FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/4.png",
                       OtherFrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/4.svg",
                       PokemonModelId = 4
                   },
                    new SpritesModel
                    {
                        Id = 5,
                        FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/5.png",
                        OtherFrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/5.svg",
                        PokemonModelId = 5
                    },
                     new SpritesModel
                     {
                         Id = 6,
                         FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/6.png",
                         OtherFrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/6.svg",
                         PokemonModelId = 6
                     },
                      new SpritesModel
                      {
                          Id = 7,
                          FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/7.png",
                          OtherFrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/7.svg",
                          PokemonModelId = 7
                      },
                       new SpritesModel
                       {
                           Id = 8,
                           FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/8.png",
                           OtherFrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/8.svg",
                           PokemonModelId = 8
                       },
                        new SpritesModel
                        {
                            Id = 9,
                            FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/9.png",
                            OtherFrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/9.svg",
                            PokemonModelId = 9
                        },
                        new SpritesModel
                        {
                            Id = 10,
                            FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/10.png",
                            OtherFrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/10.svg",
                            PokemonModelId = 10
                        },
                       new SpritesModel
                       {
                           Id = 11,
                           FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/11.png",
                           OtherFrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/11.svg",
                           PokemonModelId = 11
                       },
                       new SpritesModel
                       {
                           Id = 12,
                           FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/12.png",
                           OtherFrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/12.svg",
                           PokemonModelId = 12
                       },
                       new SpritesModel
                        {
                           Id= 13,
                            FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/13.png",
                            OtherFrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/13.svg",
                            PokemonModelId = 13
                        },
                       new SpritesModel
                        {
                           Id = 14,
                            FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/14.png",
                            OtherFrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/14.svg",
                            PokemonModelId = 14
                        },
                       new SpritesModel
                        {
                           Id = 15,
                            FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/15.png",
                            OtherFrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/15.svg",
                            PokemonModelId = 15
                        },
                       new SpritesModel
                        {
                           Id = 16,
                            FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/16.png",
                            OtherFrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/16.svg",
                            PokemonModelId = 16
                        },
                       new SpritesModel
                        {
                           Id = 17,
                            FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/17.png",
                            OtherFrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/17.svg",
                            PokemonModelId = 17
                        },
                       new SpritesModel
                        {
                           Id = 18,
                            FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/18.png",
                            OtherFrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/18.svg",
                            PokemonModelId = 18
                        },
                       new SpritesModel
                        {
                           Id = 19,
                            FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/19.png",
                            OtherFrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/19.svg",
                            PokemonModelId = 19
                        },
                       new SpritesModel
                        {
                           Id = 20,
                            FrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/20.png",
                            OtherFrontDefault = "https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/dream-world/20.svg",
                            PokemonModelId = 20
                        }
                );

            modelBuilder.Entity<StatsModel>().HasData(
                new StatsModel { Id = 1, Name = "hp", BaseStat = 49, PokemonModelId = 1 },
                new StatsModel { Id = 2, Name = "attack", BaseStat = 49, PokemonModelId = 1 },
                new StatsModel { Id = 3, Name = "defense", BaseStat = 49, PokemonModelId = 1 },
                new StatsModel { Id = 4, Name = "special-attack", BaseStat = 49, PokemonModelId = 1 },
                new StatsModel { Id = 5, Name = "special-defense", BaseStat = 49, PokemonModelId = 1 },
                new StatsModel { Id = 6, Name = "hp", BaseStat = 45, PokemonModelId = 2 },
                new StatsModel { Id = 7, Name = "attack", BaseStat = 49, PokemonModelId = 2 },
                new StatsModel { Id = 8, Name = "defense", BaseStat = 49, PokemonModelId = 2 },
                new StatsModel { Id = 9, Name = "special-attack", BaseStat = 65, PokemonModelId = 2 },
                new StatsModel { Id = 10, Name = "special-defense", BaseStat = 65, PokemonModelId = 2 },
                new StatsModel { Id = 11, Name = "hp", BaseStat = 45, PokemonModelId = 3 },
                new StatsModel { Id = 12, Name = "attack", BaseStat = 49, PokemonModelId = 3 },
                new StatsModel { Id = 13, Name = "defense", BaseStat = 49, PokemonModelId = 3 },
                new StatsModel { Id = 14, Name = "special-attack", BaseStat = 65, PokemonModelId = 3 },
                new StatsModel { Id = 15, Name = "special-defense", BaseStat = 65, PokemonModelId = 3 },
                new StatsModel { Id = 16, Name = "hp", BaseStat = 45, PokemonModelId = 4 },
                new StatsModel { Id = 17, Name = "attack", BaseStat = 49, PokemonModelId = 4 },
                new StatsModel { Id = 18, Name = "defense", BaseStat = 49, PokemonModelId = 4 },
                new StatsModel { Id = 19, Name = "special-attack", BaseStat = 65, PokemonModelId = 4 },
                new StatsModel { Id = 20, Name = "special-defense", BaseStat = 65, PokemonModelId = 4 },
                new StatsModel { Id = 21, Name = "hp", BaseStat = 45, PokemonModelId = 5 },
                new StatsModel { Id = 22, Name = "attack", BaseStat = 49, PokemonModelId = 5 },
                new StatsModel { Id = 23, Name = "defense", BaseStat = 49, PokemonModelId = 5 },
                new StatsModel { Id = 24, Name = "special-attack", BaseStat = 65, PokemonModelId = 5 },
                new StatsModel { Id = 25, Name = "special-defense", BaseStat = 65, PokemonModelId = 5 },
                new StatsModel { Id = 26, Name = "hp", BaseStat = 45, PokemonModelId = 6 },
                new StatsModel { Id = 27, Name = "attack", BaseStat = 49, PokemonModelId = 6 },
                new StatsModel { Id = 28, Name = "defense", BaseStat = 49, PokemonModelId = 6 },
                new StatsModel { Id = 29, Name = "special-attack", BaseStat = 65, PokemonModelId = 6 },
                new StatsModel { Id = 30, Name = "special-defense", BaseStat = 65, PokemonModelId = 6 },
                new StatsModel { Id = 31, Name = "hp", BaseStat = 45, PokemonModelId = 7 },
                new StatsModel { Id = 32, Name = "attack", BaseStat = 49, PokemonModelId = 7 },
                new StatsModel { Id = 33, Name = "defense", BaseStat = 49, PokemonModelId = 7 },
                new StatsModel { Id = 34, Name = "special-attack", BaseStat = 65, PokemonModelId = 7 },
                new StatsModel { Id = 35, Name = "special-defense", BaseStat = 65, PokemonModelId = 7 },
                new StatsModel { Id = 36, Name = "hp", BaseStat = 45, PokemonModelId = 8 },
                new StatsModel { Id = 37, Name = "attack", BaseStat = 49, PokemonModelId = 8 },
                new StatsModel { Id = 38, Name = "defense", BaseStat = 49, PokemonModelId = 8 },
                new StatsModel { Id = 39, Name = "special-attack", BaseStat = 65, PokemonModelId = 8 },
                new StatsModel { Id = 40, Name = "special-defense", BaseStat = 65, PokemonModelId = 8 },
                new StatsModel { Id = 41, Name = "hp", BaseStat = 45, PokemonModelId = 9 },
                new StatsModel { Id = 42, Name = "attack", BaseStat = 49, PokemonModelId = 9 },
                new StatsModel { Id = 43, Name = "defense", BaseStat = 49, PokemonModelId = 9 },
                new StatsModel { Id = 44, Name = "special-attack", BaseStat = 65, PokemonModelId = 9 },
                new StatsModel { Id = 45, Name = "special-defense", BaseStat = 65, PokemonModelId = 9 },
                new StatsModel { Id = 46, Name = "hp", BaseStat = 45, PokemonModelId = 10},
                new StatsModel { Id = 47, Name = "attack", BaseStat = 49, PokemonModelId = 10},
                new StatsModel { Id = 48, Name = "defense", BaseStat = 49, PokemonModelId = 10},
                new StatsModel { Id = 49, Name = "special-attack", BaseStat = 65, PokemonModelId = 10},
                new StatsModel { Id = 50, Name = "special-defense", BaseStat = 65, PokemonModelId = 10},
                new StatsModel { Id = 51, Name = "hp", BaseStat = 45, PokemonModelId = 11},
                new StatsModel { Id = 52, Name = "attack", BaseStat = 49, PokemonModelId = 11},
                new StatsModel { Id = 53, Name = "defense", BaseStat = 49, PokemonModelId = 11},
                new StatsModel { Id = 54, Name = "special-attack", BaseStat = 65, PokemonModelId = 11},
                new StatsModel { Id = 55, Name = "special-defense", BaseStat = 65, PokemonModelId = 11},
                new StatsModel { Id = 56, Name = "hp", BaseStat = 45, PokemonModelId = 12},
                new StatsModel { Id = 57, Name = "attack", BaseStat = 49, PokemonModelId = 12},
                new StatsModel { Id = 58, Name = "defense", BaseStat = 49, PokemonModelId = 12},
                new StatsModel { Id = 59, Name = "special-attack", BaseStat = 65, PokemonModelId = 12},
                new StatsModel { Id = 60, Name = "special-defense", BaseStat = 65, PokemonModelId = 12},
                new StatsModel { Id = 61, Name = "hp", BaseStat = 45, PokemonModelId = 13},
                new StatsModel { Id = 62, Name = "attack", BaseStat = 49, PokemonModelId = 13},
                new StatsModel { Id = 63, Name = "defense", BaseStat = 49, PokemonModelId = 13},
                new StatsModel { Id = 64, Name = "special-attack", BaseStat = 65, PokemonModelId = 13},
                new StatsModel { Id = 65, Name = "special-defense", BaseStat = 65, PokemonModelId = 13},
                new StatsModel { Id = 66, Name = "hp", BaseStat = 45, PokemonModelId = 14},
                new StatsModel { Id = 67, Name = "attack", BaseStat = 49, PokemonModelId = 14},
                new StatsModel { Id = 68, Name = "defense", BaseStat = 49, PokemonModelId = 14},
                new StatsModel { Id = 69, Name = "special-attack", BaseStat = 65, PokemonModelId = 14},
                new StatsModel { Id = 70, Name = "special-defense", BaseStat = 65, PokemonModelId = 14},
                new StatsModel { Id = 71, Name = "hp", BaseStat = 45, PokemonModelId = 15},
                new StatsModel { Id = 72, Name = "attack", BaseStat = 49, PokemonModelId = 15},
                new StatsModel { Id = 73, Name = "defense", BaseStat = 49, PokemonModelId = 15},
                new StatsModel { Id = 74, Name = "special-attack", BaseStat = 65, PokemonModelId = 15},
                new StatsModel { Id = 75, Name = "special-defense", BaseStat = 65, PokemonModelId = 15},
                new StatsModel { Id = 76, Name = "hp", BaseStat = 45, PokemonModelId = 16},
                new StatsModel { Id = 77, Name = "attack", BaseStat = 49, PokemonModelId = 16},
                new StatsModel { Id = 78, Name = "defense", BaseStat = 49, PokemonModelId = 16},
                new StatsModel { Id = 79, Name = "special-attack", BaseStat = 65, PokemonModelId = 16},
                new StatsModel { Id = 80, Name = "special-defense", BaseStat = 65, PokemonModelId = 16},
                new StatsModel { Id = 81, Name = "hp", BaseStat = 45, PokemonModelId = 17},
                new StatsModel { Id = 82, Name = "attack", BaseStat = 49, PokemonModelId = 17},
                new StatsModel { Id = 83, Name = "defense", BaseStat = 49, PokemonModelId = 17},
                new StatsModel { Id = 84, Name = "special-attack", BaseStat = 65, PokemonModelId = 17},
                new StatsModel { Id = 85, Name = "special-defense", BaseStat = 65, PokemonModelId = 17},
                new StatsModel { Id = 86, Name = "hp", BaseStat = 45, PokemonModelId = 18},
                new StatsModel { Id = 87, Name = "attack", BaseStat = 49, PokemonModelId = 18},
                new StatsModel { Id = 88, Name = "defense", BaseStat = 49, PokemonModelId = 18},
                new StatsModel { Id = 89, Name = "special-attack", BaseStat = 65, PokemonModelId = 18},
                new StatsModel { Id = 90, Name = "special-defense", BaseStat = 65, PokemonModelId = 18},
                new StatsModel { Id = 91, Name = "hp", BaseStat = 45, PokemonModelId = 19},
                new StatsModel { Id = 92, Name = "attack", BaseStat = 49, PokemonModelId = 19},
                new StatsModel { Id = 93, Name = "defense", BaseStat = 49, PokemonModelId = 19},
                new StatsModel { Id = 94, Name = "special-attack", BaseStat = 65, PokemonModelId = 19},
                new StatsModel { Id = 95, Name = "special-defense", BaseStat = 65, PokemonModelId = 19},
                new StatsModel { Id = 96, Name = "hp", BaseStat = 45, PokemonModelId = 20},
                new StatsModel { Id = 97, Name = "attack", BaseStat = 49, PokemonModelId = 20},
                new StatsModel { Id = 98, Name = "defense", BaseStat = 49, PokemonModelId = 20},
                new StatsModel { Id = 99, Name = "special-attack", BaseStat = 65, PokemonModelId = 20},
                new StatsModel { Id = 100, Name = "special-defense", BaseStat = 65, PokemonModelId = 20}
                );

            
                  
               

                modelBuilder.Entity<PokemonType>().HasData(
                    new PokemonType { Id = 1, PokemonModelId = 1, TypeModelId = 1 },
                    new PokemonType { Id = 2, PokemonModelId = 1, TypeModelId = 2 },
                    new PokemonType { Id = 3, PokemonModelId = 2, TypeModelId = 1 },
                    new PokemonType { Id = 4, PokemonModelId = 2, TypeModelId = 2 },
                    new PokemonType { Id = 5, PokemonModelId = 3, TypeModelId = 1 },
                    new PokemonType { Id = 6, PokemonModelId = 3, TypeModelId = 2 },
                    new PokemonType { Id = 7, PokemonModelId = 4, TypeModelId =  3},
                    new PokemonType { Id = 8, PokemonModelId = 5, TypeModelId = 3 },
                    new PokemonType { Id = 9, PokemonModelId = 6, TypeModelId = 3 },
                    new PokemonType { Id = 10, PokemonModelId = 6, TypeModelId = 7 },
                    new PokemonType { Id = 11, PokemonModelId = 7, TypeModelId = 4 },
                    new PokemonType { Id = 12, PokemonModelId = 9, TypeModelId = 4 },
                    new PokemonType { Id = 13, PokemonModelId = 10, TypeModelId = 5 },
                    new PokemonType { Id = 14, PokemonModelId = 11, TypeModelId = 5 },
                    new PokemonType { Id = 15, PokemonModelId = 12, TypeModelId = 5 },
                    new PokemonType { Id = 16, PokemonModelId = 12, TypeModelId = 7 },
                    new PokemonType { Id = 17, PokemonModelId = 13, TypeModelId = 5 },
                    new PokemonType { Id = 18, PokemonModelId = 13, TypeModelId = 2 },
                    new PokemonType { Id = 19, PokemonModelId = 14, TypeModelId = 2 },
                    new PokemonType { Id = 20, PokemonModelId = 15, TypeModelId = 2 },
                    new PokemonType { Id = 21, PokemonModelId = 16, TypeModelId = 6 },
                    new PokemonType { Id = 22, PokemonModelId = 17, TypeModelId = 6 },
                    new PokemonType { Id = 23, PokemonModelId = 18, TypeModelId = 6 },
                    new PokemonType { Id = 24, PokemonModelId = 19, TypeModelId = 6 },
                    new PokemonType { Id = 25, PokemonModelId = 20, TypeModelId = 6 }
                   ); 
        }
    }
}
