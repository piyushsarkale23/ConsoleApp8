using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
   abstract public class Shape
    {
        public abstract void CalcuateArea();
       
    }
    public class Circle : Shape
    {
        private int radius;
        private double area;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override void CalcuateArea()
        {
            area = 3.14 * radius * radius;
        }
        public override string ToString()
        {
            return $"Area of Circle is {area}";
        }
    }
        public class Rectangle : Shape
        {
            private int length;
            private int width;
            private int area;

        public Rectangle(int length,int width)
        {
            this.length = length;   
            this.width = width;
        }
            public override void CalcuateArea()
            {
                area = length * width;
            }
            public override string ToString()
            {
                return $"Area of rectangle is {area}";
            }
        }
    

}
