using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos
{
    public class FaseProjetoDto
    {

        public int Id { get; set; }
        public string nome { get; set; }

        public string descricao { get; set; }

    }
}
