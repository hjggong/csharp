using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_1
{
    class Program6
    {
        static void Main()
        {
            object a = null;
            object b = null;

            object c = a ?? b;
            if (c is null) Console.WriteLine("c is null");
            Console.WriteLine(c?.ToString());

            /* 
             * 출력
             * -------------------
             * c is null
             * 
             * -------------------
             */

        }
    }
}
