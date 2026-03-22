using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public partial class Cinema
    {
        private List<Ticket> _tickets = new List<Ticket>();
        public void AddTicket(Ticket t) => _tickets.Add(t);
        public Ticket[] GetAllTickets() => _tickets.ToArray();
    }




    public partial class Cinema
    {
        public void PrintAllTickets()
        {
            Console.WriteLine("--- All Tickets (from Cinema.Reporting) ---");
            int i = 1;
            foreach (var t in _tickets) Console.WriteLine($"[Ticket #{i++}] {t}");
        }

        public void Open() { Console.WriteLine("=== Cinema Opened ===\nProjector ON"); }
        public void Close() { Console.WriteLine("Projector OFF\n=== Cinema Closed ==="); }
    }


}
