using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Atividade;


namespace Api.Domain.Interfaces.Services.Atividade
{
    public interface IAtividadeService
    {

        Task<AtividadeDto> Get(Guid id);
        Task<AtividadeDtoCompleto> GetComplete(Guid id);

        Task<IEnumerable<AtividadeDto>> GetAll();
        Task<IEnumerable<AtividadeDtoCompleto>> GetCompleteAll();

        Task<IEnumerable<AtividadeDto>> GetByIdProjeto(Guid idProjeto);
        Task<IEnumerable<AtividadeDtoCompleto>> GetByCompleteIdProjeto(Guid idprojeto);


        Task<AtividadeDtoCreateResult> Post(AtividadeDtoCreate atividade);
        Task<AtividadeDtoUpdateResult> Put(AtividadeDtoUpdate atividade);
        Task<bool> Delete(Guid id);
    }
}
