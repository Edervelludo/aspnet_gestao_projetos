using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class DepartamentoMap : IEntityTypeConfiguration<DepartamentoEntity>
    {
        public void Configure(EntityTypeBuilder<DepartamentoEntity> builder)
        {
            builder.ToTable("Departamento");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.nome)
                   .IsUnique();

        }
    }
}
