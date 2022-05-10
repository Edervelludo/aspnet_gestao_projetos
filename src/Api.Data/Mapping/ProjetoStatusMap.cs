using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class ProjetoStatusMap : IEntityTypeConfiguration<ProjetoStatusEntity>
    {
        public void Configure(EntityTypeBuilder<ProjetoStatusEntity> builder)
        {
            builder.ToTable("ProjetoStatus");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.nome)
                   .IsUnique();

        }
    }
}
