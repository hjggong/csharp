using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)     // CLR 실행 시 main thread
        {
            short a = 10;       // short: 2byte  0000 0000 0000 1010
            int b = a;          // int: 4byte    0000 0000 0000 0000 0000 0000 0000 1010
            int c = 50000;      //               0000 0000 0000 0000 1100 0011 0101 0000
            short d = (short)c; //               1100 0011 0101 0000 ; overflow ==> cast
            
            Console.WriteLine("Short: {0}", d);

            try
            {
                short e = checked((short)c);    // overflow를 검사하여 예외를 발생시킴
            }
            catch (Exception e)
            {
                Console.WriteLine("== 예외 ==");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            write();
        }

        static void write()     // 메소드
        {
            int a = 0;      // 지역변수, 스택에 저장, 자동초기화X ==> 반드시 초기화
            Console.Write("{0} write() 함수 실행됨.", a);
        }
    }
}
