using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Account_Details
    {
            public int AccountNumber;
            public string AccountHolderName;
            public double Balance;

            public void GetAccountDetails()
            {
                Console.WriteLine("Enter Account Number:");
                AccountNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Account Holder Name:");
                AccountHolderName = Console.ReadLine();

                Console.WriteLine("Enter Account Balance:");
                Balance = Convert.ToDouble(Console.ReadLine());
            }

            public void DisplayAccountDetails()
            {
                Console.WriteLine("\nAccount Details:");
                Console.WriteLine($"Account Number: {AccountNumber}");
                Console.WriteLine($"Account Holder Name: {AccountHolderName}");
                Console.WriteLine($"Balance: {Balance}");
            }
        }

        public class Interest : Account_Details
        {
            public double Rate;
            public double Duration;

            public void GetInterestDetails()
            {
                Console.WriteLine("Enter Rate of Interest (in %):");
                Rate = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Time Period (in years):");
                Duration = Convert.ToDouble(Console.ReadLine());
            }

            public void CalculateAndDisplayInterest()
            {
                double interest = (Balance * Rate * Duration) / 100;
                Console.WriteLine($"\nTotal Interest Earned: {interest}");

            }
        }
    }


