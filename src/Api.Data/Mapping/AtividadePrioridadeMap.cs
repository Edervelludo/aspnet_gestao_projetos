using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class AtividadePrioridadeMap : IEntityTypeConfiguration<AtividadePrioridadeEntity>
    {
        public void Configure(EntityTypeBuilder<AtividadePrioridadeEntity> builder)
        {
            builder.ToTable("AtividadePrioridade");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.nome)
                   .IsUnique();

        }
    }
}
