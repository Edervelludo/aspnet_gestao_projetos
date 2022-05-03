using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos;
using Api.Domain.Dtos.Atividade;

namespace Api.Domain.Interfaces.Services.Empresa
{
    public interface IEmpresaService
    {

        Task<EmpresaDto> Get(Guid id);
        Task<EmpresaDtoCompleto> GetComplete(Guid id);

        Task<EmpresaDto> GetNome(string nome);
        Task<EmpresaDtoCompleto> GetNomeComplete(string nome);

        Task<IEnumerable<EmpresaDto>> GetAll();
        Task<IEnumerable<EmpresaDtoCompleto>> GetCompleteAll();

        Task<AtividadeDtoCreateResult> Post(AtividadeDtoCreate atividade);
        Task<AtividadeDtoUpdateResult> Put(AtividadeDtoUpdate atividade);
        Task<bool> Delete(Guid id);
    }
}
