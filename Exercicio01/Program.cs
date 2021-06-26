using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa a, b;
            a = new Pessoa();
            b = new Pessoa();

            Console.Write("Digte o nome da primeira pessoa: ");
            a.Nome = Console.ReadLine();
            Console.Write("Digite a idade da primeira pessoa: ");
            a.idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digte o nome da segunda pessoa: ");
            b.Nome = Console.ReadLine();
            Console.Write("Digite a idade da segunda pessoa: ");
            b.idade = Convert.ToInt32(Console.ReadLine());

            if(a.idade > b.idade)
                Console.WriteLine(a.Nome + " É mais velha (o)");
            else if(b.idade > a.idade)
                Console.WriteLine(b.Nome + " É mais velha (o)");
            else if (a.idade == b.idade)
                Console.WriteLine("As idades são iguais");

            Console.ReadKey();
        }
    }
}
