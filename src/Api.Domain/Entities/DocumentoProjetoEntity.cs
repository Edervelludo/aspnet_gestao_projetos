using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class DocumentoProjetoEntity : BaseEntity

    {
        [Required]
        public Guid projetoid { get; set; }
        public ProjetoEntity projeto { get; set; }

        [Required]
        public string titulo { get; set; }
        public string descricao { get; set; }

        public Byte[] arquivoblob { get; set; }

        public Guid idtipoArquivo { get; set; }

        public TipoArquivoEntity tipoArquivo { get; set; }
        public string formatoArquivo { get; set; }

        public IEnumerable<DocumentoHistoricoEntity> historico { get; set; }
    }
}
