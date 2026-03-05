using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_5
{
    public static class BookingHelper
    {
        public static void PrintAll(IPrintable[] items)
        {
            Console.WriteLine("\n--- BookingHelper.PrintAll ---");
            foreach (var item in items)
                item.Print();
        }
    }
}
