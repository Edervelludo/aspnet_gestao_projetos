using System;
using Api.Domain.Models;

namespace Api.Domain.Models
{
    public class DocumentoProjetoModel : BaseModel

    {

        private Guid _projetoid;
        public Guid ProjetoId
        {
            get { return _projetoid; }
            set { _projetoid = value; }
        }

        private String _titulo;
        public String Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        private String _descricao;
        public String Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }


        private Byte[] _arquivoblob;
        public Byte[] ArquivoBlob
        {
            get { return _arquivoblob; }
            set { _arquivoblob = value; }
        }

        private Guid _idtipoarquivo;
        public Guid IdTipoArquivo
        {
            get { return _idtipoarquivo; }
            set { _idtipoarquivo = value; }
        }

        private String _formatoarquivo;
        public String FormatoArquivo
        {
            get { return _formatoarquivo; }
            set { _formatoarquivo = value; }
        }




    }
}
