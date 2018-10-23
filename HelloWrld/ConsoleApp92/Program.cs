﻿//16. 실행결과를 확인하고 코드를 완성하세요.

//[실행결과]
//Dog
//Cat
//Mouse
//Mouse

using System; 

public delegate void EventHandler();

class Program
{
    public static event EventHandler _show;

    static void Main()
    {
        // Add event handlers to Show event. 
        _show = new EventHandler(Dog) + new EventHandler(Cat) + new EventHandler(Mouse) + new EventHandler(Mouse);

        // Invoke the event. 
        _show();
    }

    static void Cat()
    {
        Console.WriteLine("Cat");
    }

    static void Dog()
    {
        Console.WriteLine("Dog");
    }

    static void Mouse()
    {
        Console.WriteLine("Mouse");
    }
}
