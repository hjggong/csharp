using System;
using System.Windows.Forms;

namespace Day4
{
    class WinForm5: Form
    {
        static void Main()
        {
            Button btn1 = new Button();
            btn1.Text = "메시지";
            btn1.Left = 50;
            btn1.Top = 50;
            btn1.Click += (object sender, EventArgs e) =>
            {
                MessageBox.Show("버튼 클릭");
            };

            Button btn2 = new Button();
            btn2.Text = "종료";
            btn2.Left = 150;
            btn2.Top = 50;
            btn2.Click += (object sender, EventArgs e) =>
            {
                MessageBox.Show("종료됩니다.");
                Application.Exit();
            };

            WinForm5 w = new WinForm5();
            w.Text = "윈폼 버튼 예제";
            w.Height = 150;
            w.Controls.Add(btn1);
            w.Controls.Add(btn2);
            Application.Run(w);
        }
    }
}
