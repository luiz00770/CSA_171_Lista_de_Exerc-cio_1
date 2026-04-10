using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Área_do_retângulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a largura do retângulo: ");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a base do retângulo: ");
            double b = double.Parse(Console.ReadLine());

            double área = largura * b;

            Console.WriteLine($"A área do retângulo é de: {área}");
        }
    }
}
