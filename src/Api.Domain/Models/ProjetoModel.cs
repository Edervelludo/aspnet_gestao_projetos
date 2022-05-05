using System;
using Api.Domain.Models;

namespace Api.Domain.Models
{
    public class ProjetoEntity : BaseModel
    {

        private string _lider;
        public string Lider
        {
            get { return _lider; }
            set { _lider = value; }
        }

        private string _dono;
        public string Dono
        {
            get { return _dono; }
            set { _dono = value; }
        }


        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }


        private Guid _empresaid;
        public Guid EmpresaId
        {
            get { return _empresaid; }
            set { _empresaid = value; }
        }


        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        private DateTime _inicio;
        public DateTime Inicio
        {
            get { return _inicio; }
            set { _inicio = value; }
        }

        private DateTime _planejamentofim;
        public DateTime PlanejamentoFim
        {
            get { return _planejamentofim; }
            set { _planejamentofim = value; }
        }

        private decimal _percentualconclusao;
        public decimal PercentualConclusao
        {
            get { return _percentualconclusao; }
            set { _percentualconclusao = value; }
        }


        private decimal _custoestimado;
        public decimal CustoEstimado
        {
            get { return _custoestimado; }
            set { _custoestimado = value; }
        }


        private decimal _custoatual;
        public decimal CustoAtual
        {
            get { return _custoatual; }
            set { _custoatual = value; }
        }

        private decimal _percentualorcamento;
        public decimal PercentualOrcamento
        {
            get { return _percentualorcamento; }
            set { _percentualorcamento = value; }
        }

        private int _estimativahora;
        public int EstimativaHora
        {
            get { return _estimativahora; }
            set { _estimativahora = value; }
        }


        private int _horaatual;
        public int HoraAtual
        {
            get { return _horaatual; }
            set { _horaatual = value; }
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




    }
}
