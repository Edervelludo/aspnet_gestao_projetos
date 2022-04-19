using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dto.Questoes
{
    public class QuestaoDtoCreate
    {

        [Required(ErrorMessage = "O nome  é campo Obrigatrio")]
        [StringLength(200, ErrorMessage = "O nome da atividade deve ter no máximo {1} caracteres.")]
        public string nome { get; set; }
        [Required(ErrorMessage = "A Descrição é campo Obrigatrio")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Id do Recurso Criador é campo Obrigatorio")]
        public Guid recursoCriadorid { get; set; }
        //  public RecursoEntity recursoCriador { get; set; }
        [Required(ErrorMessage = "Id do Projeto é campo Obrigatorio")]
        public Guid projetoid { get; set; }
        //public ProjetoEntity projeto { get; set; }
        [Required(ErrorMessage = "Id Prioridade é campo Obrigatorio")]
        public Guid prioridadeid { get; set; }
        //public QuestaoPrioridadeEntity prioridade { get; set; }
        [Required(ErrorMessage = "Id do Status é campo Obrigatorio")]
        public Guid statusid { get; set; }
        // public QuestaoStatusEntity status { get; set; }

        public string atualizacoes { get; set; }

        public string resolucao { get; set; }

        public DateTime dataidentificacao { get; set; }
        public int diasresolver { get; set; }
        public DateTime dataresolucao { get; set; }



    }
}
