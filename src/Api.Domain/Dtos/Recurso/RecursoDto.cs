using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos
{
    public class RecursoDto
    {

        public Guid id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string habilidades { get; set; }
        public string observacoes { get; set; }
        public decimal valorHora { get; set; }
        public string cargo { get; set; }
        public Guid EmpresaId { get; set; }
        //public EmpresaEntity Empresa { get; set; }
        public Guid DepartamentoId { get; set; }
        //public DepartamentoEntity Departamento { get; set; }

        //public IEnumerable<AtividadeEntity> atividades { get; set; }

        //public IEnumerable<CartaoTempoEntity> cartoresTempo { get; set; }

        // public IEnumerable<QuestaoEntity> questoesCriadas { get; set; }

    }
}
