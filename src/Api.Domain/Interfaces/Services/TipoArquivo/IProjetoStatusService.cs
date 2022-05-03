using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Api.Domain.Dtos.TipoArquivo;

namespace Api.Domain.Interfaces.Services.TipoArquivo
{
    public interface ITipoArquivoService
    {
        Task<TipoArquivoDto> Get(Guid id);
        Task<TipoArquivoDtoCompleto> GetComplete(Guid id);
        Task<IEnumerable<TipoArquivoDto>> GetAll();
        Task<IEnumerable<TipoArquivoDtoCompleto>> GetCompleteAll();
    }
}
