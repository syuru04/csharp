using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class AsTest
    {   
        class EMP
        {
            public override string ToString()
            {
                return "EMP";
            }
        }
        class Programmer : EMP { }
        class Program
        {
            static void Main(string[] args)
            {
                Programmer p = new Programmer();

                EMP e = p as EMP;
                if (e != null)
                    System.Console.WriteLine(e.ToString());

            }
        }
    }
}
