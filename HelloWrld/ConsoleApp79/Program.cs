//1. 콤마로 구분해서 여러 숫자를 입력받아 합을 구하는 프로그램을 작성하세요.

using System;

namespace ConsoleApp78
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] iArr = Array.ConvertAll((Console.ReadLine()).Split(','), i => int.Parse(i));
            int sum = 0;
            for (int j = 0; j < iArr.Length; j++)
            {
                int num = 0;
                num = iArr[j];
                sum += num;
            }
            Console.WriteLine("합계 : {0}", sum);
        }
    }
}