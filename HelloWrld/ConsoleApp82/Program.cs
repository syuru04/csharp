//5. 실행결과가 아래와 같다.

//Enter a Number : 123
//Reverse of Entered Number : 321
 
//코드를 완성하세요
 
using System;
 
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, reverse = 0;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                int tmp = 0;                
                tmp = num % 10;
                num = num / 10;
                reverse = reverse * 10 + tmp;                
            }
            Console.WriteLine("Reverse of Entered Number is : " + reverse);
            Console.ReadLine();
        }
    }
}