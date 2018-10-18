using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class select
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
            for (int i = 0; i < iArray.Length; i++)
            {
                for (int j = i+1; j < iArray.Length ; j++)
                {
                    if (iArray[i] > iArray[j])
                    {
                        tmp = iArray[i];
                        iArray[i] = iArray[j];
                        iArray[j] = tmp;
                    }
                }
            }
            Console.WriteLine("\n ---선택정렬후 배열---");
            foreach (int y in iArray)
            {
                Console.Write(y + " ");
            }
        }
    }
}
