
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Área_do_triângulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da base do triângulo: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura do triângulo: ");
            double a = double.Parse(Console.ReadLine());

            double area = (a * b) / 2;

            Console.WriteLine($"A área do triângulo é de: {area}");
        }
    }
}
