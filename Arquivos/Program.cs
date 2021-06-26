using System.IO;
using System;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //string sourcePath = @"H:\temp\file 1.txt";
            //string targetPath = @"H:\temp\file 2.txt";

            string path = @"H:\temp\file 1.txt";
            FileStream fs = null;
            StreamReader sr = null;



            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);

                string line = sr.ReadLine();
                Console.WriteLine(line);
                //FileInfo fileInfo = new FileInfo(sourcePath);
                ////fileInfo.CopyTo(targetPath);
                //string[] lines = File.ReadAllLines(sourcePath);
                //foreach(string line in lines)
                //    Console.WriteLine(line);

            }catch(IOException ex)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
