using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    // 이벤트 게시자 클래스, 이벤트를 발생시키는 객체
    class EventPublisher
    {
        //public delegate void MyEventHandler();
        //public event MyEventHandler MyEvent;    // 이벤트 정의
       
        // ==>
        public event EventHandler MyEvent;

        public void Do()
        {
            //if (MyEvent != null) { MyEvent(); }
            //MyEvent?.Invoke();

            if (MyEvent != null) { MyEvent(null, null); }
        }
    }

    // 구독자 클래스
    class Subscriber
    {
        static void Main()
        {
            EventPublisher p = new EventPublisher();
            //p.MyEvent += new EventPublisher.MyEventHandler(doAction);   // 이벤트 처리 메서드 등록
            p.MyEvent += new EventHandler(doAction);    // C# 1.0
            p.MyEvent += doAction;      // C# 2.0 이상

            // C# 2.0 이상에서 delegate 이용한 무명함수로 이벤트 가입
            p.MyEvent += delegate (object sender, EventArgs e)
            {
                Console.WriteLine("MyEvent라는 이벤트 발생");
            };

            // C# 3.0 이후 람다식 이용한 무명함수로 이벤트 가입
            p.MyEvent += (sender, e) => Console.WriteLine("MyEvent라는 이벤트 발생");

            p.Do();
        }

        //static void doAction()
        static void doAction(object sender, EventArgs e)
        {
            Console.WriteLine("MyEvent라는 이벤트 발생");
        }
    }
}
