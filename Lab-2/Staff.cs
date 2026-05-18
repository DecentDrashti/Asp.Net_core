using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Staff
    {
        public string Name;
        public string Department;
        public string Designation;
        public int Experience;
        public int Salary;
        public void GetStaffDetails(int i)
        {
            Console.WriteLine("the data of staff" + i);
           
            Console.WriteLine("enter the staff Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("enter the staff department: ");
            Department = Console.ReadLine();
            Console.WriteLine("enter the staff Designation: ");
            Designation = Console.ReadLine();
            Console.WriteLine("enter the staff Experience in years: ");
            Experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the staff salary: ");
            Salary = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayStaffDetails()
        {
            Console.WriteLine("Name: " + Name);
            //Console.WriteLine("Department: " + Department);
            //Console.WriteLine("Designation: " + Designation);
            //Console.WriteLine("Experience: " + Experience);
            Console.WriteLine("Salary: " + Salary);
        }

    }
}
