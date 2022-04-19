using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Dtos.DocumentoProjeto;

namespace Api.Domain.Dtos.TipoArquivo
{
    public class TipoArquivoDtoCompleto
    {
        public Guid Id { get; set; }
        public string nome { get; set; }

        public string descricao { get; set; }

        public IEnumerable<DocumentoProjetoDtoCompleto> documentos { get; set; }

    }
}
