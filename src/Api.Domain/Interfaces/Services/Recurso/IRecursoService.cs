using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos;
using Api.Domain.Dtos.Resurso;

namespace Api.Domain.Interfaces.Services.Recurso
{
    public interface IRecursoService
    {

        Task<RecursoDto> Get(Guid id);
        Task<RecursoDtoCompleto> GetComplete(Guid id);

        Task<RecursoDto> GetNome(string nome);
        Task<RecursoDtoCompleto> GetNomeComplete(string nome);

        Task<IEnumerable<RecursoDto>> GetAll();
        Task<IEnumerable<RecursoDtoCompleto>> GetCompleteAll();

        Task<IEnumerable<RecursoDto>> GetByIdEmpresa(Guid idEmpresa);
        Task<IEnumerable<RecursoDtoCompleto>> GetByCompleteIdEmpresa(Guid idEmpresa);

        Task<RecursoDtoCreateResult> Post(RecursoDtoCreate rescurso);
        Task<RecursoDtoUpdateResult> Put(RecursoDtoUpdate rescurso);
        Task<bool> Delete(Guid id);
    }
}
