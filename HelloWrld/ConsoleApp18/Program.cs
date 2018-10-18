using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Emp
    {
        //private string name; // 멤버, 필드, 인스턴스변수
        public string Name
        {
            //get;
            //{
            //    return this.name;
            //}
            //set
            //{
            //    this.name = value;
            //}
            get;  //자동구현 속성
            set;  //자동구현 속성
        }     
        
    }
    class EmpTest
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            e.Name = "홍기리";
            Console.WriteLine(e.Name);

        }
    }
}
