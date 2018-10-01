using System;
using Shapes;

namespace ShapeUser
{
    class ShapeUser
    {
        static void Main(string[] args)
        {
            // 전용 어셈블리, 공유 어셈블리 test
            Circle c = new Circle(1.0f);
            Console.WriteLine("Area of Circle(1.0) is {0}", c.Area());
        }
    }
}
