using ReservaHotel.Entities;
using ReservaHotel.Entities.Exceptions;
using System;

namespace ReservaHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("= = = = = WELCOME = = = = =");
                Console.WriteLine();
                Console.Write("Room Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/mm/yyyy): ");
                DateTime checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                Console.Write("Check-out date (dd/mm/yyyy): ");
                DateTime checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);
                Console.WriteLine("Enter data to update the reservation: ");
                Console.Write("Check-in date (dd/mm/yyyy): ");
                checkIn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                Console.Write("Check-out date (dd/mm/yyyy): ");
                checkOut = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
                reservation.UpdatesDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

            }catch(DomainException ex){
                
                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
