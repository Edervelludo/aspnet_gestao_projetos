using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class RecursoMap : IEntityTypeConfiguration<RecursoEntity>
    {
        public void Configure(EntityTypeBuilder<RecursoEntity> builder)
        {
            builder.ToTable("Recurso");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.EmpresaId);
            builder.HasIndex(u => u.DepartamentoId);

            builder.HasOne(u => u.Empresa)
                   .WithMany(p => p.Recursos);

            builder.HasOne(u => u.Departamento)
                   .WithMany(p => p.Recursos);



        }
    }
}
