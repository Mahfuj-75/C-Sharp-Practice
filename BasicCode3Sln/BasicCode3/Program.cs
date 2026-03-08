using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode3
{
    class Account
    {
        private double balance;
        public void Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount <= balance)
                balance -= amount;
        }
        public double GetBalance()
        {
            return balance;
        }
    }
    
    internal class Program
    {
    
        static void Main(string[] args)
        {
            Account acc = new Account();
            acc.Deposit(1000);
            acc.Withdraw(500);
            Console.WriteLine("Balance: " + acc.GetBalance());
        }
    }
}
