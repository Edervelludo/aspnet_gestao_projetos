using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Api.Domain.Dtos
{
    public class EmpresaDtoCreate
    {
        [Required(ErrorMessage = "O nome da Empresa é campo Obrigatrio")]
        [StringLength(200, ErrorMessage = "O nome da empresa deve ter no máximo {1} caracteres.")]
        public string nome { get; set; }
        public string descricao { get; set; }



    }
}
