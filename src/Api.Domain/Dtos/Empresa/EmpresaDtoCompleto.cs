using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Api.Domain.Dtos
{
    public class EmpresaDtoCompleto
    {
        public Guid Id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }

        //public IEnumerable<RecursoDtoCompleto> Recursos { get; set; }
        //  public IEnumerable<ProjetoDtoCompleto> Projetos { get; set; }

    }
}
