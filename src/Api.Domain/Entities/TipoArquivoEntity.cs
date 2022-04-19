using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class TipoArquivoEntity : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string nome { get; set; }
        [MaxLength(200)]
        public string descricao { get; set; }
        public IEnumerable<DocumentoProjetoEntity> documentos { get; set; }

    }
}
