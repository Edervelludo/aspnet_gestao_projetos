using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class FaseProjetoDto
    {

        public int Id { get; set; }
        public string nome { get; set; }

        public string descricao { get; set; }

    }
}
