using System;


namespace Api.Domain.Models
{
    public class QuestaoModel : BaseModel
    {
        private string _nome;
        public string Nome
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

        private Guid _recursocriadorid;
        public Guid RecursoCriadorId
        {
            get { return _recursocriadorid; }
            set { _recursocriadorid = value; }
        }


        private Guid _projetoid;
        public Guid ProjetoId
        {
            get { return _projetoid; }
            set { _projetoid = value; }
        }


        private Guid _prioridadeid;
        public Guid PrioridadeId
        {
            get { return _prioridadeid; }
            set { _prioridadeid = value; }
        }

        private Guid _statusid;
        public Guid StatusId
        {
            get { return _statusid; }
            set { _statusid = value; }
        }

        private string _atualizacoes;
        public string Atualizacoes
        {
            get { return _atualizacoes; }
            set { _atualizacoes = value; }
        }


        private string _resolucao;
        public string Resolucao
        {
            get { return _resolucao; }
            set { _resolucao = value; }
        }


        private DateTime _dataidentificacao;
        public DateTime DataIdentificacao
        {
            get { return _dataidentificacao; }
            set { _dataidentificacao = value; }
        }

        private int _diasresolver;
        public int DiasResolver
        {
            get { return _diasresolver; }
            set { _diasresolver = value; }
        }


        private DateTime _dataresolucao;
        public DateTime DataResolucao
        {
            get { return _dataresolucao; }
            set { _dataresolucao = value; }
        }





    }
}
