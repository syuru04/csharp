using System;


namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("출력을 원하는 구구단 수를 입력하세요");
            string str = Console.ReadLine();
            int num = 0;
            int.TryParse(str, out num);

            int i ,j;
            for (i = 2; i <= 9; i++)
                {
                 Console.Write("\n");
                     for(j = 1; j <= num; j++)
                    {
                    Console.Write(j + " x " + i + " = " + (i * j));                        
                    if (j != num) Console.Write(" , ");
                    }
                }
        }
    }
}
