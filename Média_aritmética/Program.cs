using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Média_aritmética
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quatro valores para calcular a média");
            Console.Write("Primeiro valor:   ");
            double p = double.Parse(Console.ReadLine());
            Console.Write("Segundo valor:   ");
            double s = double.Parse(Console.ReadLine());
            Console.Write("Terceiro valor:   ");
            double t = double.Parse(Console.ReadLine());
            Console.Write("Quatro valor:   ");
            double q = double.Parse(Console.ReadLine());

            double m = (p + s + t + q) / 4;

            Console.WriteLine($"Sua média é de: {m}");
        }
    }
}

