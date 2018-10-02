using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program6
    {
        // 제공하는 델리게이트
        // Func: 값을 리턴하는 메소드를 참조하는 델리게이트
        // Action: 값을 리턴하지 않는 -
        // Func<param, return>
        // Action<param>

        //public delegate int MyDelegate(int i, int j);

        public static void Main()
        {
            /*
            TakesADelegate(new MyDelegate(Add));
            TakesADelegate(new MyDelegate(Minus));
            TakesADelegate(new MyDelegate(Gop));
            TakesADelegate(new MyDelegate(Namugi));
            */

            TakesADelegate(new Func<int, int, int>(Add));
            TakesADelegate(new Func<int, int, int>(Minus));
            TakesADelegate(new Func<int, int, int>(Gop));
            TakesADelegate(new Func<int, int, int>(Namugi));
        }

        //public static void TakesADelegate(MyDelegate SomeFunction)
        public static void TakesADelegate(Func<int, int, int> SomeFunction)
        {
            Console.WriteLine(SomeFunction(1, 2));
        }

        public static int Add(int i, int j)
        {
            return i + j;
        }

        public static int Minus(int i, int j)
        {
            return i - j;
        }

        public static int Gop(int i, int j)
        {
            return i * j;
        }

        public static int Namugi(int i, int j)
        {
            return i / j;
        }
    }
}
