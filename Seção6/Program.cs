using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p;
            //p.x = 10;
            //p.y = 20;

            //Console.WriteLine(p);
            //p = new Point();
            //Console.WriteLine(p);
            //Console.ReadKey();
            double? x = null;
            double? y =10.0;
            double w = x ?? 5;
            double z = y ?? 5;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if(x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X IS NULL");
            Console.WriteLine(y.Value);

            Console.ReadKey();
        }
    }
}
