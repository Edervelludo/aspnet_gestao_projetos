using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos
{
    public class ProjetoPrioridadeDto
    {
        public Guid id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }

        //public IEnumerable<ProjetoEntity> projetos { get; set; }
    }
}
