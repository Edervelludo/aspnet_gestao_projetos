using System;
using Api.Domain.Dtos.DocumentoProjeto;

namespace Api.Domain.Dtos.DocumentoHistorico
{
    public class DocumentoHistoricoDto
    {
        public Guid Id { get; set; }
        public Guid documentoid { get; set; }
        //public DocumentoProjetoDtoCompleto documento { get; set; }

        public int revisao { get; set; }
        public string arquivoblob { get; set; }

        public string formatoArquivo { get; set; }

        public Boolean atual { get; set; }



    }
}
