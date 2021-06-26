using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> func = new List<Funcionario>();
            Funcionario f = new Funcionario();

            Console.WriteLine("--------------------BEM VINDO-----------------");
            Console.Write("Digite a quantidade de funcionários: ");
            int n = int.Parse(Console.ReadLine());

            int cont = 0;
            while(cont <= n)
            {
                Console.Write("Digite o ID: ");
                f.Id = int.Parse(Console.ReadLine());
                Console.Write("Digite o nome: ");
                f.Nome = Console.ReadLine();
                Console.Write("Digite o salário: ");
                f.Salario = double.Parse(Console.ReadLine());

                func.AddRange(f.Id, f.Nome, f.Salario);

            }
        }
    }
}
