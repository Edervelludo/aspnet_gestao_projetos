using System;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Dtos.DocumentoProjeto;

namespace Api.Domain.Dtos.DocumentoHistorico
{
    public class DocumentoHistoricoDtoUpdate
    {


        [Required(ErrorMessage = "Id  é campo Obrigatorio")]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Id do Documento é campo Obrigatorio")]
        public Guid documentoid { get; set; }
        //public DocumentoProjetoDtoCompleto documento { get; set; }

        public int revisao { get; set; }
        public string arquivoblob { get; set; }

        [Required(ErrorMessage = "O Formato é campo Obrigatrio")]
        [StringLength(3, ErrorMessage = "O Formato deve ter no máximo {1} caracteres.")]
        public string formatoArquivo { get; set; }

        public Boolean atual { get; set; }



    }
}
