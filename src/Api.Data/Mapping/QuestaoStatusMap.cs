using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class QuestaoStatusMap : IEntityTypeConfiguration<QuestaoStatusEntity>
    {
        public void Configure(EntityTypeBuilder<QuestaoStatusEntity> builder)
        {
            builder.ToTable("QuestaoStatus");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.nome)
                   .IsUnique();

        }
    }
}
