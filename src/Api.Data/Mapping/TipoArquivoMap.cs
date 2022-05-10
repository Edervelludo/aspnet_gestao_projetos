using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class TipoArquivoMap : IEntityTypeConfiguration<TipoArquivoEntity>
    {
        public void Configure(EntityTypeBuilder<TipoArquivoEntity> builder)
        {
            builder.ToTable("TipoArquivo");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.nome)
                   .IsUnique();

        }
    }
}
