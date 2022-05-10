using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class QuestaoMap : IEntityTypeConfiguration<QuestaoEntity>
    {
        public void Configure(EntityTypeBuilder<QuestaoEntity> builder)
        {
            builder.ToTable("Questao");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.projetoid);
            builder.HasIndex(u => u.recursoCriadorid);

            builder.HasOne(u => u.projeto)
                   .WithMany(p => p.questoes);

            builder.HasOne(u => u.recursoCriador)
                   .WithMany(p => p.questoesCriadas);

            builder.HasOne(u => u.status)
            .WithMany(p => p.questoes);


            builder.HasOne(u => u.status)
            .WithMany(p => p.questoes);



        }
    }
}
