using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vet = new Product[n];

            for(int i =0; i<n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                vet[i] = new Product { Name = name, Price = price };
            }
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += vet[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE PRICE: " + avg.ToString());
            Console.ReadKey();
        }
    }
}
