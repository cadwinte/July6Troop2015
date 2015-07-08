using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClassTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer cust1 = new Customer()
            {
                CheckingAccount =
                {
                    AccountId = 111,
                    AccountType = "Checking",
                    AccountBalance = 100.00m,
                    IsOpen = true
                },

                SavingsAccount =
                {
                    AccountId = 222,
                    AccountType = "Savings",
                    AccountBalance = 0.00m,
                    IsOpen = false
                },

                CustomerName = "Alice Wonderberg"
            };
            Console.WriteLine(cust1.CheckingAccount.AccountId);
            Console.WriteLine(cust1.SavingsAccount.AccountId);
            Console.WriteLine(cust1.CustomerName);

            cust1.Transfer("Checking", "Savings", 5.00m);

            Console.WriteLine(cust1.CheckingAccount.AccountBalance);
            Console.WriteLine(cust1.SavingsAccount.AccountBalance);

            Console.ReadLine();
        }
    }
    enum AccountType
    {
        Checking,
        Savings
    }

    class Customer
    {
        public Customer()
        {
            CheckingAccount = new Account();
            SavingsAccount = new Account();
        }

        public string CustomerName { get; set; }

        public Account CheckingAccount { get; set; }
        public Account SavingsAccount { get; set; }

        public void Transfer(string accountFrom, string accountTo, decimal transAmount)
        {

            if (accountTo == "Savings" && accountFrom == "Checking")
            {
                CheckingAccount.AccountBalance -= transAmount;
                SavingsAccount.AccountBalance += transAmount;
            }
            else if (accountTo == "Checking" && accountFrom == "Savings")
            {
                SavingsAccount.AccountBalance -= transAmount;
                CheckingAccount.AccountBalance += transAmount;
            }

        }

        internal void Transfer()
        {
            throw new NotImplementedException();
        }
    }
    class Account
    {
        public int AccountId { get; set; }
        public string AccountType { get; set; }
        public decimal AccountBalance { get; set; }
        public bool IsOpen { get; set; }
    }
}











































            //string from = accountFrom;
            //string to = accountTo;
            //decimal amount = transAmount;

            //if (from == "Checking")
            //{
            //    accountFrom = CheckingAccount.AccountType;
            //}
            //else if (from == "Savings")
            //{
            //    accountFrom = SavingsAccount.AccountType;
            //}

            //if (to == "Checking")
            //{
            //    accountTo = CheckingAccount.AccountType;
            //}
            //else if (to == "Savings")
            //{
            //    accountTo = SavingsAccount.AccountType;
            //}

            //if (to == "Savings" && from == "Checking")
            //{
            //    CheckingAccount.AccountBalance -= amount;
            //    SavingsAccount.AccountBalance += amount;
            //}
            //else if (to == "Checking" && from == "Savings")
            //{
            //    SavingsAccount.AccountBalance -= amount;
            //    CheckingAccount.AccountBalance += amount;
            //}
