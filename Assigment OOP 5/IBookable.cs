using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_5
{
    public interface IBookable
    {
        bool Book();
        bool Cancel();
        bool IsBooked { get; }
    }
}
