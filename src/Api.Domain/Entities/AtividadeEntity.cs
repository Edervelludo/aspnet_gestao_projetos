using System;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class AtividadeEntity : BaseEntity
    {
        [Required]

        public Guid projetoid { get; set; }
        public ProjetoEntity projeto { get; set; }

        public Guid faseprojetoid { get; set; }
        public FaseProjetoEntity faseprojeto { get; set; }

        [Required]
        [MaxLength(200)]
        public string nome { get; set; }

        public Boolean marco { get; set; }

        public int duracao { get; set; }

        public DateTime inicio { get; set; }

        public DateTime fim { get; set; }
        public int diasatraso { get; set; }

        public Guid atividadestatusid { get; set; }
        public AtividadeStatusEntity atividadestatus { get; set; }

        public decimal percentualcompleto { get; set; }

        public Guid atividadeprioridadeid { get; set; }
        public AtividadePrioridadeEntity atividadeprioridade { get; set; }

        public Guid atribuidoarecursoid { get; set; }
        public RecursoEntity atribuidoarecurso { get; set; }

        public string historico { get; set; }


        public Guid atividadeprecedeid { get; set; }
        public AtividadeEntity atividadeprecede { get; set; }


    }
}


