using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Circle
    {
        public const double PI = 3.14;

        public double FindArea(double radius)
        {
            return PI * radius * radius;
        }

        public double FindPerimeter(double radius)
        {
            return 2 * PI * radius;
        }
    }
}