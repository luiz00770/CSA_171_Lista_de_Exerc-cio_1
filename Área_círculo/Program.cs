using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Área_círculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o diâmetro do círculo: ");
            double d = double.Parse(Console.ReadLine());

            double a = ((d / 2) * (d / 2)) * 3.14;

            Console.WriteLine($"A área do círculo é de: {a}");


        }
    }
}
