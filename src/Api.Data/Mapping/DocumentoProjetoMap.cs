using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class DocumentoProjetoMap : IEntityTypeConfiguration<DocumentoProjetoEntity>
    {
        public void Configure(EntityTypeBuilder<DocumentoProjetoEntity> builder)
        {
            builder.ToTable("DocumentoProjeto");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.projetoid);

            builder.HasOne(u => u.projeto)
                   .WithMany(p => p.documentos);


            builder.HasOne(u => u.tipoArquivo)
                   .WithMany(p => p.documentos);


        }
    }
}
