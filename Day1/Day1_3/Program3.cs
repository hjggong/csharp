using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 과제
namespace Day1_3
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.Write("이진수로 변환할 숫자를 입력하세요: ");
            string str = Console.ReadLine();
            int mok = 0;
            string na = "";

            bool parsed = int.TryParse(str, out mok);
            if (!parsed)
            {
                Console.WriteLine("숫자를 입력하세요.");
                Environment.Exit(0);
            }

            while (mok > 0)
            {
                na = (mok % 2) + na;
                mok /= 2;
            }
            Console.WriteLine("변환된 이진수: {0}", na);
        }
    }
}
