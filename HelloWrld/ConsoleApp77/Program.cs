using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp77
{
    public class ThreadTest3
    {

        public string lockString = "Hello";
        private static Mutex mutex = new Mutex();
        public void Print(string rank)
        {
            mutex.WaitOne();
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Thread.Sleep(100);
                        Console.Write(",");
                    }

                    Console.WriteLine("{0}{1}", rank, lockString);
                }
                mutex.ReleaseMutex();
            }
        }

        public void FirstWork() { Print("F"); }
        public void SecondWork() { Print("S"); }
        
    }
    class TestMain
    {
        [MTAThread]
        public static void Main()
        {
            ThreadTest3 t = new ThreadTest3();
            Thread first = new Thread(new ThreadStart(t.FirstWork));
            Thread second = new Thread(new ThreadStart(t.SecondWork));
            first.Start();
            second.Start();
        }
    }
}
