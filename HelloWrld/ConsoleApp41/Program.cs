#define SOUNDCARD
#define SPEAKER
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Test
    {
        [Conditional("SOUNDCARD")]
        static void print()
        {
            Console.WriteLine("사랑해=3=");
        }
        [Conditional("SPEAKER")]
        static void isSpeaker()
        {
            Console.WriteLine("마니사랑해 -3-");
        }

        static void Main(string[] args)
        {
            print();
            isSpeaker();
        }
    }
}
