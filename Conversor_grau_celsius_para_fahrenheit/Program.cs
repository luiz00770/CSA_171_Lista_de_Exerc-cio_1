using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_grau_celsius_para_fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em graus Celsius: ");
            double g = double.Parse(Console.ReadLine());

            Console.WriteLine("Essa temperatura equivale a {0}°F", (g * 1.8) + 32);



        }
    }
}
