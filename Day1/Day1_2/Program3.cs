using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_2
{
    struct Emp
    {
        public int id;
        public string name;
    }

    class Program3
    {
        public static void Main()
        {
            Emp e;
            e.id = 1;
            e.name = "홍길동";
            Console.WriteLine("사번: {0}", e.id);
            Console.WriteLine("이름: {0}", e.name);

            Emp e1 = new Emp();     // new하더라도 스택에 저장
            e1.id = 2;
            e1.name = "2길동";
            Console.WriteLine("사번: {0}", e1.id);
            Console.WriteLine("이름: {0}", e1.name);
        }
    }
}
