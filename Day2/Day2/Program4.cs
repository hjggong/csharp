using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program4
    {
        // ref: 참조할 변수 초기화O
        // out: 참조할 변수 초기화X
        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("a={0}, b={1}", a, b);
            //Swap(a, b);
            Swap(ref a, ref b);
            Console.WriteLine("a={0}, b={1}", a, b);
        }
    }
}
