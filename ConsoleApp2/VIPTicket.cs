using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class VIPTicket : Ticket
    {
        public VIPTicket(string movieName, string seatNumber, double basePrice)
            : base(movieName, seatNumber, basePrice) { }

        public override double CalculateFinalPrice() => (BasePrice + 50.0) * 1.14;

        public override string ToString() => base.ToString() + " | Lounge: Yes | Fee: 50.00";
    }
}
