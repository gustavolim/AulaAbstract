using System;
using System.Collections.Generic;
using System.Text;

namespace AulaAbstract.Entidades
{
    class Aeronave : Veiculo
    {
        public Aeronave(string veiculo) : base(veiculo)
        {
        }

        public override void Mover()
        {
            Console.WriteLine("Decolar ...");
        }

        public override void Parar()
        {
            Console.WriteLine("Aterrisar ...");

        }
    }
}
