using System;
using System.Collections.Generic;
using System.Text;

namespace AulaAbstract.Entidades
{
    abstract class Veiculo
    {
        private string _tipo;

        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        protected Veiculo(string veiculo)
        {
            Tipo = veiculo;
        }

        public virtual void Mover() { }

        public virtual void Parar() { }

    }
}
