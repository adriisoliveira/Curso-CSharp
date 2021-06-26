using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class Calculadora
    {
        public static double pi = 3.14;

        public static double Circunferencia(double r)
        {
            return 2 * pi * r;
        }

        public static double Volume(double r)
        {
            return 4 / 3 * pi * r * r * r;
        }
    }
}
