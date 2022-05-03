using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dto.Questoes;
using Api.Domain.Dtos.Atividade;
using Api.Domain.Dtos.Questoes;

namespace Api.Domain.Interfaces.Services.Questao
{
    public interface IQuestaoService
    {

        Task<QuestaoDto> Get(Guid id);
        Task<QuestaoDtoCompleto> GetComplete(Guid id);

        Task<IEnumerable<QuestaoDto>> GetAll();
        Task<IEnumerable<QuestaoDtoCompleto>> GetCompleteAll();

        Task<IEnumerable<QuestaoDto>> GetByIdProjeto(Guid idProjeto);
        Task<IEnumerable<QuestaoDtoCompleto>> GetByCompleteIdProjeto(Guid idprojeto);


        Task<IEnumerable<QuestaoDto>> GetByIdRecurso(Guid idProjeto);
        Task<IEnumerable<QuestaoDtoCompleto>> GetByCompleteIdRecurso(Guid idprojeto);

        Task<QuestaoDtoCreateResult> Post(QuestaoDtoCreate atividade);
        Task<QuestaoDtoUpdateREsult> Put(QuestaoDtoUpdate atividade);
        Task<bool> Delete(Guid id);
    }
}
