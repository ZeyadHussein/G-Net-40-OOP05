using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_5
{
    public interface ITicket : IPrintable, IBookable, ICloneable // it is ooptional to implement ICloneable, but it can be useful for creating copies of tickets
    {
        int TicketNumber { get; }
        string MovieName { get; set; }
        double Price { get; }
        double CalculatePriceWithTax();
    }
}
