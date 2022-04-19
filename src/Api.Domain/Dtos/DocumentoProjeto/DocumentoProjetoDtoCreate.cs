using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.DocumentoProjeto
{
    public class DocumentoProjetoDtoCreate

    {

        [Required(ErrorMessage = "Id do Projeto é campo Obrigatorio")]
        public Guid projetoid { get; set; }
        //public ProjetoEntity projeto { get; set; }

        [Required(ErrorMessage = "O título é campo Obrigatrio")]
        [StringLength(200, ErrorMessage = "O título deve ter no máximo {1} caracteres.")]
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string arquivoblob { get; set; }

        [Required(ErrorMessage = "Id do Tipo de Arquivo é campo Obrigatorio")]
        public Guid idtipoArquivo { get; set; }
        // public TipoArquivoDto tipoArquivo { get; set; }

        [Required(ErrorMessage = "O Formato é campo Obrigatrio")]
        [StringLength(3, ErrorMessage = "O Formato deve ter no máximo {1} caracteres.")]
        public string formatoArquivo { get; set; }
        // public IEnumerable<DocumentoHistoricoEntity> historico { get; set; }
    }
}
