using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class RecursoEntity : BaseEntity
    {

        [Required]
        [MaxLength(200)]

        public string nome { get; set; }

        [RegularExpression("^[(]{1}[1-9]{2}[)]{1}[0-9]{4,5}[-]{1}[0-9]{3,4}$", ErrorMessage = "Por favor, preencha o campo no formato: (00)1234-5678 ou (00)12345-6789")]
        public string telefone { get; set; }

        [MaxLength(500)]
        public string habilidades { get; set; }

        [MaxLength(500)]
        public string obsrevacoes { get; set; }

        public decimal valorHora { get; set; }

        [MaxLength(100)]
        public string cargo { get; set; }

        [Required]
        public Guid EmpresaId { get; set; }
        public EmpresaEntity Empresa { get; set; }


        [Required]
        public Guid DepartamentoId { get; set; }
        public DepartamentoEntity Departamento { get; set; }

        public IEnumerable<AtividadeEntity> atividades { get; set; }

        public IEnumerable<CartaoTempoEntity> cartoresTempo { get; set; }

        public IEnumerable<QuestaoEntity> questoesCriadas { get; set; }

    }
}
