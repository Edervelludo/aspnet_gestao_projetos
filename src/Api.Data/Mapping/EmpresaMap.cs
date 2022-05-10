using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class EmpresaMap : IEntityTypeConfiguration<EmpresaEntity>
    {
        public void Configure(EntityTypeBuilder<EmpresaEntity> builder)
        {
            builder.ToTable("Empresa");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.nome);


        }
    }
}
