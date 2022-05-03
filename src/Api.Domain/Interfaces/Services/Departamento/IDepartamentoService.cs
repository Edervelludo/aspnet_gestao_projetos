using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Departamento;


namespace Api.Domain.Interfaces.Services.Departamento
{
    public interface IDepartamentoService
    {
        Task<DepartamentoDto> Get(Guid id);
        Task<IEnumerable<DepartamentoDto>> GetAll();
    }
}
