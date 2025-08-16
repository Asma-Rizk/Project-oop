using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_oop
{
    class BankAccount
    {
        public int accountNumber { get; set; }
        public float balance { get; set; }
        public float amount { get; set; }

        public BankAccount(int accountNumber, float balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
            this.amount = 0; 
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Balance: {balance}");
            Console.WriteLine($"Amount: {amount}");
        }

        public void Deposit(float amount) // Change parameter type to float  
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }

        public void Withdraw(float amount) // Change parameter type to float  
        {
            if (amount > balance)
            {
                Console.WriteLine("Balance Not Enough");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}");
            }
        }
    }
    internal class savingsAccount : BankAccount
    {
        public float interestRate { get; set; }
        public savingsAccount(int accountNumber, string v, float balance, float interestRate) : base(accountNumber, balance)
        {
            this.interestRate = interestRate;
        }
        public void CalculateInterest()
        {
            float interest = balance * interestRate / 100;
            Console.WriteLine($"Interest: {interest}");
            balance += interest;
        }
    }
    internal class currentAccount : BankAccount
    {
        public float overdraftLimit { get; set; }
        public currentAccount(int accountNumber, float balance, float overdraftLimit) : base(accountNumber, balance)
        {
            this.overdraftLimit = overdraftLimit;
        }
        public new void Withdraw(float amount) // Override Withdraw method
        {
            if (amount > balance + overdraftLimit)
            {
                Console.WriteLine("Overdraft limit exceeded");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}");
            }
        }
    }
}
