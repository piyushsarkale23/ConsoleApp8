using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(5);
            c.CalcuateArea();
            Console.WriteLine(c);

            Rectangle r = new Rectangle(45,5);
            r.CalcuateArea();
            Console.WriteLine(r);
        }
    }
}
