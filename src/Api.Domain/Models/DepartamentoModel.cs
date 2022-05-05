
using System;
using Api.Domain.Models;

namespace Api.Domain.Models
{
    public class DepartamentoModel : BaseModel
    {
        private String _nome;
        public String Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private String _descricao;
        public String Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }


    }
}
