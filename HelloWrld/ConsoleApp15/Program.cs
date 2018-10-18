using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int num;
            int.TryParse(str, out num);
            int mok = num;
            string na = "";
            int i =0;
            
            while(mok > 0)
                { 
                    num = (mok % 2);
                    mok = (mok / 2);
                    na += num.ToString();
                    i++;
                }
            String temp = new String(na.ToCharArray().Reverse().ToArray());
            Console.Write(temp);
          
        }
    }
}
