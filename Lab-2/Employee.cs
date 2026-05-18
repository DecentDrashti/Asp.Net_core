using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    interface Gross
    {
        void gross_sal();
    }

    //internal class Salary : Employee
    //{
    //    public int gross_sal()
    //    {
    //    }
    //}
    internal class Employee:Salary,Gross
    {
         public Employee(int d, int h,int t) :base( d, h)//Super jevu kam che base no 
            {
            }

        public void gross_sal()
        {
            Console.WriteLine("your gross salary");
        }
         
        public void calc_sal(int d,int h,int t)
        {
            Console.WriteLine("your calculate value");
        }
    }
    


}
