using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program-1
            /*Console.WriteLine("enter the value of first number in integer");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of second number in integer");
            int num2=Convert.ToInt32(Console.ReadLine());
            Addition addition = new Addition();
            int sum_int=addition.add(num1,num2);
            Console.WriteLine(sum_int);
            Console.WriteLine("enter the value of first number in decimal");
            Double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the value of second number in decimal");
            Double number2 = Convert.ToDouble(Console.ReadLine());
            double sum_d=addition.add(number1, number2);
            Console.Write(sum_d);*/

            //program-2
            /*Console.WriteLine("enter 1 for calculating area of square and 2 for calculating area of rectangle: ");
            int n=Convert.ToInt32(Console.ReadLine());
            Area area = new Area();
            int ans = 0;
            switch (n)
            {
                case 1: Console.WriteLine("enter the length of the square");
                        int l=Convert.ToInt32(Console.ReadLine());
                        ans=area.calc_area(l);
                    break;
                case 2: Console.WriteLine("enter the length of the rectangle");
                        int len = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the breadth of the rectangle");
                        int b=Convert.ToInt32(Console.ReadLine());
                        ans=area.calc_area(len,b);
                       break; 
                default: Console.WriteLine("enter the valid choice");
                    break;
            }
            Console.WriteLine("thus the answer is:"+ans);*/

            //program-3
            /*Rbi rbi = new Rbi();
            rbi.calculateInterest();
            Sbi sbi = new Sbi();
            sbi.calculateInterest();
            HDFC hdfc = new HDFC();
            hdfc.calculateInterest();
            Icic icic= new Icic();
            icic.calculateInterest();*/

            //program-4
            /*Hospital h=new Hospital();
            h.HospitalDetails();
            Apollo apollo = new Apollo();
            apollo.HospitalDetails();
            Wockhardt wockhardt = new Wockhardt();
            wockhardt.HospitalDetails();
            Gokul_Souperspeciality gokul=new Gokul_Souperspeciality();
            gokul.HospitalDetails();*/

            //program-5
            /*Console.WriteLine("enter 1 for calculating area of square:\n2 for calculating area of rectangle: \n3 for calculating area of circle: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int ans = 0;
            Area_Shape area_Shape = new Area_Shape();
            switch (n)
            {
                case 1:
                    Console.WriteLine("enter the length of the square");
                    int l = Convert.ToInt32(Console.ReadLine());
                    ans = area_Shape.area(l);
                    break;
                case 2:
                    Console.WriteLine("enter the length of the rectangle");
                    int len = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the breadth of the rectangle");
                    int b = Convert.ToInt32(Console.ReadLine());
                    ans = area_Shape.area(len, b);
                    break;
                case 3:
                    Console.WriteLine("enter the radius of the circle");
                    double r = Convert.ToDouble(Console.ReadLine());
                    ans = Convert.ToInt32(area_Shape.area(r));
                    break;
                default:
                    Console.WriteLine("enter the valid choice");
                    break;
            }
            Console.WriteLine("thus the answer is :" + ans);*/

            //program-6
            Console.WriteLine("do you want to withdraw the money or deposit the money enter 1 for withdraw and 2 for deposit:");
            int n = Convert.ToInt32(Console.ReadLine());
            int ans = 0;
            Bank_Account b = new Bank_Account();
            switch (n)
            {
                case 1:Console.WriteLine("enter initial balance:");
                    int i = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the amount you want to withdraw:");
                    int m = Convert.ToInt32(Console.ReadLine());
                    ans=b.cash(m, i);
                    break;
                case 2:Console.WriteLine("enter te amount to deposit");
                    int amount=Convert.ToInt32(Console.ReadLine());
                    ans=b.cash(amount);
                    break;

            }
            Console.WriteLine("thus the answer is :" + ans);

        }
    }
}
