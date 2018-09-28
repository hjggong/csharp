using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_1
{
    class MyConstants
    {
        public const double PI = 3.14;      // const: 상수
        public const int MYAGE = 22;
    }

    class Program
    {
        static void Main(string[] args)
        {
            double radius = 2;
            double area = MyConstants.PI * (radius * radius);
            Console.WriteLine("Area = {0}, Age = {1}", area, MyConstants.MYAGE);

            const string name = "홍길동";
            Console.WriteLine("name: " + name);
        }
    }
}
