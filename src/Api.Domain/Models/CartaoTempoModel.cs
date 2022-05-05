using System;

using Api.Domain.Models;

namespace Api.Domain.Models
{
    public class CartaoTempoModel : BaseModel
    {

        private Guid _projetoid;
        public Guid ProjetoId
        {
            get { return _projetoid; }
            set { _projetoid = value; }
        }


        private Guid _recursoid;
        public Guid RecursoId
        {
            get { return _recursoid; }
            set { _recursoid = value; }
        }

        private DateTime _semanaini;
        public DateTime SemanaIni
        {
            get { return _semanaini; }
            set { _semanaini = value; }
        }

        private int _hdom;
        public int Hdom
        {
            get { return _hdom; }
            set { _hdom = value; }
        }

        private int _hseg;
        public int HSeg
        {
            get { return _hseg; }
            set { _hseg = value; }
        }

        private int _hter;
        public int HTer
        {
            get { return _hter; }
            set { _hter = value; }
        }

        private int _hqua;
        public int HQua
        {
            get { return _hqua; }
            set { _hqua = value; }
        }

        private int _hqui;
        public int HQui
        {
            get { return _hqui; }
            set { _hqui = value; }
        }

        private int _hsex;
        public int HSex
        {
            get { return _hsex; }
            set { _hsex = value; }
        }


        private int _hsab;
        public int HSab
        {
            get { return _hsab; }
            set { _hsab = value; }
        }


    }
}
