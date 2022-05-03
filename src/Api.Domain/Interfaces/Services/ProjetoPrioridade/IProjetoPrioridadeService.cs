using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos;


namespace Api.Domain.Interfaces.Services.ProjetoPrioridade
{
    public interface IProjetoPrioridadeService
    {
        Task<ProjetoPrioridadeDto> Get(Guid id);
        Task<ProjetoPrioridadeDtoCompleto> GetComplete(Guid id);
        Task<IEnumerable<ProjetoPrioridadeDto>> GetAll();
        Task<IEnumerable<ProjetoPrioridadeDtoCompleto>> GetCompleteAll();
    }
}
