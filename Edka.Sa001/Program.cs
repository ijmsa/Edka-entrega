using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edka.Sa001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var idade1 = 27;
            var idade2 = 52;
            var idade3 = 70;
            var idade4 = 25;
            var idade5 = 39;

            Console.WriteLine("A média é:" + Convert.ToDouble(idade1 + idade2 + idade3 + idade4 + idade5)/5);
            Console.ReadKey();
        }
    }
}
