//4. 아래와 같이 출력하는 프로그램을 작성하세요.
//*
//***
//*****

using System;
namespace ConsoleApp81
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            for (int i = 0; i < 3; i++)
            {   
                for (int j = 0; j <=i+k; j++)
                {                    
                    Console.Write("*");                    
                }
                k += 1;
                Console.WriteLine();
            }
        }
    }
}
