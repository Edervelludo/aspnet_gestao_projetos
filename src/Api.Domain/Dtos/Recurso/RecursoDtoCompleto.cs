using System;
using System.Collections.Generic;
using Api.Domain.Dtos.Atividade;
using Api.Domain.Dtos.CartaoTempo;
using Api.Domain.Dtos.Questoes;
using Api.Domain.Dtos.Departamento;

namespace Api.Domain.Dtos
{
    public class RecursoDtoCompleto
    {

        public Guid id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string habilidades { get; set; }
        public string observacoes { get; set; }
        public decimal valorHora { get; set; }
        public string cargo { get; set; }
        public Guid EmpresaId { get; set; }
        public EmpresaDtoCompleto Empresa { get; set; }
        public Guid DepartamentoId { get; set; }
        public DepartamentoDtoCompleto Departamento { get; set; }

        public IEnumerable<AtividadeDtoCompleto> atividades { get; set; }

        public IEnumerable<CartaoTempoDtoCompleto> cartoresTempo { get; set; }

        public IEnumerable<QuestaoDtoCompleto> questoesCriadas { get; set; }

    }
}
