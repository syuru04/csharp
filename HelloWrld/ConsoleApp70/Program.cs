using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp70
{
    class Program
    {
        static void Main()
        {
            string[] myFaver =
            {
                "Apple, Banana , Strawberry","Baseball,Football,Basketball","Programmin, Design,Assembly"
            };

            var favorite =
                from m in myFaver
                let favor = m.Split(',')
                from word in favor
                let w = word.ToLower()
                where w[0] == 'a'
                select word;

            foreach (var w in favorite)
            {
                Console.WriteLine("A로 시작되는 단어 {0}",w);
            }
        }
    }
}
