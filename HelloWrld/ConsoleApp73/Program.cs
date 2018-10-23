﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp73
{
    class ThreadTest2
    {
        bool sleep = false;

        static AutoResetEvent autoEvent = new AutoResetEvent(false);

        public void FirstWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("F{0}", i);
                if( i== 5)
                {
                    sleep = true;
                    Console.WriteLine("");
                    Console.WriteLine("first 쉼..");
                    autoEvent.WaitOne();
                }
            }
        }
        static void Main(string[] args)
        {
            ThreadTest2 t = new ThreadTest2();
            Thread first = new Thread(new ThreadStart(t.FirstWork));
            first.Start();
            while (t.sleep == false) { }
            Console.WriteLine("first를 깨웁니다...2초후 깨어 납니다.");
            Thread.Sleep(2000);
            autoEvent.Set();
        }
    }
}
