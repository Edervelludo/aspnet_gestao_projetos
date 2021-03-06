using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Questoes
{
    public class QuestaoDtoCreateResult
    {

        public Guid Id { get; set; }
        public string nome { get; set; }

        public string descricao { get; set; }


        public Guid recursoCriadorid { get; set; }
        // public RecursoEntity recursoCriador { get; set; }

        public Guid projetoid { get; set; }
        //  public ProjetoEntity projeto { get; set; }

        public Guid prioridadeid { get; set; }
        // public QuestaoPrioridadeEntity prioridade { get; set; }

        public Guid statusid { get; set; }
        //public QuestaoStatusEntity status { get; set; }

        public string atualizacoes { get; set; }

        public string resolucao { get; set; }

        public DateTime dataidentificacao { get; set; }
        public int diasresolver { get; set; }
        public DateTime dataresolucao { get; set; }

        public DateTime CreateAt { get; set; }

    }
}
