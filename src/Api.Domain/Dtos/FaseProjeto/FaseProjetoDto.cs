using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos
{
    public class FaseProjetoDto
    {

        public Guid Id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }

    }
}
