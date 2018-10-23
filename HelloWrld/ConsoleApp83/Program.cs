//6. 사용자로 부터 하나의 수를 입력받고 그수까지의 소수의 합을 구하는 프로그램을 작성하세요.

using System;

namespace ConsoleApp83
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            int sum = 0;
            bool k = true;
            Console.Write("소수 : ");
            for (int i = 2; i <= num; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        k = false;
                    };
                }
                if (k == true)
                {
                 sum += i;
                 Console.Write("{0} ", i);
                }
                k = true; 
            }
            Console.WriteLine("\n 소수의 합 : {0}", sum);
        }
    }
}
