using System;
using System.Collections.Generic;
using System.Text;
using ReservaHotel.Entities.Exceptions;

namespace ReservaHotel.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation() { }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
                throw new DomainException("Error in Reservation: Checkou date must be after check-in date");

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public string UpdatesDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
                throw new DomainException( "Error in Reservation: dates for update must be future dates");
            if (checkOut <= checkIn)
                throw new DomainException("Error in Reservation: Checkou date must be after check-in date");

            CheckIn = checkIn;
            CheckOut = checkOut;

            return null;
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", CheckIn: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", CheckOut: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
