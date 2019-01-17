using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circle
    {
        void Area()
        {
            Console.Write("Enter side length: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area is : " + (Math.PI * r * r) );
            Console.ReadKey();
        }
    }
}
