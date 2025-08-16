using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_oop
{
    class Bank
    {
        private string _fullname;
        private string _branchCode;
        private float _balance;
        private List<BankAccount> _accounts;
        public Bank(string fullname, string branchCode, float balance)
        {
            _fullname = fullname;
            _branchCode = branchCode;
            _balance = balance;
            _accounts = new List<BankAccount>();
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Full Name: {_fullname}");
            Console.WriteLine($"Branch Code: {_branchCode}");
            Console.WriteLine($"Balance: {_balance}");
        }

        public BankAccount SearchAccount(int accountNumber)
        {
            foreach (var account in _accounts)
            {
                if (account.accountNumber == accountNumber)
                {
                    return account;
                }
            }
            return null;
        }
    }
}
