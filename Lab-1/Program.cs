using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //program-1
            /*Console.WriteLine("Name: Drashti Ruparelia");
            Console.WriteLine("address");
            Console.WriteLine("contact number");
            Console.WriteLine("city:Rajkot");*/

            //program-2
            /*Console.WriteLine("enter the first number");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("first number is:" + a + "\nsecond number is:" + b); */

            //program-3
            /*Console.WriteLine("enter your name");
            string name=Console.ReadLine();
            Console.WriteLine("enter your country name");
            string cname=Console.ReadLine();
            Console.WriteLine("Hello "+name+ " from country "+cname);*/

            //program-4
            /*Console.WriteLine("enter the length:");
            int l=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the width:");
            int b=Convert.ToInt32(Console.ReadLine());
            int area = l * b;
            Console.WriteLine("area is: " + area);*/

            //program-5
            /*Console.WriteLine("enter the following number for finding the areas of following shape");
            Console.WriteLine("1.circle\n2.Square\n3.rectangle");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:Console.WriteLine("enter the radius of circle");
                       double radii=Convert.ToDouble(Console.ReadLine());
                       Console.WriteLine("Area of circle is: " + (3.14 * radii * radii));
                       break;

                case 2:
                    Console.WriteLine("enter the length of square");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of square is: " + (length*length));
                    break;

                case 3:
                    Console.WriteLine("enter the length of rectangle");
                    double len = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter the breadth of rectangle");
                    double breadth = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Area of rectangle is: " + (len*breadth));
                    break;

                default:Console.WriteLine("enter the number between 1-3 for proper output");
                    break;
            }*/

            //program-6
            /*Console.WriteLine("enter the temperature");
            double temp=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the number for the degree in which you will provide temperature");
            Console.WriteLine("1.celsius\n2.fahrenhit");
            int num=Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1: Console.WriteLine("the temperature in fahrenhit is: " + ((temp * 9 / 5) + 32) + "F");
                    break;
                case 2: Console.WriteLine("the temperature in celsius is: " + ((temp - 32) * 5/ 9) + "C");
                    break;
            }*/

            //program-7
            /*Console.WriteLine("enter the principle value: ");
            double p= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the rate value: ");
            double r=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the time value(in years): ");
            double t=Convert.ToDouble(Console.ReadLine());
            double si = (p * r * t) / 100;
            Console.WriteLine("thus the simple interest of given value is: " + si);*/

            //program-8
            /*
            Console.WriteLine("enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //simple calculator using if else
            
            Console.WriteLine("enter the sign which you need to perform on this two number: ");
            string c = Console.ReadLine();
            if (c == "+")
            {
                Console.WriteLine("The Answer is: " + (num1 + num2));
            }
            else if (c == "-")
            {
                Console.WriteLine("The Answer is: " + (num1 - num2));
            }
            else if (c == "*")
            {
                Console.WriteLine("The Answer is: " + (num1 * num2));
            }
            else 
            {
                Console.WriteLine("The Answer is:" + (num1 / num2));
            }

            //simple calculator using switch case:
            Console.WriteLine("enter the number according to sign which you need to perform on the numbers");
            Console.WriteLine("enter\n1.addition\n2.subtraction\n3.multiplication\n4.division");
            int c=Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:Console.WriteLine("The Answer is: " + (num1 + num2));
                    break;
                case 2:Console.WriteLine("The Answer is: " + (num1 - num2));
                    break ;
                case 3:Console.WriteLine("The Answer is: " + (num1 * num2));
                    break;
                case 4:Console.WriteLine("The Answer is: " + (num1 / num2));
                    break;
                default: Console.WriteLine("enter the valid number from 1-4");
                    break;
            }*/

            //program-9
            /*Console.WriteLine("enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("before swap:-\nnumber1:" + num1 + "\nnumber2:" + num2);
            num1 = num1 +num2;
            num2 = num1 - num2;
            num1=num1 - num2;
            Console.WriteLine("after swap:\nnumber1:" + num1 + "\nnumber2:" + num2);*/

            //program-10
            Console.WriteLine("enter the number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int max = (num1 > num2) ? (num1 > num3 ? num1:num3):(num2>num3?num2:num3);
            Console.WriteLine("the largest number is: "+max);

        }
    }
}
