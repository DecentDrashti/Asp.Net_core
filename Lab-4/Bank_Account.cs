using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public  class Bank_Account
    {
        int initialBalance;
        string AccountHolderName;

        public Bank_Account()
        {
         }
        public Bank_Account(int amount,string name) 
        {
            this.initialBalance = amount;
            this.AccountHolderName = name;
        }
        public int cash(int money)
        {
            return initialBalance+money;
        }
        public int cash(int money, int initialBalance) 
        {
            return initialBalance - money;
        }
        
    }
}
