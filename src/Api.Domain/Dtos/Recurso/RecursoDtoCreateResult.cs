using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos
{
    public class RecursoDtoCreateResult
    {

        public Guid id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string habilidades { get; set; }
        public string observacoes { get; set; }
        public decimal valorHora { get; set; }
        public string cargo { get; set; }
        public Guid EmpresaId { get; set; }
        public Guid DepartamentoId { get; set; }
        public DateTime CreateAt { get; set; }

    }
}
