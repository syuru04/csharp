using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp25
{
    class bubble
    {
        static void Main()
        {
            Console.WriteLine(", 로 구분하여 숫자 를 입력하세요");
            string str = Console.ReadLine();
            Console.WriteLine(str);
            string[] sArray = str.Split(',');
            Console.WriteLine("---입력한 배열---");
            foreach (string s in sArray)
            {
                Console.Write(s + " ");
            }

            int[] iArray = Array.ConvertAll(sArray, s => int.Parse(s));
            int tmp;
            for (int i = 1; i < iArray.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (iArray[j] > iArray[i])
                    {
                        tmp = iArray[i];
                        iArray[i] = iArray[j];
                        iArray[j] = tmp;
                    }
                }
            }
            Console.WriteLine("\n ---버블정렬후 배열---");
            foreach (int y in iArray)
            {
                Console.Write(y + " ");
            }
        }
    }
}
