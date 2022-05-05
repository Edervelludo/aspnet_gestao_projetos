using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class ProjetoEntity : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string lider { get; set; }

        [MaxLength(200)]
        public string dono { get; set; }

        [MaxLength(200)]
        public string nome { get; set; }

        [Required]
        public Guid EmpresaId { get; set; }
        public EmpresaEntity Empresa { get; set; }

        [MaxLength(1000)]
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
        public ProjetoPrioridadeEntity prioridade { get; set; }


        public Guid statusGuid { get; set; }
        public ProjetoStatusEntity status { get; set; }

        public IEnumerable<AtividadeEntity> atividades { get; set; }
        public IEnumerable<CartaoTempoEntity> cartoesTempo { get; set; }
        public IEnumerable<DocumentoProjetoEntity> documentos { get; set; }

        public IEnumerable<QuestaoEntity> questoes { get; set; }

    }
}
