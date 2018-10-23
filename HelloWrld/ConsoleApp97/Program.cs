using System;
using System.Windows.Forms;

namespace ConsoleApp96
{
    class Program : Form
    {
        static void Main(string[] args)
        {
            Program form = new Program();
            form.Click += new EventHandler((sender, evntArgs) => { Console.WriteLine("폼클릭 이벤트");Application.Exit();});
            Console.WriteLine("윈도우 시작 ..");
            Application.Run(form);
            Console.WriteLine("윈도우 종료");
        }       
    }
}
