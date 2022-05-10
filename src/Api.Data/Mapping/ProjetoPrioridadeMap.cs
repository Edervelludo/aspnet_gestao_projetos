using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class ProjetoPrioridadeMap : IEntityTypeConfiguration<ProjetoPrioridadeEntity>
    {
        public void Configure(EntityTypeBuilder<ProjetoPrioridadeEntity> builder)
        {
            builder.ToTable("ProjetoPrioridade");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.nome)
                   .IsUnique();

        }
    }
}
