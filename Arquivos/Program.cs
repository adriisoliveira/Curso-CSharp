using System.IO;
using System;
using System.Collections.Generic;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"H:\temp\myFolder\file 1.txt";
            string sourcePath = @"H:\temp\file 1.txt";
            string targetPath = @"H:\temp\file 2.txt";

            // CLASSE PATH
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());






            ////DIRECTORY AND DIRECTORYINFO

            ////Listar Diretorios
            //try
            //{
            //    var folder =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("FOLDERS: ");
            //    foreach(string s in folder)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine("An ocurred a error: ", ex.Message);
            //}

            ////Listar os arquivos
            //try
            //{
            //    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("FILES: ");
            //    foreach (string s in files)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine("An ocurred a error: ", ex.Message);
            //}

            ////Criar uma pasta
            //Directory.CreateDirectory(path + "\\NewFolder");


            //STREAM WRITER
            //try
            //{
            //    string[] lines = File.ReadAllLines(sourcePath);
            //    using(StreamWriter sw = File.AppendText(targetPath))
            //    {
            //        foreach(string line in lines)
            //        {
            //            sw.WriteLine(line.ToUpper());
            //        }                }
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine("An ocurred a error: ", ex.Message);
            //}


            //try
            //{
            //    using (StreamReader sr = File.OpenText(path))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            string line = sr.ReadLine();
            //            Console.WriteLine(line);
            //        }
            //    }
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine("An ocurred a error: ", ex.Message);
            //}



            //try
            //{
            //    using (FileStream fs = new FileStream(path, FileMode.Open))
            //    {
            //        using (StreamReader sr = new StreamReader(fs))
            //        {
            //            while (!sr.EndOfStream)
            //            {
            //                string line = sr.ReadLine();
            //                Console.WriteLine(line);
            //            }
            //        }
            //    }
            //}catch(IOException ex)
            //{
            //    Console.WriteLine("An ocurred a error: ", ex.Message);
            //}


            //STREAM READER
            //try
            //{
            //    fs = new FileStream(path, FileMode.Open);
            //    sr = new StreamReader(fs);
            //    //Ler o arquivo todo
            //    while (!sr.EndOfStream)
            //    {
            //        string line = sr.ReadLine();
            //        Console.WriteLine(line);
            //    }
            //    //FileInfo fileInfo = new FileInfo(sourcePath);
            //    ////fileInfo.CopyTo(targetPath);
            //    //string[] lines = File.ReadAllLines(sourcePath);
            //    //foreach(string line in lines)
            //    //    Console.WriteLine(line);

            //}catch(IOException ex)
            //{
            //    Console.WriteLine("An error ocurred");
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    if (sr != null) sr.Close();
            //    if (fs != null) fs.Close();
            //}
        }
        }
}
