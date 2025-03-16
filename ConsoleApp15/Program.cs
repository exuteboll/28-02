using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p2 = new Point(2.5,4.2);
            Point p3 = new Point(4.0, 2.5);
            p1.Print();
            p2.Print();
            p3.Print();
            Console.WriteLine($"всего раз: {Point.GetCount()}");
            Console.ReadKey();
            
        }
    }
}
