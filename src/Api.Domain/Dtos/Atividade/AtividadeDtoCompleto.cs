using System;
using Api.Domain.Dtos.AtividadePrioridade;
using Api.Domain.Dtos.AtividadeStatus;
using Api.Domain.Dtos.Projeto;

namespace Api.Domain.Dtos.Atividade
{
    public class AtividadeDtoCompleto
    {
        public Guid Id { get; set; }
        public Guid ProjetoId { get; set; }
        public ProjetoDtoCompleto ProjetoDto { get; set; }
        public Guid FaseProjetoId { get; set; }
        public FaseProjetoDto FaseProjeto { get; set; }
        public string Nome { get; set; }

        public Boolean Marco { get; set; }

        public int Duracao { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Fim { get; set; }
        public int DiasAtraso { get; set; }

        public Guid AtividadeStatusId { get; set; }

        public AtividadeStatusDto AtividadeStatus { get; set; }
        public decimal PercentualCompleto { get; set; }

        public Guid AtividadePrioridadeid { get; set; }
        public AtividadePrioridadeDto AtividadePrioridade { get; set; }

        public Guid AtribuidoaRecursoId { get; set; }
        public RecursoDtoCompleto AtribuidoARecurso { get; set; }
        public string Historico { get; set; }

        public Guid AtividadePrecedeId { get; set; }
        public AtividadeDtoCompleto AtividadePrecede { get; set; }

    }
}
