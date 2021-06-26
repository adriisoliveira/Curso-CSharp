using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto a = new Produto();
                
            Console.WriteLine("==========Bem Vindo=============");
            Console.Write("Digite o nome do produto: ");
            a.nomeProduto = Console.ReadLine();
            Console.Write("Digite o preço do produto: R$");
            a.precoProduto = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o estoque do produto: ");
            a.qntProduto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            double valorTotal = a.ValorTotalEmEstoque();
            Console.WriteLine("Seu estoque é de: R$ " + valorTotal);
            Console.WriteLine("");

            //Console.WriteLine("Deseja alterar o estoque?");
            //Console.WriteLine("1 - Sim");
            //Console.WriteLine("2 - Não");
            //int opt = Convert.ToInt32(Console.ReadLine());
            //if (opt == 1)
            //{
            //    Console.WriteLine("1. Adicionar");
            //    Console.WriteLine("2. Remover");
            //    int opcao = Convert.ToInt32(Console.ReadLine());
            //    if (opcao == 1)
            //    {
            //        Console.WriteLine("Quanto vai adicionar?");
            //        int qnt = Convert.ToInt32(Console.ReadLine());
            //        a.AdicionarProdutos(qnt);
            //        Console.WriteLine("Seu novo estoque é de:");
            //        Console.WriteLine(a.qntProduto);
            //        Console.WriteLine("Valor: R$ " + a.ValorTotalEmEstoque());
            //    }
            //    else if (opcao == 2)
            //    {
            //        Console.WriteLine("Quanto vai remover?");
            //        int qnt = Convert.ToInt32(Console.ReadLine());
            //        a.RemoverProdutos(qnt);
            //        Console.WriteLine("Seu novo estoque é de:");
            //        Console.WriteLine(a.qntProduto);
            //        Console.WriteLine("Valor: R$ " + a.ValorTotalEmEstoque());
            //    }
            //    else
            //        Console.WriteLine("Opção inválida!");
            //}
            //else if (opt == 2)
            //{
            //    Console.WriteLine("Obrigada!!");
            //}

            //Console.WriteLine("Dados do produto: " + a.nomeProduto + ", R$" + a.precoProduto + " , Qnt: " + a.qntProduto + " Valor Estoque: R$" + a.ValorTotalEmEstoque());
            Console.WriteLine("Dados do produto: " + a); 
            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int novaQnt = Convert.ToInt32(Console.ReadLine());
            a.AdicionarProdutos(novaQnt);
            Console.WriteLine("");
            //Console.WriteLine("Dados atualizados: " + a.nomeProduto + ", R$" + a.precoProduto + " , Qnt: " + a.qntProduto + " Valor Estoque: R$" + a.ValorTotalEmEstoque());
            Console.WriteLine("Dados do produto: " + a);

            Console.WriteLine("");
            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            Console.WriteLine("Dados do produto: " + a);
            novaQnt = Convert.ToInt32(Console.ReadLine());
            a.RemoverProdutos(novaQnt);
            Console.WriteLine("");
            Console.WriteLine("Dados do produto: " + a);
            //Console.WriteLine("Dados atualizados: " + a.nomeProduto + ", R$" + a.precoProduto + " , Qnt: " + a.qntProduto + " Valor Estoque: R$" + a.ValorTotalEmEstoque());
            Console.WriteLine("");

            Console.WriteLine("Obrigada!!");
            Console.ReadKey();
        }
    }
}
