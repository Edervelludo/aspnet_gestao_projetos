using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class QuestaoPrioridadeEntity : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string nome { get; set; }

        [MaxLength(200)]
        public string descricao { get; set; }

        public IEnumerable<QuestaoEntity> questoes { get; set; }
    }
}
