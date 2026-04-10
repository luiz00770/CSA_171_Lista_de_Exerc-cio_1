using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Área_do_quadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da aresta do seu quadrado: ");
            double aresta = double.Parse(Console.ReadLine());

            double área = aresta * aresta;
            Console.WriteLine($"A área do quadrado é: {área}");
        }
    }
}
