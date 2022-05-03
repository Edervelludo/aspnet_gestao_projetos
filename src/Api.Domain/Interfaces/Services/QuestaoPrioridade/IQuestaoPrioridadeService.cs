using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.QuestaoPrioridade;


namespace Api.Domain.Interfaces.Services.QuestaoPrioridade
{
    public interface IQuestaoPrioridadeService
    {
        Task<QuestaoPrioridadeDto> Get(Guid id);
        Task<IEnumerable<QuestaoPrioridadeDto>> GetAll();
    }
}
