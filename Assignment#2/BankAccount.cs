using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bankaccount
{
    internal class BankAccount
    {
        private string id;      
        private string firstName;
        private string lastName;
        private double balance;
        private int numOfTransactions;

        public BankAccount()
        {
            this.id = "Unknown";
            this.firstName = "Unknown";
            this.lastName = "Unknown";
            this.balance = 0.0;
            this.numOfTransactions = 0;
        }
        //I use 'in' keyword to pass the read_only referents to make program more efficiency
        public BankAccount(in string id, in string firstName, in string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.balance = 0.0;
            this.numOfTransactions = 0;
        }
        public BankAccount(in string id, in string firstName, in string lastName, in double balance)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.setBalance(balance);
            this.numOfTransactions = 0;
        }
        // use proprety with some logic to the set accessor
        // The output statements are meant to help testing in APP file
        public string ID
        {
            get
            {
                return this.id;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) {
                    Console.WriteLine("You entered ID: " + value);
                    throw new Exception("Empty input");
                }
                else if(!int.TryParse(value, out _))
                {
                    Console.WriteLine("You entered ID: " + value);
                    throw new Exception("Include none number value");
                }
                else
                    this.id = value;
            }
        }
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {

                    Console.WriteLine("You entered first name: " + value);
                    throw new Exception("Empty input");
                }
                else if (!value.All(char.IsLetter))
                {
                    Console.WriteLine("You entered first name: " + value);
                    throw new Exception("Invalid value");
                }
                else
                    this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You entered last name: " + value);
                    throw new Exception("Empty input");
                }
                else if (!value.All(char.IsLetter))
                {
                    Console.WriteLine("You entered last name: " + value);
                    throw new Exception("Invalid value");
                }
                else
                    this.lastName = value;
            }
        }
        //I only create getter for balance and only use constructor and other two methods to change value
        public double getBalance() { return this.balance; }
        //This setter for balance is used for constructor
        public void setBalance(in double balance)
        {
            if(balance < 0)
            {
                throw new Exception("Negative balance");
            }
            else
                this.balance = balance;
            Console.WriteLine("Balance: " + this.getBalance());
        }
        //I only create a getter for Transactions because I only use constructor and other two methods to change value
        public int getNumOfTransactions() { return this.numOfTransactions; }
       
        public void deposit(in double amount) {
            Console.WriteLine("Deposit: $" + amount);
            if (amount < 0)
            {
                throw new Exception("Negative value");
            }
            else if (amount > 1000)
            {
                throw new Exception("Cannot deposit more than S1000 at a time");
            }
            else
            {
                this.balance += amount;
                this.numOfTransactions++;
                Console.WriteLine("You have deposited $"+amount);
            }

        } 
        public void withdraw(in double amount) {
            Console.WriteLine("Withdraw: $" + amount);

            if (amount < 0)
            {
                throw new Exception("Negative value");
            }
            else if (amount > this.getBalance())
            {
                throw new Exception("Your account balance is not enough");
            }
            else
            {
                this.balance -= amount;
                this.numOfTransactions++;
                Console.WriteLine("You have withdrawed $" + amount);

            }
        }
        public override string ToString(){
            return "Account ID: " + this.ID + '\n'
                + "Name: " + this.FirstName + " " + this.LastName + '\n'
                + "Balance: $" + this.getBalance() + "\n"
                + "Transactions: " + this.getNumOfTransactions() + " time/times\n";
        }
    }
}

