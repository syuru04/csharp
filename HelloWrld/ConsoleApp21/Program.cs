using System;
namespace ConsoleApplication2
{
    interface Dog //안에 올수있는것 : 메소드, 속성, 이벤트, 인덱서,,,,, 필드(멤버) X
    {
        string name { get; set; } //속성
        void jitda(); //추상메소드
    }
    class Pudle : Dog
    {
        public string name { get; set; }
        public void work() { Console.WriteLine(name + " 일한다."); }
        public void jitda() { Console.WriteLine(name + " 짖다~~~~~."); }
    }
    class Jindo : Dog
    {
        public string name { get; set; }
        public void run() { Console.WriteLine(name + " 달린다."); }
        public void jitda() { Console.WriteLine(name + " 짖다~~~~~."); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog p = new Pudle(); p.name = "푸들이"; p.jitda(); ((Pudle)p).work();
            Dog j = new Jindo(); j.name = "진도이"; j.jitda(); ((Jindo)j).run();
        }
    }
}