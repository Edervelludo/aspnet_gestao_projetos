using System;

namespace Api.Domain.Entities
{
    public class DocumentoProjetoEntity : BaseEntity

    {

        public Guid projetoid { get; set; }
        public ProjetoEntity projeto { get; set; }

        public string titulo { get; set; }
        public string descricao { get; set; }

        public string arquivoblob { get; set; }

        public string tipoArquivo { get; set; }
        public string formatoArquivo { get; set; }

        public IEquatable<DocumentoHistoricoEntity> historico { get; set; }
    }
}
