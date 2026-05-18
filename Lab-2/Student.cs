using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Student
    {
        int Enrollment_No;
        string Student_Name;
        int Semester;
        double CPI;
        double SPI;

        public void GetStudentDetails(int i)
        {
            Console.WriteLine("the data of Student" + i);
            Console.WriteLine("enter Student id: ");
            Enrollment_No = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Student Name: ");
            Student_Name = Console.ReadLine();
            Console.WriteLine("enter the Student Semester: ");
            Semester = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the candidate weight: ");
            CPI = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the candidate height: ");
            SPI = Convert.ToDouble(Console.ReadLine());

        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine("Enrollmentno: " + Enrollment_No);
            Console.WriteLine("Name: " + Student_Name);
            Console.WriteLine("semester: " + Semester);
            Console.WriteLine("CPI: " + CPI);
            Console.WriteLine("SPI: " + SPI);
        }
    }
}
