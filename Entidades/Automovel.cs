using System;
using System.Collections.Generic;
using System.Text;

namespace AulaAbstract.Entidades
{
    class Automovel : Veiculo
    {
        public Automovel(string veiculo) : base(veiculo)
        {
        }

        public override void Mover()
        {
            Console.WriteLine("Acelerar ...");
        }

        public override void Parar()
        {
            Console.WriteLine("Acelerar ...");
        }
    }
}
