using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Api.Domain.Dtos
{
    public class EmpresaDto
    {
        public Guid Id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }

        //public IEnumerable<RecursoEntity> Recursos { get; set; }
        //public IEnumerable<ProjetoEntity> Projetos { get; set; }

    }
}
