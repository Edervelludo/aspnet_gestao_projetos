using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Dtos.DocumentoHistorico;
using Api.Domain.Dtos.Projeto;
using Api.Domain.Dtos.TipoArquivo;

namespace Api.Domain.Dtos.DocumentoProjeto
{
    public class DocumentoProjetoDtoCompleto

    {
        public Guid Id { get; set; }
        public Guid projetoid { get; set; }

        public ProjetoDtoCompleto projeto { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string arquivoblob { get; set; }
        public Guid idtipoArquivo { get; set; }

        public TipoArquivoDto tipoArquivo { get; set; }
        public string formatoArquivo { get; set; }

        public IEnumerable<DocumentoHistoricoDtoCompleto> historico { get; set; }
    }
}
