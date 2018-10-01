using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class MyBaseClass
    {
        public MyBaseClass()
        {
            Console.WriteLine(">>> MyBaseClass()");
        }

        public MyBaseClass(int i)
        {
            Console.WriteLine(">>> MyBaseClass(int i)");
        }
    }

    class Myclass : MyBaseClass
    {
        public Myclass()
        {
            Console.WriteLine(">>> MyClass()");
        }

        public Myclass(int i):base(i)
        {
            Console.WriteLine(">>> MyClass(int i)");
        }

        public Myclass(int i, int j)
        {
            Console.WriteLine(">>> MyClass(int i, int j)");
        }

        public Myclass(int i, int j, int k) : base(i)
        {
            Console.WriteLine(">>> MyClass(int i, int j, int k)");
        }

        public Myclass(int i, int j, int k, int l) : this(i,j)
        {
            Console.WriteLine(">>> MyClass(int i, int j, int k, int l)");
        }
    }

    class Program2
    {
        static void Main()
        {
            Console.WriteLine("--- m1 ---");
            Myclass m1 = new Myclass();
            Console.WriteLine("--- m2 ---");
            Myclass m2 = new Myclass(1);
            Console.WriteLine("--- m3 ---");
            Myclass m3 = new Myclass(1, 2);
            Console.WriteLine("--- m4 ---");
            Myclass m4 = new Myclass(1, 2, 3);
            Console.WriteLine("--- m5 ---");
            Myclass m5 = new Myclass(1, 2, 3, 4);
        }
    }
}
