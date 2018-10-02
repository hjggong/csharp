using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    class Program3
    {
        public static Thread sleeperThread;

        public static void Main()
        {
            // delegate와 method 이름 같아야 함.
            sleeperThread = new Thread(new ThreadStart(ThreadToSleep));
            sleeperThread.Start();
            sleeperThread.Interrupt();
        }

        private static void ThreadToSleep()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine("[Sleeper: " + i++ + "]");
                if (i == 9)
                {
                    try
                    {
                        Console.WriteLine("i가 9가 되어 1초 쉼");
                        Thread.Sleep(1000);
                    }
                    catch(ThreadInterruptedException e)
                    {
                        Console.WriteLine("ThreadInterruptedException...");
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
