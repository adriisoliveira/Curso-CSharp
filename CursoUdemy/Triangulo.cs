using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double AreaTraingulo()
        {
            double p = (A + B + C)/ 2.0;
            return Math.Sqrt(p*(p-A)*(p-B)*(p-C));
        }
    }
}
