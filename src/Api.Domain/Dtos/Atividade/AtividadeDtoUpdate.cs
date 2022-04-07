using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Api.Domain.Dtos.Atividade
{
    public class AtividadeDtoUpdate
    {

        [Required(ErrorMessage = "Id é campo Obrigatorio")]
        public Guid Id { get; set; }



        [Required(ErrorMessage = "Id do Projeto é campo Obrigatorio")]
        public Guid ProjetoId { get; set; }

        [Required(ErrorMessage = "Id da Fase do projeto é campo Obrigatorio")]
        public Guid FaseprojetoId { get; set; }

        [Required(ErrorMessage = "O nome da atividade é campo Obrigatrio")]
        [StringLength(200, ErrorMessage = "O nome da atividade deve ter no máximo {1} caracteres.")]
        public string Nome { get; set; }

        public Boolean Marco { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Valor inválido")]
        public int Duracao { get; set; }


        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime Inicio { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]

        public DateTime Fim { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Valor inválido")]
        public int DiasAtraso { get; set; }

        [Required(ErrorMessage = "O id do status da avtividade é campo Obrigatrio")]
        public Guid AtividadeStatusId { get; set; }

        [Range(0, 100, ErrorMessage = "Valor inválido")]
        public decimal PercentualCompleto { get; set; }

        [Required(ErrorMessage = "A id da prioridade da avtividade é campo Obrigatrio")]
        public Guid AtividadePrioridadeid { get; set; }

        public Guid AtribuidoaRecursoId { get; set; }
        public string Historico { get; set; }

        public Guid AtividadePrecedeId { get; set; }

    }
}
