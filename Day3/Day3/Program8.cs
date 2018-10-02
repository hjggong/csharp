using System;

namespace Day3
{
    public delegate void CallBack();

    class Program8
    {
        static void Main()
        {
            MyClass my = new MyClass();
            my.MyMethod1();
            my.MyMethod2();
            Console.WriteLine("-----------------------");

            my.GetCallback(my.MyMethod1);
            my.GetCallback(my.MyMethod2);
        }
    }

    class MyClass
    {
        public MyClass() { }

        public void GetCallback(CallBack callBack)
        {
            callBack();
        }

        public void MyMethod1()
        {
            Console.WriteLine("My Method 1");
        }
        public void MyMethod2()
        {
            Console.WriteLine("My Method 2");
        }
    }
}
