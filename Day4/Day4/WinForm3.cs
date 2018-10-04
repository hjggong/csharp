using System;
using System.Windows.Forms;

namespace Day4
{
    class WinForm3: Form
    {
        public void MouseHandler(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Sender: " + ((Form)sender).Text);
            Console.WriteLine("Sender: " + ((Form)sender).Name);
            Console.WriteLine("X: {0}, Y: {1}", e.X, e.Y);
            Console.WriteLine("Button: {0}, Clicks: {1}", e.Button, e.Clicks);
        }

        public WinForm3(string title)
        {
            this.Text = title;
            this.Name = "윈폼";
            this.MouseDown += new MouseEventHandler(MouseHandler);
        }

        static void Main()
        {
            Application.Run(new WinForm3("마우스 이벤트 예제"));
        }
    }
}
