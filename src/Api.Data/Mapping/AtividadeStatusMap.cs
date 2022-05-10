using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class AtividadeStatusMap : IEntityTypeConfiguration<AtividadeStatusEntity>
    {
        public void Configure(EntityTypeBuilder<AtividadeStatusEntity> builder)
        {
            builder.ToTable("AtividadeStatus");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.nome)
                   .IsUnique();

        }
    }
}
