using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcArea();
        }

        static void CalcArea()
        {
            double a, b, c, p, area;
            Console.WriteLine("Please enter the measurements of the three sides of a triangle");

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());

            p = (a + b + c) / 2;

            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("The area of the triangle is {0}", area);


        }
    }
}
