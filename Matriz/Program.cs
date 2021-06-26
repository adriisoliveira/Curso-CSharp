using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[,] mat = new double[2, 3];
            //Console.WriteLine(mat.Length);
            //Console.WriteLine(mat.Rank);
            //Console.WriteLine(mat.GetLength(0));
            //Console.WriteLine(mat.GetLength(1));

            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j< n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("MAIN DIAGONAL");
            for (int i = 0; i< n; i++)
            {
                Console.WriteLine(mat[i, i] + " ");
            }

            int count = 0;
            Console.WriteLine("Netagive numbers");
            for(int i = 0; i< n; i++)
            {
                for (int j = 0; j<n; j++)
                {
                    if(mat[i,j] < 0)
                        count ++;
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
