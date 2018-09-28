using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_1
{
    class Emp
    {
        public override string ToString()
        {
            return "Emp";
        }
    }
    class Programmer : Emp { }
    class Program4
    {
        static void Main()
        {
            Programmer p = new Programmer();
            Emp e = p as Emp;
            if (e != null)
            {
                System.Console.WriteLine(e.ToString());
                System.Console.WriteLine(e);
            }                
        }
    }
}
