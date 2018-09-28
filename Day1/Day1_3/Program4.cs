using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_3
{
    class Program4
    {
        static void Main()
        {
            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Sum(1, 2 ,3));
        }

        static int Sum(params int[] iArr)       // 가변길이 파라미터
        {
            int sum = 0;
            foreach (int i in iArr) sum += i;
            return sum;
        }

        // 메소드 오버로딩: 파라미터 개수나 타입 다르게.
        /*
        static int Sum(int i, int j)
        {
            return i + j;
        }

        static int Sum(int i, int j, int k)
        {
            return i + j + k;
        }
        */
    }
}
