using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Projeto
{
    public class ProjetoDtoCreateResult
    {
        public Guid Id { get; set; }
        public string lider { get; set; }
        public string dono { get; set; }
        public string nome { get; set; }
        public Guid EmpresaId { get; set; }
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

        public Guid statusGuid { get; set; }

        public DateTime CreateAt { get; set; }

    }
}
