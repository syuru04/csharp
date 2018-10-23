//2. 하나의 숫자를 입력받아서 홀수/짝수를 판정하세요.

using System;
namespace ConsoleApp78
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요.");
            int B = int.Parse(Console.ReadLine());
            if (B % 2 == 0)
            {
                Console.WriteLine("짝수입니다.");
            }
            else
            {
                Console.WriteLine("홀수입니다.");
            }
        }
    }
}
