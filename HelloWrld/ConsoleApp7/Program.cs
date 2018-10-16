using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{   
    //public class Bitoper
    //{
    //    public static void Main(string[] args)
    //    {
    //        int i = 10, j = 20;
    //        int a;
    //        a = i & j; i = i >> 3; j = i << 3;
    //        Console.WriteLine("a = {0}, i = {1}, j = {2}", a, i, j);
    //        Console.ReadLine();
    //    }
    //}


    class LogicalAnd
    {
        static void Main()
        {
            Console.WriteLine("정상적인 AND : ");
            if (Method1() & Method2())
                Console.WriteLine("Both methods returned true.");
            else
                Console.WriteLine("둘중 하나의 메소드는 false");

            Console.WriteLine("\n Short-circuit AND:");

            if (Method1() && Method2()) ;
            Console.WriteLine("Both methods returned true.");
            else
             Console.WriteLine("둘중 하나의 메소드는 false");

            Console.WriteLine("0x{0:x}", 0xf8 & 0x3f);

        }
        static bool Method1()
        {
            Console.WriteLine("메소드1...");
            return false;
        }
        static bool Method2()
        {
            Console.WriteLine("메소드2...");
            return true;
        }



    }
}
