using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("==========Bem Vindo=============");
            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double cir = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + cir.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.pi.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();
        }

        
    }
}
