﻿//12. 실행결과는? (먼저 예측하고 코딩해보세요.)

using System;
using System.Linq;

class hello
{
    static void Main()
    {

        int[] oneToTen = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var evenNumbers = oneToTen.Where(n => n % 2 == 0);
        foreach (int i in evenNumbers) { 

            Console.Write("{0} ", i);
        }
    }
 }