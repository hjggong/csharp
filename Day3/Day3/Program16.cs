using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program16
    {
        static void Main()
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var onjQuery1 = from n in num
                            where n % 2 == 1
                            orderby n
                            select n;

            foreach (int i in onjQuery1)
                Console.WriteLine("홀수: {0}", i);

            IEnumerable<int> onjQuery2 = from n in num
                                         where n > 3
                                         orderby n descending
                                         select n;

            foreach (int i in onjQuery2)
                Console.WriteLine(i);

            Console.Write("========================\n\n");

            // Aggregate: 연산 결과 포워드
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            var result = numbers.Aggregate((a, b) => a * b);
            Console.WriteLine("Aggregation: " + result);

            result = numbers.Aggregate(10, (a, b) => a + b);
            Console.WriteLine("Aggregation with seed: " + result);

            result = numbers.Where(n => n % 2 == 0).Aggregate((a, b) => a * b);
            Console.WriteLine("Aggregation.Where: " + result);
        }
    }
}
