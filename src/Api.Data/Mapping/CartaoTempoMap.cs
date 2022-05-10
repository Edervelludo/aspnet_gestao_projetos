using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class CartaoTempoMap : IEntityTypeConfiguration<CartaoTempoEntity>
    {
        public void Configure(EntityTypeBuilder<CartaoTempoEntity> builder)
        {
            builder.ToTable("CartaoTempo");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.projetoid);

            builder.HasOne(u => u.projeto)
                   .WithMany(p => p.cartoesTempo);


            builder.HasOne(u => u.recurso)
                   .WithMany(p => p.cartoresTempo);


        }
    }
}
