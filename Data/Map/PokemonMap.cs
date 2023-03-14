
/* using Clone_PokeAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clone_PokeAPI.Data.Map
{

    public class PokemonMap : IEntityTypeConfiguration<PokemonInfoModel>
    {
        public void Configure(EntityTypeBuilder<PokemonInfoModel> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name).IsRequired().HasMaxLength(150);

            builder.Property(p => p.URLDescription).IsRequired();

            builder.OwnsOne(x => x.Type, type =>
            {
                type.ToTable("TypesPokemon");
                type.Property<string>(nameof(TypeModel.TypeName))
                    .IsRequired()
                    .HasColumnName("TypeName")
                    .HasMaxLength(50);

                type.Property<string>(nameof(TypeModel.URL))
                    .HasColumnName("TypeURL");
            });

            builder.OwnsOne(p => p.Stat, state =>
            {
                state.Property<string>(nameof(StatsModel.Name))
                .IsRequired()
                .HasColumnName("StatName")
                .HasColumnType("nvarchar(50)");

                state.Property<int>(nameof(StatsModel.BaseValue))
                .IsRequired()
                .HasColumnType("nvarchar(10)")
                .HasColumnName("StatValue");

                state.Property<string>(nameof(StatsModel.URL))
                .HasColumnName("StatURL")
                .HasColumnType("nvarchar(350)");
            });

            builder.OwnsOne(p => p.Sprites, sprites =>
            {
                sprites.WithOwner();
                sprites.Property<string>(nameof(SpritesModel.FrontDefault))
                .IsRequired()
                .HasColumnType("nvarchar(400)");

                sprites.OwnsOne(s => s.Other, other =>
                {
                    other.Property(d => d.OtherFrontDefault)
                    .HasColumnType("nvarchar(400)")
                    .IsRequired();  
                });
            });
        }
    }
} */
