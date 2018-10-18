using System;

namespace ConsoleApp49
{
    delegate void OnjDelegate(double a, double b);
    class MainApp
    { 
        
            static void Plus(double a, double b) { Console.WriteLine("{0} + {1} = {2}", a, b, a + b); }
            static void Minus(double a, double b) { Console.WriteLine("{0} - {1} = {2}", a, b, a - b); }
            static void Multiplication(double a, double b) { Console.WriteLine("{0} * {1} = {2}", a, b, a * b); }
            static void Division(double a, double b) { Console.WriteLine("{0} / {1} = {2}", a, b, a / b); }
            static void Main(string[] args)
            {
            Console.WriteLine(", 로 구분하여 숫자 를 입력하세요");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            string[] sArray = str.Split(',');
            double[] iArray = Array.ConvertAll(sArray, s => double.Parse(s));

            double num;
            double.TryParse(str, out num);
                MainApp m = new MainApp();
                OnjDelegate CallBack1 = new OnjDelegate(MainApp.Plus);
                OnjDelegate CallBack2 = new OnjDelegate(MainApp.Minus);
                OnjDelegate CallBack3 = new OnjDelegate(MainApp.Multiplication);
                OnjDelegate CallBack4 = new OnjDelegate(MainApp.Division);
                OnjDelegate CallBack = CallBack1 + CallBack2 + CallBack3 + CallBack4;
                CallBack(iArray[0],iArray[1]);
            }
        }

}


