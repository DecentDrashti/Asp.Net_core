using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Salary
    {
        int TA;
        int DA;
        int HRA;
        public Salary(int d, int h)
        {
            this.DA = d;
            this.HRA = h;
        }
        public int calc_salary(int DA, int HRA,int TA)
        {

            int total = DA + HRA + TA;
            return total;
        }
    }
}
