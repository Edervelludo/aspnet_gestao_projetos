using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos;


namespace Api.Domain.Interfaces.Services.ProjetoStatus
{
    public interface IProjetoStatusService
    {
        Task<ProjetoStatusDto> Get(Guid id);
        Task<ProjetoStatusDtoCompleto> GetComplete(Guid id);
        Task<IEnumerable<ProjetoStatusDto>> GetAll();
        Task<IEnumerable<ProjetoStatusDtoCompleto>> GetCompleteAll();
    }
}
