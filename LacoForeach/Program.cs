using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = new string[] { "Maria", "Bob", "Alex" };

            foreach(string obj in vet)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();
        }
    }
}
