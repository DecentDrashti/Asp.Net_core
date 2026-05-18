using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    interface Shape
    {
        double Circle(double x);
        int Triangle(int b, int h);
        int Square(int l);
    }

    internal class Cal_Area : Shape
    {
        public double Circle(double x)
        {
            return 3.14 * x * x;
        }

        public int Triangle(int b, int h)
        {
            return (b + h) / 2;
        }

        public int Square(int l)
        {
            return l * l;
        }

    }
}
