using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_3
{
    class Program2
    {
        static void Main(string[] args)
        {
            int[] iArr = { 1, 3, 5, 7, 9 };
            int sum = 0;

            foreach(int i in iArr)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
