using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_5
{
    public class StandardTicket : ITicket
    {
        private static int counter = 1;

        public int TicketNumber { get; }
        public string MovieName { get; set; }
        public string Seat { get; set; }
        public double Price { get; }
        public bool IsBooked { get; private set; }

        public StandardTicket(string movie, string seat, double price)
        {
            TicketNumber = counter++;
            MovieName = movie;
            Seat = seat;
            Price = price;
        }

        public double CalculatePriceWithTax() => Price * 1.14;

        public bool Book()
        {
            if (IsBooked) return false;
            IsBooked = true;
            return true;
        }

        public bool Cancel()
        {
            if (!IsBooked) return false;
            IsBooked = false;
            return true;
        }

        public void Print()
        {
            Console.WriteLine(
                $"[Ticket #{TicketNumber}] {MovieName} | Standard | Seat: {Seat} | " +
                $"Price: {Price} | After Tax: {CalculatePriceWithTax()} | Booked: {(IsBooked ? "Yes" : "No")}"
            );
        }

        public object Clone()
        {
            return new StandardTicket(MovieName, Seat, Price);
        }
    }
}
