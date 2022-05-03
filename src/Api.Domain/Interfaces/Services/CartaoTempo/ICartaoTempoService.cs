using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Atividade;
using Api.Domain.Dtos.CartaoTempo;

namespace Api.Domain.Interfaces.Services.Atividade
{
    public interface ICartaoTempoService
    {
        Task<CartaoTempoDto> Get(Guid id);
        Task<CartaoTempoDtoCompleto> GetComplete(Guid id);

        Task<IEnumerable<CartaoTempoDto>> GetAll();
        Task<IEnumerable<CartaoTempoDtoCompleto>> GetCompleteAll();

        Task<IEnumerable<CartaoTempoDto>> GetByIdProjeto(Guid idprojeto);
        Task<IEnumerable<CartaoTempoDtoCompleto>> GetByIdProjetoComplete(Guid idprojeto);

        Task<IEnumerable<CartaoTempoDto>> GetByIdRecurso(Guid idrecurso);
        Task<IEnumerable<CartaoTempoDtoCompleto>> GetByIdRecursoComplete(Guid idrecurso);

        Task<AtividadeDtoCreateResult> Post(AtividadeDtoCreate atividade);
        Task<AtividadeDtoUpdateResult> Put(AtividadeDtoUpdate atividade);
        Task<bool> Delete(Guid id);
    }
}
