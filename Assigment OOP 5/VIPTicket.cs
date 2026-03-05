using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_5
{
    public class VIPTicket : ITicket
    {
        private static int counter = 1;

        public int TicketNumber { get; }
        public string MovieName { get; set; }
        public bool LoungeAccess { get; set; }
        public double VIPFee { get; set; }
        public double Price { get; }
        public bool IsBooked { get; private set; }

        public VIPTicket(string movie, double price, bool lounge, double fee)
        {
            TicketNumber = counter++;
            MovieName = movie;
            Price = price;
            LoungeAccess = lounge;
            VIPFee = fee;
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
                $"[Ticket #{TicketNumber}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | " +
                $"Fee: {VIPFee} | Price: {Price} | After Tax: {CalculatePriceWithTax()} | " +
                $"Booked: {(IsBooked ? "Yes" : "No")}"
            );
        }

        public object Clone()
        {
            return new VIPTicket(MovieName, Price, LoungeAccess, VIPFee);
        }
    }
}
