using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEncapsulation
{
    class ProgramTwo
    {
        static void Main(string[] args)
        {
            BankAccount bankacc1 = new BankAccount("12250923",25000);

            bankacc1.DisplayAccountDetails();
            bankacc1.Deposit(2500);
            bankacc1.GetBalance();
            bankacc1.Withdraw(500);
            bankacc1.GetBalance();

            //bankacc1.acc_no = "23456";
        }
    }

    class BankAccount
    {
        private string acc_no;
        private decimal acc_bal;

        //public string AccountNumber
        //{
        //    get { return acc_no; }
        //    set { acc_no = value; }
        //}

        //public decimal Balance
        //{
        //    get { return acc_bal; }
        //    set { acc_bal = value; }
        //}

        public BankAccount(string acc_no,decimal init_bal=0)
        {
            this.acc_no = acc_no;
            if (init_bal >= 0)
            {
                acc_bal = init_bal;

            }
            else
            {
                throw new ArgumentException("Balance cannot be negative");
            }
                
        }

        public void GetBalance()
        {
            Console.WriteLine($"Balance: {acc_bal}");
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Console.WriteLine($"Deposit Amount: {amount}");
                acc_bal += amount;
            }
            else
            {
                Console.WriteLine("Deposit Amount should be positive");
            }

        }

        public void Withdraw(decimal amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive");
            }

            else if(amount > acc_bal)
            {
                Console.WriteLine("Insufficient funds");
            }

            else
            {
                acc_bal -= amount;
                Console.WriteLine($"Amount withdrawn: {amount}");
            }
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {acc_no}\nBalance: {acc_bal}");
        }
    }
}
