using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_quadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do lado do quadrado: ");
            double l = double.Parse(Console.ReadLine());

            double d = l* 1.414;

            Console.WriteLine($"O valor da diagonal desse quadrado é de aproximadamente: {d}"); 

        }
    }
}
