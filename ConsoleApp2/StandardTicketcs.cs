using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    
        public class StandardTicket : Ticket
        {
            public StandardTicket(string movieName, string seatNumber, double basePrice)
                : base(movieName, seatNumber, basePrice) { }

            public override double CalculateFinalPrice() => BasePrice * 1.14;
        }
    }

