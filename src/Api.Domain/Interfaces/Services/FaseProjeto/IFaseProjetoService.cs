using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos;


namespace Api.Domain.Interfaces.Services.FaseProjeto
{
    public interface IFaseProjetoService
    {
        Task<FaseProjetoDto> Get(Guid id);
        Task<IEnumerable<FaseProjetoDto>> GetAll();
    }
}
