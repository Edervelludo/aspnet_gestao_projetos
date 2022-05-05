using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Projeto
{
    public class ProjetoDto
    {
        public Guid Id { get; set; }
        public string lider { get; set; }
        public string dono { get; set; }
        public string nome { get; set; }
        public Guid EmpresaId { get; set; }
        //public EmpresaEntity Empresa { get; set; }
        public string descricao { get; set; }
        public DateTime inicio { get; set; }
        public DateTime planejamentofim { get; set; }
        public decimal percentualConclusao { get; set; }
        public decimal custoEstimado { get; set; }
        public decimal custoAtual { get; set; }
        public decimal percentualOrcamento { get; set; }
        public int estimativaHora { get; set; }
        public int horaAtual { get; set; }
        public Guid prioridadeGuid { get; set; }
        // public ProjetoPrioridadeEntity prioridade { get; set; }
        public Guid statusGuid { get; set; }
        // public ProjetoStatusEntity status { get; set; }
        //   public IEnumerable<AtividadeEntity> atividades { get; set; }
        //   public IEnumerable<CartaoTempoEntity> cartoesTempo { get; set; }
        //   public IEnumerable<DocumentoProjetoEntity> documentos { get; set; }




    }
}
