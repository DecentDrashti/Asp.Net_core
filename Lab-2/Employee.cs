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
    internal class Salary
    {
        protected int _HRA, _TA, _DA; // Renamed fields to avoid ambiguity

        // Constructor
        public Salary(int d, int h, int t)
        {
            _DA = d;
            _HRA = h;
            _TA = t;
        }

        // Display Salary Allowances
        public void Disp_sal()
        {
            Console.WriteLine("DA  : " + _DA);
            Console.WriteLine("HRA : " + _HRA);
            Console.WriteLine("TA  : " + _TA);
        }
    }

    // Employee Class
    internal class Employee : Salary, Gross
    {
        // Constructor
        public Employee(int d, int h, int t)
            : base(d, h, t) // base works like super
        {
        }

        // Interface Method
        public void gross_sal()
        {
            int gross = _DA + _HRA + _TA; // Updated to use renamed fields

            Console.WriteLine("\nYour Gross Salary Details");
            Disp_sal();
            Console.WriteLine("Gross Salary : " + gross);
        }

        // Another Method
        public void calc_sal(int d, int h, int t)
        {
            int total = d + h + t;

            Console.WriteLine("Calculated Value : " + total);
        }
    }
}
