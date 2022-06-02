using System;
using Mentoria_.NET.Exercicio_1;
using Mentoria_.NET.Exercicio_2;

namespace Mentoria_.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            //NumeroInverso.numeroReverso();

            Vendedor tais = new Vendedor("Tais", 22222222222, 120, 50);
            Consultor consultor = new Consultor("Consultor", 22222222222, 40, 200);

            Console.WriteLine("\nVendedor: ");
            Console.WriteLine(tais.ToString());
            Console.WriteLine("\nConsultor: ");
            Console.WriteLine(consultor.ToString());
        }   
    }
}
