using System;
using System.Drawing;

namespace Shapes
{
    public class Circle
    {
        double radius;      // 인스턴스 변수

        // 생성자
        public Circle()
        {
            radius = 0;
        }

        // 생성자
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // 메서드
        public double Area()
        {
            return Math.PI * (radius * radius);
        }

        public void Draw()
        {
            Pen p = new Pen(Color.Red);
        }
    }
}
