using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_3
{
    class Program5
    {
        static void Main()
        {
            Console.WriteLine(Minus(1, 2));
            Console.WriteLine(Minus(1));
            Console.WriteLine(Minus(i:8, j:9));
            Console.WriteLine(Minus(j:8, i:9));
            Console.WriteLine(Minus());
        }

        static int Minus(int i = 0, int j=0)
        {
            return i-j;
        }
    }
}
