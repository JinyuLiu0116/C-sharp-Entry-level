using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Assignment3
{   
    //make class public
    public class BanckAcount
    {
        private string ownerName;
        //use Guid class to assgin a unique identifier to account number
        private Guid acountNum;
        private decimal balance;

        public BanckAcount(in string ownerName)
        {
            OwnerName = ownerName;
            AcountNum = Guid.NewGuid();
            Balance = 0; //new account with 0 money.
        }
        public string OwnerName
        {
            get
            {
                return this.ownerName;
            }
            set { 
                this.ownerName = value;
            }
        }
        public Guid AcountNum
        {
            get
            {
                return this.acountNum;
            }
            set
            {
                this.acountNum = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            //make seter private to enable change balance throw balance propity
            private set
            {
                this.balance = value;
            }
        }
        public string Deposit(in decimal amount)
        {
            if (amount <= 0)//cannot allow deposit negative or zero value
            {
                return "You cannot deposit $" + amount;
            }
            else if (amount > 10000)//set a limit number for deposit
            {
                return "Reached deposit limit";
            }
            else
             {   
                Balance += amount;
                return "Deposit successful";
            }
        }
        public string Withdraw(in decimal amount)
        {
            if (amount <= 0)//cannot allow withdraw negative or zero value
            {
                return "You cannot withdraw $" + amount;
            }
            else if(amount > Balance)//not allow to withdraw the value more than balance
            {
                return "You don't have enough money";
            }
            else if (amount > 1000)//set a limit number for withdraw
            {
                return "Reached withdraw limit";
            }
            else
            {
                Balance -= amount;
                return "Withdraw successful";
            }
        }
    }
}

