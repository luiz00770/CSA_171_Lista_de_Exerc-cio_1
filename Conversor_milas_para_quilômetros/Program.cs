using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_milas_para_quilômetros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da milha: ");
            double milha = double.Parse(Console.ReadLine());

            double metro = 1852 * milha;
            double quilometro =  metro/1000 ;

            Console.WriteLine("");
            Console.WriteLine($"{milha} milhas equivalem a {quilometro}km");
        }
    }
}
