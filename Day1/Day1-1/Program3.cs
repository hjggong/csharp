using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Day1_1
{
    class Program3
    {
        public static void Main()
        {
            #region 기본연산자
            Console.WriteLine(">>>>>>> 기본연산자 <<<<<<<");
            int iSize = sizeof(int);
            Console.WriteLine("int형 바이트 길이:{0}", iSize);

            Type myType1 = typeof(int);
            Console.WriteLine("type(int): {0}", myType1);

            int i = 10;
            Type myType2 = i.GetType();
            Console.WriteLine("i.getType(): {0}", myType2);

            // 변수의 사이즈를 구할 때
            int j = 99;
            Console.WriteLine("Size of j: {0}", Marshal.SizeOf(j));
            #endregion

            #region 산술연산자
            Console.WriteLine(">>>>>>> 산술연산자 <<<<<<<");
            Console.WriteLine(+3);
            Console.WriteLine(3 + 3);
            Console.WriteLine(3 + .3);
            Console.WriteLine("3" + "3");
            Console.WriteLine(3.0 + "3");

            Console.WriteLine(!true);

            // ~: 비트 보수 연산, 각 비트 반전
            byte x = 10;            // 0000 1010
            Console.WriteLine(~x);  // 1111 0101

            Console.WriteLine(unchecked( (short)50000 ));
            #endregion            
        }
    }
}
