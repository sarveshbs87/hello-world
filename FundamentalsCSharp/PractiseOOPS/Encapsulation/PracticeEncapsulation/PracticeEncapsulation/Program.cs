namespace PracticeEncapsulation
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            try {
                Bank bank = new Bank();

                bank.Amount = 100;
                Console.WriteLine(bank.Amount);

                bank.Amount = -150;
                //Console.WriteLine(bank.Amount);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }

    public class Bank
        {
            private int amount;

            public int Amount
            {
                get
                {
                    return amount;
                }
                set
                {
                    if (value > 0)
                    {
                        amount = value;
                    }
                    else
                    {
                        throw new Exception("Please pass a positive value");
                    }
                }
            }
            
        }
}
