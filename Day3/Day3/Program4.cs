using System;
using System.Runtime.InteropServices;

namespace Day3
{
    class Program4
    {
        [DllImport("User32.Dll")]
        public static extern int MessageBox(int h, string m, string c, int type);

        static void Main()
        {
            MessageBox(0, "Hello!", "In C#", 0);
        }
    }
}
