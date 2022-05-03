using System;

using System.Collections.Generic;

using Api.Domain.Dtos.Atividade;
using Api.Domain.Dtos.CartaoTempo;
using Api.Domain.Dtos.DocumentoProjeto;
using Api.Domain.Dtos.Questoes;

namespace Api.Domain.Dtos.Projeto
{
    public class ProjetoDtoCompleto
    {
        public Guid Id { get; set; }
        public string lider { get; set; }
        public string dono { get; set; }
        public string nome { get; set; }
        public Guid EmpresaId { get; set; }
        public EmpresaDtoCompleto Empresa { get; set; }
        public string descricao { get; set; }
        public DateTime inicio { get; set; }
        public DateTime planejamentofim { get; set; }
        public decimal percentualConclusao { get; set; }
        public decimal custoEstimado { get; set; }
        public decimal cursoAtual { get; set; }
        public decimal percentualOrcamento { get; set; }
        public int estimativaHora { get; set; }
        public int horaAtual { get; set; }
        public Guid prioridadeGuid { get; set; }
        public ProjetoPrioridadeDtoCompleto prioridade { get; set; }
        public Guid statusGuid { get; set; }
        public ProjetoStatusDtoCompleto status { get; set; }
        public IEnumerable<AtividadeDtoCompleto> atividades { get; set; }
        public IEnumerable<CartaoTempoDtoCompleto> cartoesTempo { get; set; }

        public IEnumerable<DocumentoProjetoDtoCompleto> documentos { get; set; }

        public IEnumerable<QuestaoDtoCompleto> questoes { get; set; }


    }
}
