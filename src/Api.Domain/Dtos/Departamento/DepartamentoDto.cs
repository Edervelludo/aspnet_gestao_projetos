using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Departamento
{
    public class DepartamentoDto
    {
        public Guid id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }

        public IEnumerable<RecursoDtoCompleto> Recursos { get; set; }
    }
}
