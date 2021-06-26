using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<string> list2 = new List<string> { "Maria", "Bob" };

            list.Add("Ana");
            list.Add("Marcos");
            list.Insert(1, "Bob");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
                Console.WriteLine("");
            }

            Console.WriteLine("List Count: " + list.Count);

            string si = list.Find(x => x[0] == 'M');
            Console.WriteLine("First M: " + si);
            Console.WriteLine("");

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine(s2);
            Console.WriteLine("");

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine(pos1);
            Console.WriteLine("");

            int pos2 = list.FindLastIndex(x => x[0] == 'B');
            Console.WriteLine(pos2);
            Console.WriteLine("");

            List<string> list3 = list.FindAll(x => x.Length == 3);
            foreach(string obj in list3)
            {
                Console.WriteLine(obj);
                Console.WriteLine("");
            }

            list.Remove("Bob");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
                Console.WriteLine("");
            }

            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
                Console.WriteLine("");

            }

            list.RemoveAt(0);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
                Console.WriteLine("");

            }

            Console.ReadKey();
        }

        //private static bool Test(string s)
        //{
        //    return s[0] == 'M';
        //}
    }
}
