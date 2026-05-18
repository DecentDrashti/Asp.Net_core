using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--program-1
            /*Console.WriteLine("enter the number of candidate you want to enter");
            int n=Convert.ToInt32(Console.ReadLine());
            Candidate[] c = new Candidate[n+1];

            Console.WriteLine("now enter the candidate detail");
                int i = 1;
                while (i != n + 1) {
                c[i] = new Candidate();
                c[i].GetCandidate(i);
                c[i].DisplayCandidateDetails();
                i++;
                 }*/
            //----------------------------------------------

            //program-2
            /* Console.WriteLine("enter the number of staff you want to enter");
             int n = Convert.ToInt32(Console.ReadLine());
             Staff[] s = new Staff[n + 1];

             Console.WriteLine("now enter the Staff detail");
             for(int i = 1;i!=n+1;i++)
             {
                 s[i] = new Staff();
                 s[i].GetStaffDetails(i);
             }
             for (int i = 1; i < s.Length; i++)
             {
                 if (s[i].Designation == "HOD" || s[i].Designation=="hod")
                 {
                     s[i].DisplayStaffDetails();
                 }
             }*/
            //---------------------------------------------------

            //program-3
            /*Console.WriteLine("enter the number of user you want to enter in Bank account");
            int n = Convert.ToInt32(Console.ReadLine());
            Bank_Account[] Banks = new Bank_Account[n + 1];
            Console.WriteLine("now enter the Account detail");
            for (int i = 1; i != n + 1; i++)
            {
                Banks[i] = new Bank_Account();
                Banks[i].GetAccountDetails(i);
                Banks[i].DisplayAccountDetails();
            }*/
            //---------------------------------------------------------

            //program-4
            /*Console.WriteLine("enter the number ofstudent you want to enter ");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] stu = new Student[n + 1];
            Console.WriteLine("now enter the student detail");
            for (int i = 1; i != n + 1; i++)
            {
                stu[i] = new Student();
                stu[i].GetStudentDetails(i);
                stu[i].DisplayStudentDetails();
            }*/

            //program-5
            /*Console.WriteLine("enter the length of the rectangle");
            int l=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the breadth of the rectangle");
            int b=Convert.ToInt32(Console.ReadLine());  
            Rectangle r1 = new Rectangle();
            int Ans=r1.Area(l, b);
            Console.WriteLine("thus the area of rectangle is: " + Ans);*/

            //program-6
            /*Interest account = new Interest();
            account.GetAccountDetails();
            account.DisplayAccountDetails();
            account.GetInterestDetails();
            account.CalculateAndDisplayInterest();*/
           

            //program-7
            /*Console.WriteLine("enter the salary of TA: ");
            int TA=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the salary of DA: ");
            int DA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the salary of HRA: ");
            int HRA = Convert.ToInt32(Console.ReadLine());
            Salary sal=new Salary(DA,HRA);
            int total=sal.calc_salary(TA, DA, HRA);
            Console.WriteLine("total salary: "+total);*/

            //program-8
            /*Console.WriteLine("enter the 1st distance:");
            double d1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the 2nd distance:");
            double d2 = Convert.ToDouble(Console.ReadLine());
            Distance distance = new Distance(d1, d2);
            distance.calc_dist();
            distance.DisplayAddition();*/

            //program-9
            /*Furniture furniture = new Furniture();
            furniture.fur();
            Table table = new Table();
            table.tabl();*/

            //program-10
           Employee e = new Employee(3000, 2000, 1500);

            e.gross_sal();
            
            e.calc_sal(3000, 2000, 1500);
            
            Console.ReadLine();


        }
    }
}
