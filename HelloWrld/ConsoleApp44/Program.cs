using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp44
{
    class Delegate1
    {
        
        public static void Main(string[] args)
        {
            Action<int, int> myMethod = (i, j) =>
            {
                Console.WriteLine(i + j);
            };
            //OnjSum myMethod = new OnjSum(Sum);
            //OnjSum myMethod = Sum;
            myMethod(10, 30);
        }
         
    }
}
