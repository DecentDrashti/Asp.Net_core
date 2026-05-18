using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class Area_Shape
    {
        public int area(int x)
        {
            return x * x;
        }
        public int area(int x, int y)
        {
            return x *  y ;
        }
        public double area(double r)
        {
            return 3.14*r*r;
        }

    }
}
