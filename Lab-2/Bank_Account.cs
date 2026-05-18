using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Bank_Account
    {
        int AccountNo;
        string User_Name;
        string Account_Type;
        int Account_Balance;

        public void GetAccountDetails(int i)
        {
            Console.WriteLine("the data of account holder" + i+"are:");
            Console.WriteLine("enter account holder AccountNo: ");
            AccountNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your name: ");
            User_Name = Console.ReadLine();
            Console.WriteLine("enter the your Account type: ");
            Account_Type = Console.ReadLine();
            Console.WriteLine("enter the account balance : ");
            Account_Balance = Convert.ToInt32(Console.ReadLine());

        }
        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account no: " + AccountNo);
            Console.WriteLine("Name: " + User_Name);
            Console.WriteLine("Account_Type: " + Account_Type);
            Console.WriteLine("Account_Balance " + Account_Balance);
            
        }
    }
}
