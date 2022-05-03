using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.DocumentoProjeto;


namespace Api.Domain.Interfaces.Services.DocumentoProjeto
{
    public interface IDocumentoProjetoService
    {

        Task<DocumentoProjetoDto> Get(Guid id);
        Task<DocumentoProjetoDtoCompleto> GetComplete(Guid id);

        Task<IEnumerable<DocumentoProjetoDto>> GetAll();
        Task<IEnumerable<DocumentoProjetoDtoCompleto>> GetCompleteAll();

        Task<IEnumerable<DocumentoProjetoDto>> GetByIdProjeto(Guid idProjeto);
        Task<IEnumerable<DocumentoProjetoDtoCompleto>> GetByCompleteIdProjeto(Guid idprojeto);


        Task<DocumentoProjetoDtoCreateResult> Post(DocumentoProjetoDtoCreate documento);
        Task<DocumentoProjetoDtoUpdateResult> Put(DocumentoProjetoDtoUpdate documento);
        Task<bool> Delete(Guid id);
    }
}
