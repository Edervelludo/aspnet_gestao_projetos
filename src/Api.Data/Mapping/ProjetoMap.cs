using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class ProjetoMap : IEntityTypeConfiguration<ProjetoEntity>
    {
        public void Configure(EntityTypeBuilder<ProjetoEntity> builder)
        {
            builder.ToTable("Projeto");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.EmpresaId);
            builder.HasIndex(u => u.dono);
            builder.HasIndex(u => u.lider);


            builder.HasOne(u => u.Empresa)
                   .WithMany(p => p.Projetos);


            builder.HasOne(u => u.prioridade)
                   .WithMany(p => p.projetos);


            builder.HasOne(u => u.status)
            .WithMany(p => p.projetos);




        }
    }
}
