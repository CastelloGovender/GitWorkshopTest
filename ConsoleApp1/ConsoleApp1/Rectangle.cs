using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Rectangle
    {
        public void Area() {
            int l = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int a = l * w;
            Console.WriteLine("The area is: "+a);
        }
    }
}
