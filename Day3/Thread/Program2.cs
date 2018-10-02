using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    public class Program2
    {
        public bool sleep = false;

        // 차단기 내려감
        static AutoResetEvent autoEvent = new AutoResetEvent(false);

        public void FirstWork()
        {
            for(int i=0; i<10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("F{0} ", i);
                if (i == 5)
                {
                    sleep = true;
                    Console.WriteLine("");
                    Console.WriteLine("first 쉼..");
                    //Thread.CurrentThread.Suspend();
                    autoEvent.WaitOne();
                }
            }
        }

        public static void Main()
        {
            Program2 p = new Program2();
            Thread first = new Thread(new ThreadStart(p.FirstWork));
            first.Start();

            while (p.sleep == false) { }
            Console.WriteLine("first를 깨웁니다..2초 후 깨어납니다.");
            Thread.Sleep(2000);
            //first.Resume();
            autoEvent.Set();
        }
    }
}
