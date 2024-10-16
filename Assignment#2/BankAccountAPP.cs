using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace bankaccount
{
    internal class BankAccountAPP
    {
        //I use 'try' and 'catch' for each invalid case to make sure program keep running.
        static void Main(string[] args)
        {
            //default case
            try
            {
                BankAccount accountJohnC = new BankAccount("12345", "John", "C", 50.00);
                accountJohnC.deposit(10.00);
                accountJohnC.deposit(50.00);
                accountJohnC.deposit(10.00);
                accountJohnC.deposit(70.00);
                accountJohnC.withdraw(100.00);
                accountJohnC.LastName = "Cool";
                Console.WriteLine("John's account info:" + accountJohnC.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            Console.WriteLine("************************************************************");
            try
            {
                BankAccount account1 = new BankAccount();
                account1.ID = "1234K";
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            try
            {
                BankAccount account1 = new BankAccount();
                account1.FirstName = "";
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            try
            {
                BankAccount account1 = new BankAccount();
                account1.LastName = "Account1";
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            try
            {
                BankAccount account1 = new BankAccount();
                account1.ID = "12346";
                account1.FirstName = "Test";
                account1.LastName = "Account";
                Console.WriteLine("Testing: " + account1.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            Console.WriteLine("************************************************************");
            try
            {
                BankAccount account2 = new BankAccount("54321", "Jinyu", "Liu");
                account2.setBalance(-100);
            } 
            catch (Exception e) {
                Console.WriteLine("Exception: " + e.Message);
            }
            try
            {
                BankAccount account2 = new BankAccount("54321", "Jinyu", "Liu");
                account2.deposit(-100);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            try
            {
                BankAccount account2 = new BankAccount("54321", "Jinyu", "Liu");
                account2.withdraw(-100);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            try
            {
                BankAccount account2 = new BankAccount("54321", "Jinyu", "Liu");
                account2.withdraw(10000000);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            try
            {
                BankAccount account2 = new BankAccount("54321", "Jinyu", "Liu");
                account2.setBalance(5000);
                account2.deposit(1001);
                account2.withdraw(500);
                account2.getNumOfTransactions();
                Console.WriteLine("Jinyu's account info:" + account2.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Auto message: Code has been executed");
            }
            Console.ReadKey();
         }
    }
}
