using System;
using System.Threading;

namespace ThreadTest
{
    public class ThreadT
    {
        public string lockString = "Hello";
        //private object obj = new object();
        private static Mutex mutex = new Mutex();

        public void Print(string rank)
        {
            /*
            lock (obj)      // 처음 쓰레드가 끝날 때까지 다른 쓰레드 접근 금지
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Thread.Sleep(100);
                        Console.Write(".");
                    }

                    Console.WriteLine("{0}{1} ", rank, lockString);
                }
            }
            */
            /*
            Monitor.Enter(obj);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Thread.Sleep(100);
                    Console.Write(".");
                }

                Console.WriteLine("{0}{1} ", rank, lockString);
            }
            Monitor.Exit(obj);
            */
            mutex.WaitOne();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Thread.Sleep(100);
                    Console.Write(".");
                }

                Console.WriteLine("{0}{1} ", rank, lockString);
            }
            mutex.ReleaseMutex();
        }

        public void FirstWork() { Print("F"); }
        public void SecondWork() { Print("S"); }
    }

    class Program5
    {
        public static void Main()
        {
            ThreadT t = new ThreadT();
            Thread first = new Thread(new ThreadStart(t.FirstWork));
            Thread second = new Thread(new ThreadStart(t.SecondWork));

            first.Start();
            second.Start();
        }
    }
}
