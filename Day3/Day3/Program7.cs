using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    delegate void OnjDelegate(int a, int b);

    class Calc
    {
        static void Plus(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        static void Minus(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        void Multiplication(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
        void Division(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }

        static void Main()
        {
            Calc c = new Calc();
            /*
            OnjDelegate CallBack = (OnjDelegate)Delegate.Combine(
                   new OnjDelegate(Calc.Plus),
                   new OnjDelegate(Calc.Minus),
                   new OnjDelegate(c.Multiplication),
                   new OnjDelegate(c.Division));
            */

            OnjDelegate CallBack = new OnjDelegate(Calc.Plus);
            CallBack += new OnjDelegate(Calc.Minus);
            CallBack += new OnjDelegate(c.Multiplication);
            CallBack += new OnjDelegate(c.Division);

            CallBack(4, 3);

        }
    }
}
