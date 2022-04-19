using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Api.Domain.Dtos
{
    public class EmpresaDtoUpdateResult
    {
        public Guid Id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public DateTime UpdateAt { get; set; }

    }
}
