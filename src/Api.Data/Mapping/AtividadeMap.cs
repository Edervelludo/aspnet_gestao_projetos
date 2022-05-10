using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class AtividadeMap : IEntityTypeConfiguration<AtividadeEntity>
    {
        public void Configure(EntityTypeBuilder<AtividadeEntity> builder)
        {
            builder.ToTable("Atividade");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.projetoid);

            builder.HasOne(u => u.projeto)
                   .WithMany(p => p.atividades);

            builder.HasOne(u => u.atividadeprecede);

            builder.HasOne(u => u.atividadeprioridade)
                   .WithMany(p => p.atividades);


            builder.HasOne(u => u.faseprojeto)
            .WithMany(p => p.atividades);

            builder.HasOne(u => u.atividadestatus)
            .WithMany(p => p.atividades);

            builder.HasOne(u => u.atribuidoarecurso)
            .WithMany(p => p.atividades);


        }
    }
}
