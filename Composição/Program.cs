using System;
using Composição.Entities;
using Composição.Entities.Enums;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Composição
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========== WELCOME ===============");
            Console.Write("Enter departament's name: ");
            string dptName = Console.ReadLine();
            Console.WriteLine("Enter Worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            var levelString = Console.ReadLine();
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), levelString);
            Console.Write("Base Salary:");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Department dpt = new Department(dptName);

            Worker worker = new Worker(name, level, baseSalary, dpt);

            Console.WriteLine();
            Console.WriteLine("- - - - - CONTRACTS - - - - -");
            Console.WriteLine();

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.Write($"Enter #{i} contract data: ");
                Console.Write("Date(DD/MM/YYYY) : ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, value, duration);

                worker.AddContract(contract);

                Console.WriteLine();
            }


            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine();
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Departament.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year,month));


            Console.ReadKey();
        }
    }
}
