﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp24
{
    class Emp
    {
        public int Empno
        {
            get; set;
        }
        public string Ename
        {
            get; set;
        }
        public override string ToString()
        {
            return "[사번 : " + Empno + ", 이름 : " + Ename + "]";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Emp e1 = new Emp();
            e1.Empno = 1;
            e1.Ename = " 오라클 자바커뮤니티";
            Console.WriteLine(e1);

            Emp e2 = new Emp()
            {
                Empno = 2,
                Ename = "정재훈"
            };
            Console.WriteLine(e2);
        }
    }
}
