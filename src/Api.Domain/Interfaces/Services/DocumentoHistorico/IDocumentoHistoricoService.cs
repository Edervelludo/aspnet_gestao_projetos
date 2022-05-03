using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Api.Domain.Dtos.DocumentoHistorico;

namespace Api.Domain.Interfaces.Services.DocumentoHistorico
{
    public interface IDocumentoHistoricoService
    {

        Task<DocumentoHistoricoDto> Get(Guid id);
        Task<DocumentoHistoricoDtoCompleto> GetComplete(Guid id);

        Task<IEnumerable<DocumentoHistoricoDto>> GetAll();
        Task<IEnumerable<DocumentoHistoricoDtoCompleto>> GetCompleteAll();

        Task<IEnumerable<DocumentoHistoricoDto>> GetByIdProjeto(Guid idDocumento);
        Task<IEnumerable<DocumentoHistoricoDtoCompleto>> GetByCompleteIdProjeto(Guid idDocumento);


        Task<DocumentoHistoricoDtoCreateResult> Post(DocumentoHistoricoDtoCreate historico);
        Task<DocumentoHistoricoDtoUpdateResult> Put(DocumentoHistoricoDtoUpdate historico);
        Task<bool> Delete(Guid id);
    }
}
