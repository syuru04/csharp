﻿using System;
using System.Windows.Forms;

namespace ConsoleApp102
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageBox.Show("메세지");
            MessageBox.Show("메세지", "타이틀");

            DialogResult result1 = MessageBox.Show("메세지", "타이틀(두 버튼 메세지 박스", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes) Console.WriteLine("YES 클릭");
            else Console.WriteLine("NO클릭");
            Console.WriteLine("1. ----------");


            DialogResult result2 = MessageBox.Show("메시지", "타이틀(Question 메시지박스,YesNoCancel)", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes) Console.WriteLine("Yes 클릭");
            else if (result2 == DialogResult.No) Console.WriteLine("No 클릭");
            else if (result2 == DialogResult.Cancel) Console.WriteLine("Cancel 클릭");
            Console.WriteLine("2. -----------");

            DialogResult result3 = MessageBox.Show("메시지", "타이틀(Question 메시지박스,YesNoCancel,Default버튼)", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        //MessageBox.Show(MessageBox.Show("메시지", "타이틀(메시지 우측 정렬, Error 아이콘)", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign,true);      
        //MessageBox.Show("메시지", "타이틀(exclamation icon)", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
    }
}
