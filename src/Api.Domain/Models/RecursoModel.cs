using System;


namespace Api.Domain.Models
{
    public class RecursoModel : BaseModel
    {

        private String _nome;
        public String Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _telefone;
        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; }
        }


        private string _observacoes;
        public string MyProperty
        {
            get { return _observacoes; }
            set { _observacoes = value; }
        }

        private decimal _valorhora;
        public decimal ValorHora
        {
            get { return _valorhora; }
            set { _valorhora = value; }
        }


        private string _cargo;
        public string Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }


        private Guid _projetoid;
        public Guid ProjetoId
        {
            get { return _projetoid; }
            set { _projetoid = value; }
        }


        private Guid _departamento;
        public Guid Departamento
        {
            get { return _departamento; }
            set { _departamento = value; }
        }



    }
}
