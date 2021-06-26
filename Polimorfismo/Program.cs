using Polimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();

            Console.WriteLine("====== WELCOME =====");
            Console.WriteLine();

            Console.Write("Enter the number of employees: ");
            int n = Int32.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n): ");
                char x = Char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = Int32.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = Double.Parse(Console.ReadLine());

                if(x == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additional = double.Parse(Console.ReadLine());
                    employee.Add(new OutsourcedEmployee(name, hours, value, additional));
                }
                else
                {
                    employee.Add(new Employee(name, hours, value));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach (Employee emp in employee)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}
