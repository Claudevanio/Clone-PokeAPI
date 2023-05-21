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
                    Name = "bulbasaur",
                    Weight = 69,
                    Height = 7
                },
    new PokemonModel
    {
        Id = 2,
        Name = "ivysaur",
        Weight = 130,
        Height = 10
    },
    new PokemonModel
    {
        Id = 3,
        Name = "venusaur",
        Weight = 1000,
        Height = 20
    },
    new PokemonModel
    {
        Id = 4,
        Name = "charmander",
        Weight = 85,
        Height = 6
    },
    new PokemonModel
    {
        Id = 5,
        Name = "charmeleon",
        Weight = 190,
        Height = 11
    },
    new PokemonModel
    {
        Id = 6,
        Name = "charizard",
        Weight = 905,
        Height = 17
    },
    new PokemonModel
    {
        Id = 7,
        Name = "squirtle",
        Weight = 90,
        Height = 5
    },
    new PokemonModel
    {
        Id = 8,
        Name = "wartortle",
        Weight = 225,
        Height = 10
    },
    new PokemonModel
    {
        Id = 9,
        Name = "blastoise",
        Weight = 855,
        Height = 16
    },
    new PokemonModel
    {
        Id = 10,
        Name = "caterpie",
        Weight = 29,
        Height = 3
    },
    new PokemonModel
    {
        Id = 11,
        Name = "metapod",
        Weight = 99,
        Height = 7
    },
    new PokemonModel
    {
        Id = 12,
        Name = "butterfree",
        Weight = 320,
        Height = 11
    },
    new PokemonModel
    {
        Id = 13,
        Name = "weedle",
        Weight = 32,
        Height = 3
    },
    new PokemonModel
    {
        Id = 14,
        Name = "kakuna",
        Weight = 100,
        Height = 6
    },
    new PokemonModel
    {
        Id = 15,
        Name = "beedrill",
        Weight = 295,
        Height = 10
    },
    new PokemonModel
    {
        Id = 16,
        Name = "pidgey",
        Weight = 18,
        Height = 3
    },
    new PokemonModel
    {
        Id = 17,
        Name = "pidgeotto",
        Weight = 300,
        Height = 11
    },
    new PokemonModel
    {
        Id = 18,
        Name = "pidgeot",
        Weight = 395,
        Height = 15
    },
    new PokemonModel
    {
        Id = 19,
        Name = "rattata",
        Weight = 35,
        Height = 3
    },
    new PokemonModel
    {
        Id = 20,
        Name = "raticate",
        Weight = 185,
        Height = 7
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
    // Pokemon 1
    new StatsModel { Id = 1, Name = "hp", BaseStat = 60, PokemonModelId = 1 },
    new StatsModel { Id = 2, Name = "attack", BaseStat = 62, PokemonModelId = 1 },
    new StatsModel { Id = 3, Name = "defense", BaseStat = 63, PokemonModelId = 1 },
    new StatsModel { Id = 4, Name = "speed", BaseStat = 63, PokemonModelId = 1 },
    // Pokemon 2
    new StatsModel { Id = 5, Name = "hp", BaseStat = 45, PokemonModelId = 2 },
    new StatsModel { Id = 6, Name = "attack", BaseStat = 49, PokemonModelId = 2 },
    new StatsModel { Id = 7, Name = "defense", BaseStat = 49, PokemonModelId = 2 },
    new StatsModel { Id = 8, Name = "speed", BaseStat = 45, PokemonModelId = 2 },
    // Pokemon 3
    new StatsModel { Id = 9, Name = "hp", BaseStat = 39, PokemonModelId = 3 },
    new StatsModel { Id = 10, Name = "attack", BaseStat = 52, PokemonModelId = 3 },
    new StatsModel { Id = 11, Name = "defense", BaseStat = 43, PokemonModelId = 3 },
    new StatsModel { Id = 12, Name = "speed", BaseStat = 65, PokemonModelId = 3 },
    // Pokemon 4
    new StatsModel { Id = 13, Name = "hp", BaseStat = 58, PokemonModelId = 4 },
    new StatsModel { Id = 14, Name = "attack", BaseStat = 64, PokemonModelId = 4 },
    new StatsModel { Id = 15, Name = "defense", BaseStat = 58, PokemonModelId = 4 },
    new StatsModel { Id = 16, Name = "speed", BaseStat = 80, PokemonModelId = 4 },
    // Pokemon 5
    new StatsModel { Id = 17, Name = "hp", BaseStat = 44, PokemonModelId = 5 },
    new StatsModel { Id = 18, Name = "attack", BaseStat = 48, PokemonModelId = 5 },
    new StatsModel { Id = 19, Name = "defense", BaseStat = 65, PokemonModelId = 5 },
    new StatsModel { Id = 20, Name = "speed", BaseStat = 43, PokemonModelId = 5 },
    // Pokemon 6
    new StatsModel { Id = 21, Name = "hp", BaseStat = 59, PokemonModelId = 6 },
    new StatsModel { Id = 22, Name = "attack", BaseStat = 63, PokemonModelId = 6 },
    new StatsModel { Id = 23, Name = "defense", BaseStat = 80, PokemonModelId = 6 },
    new StatsModel { Id = 24, Name = "speed", BaseStat = 58, PokemonModelId = 6 },
    // Pokemon 7
    new StatsModel { Id = 25, Name = "hp", BaseStat = 79, PokemonModelId = 7 },
    new StatsModel { Id = 26, Name = "attack", BaseStat = 83, PokemonModelId = 7 },
    new StatsModel { Id = 27, Name = "defense", BaseStat = 100, PokemonModelId = 7 },
    new StatsModel { Id = 28, Name = "speed", BaseStat = 78, PokemonModelId = 7 },
    // Pokemon 8
    new StatsModel { Id = 29, Name = "hp", BaseStat = 45, PokemonModelId = 8 },
    new StatsModel { Id = 30, Name = "attack", BaseStat = 30, PokemonModelId = 8 },
    new StatsModel { Id = 31, Name = "defense", BaseStat = 35, PokemonModelId = 8 },
    new StatsModel { Id = 32, Name = "speed", BaseStat = 45, PokemonModelId = 8 },
    // Pokemon 9
    new StatsModel { Id = 33, Name = "hp", BaseStat = 60, PokemonModelId = 9 },
    new StatsModel { Id = 34, Name = "attack", BaseStat = 60, PokemonModelId = 9 },
    new StatsModel { Id = 35, Name = "defense", BaseStat = 70, PokemonModelId = 9 },
    new StatsModel { Id = 36, Name = "speed", BaseStat = 40, PokemonModelId = 9 },
    // Pokemon 10
    new StatsModel { Id = 37, Name = "hp", BaseStat = 40, PokemonModelId = 10 },
    new StatsModel { Id = 38, Name = "attack", BaseStat = 45, PokemonModelId = 10 },
    new StatsModel { Id = 39, Name = "defense", BaseStat = 40, PokemonModelId = 10 },
    new StatsModel { Id = 40, Name = "speed", BaseStat = 56, PokemonModelId = 10 },
    // Pokemon 11
    new StatsModel { Id = 41, Name = "hp", BaseStat = 45, PokemonModelId = 11 },
    new StatsModel { Id = 42, Name = "attack", BaseStat = 50, PokemonModelId = 11 },
    new StatsModel { Id = 43, Name = "defense", BaseStat = 55, PokemonModelId = 11 },
    new StatsModel { Id = 44, Name = "speed", BaseStat = 30, PokemonModelId = 11 },
    // Pokemon 12
    new StatsModel { Id = 45, Name = "hp", BaseStat = 60, PokemonModelId = 12 },
    new StatsModel { Id = 46, Name = "attack", BaseStat = 62, PokemonModelId = 12 },
    new StatsModel { Id = 47, Name = "defense", BaseStat = 63, PokemonModelId = 12 },
    new StatsModel { Id = 48, Name = "speed", BaseStat = 60, PokemonModelId = 12 },
    // Pokemon 13
    new StatsModel { Id = 49, Name = "hp", BaseStat = 50, PokemonModelId = 13 },
    new StatsModel { Id = 50, Name = "attack", BaseStat = 52, PokemonModelId = 13 },
    new StatsModel { Id = 51, Name = "defense", BaseStat = 48, PokemonModelId = 13 },
    new StatsModel { Id = 52, Name = "speed", BaseStat = 55, PokemonModelId = 13 },
    // Pokemon 14
    new StatsModel { Id = 53, Name = "hp", BaseStat = 80, PokemonModelId = 14 },
    new StatsModel { Id = 54, Name = "attack", BaseStat = 82, PokemonModelId = 14 },
    new StatsModel { Id = 55, Name = "defense", BaseStat = 78, PokemonModelId = 14 },
    new StatsModel { Id = 56, Name = "speed", BaseStat = 80, PokemonModelId = 14 },
    // Pokemon 15
    new StatsModel { Id = 57, Name = "hp", BaseStat = 40, PokemonModelId = 15 },
    new StatsModel { Id = 58, Name = "attack", BaseStat = 45, PokemonModelId = 15 },
    new StatsModel { Id = 59, Name = "defense", BaseStat = 35, PokemonModelId = 15 },
    new StatsModel { Id = 60, Name = "speed", BaseStat = 55, PokemonModelId = 15 },
    // Pokemon 16
    new StatsModel { Id = 61, Name = "hp", BaseStat = 65, PokemonModelId = 16 },
    new StatsModel { Id = 62, Name = "attack", BaseStat = 70, PokemonModelId = 16 },
    new StatsModel { Id = 63, Name = "defense", BaseStat = 60, PokemonModelId = 16 },
    new StatsModel { Id = 64, Name = "speed", BaseStat = 65, PokemonModelId = 16 },
    // Pokemon 17
    new StatsModel { Id = 65, Name = "hp", BaseStat = 65, PokemonModelId = 17 },
    new StatsModel { Id = 66, Name = "attack", BaseStat = 75, PokemonModelId = 17 },
    new StatsModel { Id = 67, Name = "defense", BaseStat = 70, PokemonModelId = 17 },
    new StatsModel { Id = 68, Name = "speed", BaseStat = 90, PokemonModelId = 17 },
    // Pokemon 18
    new StatsModel { Id = 69, Name = "hp", BaseStat = 35, PokemonModelId = 18 },
    new StatsModel { Id = 70, Name = "attack", BaseStat = 70, PokemonModelId = 18 },
    new StatsModel { Id = 71, Name = "defense", BaseStat = 55, PokemonModelId = 18 },
    new StatsModel { Id = 72, Name = "speed", BaseStat = 25, PokemonModelId = 18 },
    // Pokemon 19
    new StatsModel { Id = 73, Name = "hp", BaseStat = 70, PokemonModelId = 19 },
    new StatsModel { Id = 74, Name = "attack", BaseStat = 85, PokemonModelId = 19 },
    new StatsModel { Id = 75, Name = "defense", BaseStat = 65, PokemonModelId = 19 },
    new StatsModel { Id = 76, Name = "speed", BaseStat = 90, PokemonModelId = 19 },
    // Pokemon 20
    new StatsModel { Id = 77, Name = "hp", BaseStat = 55, PokemonModelId = 20 },
    new StatsModel { Id = 78, Name = "attack", BaseStat = 40, PokemonModelId = 20 },
    new StatsModel { Id = 79, Name = "defense", BaseStat = 40, PokemonModelId = 20 },
    new StatsModel { Id = 80, Name = "speed", BaseStat = 90, PokemonModelId = 20 }
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
