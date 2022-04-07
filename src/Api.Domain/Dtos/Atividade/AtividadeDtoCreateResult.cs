using System;

namespace Api.Domain.Dtos.Atividade
{
    public class AtividadeDtoCreateResult
    {

        public Guid Id { get; set; }
        public Guid ProjetoId { get; set; }
        public Guid FaseprojetoId { get; set; }
        public string Nome { get; set; }

        public Boolean Marco { get; set; }

        public int Duracao { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Fim { get; set; }
        public int DiasAtraso { get; set; }

        public Guid AtividadeStatusId { get; set; }
        public decimal PercentualCompleto { get; set; }

        public Guid AtividadePrioridadeid { get; set; }

        public Guid AtribuidoaRecursoId { get; set; }
        public string Historico { get; set; }

        public Guid AtividadePrecedeId { get; set; }

        public DateTime CreateAt { get; set; }


    }
}
