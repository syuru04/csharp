using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;            
            int sum = 0;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0}번째 숫자를입력하세요", i);
                string str = Console.ReadLine();
                int num = 0;
                int.TryParse(str, out num);
                sum += num;               
                
            }
            double avg = (double)sum / 10;
            Console.WriteLine("합 : {0}", sum);
            Console.WriteLine("평균 : {0}", avg);
        }
    }
}

