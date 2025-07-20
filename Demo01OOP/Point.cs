using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01OOP
{
    internal struct Point
    {
        public int x = default;
        public int y = default;


        //public Point()
        //{

        //}

        //public Point()
        //{
        //    x = 12;
        //    y = 12; 
        
        //}
        public Point(int X , int Y)
        {
            x = X;
            y = Y; 

        }

        public void PrintPoint()
        { 
            Console.WriteLine($"({x}, {y})");
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}
