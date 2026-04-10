using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do primeiro produto: ");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo produto: ");
            double s = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do terceiro produto: ");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do quarto produto: ");
            double qua = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do quinto produto: ");
            double qui = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o dinheiro recebido");
            double dr = double.Parse(Console.ReadLine());

            double tr = dr - (p + s + t + qua + qui);


            if (tr <= 0)
            {
                Console.WriteLine("Não precisa de troco");
            }

            else
            {
                Console.WriteLine($"O troco é de: {tr}");

            }





                }
            }
        }
