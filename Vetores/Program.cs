using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double sum = 0;
            for(int i =0; i< n; i++)
            {
                sum += vet[i];
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE HEIGH: " + avg);
            Console.ReadKey();
        }
    }
}
