using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.QuestaoStatus;


namespace Api.Domain.Interfaces.Services.QuestaoStatus
{
    public interface IQuestaoPrioridadeService
    {
        Task<QuestaoStatusDto> Get(Guid id);
        Task<IEnumerable<QuestaoStatusDto>> GetAll();
    }
}
