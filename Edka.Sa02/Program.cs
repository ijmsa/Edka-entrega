using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] idades = new int[10]
            {
                18,29,37,48,17,16,54,72,45,30
  
            };
            double soma = 0;
            double media = 0;
            for (int i =0; i < idades.Length; i++)
            {
                Console.WriteLine(idades[i]);
                soma += idades[i];
            }
            media = soma / 10;

            Console.WriteLine("A média é" + media);
            Console.ReadKey();


        }
    }
}
