using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancária
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            double valor;

            Console.WriteLine("-------------BEM VINDO!------------");

            Console.Write("Entre o numero da conta: ");
            conta.NumeroConta = Console.ReadLine();
            Console.Write("Entre o Titular da conta: ");
            conta.TitularConta = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n) ");
            char opcao = Convert.ToChar(Console.ReadLine());
            if(opcao == 's' || opcao == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: R$");
                valor = Convert.ToDouble(Console.ReadLine());
                conta.Deposito(valor);
            }
            else if(opcao == 'n' || opcao == 'N')
            {
                conta.Deposito(0);
                Console.WriteLine(conta);
            }
            Console.WriteLine("");

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine("");

            Console.Write("Entre um valor para depósito: R$");
            valor = Convert.ToDouble(Console.ReadLine());
            conta.Deposito(valor);
            Console.WriteLine("");

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para Saque: R$");
            valor = Convert.ToDouble(Console.ReadLine());
            conta.Saque(valor);
            Console.WriteLine("");

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.ReadKey();

        }
    }
}
