using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Média_geométrica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores para calcular a média geométrica");
            Console.Write("Primeiro valor:   ");
            double p = double.Parse(Console.ReadLine());
            Console.Write("Segundo valor:   ");
            double s = double.Parse(Console.ReadLine());

            double n = p * s;
            double m = Math.Sqrt(n);

            Console.WriteLine($"Sua média é de: {m}");
        }
    }
}
