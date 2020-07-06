using AulaAbstract.Entidades;
using System;

namespace AulaAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo[] veiculo = new Veiculo[2];
            veiculo[0] = new Automovel("Fusca");
            veiculo[1] = new Aeronave("Airbus");

            MoverVeiculo(veiculo[0]);
            MoverVeiculo(veiculo[1]);

            Console.ReadKey();
        }

        public static void MoverVeiculo(Veiculo veiculo)
        {
            Console.WriteLine(veiculo.Tipo);
            veiculo.Mover();
        }
    }
}
