using System;
using System.Collections.Generic;

namespace project_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(new savingsAccount(1, "Asma", 5000, 3.5f));
            accounts.Add(new savingsAccount(2, "Kasem", 2000, 100f));
            accounts.Add(new savingsAccount(3, "Ali", 10000, 5000));
            accounts.Add(new savingsAccount(4, "Sara", 15000, 2000));

            Console.WriteLine("Bank Accounts:");
            foreach (var account in accounts)
            {
                account.DisplayDetails();
                Console.WriteLine();
            }

            // remove an account with account number 1
            accounts.RemoveAll(account => account.accountNumber == 1);

            Console.WriteLine("Bank Accounts after removal:");
            foreach (var account in accounts)
            {
                account.DisplayDetails();
                Console.WriteLine();
            }
            var bank= new Bank("my bank ","br001",0);

            savingsAccount s1 = new savingsAccount(1001, "Asmaa Rizk", 5000, 600);
            currentAccount c1 = new currentAccount(2001, 10000, 50000);
            bank.Equals(s1);
            bank.Equals(c1);

            Console.WriteLine("Bank Accounts after adding new accounts:");
            foreach (var account in accounts)
            {
                var research=bank.SearchAccount(account.accountNumber);
                //search for an account with account number 2001

                var result = bank.SearchAccount(2001);
                if (result != null)
                {
                    Console.WriteLine("Account found:");
                    result.DisplayDetails();
                }
                else
                {
                    Console.WriteLine("Account not found!");
                }

            }
        }
    }
}