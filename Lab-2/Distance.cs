using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Distance
    {
        double dist1;
        double dist2;
        double dist3;
        // Constructor to initialize dist1 and dist2
        public Distance(double d1, double d2)
        {
            dist1 = d1;
            dist2 = d2;
            dist3 = 0; // Initialize dist3 to 0
        }
        public void calc_dist() 
        {
            dist3 = dist1 + dist2;
        }
        public void DisplayAddition()
        {
            Console.WriteLine("The addition of dist1 and dist2 is: " + dist3);
        }
    }
}
