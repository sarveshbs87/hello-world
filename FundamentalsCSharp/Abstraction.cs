using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCSharp
{
    public abstract class Bank
    {
        public abstract void GetMiniStatement();
        public abstract void CheckBalance();
        public abstract void Withdraw();
    }

    class SBI : Bank
    {
        public override void GetMiniStatement()
        {
            Console.WriteLine("This is the statement of SBI account"); ;
        }

        public override void CheckBalance()
        {
            Console.WriteLine("This is the balance in the SBI account");
        }

        public override void Withdraw()
        {
            Console.WriteLine("Amount has been withdrawn from the SBI account");
        }
    }

    class HDFC : Bank
    {
        public override void GetMiniStatement()
        {
            Console.WriteLine("This is the statement of HDFC account"); ;
        }

        public override void CheckBalance()
        {
            Console.WriteLine("This is the balance in the HDFC account");
        }

        public override void Withdraw()
        {
            Console.WriteLine("Amount has been withdrawn from the HDFC account");
        }
    }

    public class BankRepo
    {
        public static Bank GetBankDetails(string BankATMType)
        {
            Bank bank = null;
            if (BankATMType == "SBI")
                bank = new SBI();
            else if (BankATMType == "HDFC")
                bank = new HDFC();

            return bank;
        }
    }
    internal class Abstraction
    {
        static void Main(string[] args)
        {
            Bank sbiBank = BankRepo.GetBankDetails("SBI");
            //Bank sbiBank = new SBI();
            sbiBank.CheckBalance();
            sbiBank.Withdraw();
            sbiBank.GetMiniStatement();

            Bank hdfcBank = BankRepo.GetBankDetails("HDFC");
            //Bank hdfcBank = new HDFC();
            hdfcBank.CheckBalance();
            hdfcBank.Withdraw();
            hdfcBank.GetMiniStatement();

            Console.ReadKey();
        }
    }
}
