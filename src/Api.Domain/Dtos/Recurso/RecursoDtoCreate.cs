using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Dtos.Atividade;
using Api.Domain.Dtos.CartaoTempo;

namespace Api.Domain.Dtos.Resurso
{
    public class RecursoDtoCreate
    {
        [Required(ErrorMessage = "O nome  é campo Obrigatrio")]
        [StringLength(200, ErrorMessage = "O nome  deve ter no máximo {1} caracteres.")]

        public string nome { get; set; }

        [RegularExpression("^[(]{1}[1-9]{2}[)]{1}[0-9]{4,5}[-]{1}[0-9]{3,4}$", ErrorMessage = "Por favor, preencha o campo no formato: (00)1234-5678 ou (00)12345-6789")]
        public string telefone { get; set; }

        [StringLength(500, ErrorMessage = "Habilidades deve ter no máximo {1} caracteres.")]
        public string habilidades { get; set; }

        [StringLength(500, ErrorMessage = "Observações deve ter no máximo {1} caracteres.")]
        public string obsrevacoes { get; set; }
        public decimal valorHora { get; set; }

        [StringLength(100, ErrorMessage = "Cargo deve ter no máximo {1} caracteres.")]
        public string cargo { get; set; }

        [Required(ErrorMessage = "O id da empresa é campo Obrigatrio")]
        public Guid EmpresaId { get; set; }
        [Required(ErrorMessage = "O id da departamento é campo Obrigatrio")]
        public Guid DepartamentoId { get; set; }



    }
}
