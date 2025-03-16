using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Point
    {
        private double x;
        private double y;
        static int count = 0;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            count++;
        }
        public Point()
        {
            this.x = 1.0;
            this.y = 1.0;
            count++;
        }
        public static int GetCount()
        {
            return count;
        }

        public double GetX()
        { return x; }
        public void  SetX(double value) 
        {  x = value; }
        public void SetY(double value)
        {  y = value; }
        public double GetY() 
        { return y; }

        public void Print()
        { Console.WriteLine($"X = {x}\n Y = {y}"); }



    }
}
