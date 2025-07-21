using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01OOP
{
    internal struct Point02
    {
        public double X { get; set; }
        public double Y { get; set; }

        public static double Distance(Point02 p1, Point02 p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            return Sqrt(dx * dx + dy * dy);
        }

        private static double Sqrt(double x)
        {
            double guess = x / 2;
            for (int i = 0; i < 10; i++)
                guess = (guess + x / guess) / 2;
            return guess;
        }

    }
}
