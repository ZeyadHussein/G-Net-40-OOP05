using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_5
{
    public class Employee
    {
        public string Title;
        public Department Dept;

        public Employee ShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }
    }
}
