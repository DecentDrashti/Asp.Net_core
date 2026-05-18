using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class Hospital
    {
        public void HospitalDetails() 
        {
            Console.WriteLine("hello from hospital");
        }
    }
    public class Apollo:Hospital
    {
        public void HospitalDetails()
        {
            Console.WriteLine("hello from apollo");
        }
    }
    public class Wockhardt:Hospital
    {
        public void HospitalDetails()
        {
            Console.WriteLine("hello from wockhardt");
        }
    }
    public class Gokul_Souperspeciality:Hospital
    {
        public void HospitalDetails()
        {
            Console.WriteLine("hello from gokul");
        }
    }
}
