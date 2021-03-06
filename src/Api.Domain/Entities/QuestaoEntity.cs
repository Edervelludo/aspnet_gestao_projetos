using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class QuestaoEntity : BaseEntity
    {

        [Required]
        [MaxLength(200)]
        public string nome { get; set; }
        [Required]
        public string descricao { get; set; }

        [Required]
        public Guid recursoCriadorid { get; set; }
        public RecursoEntity recursoCriador { get; set; }
        [Required]
        public Guid projetoid { get; set; }
        public ProjetoEntity projeto { get; set; }
        [Required]
        public Guid prioridadeid { get; set; }
        public QuestaoPrioridadeEntity prioridade { get; set; }
        [Required]
        public Guid statusid { get; set; }
        public QuestaoStatusEntity status { get; set; }

        public string atualizacoes { get; set; }

        public string resolucao { get; set; }

        public DateTime dataidentificacao { get; set; }
        public int diasresolver { get; set; }
        public DateTime dataresolucao { get; set; }



    }
}
