using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program11
    {
        //delegate int Calc(int i, int j);
        //delegate void Calc(int i, int j);

        static void Main()
        {
            //Calc c = new Calc(MySum);
            //Console.WriteLine("1+2={0}", c(1, 2));
            //c(1, 2);
            Action<int, int> ac = new Action<int, int>(MySum);
            ac(1, 2);

            //Calc c1 = delegate (int i, int j)       // 익명메소드
            Action<int, int> ac1 = delegate(int i, int j)
            {
                //return i + j;
                Console.WriteLine(i + j);
            };
            //Console.WriteLine("3+4={0}", c1(3, 4));
            //c1(3, 4);
            ac1(3, 4);

            // 람다식
            //Calc c2 = (int i, int j) => i + j;
            //Console.WriteLine("5+6={0}", c2(5, 6));           
            //Calc c2 = (int i, int j) => Console.WriteLine(i + j);
            //c2(5, 6);
            Action<int, int> ac2 = (int i, int j) => Console.WriteLine(i + j);
            ac2(5, 6);
        }

        static void MySum(int i, int j)
        {
            //return i + j;
            Console.WriteLine(i + j);
        }
    }
}
