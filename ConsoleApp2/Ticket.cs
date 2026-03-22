using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public abstract class Ticket
    {
        public string MovieName { get; set; }
        public string SeatNumber { get; set; }
        public double BasePrice { get; set; }
        public bool IsBooked { get; protected set; }

        protected Ticket(string movieName, string seatNumber, double basePrice)
        {
            MovieName = movieName;
            SeatNumber = seatNumber;
            BasePrice = basePrice;
            IsBooked = false;
        }

        public abstract double CalculateFinalPrice();

        public virtual void Book()
        {
            IsBooked = true;
            Console.WriteLine($"Ticket for {MovieName} at {SeatNumber} has been booked.");
        }

        public override string ToString()
        {
            return $"[{GetType().Name}] {MovieName} | Seat: {SeatNumber} | Price: {BasePrice:F2} | Final: {CalculateFinalPrice():F2} | Booked: {(IsBooked ? "Yes" : "No")}";
        }



    }
}
