using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_4
{
    class Emp
    {
        public string Name      // 자동구현속성
        {
            get;
            set;
        }
        /*
        private string name;
        public string Name      // 속성Property
        {
            get { return name; }
            set { name = value; }
        }
        */
        /*
        private string name;
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        */
    }

    class Program
    {
        static void Main(string[] args)
        {
            Emp e = new Emp();
            e.Name = "홍길이";
            Console.WriteLine(e.Name);

            /*
            e.setName("홍길이");
            Console.WriteLine(e.getName());
            */
        }
    }
}
