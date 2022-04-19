using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.DocumentoProjeto
{
    public class DocumentoProjetoDtoCreateResult

    {
        public Guid Id { get; set; }
        public Guid projetoid { get; set; }
        //public ProjetoEntity projeto { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string arquivoblob { get; set; }
        public Guid idtipoArquivo { get; set; }
        // public TipoArquivoDto tipoArquivo { get; set; }
        public string formatoArquivo { get; set; }
        // public IEnumerable<DocumentoHistoricoEntity> historico { get; set; }

        public DateTime CreateAt { get; set; }
    }
}
