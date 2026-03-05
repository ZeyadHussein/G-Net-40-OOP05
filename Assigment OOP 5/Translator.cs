using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_OOP_5
{
    public class Translator : IEnglishSpeaker, IArabicSpeaker
    {

        void IEnglishSpeaker.Greet()
        {
            Console.WriteLine("Hello");
        }

        void IArabicSpeaker.Greet()
        {
            Console.WriteLine("Ahlan");
        }
    }
}
