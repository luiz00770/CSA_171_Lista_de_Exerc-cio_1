using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotação_dólar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite uma quantidade de dólares: ");
            double d = double.Parse(Console.ReadLine());

            double r = c * d;

            Console.WriteLine($"US${d} equivalem a R${r}");
        }
    }
}
