using System;
using System.Windows.Forms;

namespace Day4
{
    class OnjMessageFilter: IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            /*
            const int WM_SYSKEYDOWN = 0x0104;
            if (m.Msg == WM_SYSKEYDOWN)
            {
                bool alt = ((int)m.LParam & 0x20000000) != 0;
                if( alt && (m.WParam == new IntPtr((int)Keys.F4)))
                {
                    Console.WriteLine("ALT + F4 Filtering..");
                    return true;
                }
            }
            */

            if(m.Msg == 0x201)
            {
                Console.WriteLine("마우스 클릭 필터링 됨.");
                return true;
            }

            return false;
        }
    }

    class WinForm2: Form
    {
        static void Main()
        {
            Application.AddMessageFilter(new OnjMessageFilter());
            WinForm2 w = new WinForm2();
            w.Click += new EventHandler(w.Form_Click);
            Application.Run(w);
        }

        void Form_Click(object sender, EventArgs e)
        {
            Console.WriteLine("마우스 클릭 이벤트 발생");
            Application.Exit();
        }
    }
}
