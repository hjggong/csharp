using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    //public class Dog

    // 추상클래스; 틀, 스펙을 정의
    //public abstract class Dog

    // 안에; 메소드, 속성, 이벤트, 인덱서 ,,,필드(멤버)X
    interface Dog
    {
        //public string name { get; set; }
        string name { get; set; }

        // 상속
        //public void jitda()

        // 재정의
        /*
        public virtual void jitda()
        {
            Console.WriteLine(name + "가 짖다.");
        }
        */

        // 추상메소드
        //public abstract void jitda();   

        void jitda();
    }

    public class Pudle:Dog
    {
        public string name { get; set; }

        // 재정의
        /*
        public override void jitda()
        {
            Console.WriteLine("푸들푸들~~");
        }
        */
        public void work() { Console.WriteLine(name + "가 일한다."); }
        public void jitda() { Console.WriteLine("짖다~~~~~~~"); }
    }

    public class Jindo : Dog
    {
        public string name { get; set; }

        // 재정의
        /*
        public override void jitda()
        {
            Console.WriteLine("진도진도~~");
        }
        */
        public void run() { Console.WriteLine(name + "가 달린다."); }
        public void jitda() { Console.WriteLine("짖다~~~~~~~"); }
    }

    class DogManager       // class 앞에; public, internal
    {
        static void Main()
        {
            //Pudle p = new Pudle();
            //p.name = "푸들이";
            //p.jitda();
            //p.work();

            //Dog p = new Pudle();
            //p.name = "푸들이";
            //p.jitda();
            //((Pudle)p).work();

            object p = new Pudle();
            ((Dog)p).name = "푸들이";
            ((Dog)p).jitda();
            ((Pudle)p).work();

            //Jindo j = new Jindo();
            //j.name = "진도이";
            //j.jitda();
            //j.run();

            //Dog j = new Jindo();
            //j.name = "진도이";
            //j.jitda();
            //((Jindo)j).run();

            object j = new Jindo();
            ((Dog)j).name = "진도이";
            ((Dog)j).jitda();
            ((Jindo)j).run();
        }
    }
}
