using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.AtividadeStatus;

namespace Api.Domain.Interfaces.Services.AtividadeStatus
{
    public interface IAtividadeStatusService
    {
        Task<AtividadeStatusDto> Get(Guid id);
        Task<IEnumerable<AtividadeStatusDto>> GetAll();
    }
}
