using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_5
{
    public class IMAXTicket : ITicket
    {
        private static int counter = 1;

        public int TicketNumber { get; }
        public string MovieName { get; set; }
        public bool Is3D { get; set; }
        public double Price { get; }
        public bool IsBooked { get; private set; }

        public IMAXTicket(string movie, double price, bool is3d)
        {
            TicketNumber = counter++;
            MovieName = movie;
            Price = price;
            Is3D = is3d;
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
                $"[Ticket #{TicketNumber}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | " +
                $"Price: {Price} | After Tax: {CalculatePriceWithTax()} | Booked: {(IsBooked ? "Yes" : "No")}"
            );
        }

        public object Clone()
        {
            return new IMAXTicket(MovieName, Price, Is3D);
        }
    }
}
