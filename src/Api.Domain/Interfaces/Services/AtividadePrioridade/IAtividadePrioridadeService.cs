using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.AtividadePrioridade;


namespace Api.Domain.Interfaces.Services.AtividadePrioridade
{
    public interface IAtividadePrioridadeService
    {
        Task<AtividadePrioridadeDto> Get(Guid id);
        Task<IEnumerable<AtividadePrioridadeDto>> GetAll();
    }
}
