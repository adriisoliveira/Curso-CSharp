using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

           

            Console.WriteLine("============Bem vindo==============");
            Console.WriteLine("Digite os valores do primeiro triângulo: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os valores do segundo triângulo: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double p = (x.A + x.B + x.C) / 2.0;

            //double areaX = Math.Sqrt(p - x.A) * (p - x.B) * (p - x.C);
            double areaX = x.AreaTraingulo();

            //p = (y.A + y.B + y.C) / 2.0;
            //double areaY = Math.Sqrt(p - y.A) * (p - y.B) * (p - y.C);
            double areaY = y.AreaTraingulo();

            Console.WriteLine("Área de X: " + areaX.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            
            if(areaX > areaY)
                Console.WriteLine("X tem a maior área!");
            else
                Console.WriteLine("Y tem a maior área!");

            Console.ReadKey();
        }
    }
}
