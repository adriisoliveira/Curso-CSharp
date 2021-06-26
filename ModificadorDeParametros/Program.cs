using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorDeParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Calculator.Sum( 10, 20, 30, 40 );

            Console.WriteLine(result);

            result = Calculator.Sum( 10, 20, 30, 40, 50 );

            Console.WriteLine(result);

            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);

            Console.ReadKey();
        }
    }
}
