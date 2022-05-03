using System;


namespace Api.Domain.Models
{
    public class AtividadeModel : BaseModel
    {
        private Guid _projetoid;
        public Guid Projetoid
        {
            get { return _projetoid; }
            set { _projetoid = value; }

        }

        private Guid _faseprojetoid;
        public Guid Faseprojetoid
        {
            get { return _faseprojetoid; }
            set { _faseprojetoid = value; }
        }


        private String _nome;
        public String Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }



        private Boolean _marco;
        public Boolean Marco
        {
            get { return _marco; }
            set { _marco = value; }
        }

        private int _duracao;
        public int Duracao
        {
            get { return _duracao; }
            set { _duracao = value; }
        }


        private DateTime _inicio;
        public DateTime Inicio
        {
            get { return _inicio; }
            set { _inicio = value; }
        }


        private DateTime _fim;
        public DateTime Fim
        {
            get { return _fim; }
            set { _fim = value; }
        }

        private int _diasatraso;
        public int DiasAtraso
        {
            get { return _diasatraso; }
            set { _diasatraso = value; }
        }

        private Guid _atividadestatusid;
        public Guid AtividadeStatusId
        {
            get { return _atividadestatusid; }
            set { _atividadestatusid = value; }
        }

        private decimal _percentualcompleto;
        public decimal PercentualCompleto
        {
            get { return _percentualcompleto; }
            set { _percentualcompleto = value; }
        }


        private Guid _atividadeprioridadeid;
        public Guid AtividadePrioridadeId
        {
            get { return _atividadeprioridadeid; }
            set { _atividadeprioridadeid = value; }
        }

        private Guid _atribuidoarecursoid;
        public Guid AtribuidoARecursoId
        {
            get { return _atribuidoarecursoid; }
            set { _atribuidoarecursoid = value; }
        }

        private String _historico;
        public String Historico
        {
            get { return _historico; }
            set { _historico = value; }
        }


        private Guid _atividadeprecedeid;
        public Guid AtividadePrecedeId
        {
            get { return _atividadeprecedeid; }
            set { _atividadeprecedeid = value; }
        }





    }
}


