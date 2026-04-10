using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potência
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número x: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um número y");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("O valor x elevado a y é igual a: {0}", Math.Pow(x, y));
        }
    }
}
