using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace Api.Domain.Entities
{
    public class EmpresaEntity : BaseEntity
    {
        [Required]
        [MaxLength(200)]
        public string nome { get; set; }
        [MaxLength(200)]
        public string descricao { get; set; }
        public IEnumerable<RecursoEntity> Recursos { get; set; }
        public IEnumerable<ProjetoEntity> Projetos { get; set; }
    }
}
