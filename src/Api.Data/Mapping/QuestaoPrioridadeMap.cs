using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class QuestaoPrioridadeMap : IEntityTypeConfiguration<QuestaoPrioridadeEntity>
    {
        public void Configure(EntityTypeBuilder<QuestaoPrioridadeEntity> builder)
        {
            builder.ToTable("QuestaoPrioridade");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.nome)
                   .IsUnique();

        }
    }
}
