using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public static class TicketExtensions
    {
        public static string GenerateReceipt(this Ticket ticket)
        {
            return $"========== RECEIPT ==========\nMovie : {ticket.MovieName}\nType  : {ticket.GetType().Name}\nPrice : {ticket.BasePrice:F2}\nFinal : {ticket.CalculateFinalPrice():F2}\nStatus: {(ticket.IsBooked ? "Booked" : "Available")}\n=============================";
        }

        public static double CalculateTotalRevenue(this Ticket[] tickets)
        {
            double total = 0;
            foreach (var t in tickets) if (t.IsBooked) total += t.CalculateFinalPrice();
            return total;
        }
    }
}
