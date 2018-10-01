using System;
using System.Collections.Generic;

namespace Day2
{
    class SumTest<T>
    {
        public T Sum(T i, T j)
        {
            return (dynamic)i + (dynamic)j;
        }
    }

    class Program8
    {
        static T[] GetArray<T>(int size, T val)
        {
            T[] array = new T[size];
            for(int i=0; i<size; i++)
            {
                array[i] = val;
            }
            return array;
        }


        public static void Main()
        {
            SumTest<int> s1 = new SumTest<int>();
            Console.WriteLine("정수의 합: {0} + {1} = {2}", 1, 2, s1.Sum(1, 2));

            SumTest<double> s2 = new SumTest<double>();
            Console.WriteLine("실수의 합: {0:f} + {1:f} = {2:f}", 1.0, 2.0, s2.Sum(1.0, 2.0));


            Console.Write("\n\n\n\n");
            string[] str_array = GetArray<string>(3, "오라클자바커뮤니티,오라클자바커뮤니티");
            foreach (string s in str_array)
                Console.WriteLine(s);

            int[] int_array = GetArray<int>(5, 999);
            foreach (int i in int_array)
                Console.WriteLine(i);
        }
    }
}
