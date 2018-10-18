using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{

    public class Dog
    {
        public string name { get; set; }
        public void jitda()
        {
            Console.WriteLine(name + "가 짖다");
        }
    }
    public class Pudle : Dog
    {
        public void work() { Console.WriteLine(name + "가 일한다"); }
    }
    public class Jindo : Dog
    {
        public void run() { Console.WriteLine(name + "가 달린다"); }
    }
    class DogManager
    {
        static void Main()
        {
            Pudle p = new Pudle(); p.name = "푸들이"; p.jitda(); p.work();
            Jindo J = new Jindo(); J.name = "진돌이"; J.jitda(); J.run();

        }
    }
}
