using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção7
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 10;
            //var y = 10; //y é uma variável e o tipo dela vai ser adicionado confome implementação.
            //var z = 20.0;
            //var w = "Nome";
            //var c = '@';

            //SWITCH CASE
            //var var = int.Parse(Console.ReadLine());

            //switch (var)
            //{
            //    case 1:
            //        Console.WriteLine("É 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("É 2");
            //        break;
            //}

            //Console.ReadKey();

            //EXPRESSÃO CONDICIONAL TERNÁRIA
            //(2 > 4) ? 50 : 80 -> Condição ? se_verdadeiro : se_falso

            //double preco = double.Parse(Console.ReadLine());
            //double desconto = (preco < 20) ? preco*0.1 : preco *0.5;

            ////if(preco < 20.0)
            ////{
            ////    desconto = preco * 0.1;
            ////}
            ////else
            ////{
            ////    desconto = preco * 0.5;
            ////}
            //Console.WriteLine(desconto);

            //FUNÇÕES PARA STRING

            //string original = "abcde FGHIJ ABC abc DEFG    ";
            //Console.WriteLine(original);

            ////converter pra maiusculo
            //string s1 = original.ToUpper();
            //Console.WriteLine(s1 + "-");

            ////converter pra minusculo
            //string s2 = original.ToLower();
            //Console.WriteLine(s2 + "-");

            ////apagar os espaços em banco na frente e no final 
            //string s3 = original.Trim();
            //Console.WriteLine(s3 + "-");

            ////procurar a posição de algo, a primeira ocorrencia
            //int n1 = original.IndexOf("bc");
            //Console.WriteLine(n1 + "-");

            ////procurar a ultima ocorrencia de algo
            //int n2 = original.LastIndexOf("bc");
            //Console.WriteLine(n2 + "-");

            ////Cortar a sting pelo indice
            //string s4 = original.Substring(3);
            //Console.WriteLine(s4 + "-");

            ////cortar a string pelo indice e a quantidade
            //string s5 = original.Substring(3, 5);
            //Console.WriteLine(s5 + "-");

            ////susbtituir uma parte da sting
            //string s6 = original.Replace('a', 'x');
            //Console.WriteLine(s6 + "-");

            ////replace da string toda
            //string s7 = original.Replace("abc", "xy");
            //Console.WriteLine(s7 + "-");

            ////testar se a string está vazia
            //bool b1 = String.IsNullOrEmpty(original);
            //Console.WriteLine(b1 + "-");

            ////verificar se a variavel é nula ou espaço em branco
            //bool b2 = String.IsNullOrWhiteSpace(original);
            //Console.WriteLine(b2 + "-");

            //DATETIME
            //Now= pega dia e horário do sistema atual
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);

            Console.WriteLine(d1.Ticks);

            //instancia o ano, mes e dia
            DateTime d2 = new DateTime(2018, 11, 25);
            Console.WriteLine(d2);

            //instancia o ano, mes, dia, hora, minuto e segundo
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3);
            Console.WriteLine(d3);

            //instancia ano, mes, dia, hora, minuto, segundo, milisegundo
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 555);
            Console.WriteLine(d4);

            DateTime d5 = DateTime.Now;
            Console.WriteLine(d5);

            DateTime d6 = DateTime.Today;
            Console.WriteLine(d6);

            DateTime d7 = DateTime.UtcNow;
            Console.WriteLine(d7);

            //converter para string
            DateTime d8 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d8);

            //converter e determinar o formato
            DateTime d9 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d9);


            Console.ReadKey();
        }
    }
}
