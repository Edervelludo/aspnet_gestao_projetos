using System;

namespace Api.Domain.Entities
{
    public class DocumentoHistoricoEntity : BaseEntity
    {
        public Guid documentoid { get; set; }
        public DocumentoProjetoEntity documento { get; set; }

        public int revisao { get; set; }
        public string arquivoblob { get; set; }

        public string formatoArquivo { get; set; }

        public Boolean atual { get; set; }



    }
}
