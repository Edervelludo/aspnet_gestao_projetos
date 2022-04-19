using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.TipoArquivo
{
    public class TipoArquivoDto
    {
        public Guid Id { get; set; }
        public string nome { get; set; }

        public string descricao { get; set; }
        //public IEnumerable<DocumentoProjetoD> documentos { get; set; }

    }
}
