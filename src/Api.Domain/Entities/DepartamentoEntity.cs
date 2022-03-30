using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class DepartamentoEntity : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string nome { get; set; }

        [MaxLength(200)]
        public string descricao { get; set; }
    }
}
