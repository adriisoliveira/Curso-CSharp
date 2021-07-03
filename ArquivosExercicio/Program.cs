using System;
using System.Collections.Generic;
using System.IO;

namespace ArquivosExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            var sourcePath = @"H:\temp\Exercicio\items.csv";
            StreamReader sr = null;

            var sumary = new StreamReader(File.OpenRead(sourcePath));
            List<string> name = new List<string>();
            List<string> value = new List<string>();
            List<string> qnt = new List<string>();
            while (!sumary.EndOfStream)
            {
                var line = sumary.ReadLine();
                var values = line.Split(',');

                name.Add(values[0]);
                value.Add(values[1]);
                qnt.Add(values[2]);



            }

        }
    }
}
