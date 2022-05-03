using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Projeto;


namespace Api.Domain.Interfaces.Services.Projeto
{
    public interface IProjetoService
    {

        Task<ProjetoDto> Get(Guid id);
        Task<ProjetoDtoCompleto> GetComplete(Guid id);

        Task<IEnumerable<ProjetoDto>> GetAll();
        Task<IEnumerable<ProjetoDtoCompleto>> GetCompleteAll();

        Task<IEnumerable<ProjetoDto>> GetByIdEmpresa(Guid idProjeto);
        Task<IEnumerable<ProjetoDtoCompleto>> GetByCompleteIdEmpresa(Guid idprojeto);

        Task<ProjetoDtoCreateResult> Post(ProjetoDtoCreate atividade);
        Task<ProjetoDtoUpdateResult> Put(ProjetoDtoUpdate atividade);
        Task<bool> Delete(Guid id);
    }
}
