using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요.");
            string str = Console.ReadLine();
            int m = 0;
            bool parsed = int.TryParse(str, out m);

            if (!parsed)
            {
                Console.WriteLine("숫자를 입력하세요.");
                Environment.Exit(0);
            }

            /*
            try
            {
                m = int.Parse(str);
            }
            catch (FormatException e)
            {
                Console.WriteLine("숫자를 입력하세요.");
                Environment.Exit(0);
            }
            */


            int sum = 0;
            for (int i = 0; i <= m; i++)
            {
                if (i % 2 == 0) sum += i;
                i++;
            }
            Console.WriteLine("1부터 {0}까지 짝수의 합은 {1}", m, sum);


            /*
            int i = 0;
            int sum = 0;

            do
            {
                if (i % 2 == 0) sum += i;
                i++;
            } while (i <= m);
            Console.WriteLine("1부터 {0}까지 짝수의 합은 {1}", m, sum);
            */

            /*
            int i = 0;
            int sum = 0;

            while(i <= m)
            {
                if (i%2 == 0) sum += i;
                i++;
            }
            Console.WriteLine("1부터 {0}까지 짝수의 합은 {1}", m, sum);            
            */
        }
    }
}
