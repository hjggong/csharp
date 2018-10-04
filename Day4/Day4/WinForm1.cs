using System;
using System.Windows.Forms;

namespace Day4
{
    class WinForm1 : Form
    {
        static void Main()
        {
            WinForm1 form = new WinForm1();

            form.Click += new EventHandler(form.Form_Click);
            /*
            form.Click += new EventHandler(
                (sender, EventArgs) =>
                {
                    Console.WriteLine("람다식:: 폼클릭 이벤트");
                    Application.Exit();
                });
            */

            Console.WriteLine("윈도우 시작");
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