using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 10);
            Console.WriteLine("==========Bem Vindo=============");


            Console.WriteLine(p.Nome);
            p.Nome = "TV 4K";
            Console.WriteLine(p.Nome);

            Console.ReadKey();
        }
    }
}
