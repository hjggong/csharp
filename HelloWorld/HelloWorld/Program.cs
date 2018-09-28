using System;                // using: 해당 네임스페이스의 클래스를 사용하겠다.
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld        // namespace: 분류이름
{
    class Program           // class: 설계도;규격정의
    {
        static void Main(string[] args)         // static: 객체 생성없이 사용 가능
        {                                       // Main: CLR이 실행
            Console.WriteLine("Hello C#");
        }
    }
}