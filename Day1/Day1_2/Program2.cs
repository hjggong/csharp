using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_2
{
    enum Day1
    {
        // 0, 1, 2, 3, 4, 5, 6
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    enum Day2 : byte
    {
        // 11, 12, 13, 14, 15, 16, 111
        Monday = 11, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday = Monday + 100
    }

    class Program2
    {
        static void Main()
        {
            Day1 whatDay = Day1.Sunday;
            Console.WriteLine("{0}", whatDay);          //Sunday
            Console.WriteLine("{0}", (int)whatDay);     //6

            whatDay = (Day1)6;
            Console.WriteLine("{0}", whatDay);          //Sunday
            whatDay = (Day1)2;
            Console.WriteLine("{0}", whatDay);          //Wednesday

            Day2 whatDay2 = Day2.Monday;
            Console.WriteLine("{0}", whatDay2);         //Monday
            Console.WriteLine("{0}", (byte)whatDay2);   //11

            whatDay2 = (Day2)111;
            Console.WriteLine("{0}", whatDay2);         //Sunday


        }
    }
}
