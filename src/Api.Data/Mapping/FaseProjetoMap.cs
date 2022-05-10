using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class FaseProjetoMap : IEntityTypeConfiguration<FaseProjetoEntity>
    {
        public void Configure(EntityTypeBuilder<FaseProjetoEntity> builder)
        {
            builder.ToTable("FaseProjeto");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.nome)
                   .IsUnique();

        }
    }
}
