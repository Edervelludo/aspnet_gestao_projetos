using System;
using Api.Domain.Models;

namespace Api.Domain.Models
{
    public class DocumentoHistoricoModel : BaseModel
    {
        private Guid _documentoid;
        public Guid DocumentoId
        {
            get { return _documentoid; }
            set { _documentoid = value; }
        }

        private int _revisao;
        public int Revisao
        {
            get { return _revisao; }
            set { _revisao = value; }
        }


        private byte[] _arquivoblob;
        public byte[] ArquivoBlob
        {
            get { return _arquivoblob; }
            set { _arquivoblob = value; }
        }

        private String _formatoarquivo;
        public String FormatoArquivo
        {
            get { return _formatoarquivo; }
            set { _formatoarquivo = value; }
        }

        private Boolean _atual;
        public Boolean Atual
        {
            get { return _atual; }
            set { _atual = value; }
        }






    }
}
