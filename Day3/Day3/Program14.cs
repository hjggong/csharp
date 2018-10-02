using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program14
    {
        static void Main()
        {
            int[] scores = { 30, 54, 64, 54, 99, 11 };

            int oddScoreSum = scores.Where(n => n % 2 == 1).Sum();
            Console.WriteLine("홀수의 합: {0}", oddScoreSum);

            int oddCount = scores.Where(n => n % 2 == 1).Count();
            Console.WriteLine("홀수의 개수: {0}", oddCount);

            int Count = scores.Where(n => n > 50).Count();
            Console.WriteLine("50보다 큰 수의 개수: {0}", oddCount);

            int Max = scores.Max();
            Console.WriteLine("배열의 최대값: {0}", Max);

            int Min = scores.Min();
            Console.WriteLine("배열의 최소값: {0}", Min);
        }
    }
}
