using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main()
        {
            Program p = new Program();
            Console.WriteLine(p.Sum( i: 1, j :2)); // 명명된 인수, 파라미터를 선택해줌
            Console.WriteLine(p.Sum( j: 2)); 
        }
        int Sum(int i =0 , int j =0) // 값을 안주면 0으로 처리 , 선택적 인수
        {
            return i + j;
        }
    }
}
