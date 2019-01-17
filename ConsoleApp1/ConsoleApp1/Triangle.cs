using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Triangle
    {
        double h;
        double b;

        public Triangle()
        {
            this.h = 0;
            this.b = 0;
        }

        public Triangle(double height, double breadth)
        {
            this.h = height;
            this.b = breadth;
        }

        public double Area_of_Triangle(double height, double breadth)
        {
            double area = 0.5 * height * breadth;
            return area;
        }
    }
}
