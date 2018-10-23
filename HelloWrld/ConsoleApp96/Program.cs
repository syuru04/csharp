using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp96
{
    class Program :Form
    {
        static void Main(string[] args)
        {
            Program form = new Program();
            form.Click += new EventHandler(form.Form_Click);
            Console.WriteLine("윈도우 시작 ..");
            Application.Run(form);
            Console.WriteLine("윈도우 종료");
        }
        void Form_Click(object sender, EventArgs e)
        {
            Console.WriteLine("폼클릭 이벤트");
            Application.Exit();
        }
    }
}
