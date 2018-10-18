using System;

class A
{
    internal A() {  }
    ~A()
    {
        System.Console.WriteLine("A소멸~ ");
    }
   
}
class B : A
{
    static void Main()
    {
        B a = new B();  // object -> A -> B
        System.GC.Collect();
    }

}