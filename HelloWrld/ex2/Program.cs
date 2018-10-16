using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int num;
            int.TryParse(str, out num);          
            Console.WriteLine(" 입력숫자 : {0} ", num);
            int sum = 0;
            int i = 0;
            Console.Write("{0}까지의 숫자 : ", num);
            for (i = 1; i <= num; i++)
            {
                Console.Write(i);
            }


            for (i = 0; i <= num; i++)
            {
                sum += i;
            }
            Console.WriteLine("\n {0}까지 의 합은 : {1} ", num, sum);

        }
    }
}
