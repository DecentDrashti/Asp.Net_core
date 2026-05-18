using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_3;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------------program-1-----------------
            /*int num = 50;
            int ans = 0;
            try
            {
                ans = num / ans;
                Console.WriteLine("answer:" + ans);
            }
            catch (Exception e)
            {
                Console.WriteLine("any number divide by zero is infinite");
            }*/

            //----------------program-2---------------
            /*int[] arr = new int[5];
            try
            {
                for (int i = 0; i <= arr.Length; i++)
                {
                    Console.WriteLine("enter the number");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("index out of bound");
            }*/

            //----------------program-3---------------
            /*Calculate c = new Calculate();
            Console.WriteLine("enter 1 for addition of two number and 2 for addition of three number");
            int choice=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the first number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2=Convert.ToInt32(Console.ReadLine());

            if (choice == 2)
            {
                Console.WriteLine("enter the third number");
                int num3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Answer is:"+c.SumOfThree(num1,num2, num3));
            }
            else if (choice == 1)
            {
                Console.WriteLine("Answer is:"+c.SumOfTwo(num1, num2));
            }
            else
            {
                Console.WriteLine("enter number according to instructions");
            }*/

            //----------------program-4---------------
            /*Result r=new Result();
            Console.WriteLine("enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the sum is: " + r.Add(num1,num2));*/

            //----------------program-5-----------------
            /*String name = "Drashti";
            Console.WriteLine(name);
            string surname = "Ruparelia";
            string fullname = string.Concat(name, surname);
            Console.WriteLine("My Name is: " + fullname);
            bool result = name.Equals(fullname);
            Console.WriteLine(result);
            Console.WriteLine(fullname.ToUpper());
            bool check = name.Contains("D");
            Console.WriteLine(check);*/

            //----------------program-6/10-----------------
            /*String name = "Drashti";
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.ToUpper());*/

            //----------------program-7-----------------
            /*Cal_Area area = new Cal_Area();
            Console.WriteLine(area.Circle(2.5));
            Console.WriteLine(area.Square(2));
            Console.WriteLine(area.Triangle(2, 3));*/

            //----------------program-8-----------------

            /*try
            {
                Console.WriteLine("enter the number");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 != 0)
                {
                    throw new Exception("number is odd");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);//exception upper thi constructor ma gyu atle je aiya print karavu e avene atle aiya print karavyu
            }*/

            //----------------program-9-----------------
            //Console.WriteLine("enter your sentence");
            //string sentence=Console.ReadLine();
            //int n=sentence.Length;
            //int curr_len = 0;
            //int res = 0;
            //for (int i = 0;  i < n; i++)
            //{//max length made
            //    if (sentence.charAt(i) != '') {
            //        curr_len++;
            //    }
            //    else
            //    {
            //        res=Math.Max(res, curr_len);
            //        curr_len = 0;
            //    }
            //}
            //return Math.Max(res, curr_len);


        }
    }
}
