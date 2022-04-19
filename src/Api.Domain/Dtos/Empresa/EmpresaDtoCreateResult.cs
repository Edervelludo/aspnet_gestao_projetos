using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Api.Domain.Dtos
{
    public class EmpresaDtoCreateResult
    {
        public Guid Id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public DateTime CreateAt { get; set; }

    }
}
