using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo x = new Retangulo();

            Console.WriteLine("==========BEM VINDO============");

            Console.Write("Digite a Altura do retângulo: ");
            x.Altura = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a Largura do retângulo: ");
            x.Largura = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA: "+ x.Area());
            Console.WriteLine("PERÍMETRO: " + x.Perimetro());
            Console.WriteLine("DIAGONAL: " + x.Diagonal());
           
            Console.ReadKey();
        }
    }
}
