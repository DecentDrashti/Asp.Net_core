using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class Rbi
    {
        public void calculateInterest()
        {
            Console.WriteLine("calculate interest using rbi");
        }
    }
    public class HDFC :Rbi
    {
        public void calculateInterest()
        {
            Console.WriteLine("calculate interest using hdfc");
        }
    }
    public class Sbi : Rbi
    {
        public void calculateInterest()
        {
            Console.WriteLine("calculate interest using Sbi");
        }
    }
    public class Icic : Rbi
    {
        public void calculateInterest()
        {
            Console.WriteLine("calculate interest using icic");
        }
    }
}
