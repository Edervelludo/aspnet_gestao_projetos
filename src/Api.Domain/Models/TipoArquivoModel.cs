using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Models;

namespace Api.Domain.Model
{
    public class TipoArquivoModel : BaseModel
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
