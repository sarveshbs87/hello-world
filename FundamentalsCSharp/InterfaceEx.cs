using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCSharp
{
    interface IExample
    {
        void Display(int id, string name);
        void Show(int id, string name);
        void Hide(int id, string name);

    }

    interface IBank
    {
        void GetMiniStatement();
        void CheckBalance();
        void Withdraw();
    }

    public class HDFCI : IBank
    {
        public void GetMiniStatement()
        {
            Console.WriteLine("This is the statement from the HDFC bank account");
        }
        public void CheckBalance()
        {
            Console.WriteLine("This is the balance in the HDFC bank account");
        }
        public void Withdraw()
        {
            Console.WriteLine("This is the amount withdrawn from the HDFC bank account");
        }
    }

    public class SBII : IBank
    {
        public void GetMiniStatement()
        {
            Console.WriteLine("This is the statement from the SBI bank account");
        }
        public void CheckBalance()
        {
            Console.WriteLine("This is the balance in the SBI bank account");
        }
        public void Withdraw()
        {
            Console.WriteLine("This is the amount withdrawn from the SBI bank account");
        }
    }

    class BankRepoInt
    {
        public static IBank GetBankInfo(string bankname)
        {
            IBank bankObj = null;
            if (bankname == "SBI")
                bankObj = new SBII();
            else if (bankname == "HDFC")
                bankObj = new HDFCI();
            return bankObj;
        }
    }

    class InterfaceEx:IExample
    {
        public void Display(int id, string name) {
            Console.WriteLine($"This is the Display method--->>>ID: {id}........NAME:{name}");
        }
        
        public void Show(int id, string name)
        {
            Console.WriteLine($"This is the Show method--->>>ID: {id}........NAME:{name}");
        }

        public void Hide(int id, string name)
        {
            Console.WriteLine($"This is the Hide method--->>>ID: {id}........NAME:{name}");
        }

        static void Main(string[] args)
        {
            InterfaceEx intfObj = new InterfaceEx();
            intfObj.Display(12,"Rajkumar");
            //intfObj.Show(24,"Ravi");
            //intfObj.Hide(09,"Shankar");

            //
            /*
            IBank bankObj = new HDFCI();
            bankObj.GetMiniStatement();
            bankObj.CheckBalance();
            bankObj.Withdraw();

            IBank bankObj2 = new SBII();
            bankObj2.GetMiniStatement();
            bankObj2.CheckBalance();
            bankObj2.Withdraw();*/

            IBank banksbi = BankRepoInt.GetBankInfo("SBI");
            banksbi.GetMiniStatement();
            banksbi.CheckBalance();
            banksbi.Withdraw();

            IBank bankhdfc = BankRepoInt.GetBankInfo("HDFC");
            bankhdfc.GetMiniStatement();
            bankhdfc.CheckBalance();
            bankhdfc.Withdraw();

            Console.ReadKey();

        }
    }
}
