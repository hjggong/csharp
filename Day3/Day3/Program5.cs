using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Delegate1
    {
        private delegate int OnjSum(int i, int j);

        public static void Main()
        {
            //OnjSum myMethod = new OnjSum(Sum);
            //OnjSum myMethod = Sum;
            OnjSum myMethod = new OnjSum(Delegate1.Sum);
            Console.WriteLine("두 수의 합: {0}", myMethod(10, 30));
        }

        static int Sum(int i, int j)
        {
            return i + j;
        }
    }
}
