using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class IMAXTicket : Ticket
    {
        public IMAXTicket(string movieName, string seatNumber, double basePrice)
            : base(movieName, seatNumber, basePrice) { }

        public override double CalculateFinalPrice() => BasePrice * 1.14;

        public override string ToString() => base.ToString() + " | 3D: Yes";
    }

}
