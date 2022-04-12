using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Dtos.Projeto;

namespace Api.Domain.Dtos
{
    public class ProjetoPrioridadeDtoComleto
    {
        public Guid id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }

        public IEnumerable<ProjetoDtoCompleto> projetos { get; set; }
    }
}
