using ComposiçãoExercicio.Entities;
using ComposiçãoExercicio.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ComposiçãoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("====== WELCOME ====== ");
            Console.WriteLine("Enter Client Data");
            Console.Write("Name: ");
            string clientName = Console.ReadLine(); 
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Enter Oder data:");
            Console.Write("Status: ");
            var stautsOrder = Console.ReadLine();
            OrderStatus orderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), stautsOrder);

            Client client = new Client(clientName, email, birthDate);
            Order order = new Order(DateTime.Now, orderStatus, client);

            Console.Write("How many items to this order: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);


            }


            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);

            Console.ReadKey();
        }
    }
}
