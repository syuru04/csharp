using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp48
{

    delegate void OnjDelegate(int a, int b);
    class MainApp
    {
        static void Plus(int a, int b) { Console.WriteLine("{0} + {1} = {2}", a, b, a + b); }
        static void Minus(int a, int b) { Console.WriteLine("{0} - {1} = {2}", a, b, a - b); }
        void Multiplication(int a, int b) { Console.WriteLine("{0} * {1} = {2}", a, b, a * b); }
        void Division(int a, int b) { Console.WriteLine("{0} / {1} = {2}", a, b, a / b); }
        static void Main(string[] args)
        {
            MainApp m = new MainApp();
            OnjDelegate CallBack1 = new OnjDelegate(MainApp.Plus);
            OnjDelegate CallBack2 = new OnjDelegate(MainApp.Minus);
            OnjDelegate CallBack3 = new OnjDelegate(m.Multiplication);
            OnjDelegate CallBack4 = new OnjDelegate(m.Division);
            OnjDelegate CallBack = CallBack1 + CallBack2 + CallBack3 + CallBack4;
            CallBack(4, 3);
        }
    }
}
