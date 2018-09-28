﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_4
{
    class Triangle1
    {
        private int width;
        private int height;
        private int area;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int Area
        {
            get { return (width * height) / 2; }
        }
    }

    class Triangle2
    {
        public int Width
        {
            get;
            set;
        }
        public int Height
        {
            get;
            set;
        }
        public int Area
        {
            get { return (Width * Height) / 2; }
        }
    }

    class Program2
    {
        static void Main()
        {
            Triangle1 t1 = new Triangle1();
            t1.Width = 6;
            t1.Height = 6;

            Console.WriteLine("밑변은 {0}", t1.Width);
            Console.WriteLine("높이는 {0}", t1.Height);
            Console.WriteLine("면적은 {0}", t1.Area);

            Console.WriteLine("===============================");

            Triangle2 t2 = new Triangle2();
            t2.Width = 8;
            t2.Height = 8;

            Console.WriteLine("밑변은 {0}", t2.Width);
            Console.WriteLine("높이는 {0}", t2.Height);
            Console.WriteLine("면적은 {0}", t2.Area);
        }
    }
}
