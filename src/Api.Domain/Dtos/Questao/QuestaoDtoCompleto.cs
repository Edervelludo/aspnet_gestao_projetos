using System;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Dtos.Projeto;
using Api.Domain.Dtos.QuestaoPrioridade;
using Api.Domain.Dtos.QuestaoStatus;

namespace Api.Domain.Dtos.Questoes
{
    public class QuestaoDtoCompleto
    {

        public Guid Id { get; set; }
        public string nome { get; set; }

        public string descricao { get; set; }

        public Guid recursoCriadorid { get; set; }
        public RecursoDtoCompleto recursoCriador { get; set; }

        public Guid projetoid { get; set; }
        public ProjetoDtoCompleto projeto { get; set; }

        public Guid prioridadeid { get; set; }
        public QuestaoPrioridadeDto prioridade { get; set; }

        public Guid statusid { get; set; }
        public QuestaoStatusDto status { get; set; }

        public string atualizacoes { get; set; }

        public string resolucao { get; set; }

        public DateTime dataidentificacao { get; set; }
        public int diasresolver { get; set; }
        public DateTime dataresolucao { get; set; }



    }
}
