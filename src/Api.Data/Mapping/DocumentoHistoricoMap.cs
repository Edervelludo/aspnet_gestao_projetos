using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class DocumentoHistoricoMap : IEntityTypeConfiguration<DocumentoHistoricoEntity>
    {
        public void Configure(EntityTypeBuilder<DocumentoHistoricoEntity> builder)
        {
            builder.ToTable("DocumentoHistorico");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.documentoid);

            builder.HasOne(u => u.documento)
                   .WithMany(p => p.historico);


        }
    }
}
