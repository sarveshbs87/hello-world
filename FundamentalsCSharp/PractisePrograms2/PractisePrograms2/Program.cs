using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;

namespace PractisePrograms2
{
    internal class Program
    {
        public string name = "Sarvesh";
        public int age = 36;
        public string place = "Bengaluru";

        int num1, num2, temp;
        public void swap(int num1,int num2)
        {
            //Console.WriteLine("Enter the first number");
            //num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number");
            //num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Before swapping, the first number is {num1} and the second number is {num2}");
            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"After swapping, the first number is {num1} and the second number is {num2}");
        }

        public void returnSomething(string awordline)
        {
            Console.WriteLine($"Something {awordline}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program prg = new Program();
            //Console.WriteLine($"My name is {prg.name}, I am {prg.age} years old and I live in {prg.place}");
            //prg.swap(6,10);
            //prg.AddTwoNums(11, 12);
            //prg.NumIncrement(25);
            //prg.returnSomething("Yes it is!");
            //bool abool = prg.flipBool(true);
            //Console.WriteLine(abool);

            int[] ansArr = prg.arrOfMultiples(7, 12);
            //foreach(int item in ansArr)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(string.Join(", ",ansArr));
            //Console.WriteLine(prg.reverseCase("whEreThEreisaWILLtherIsaWay"));
            Console.WriteLine( prg.Bomb("Well something goes boom!"));
            Console.ReadLine();
        
        }

        public void AddTwoNums(int a, int b)
        {
            Console.WriteLine($"The sum of {a} and {b} is {a + b}"); ;
        }

        public void NumIncrement(int incanum)
        {
            Console.WriteLine($"THe increment of {incanum} is {incanum+1}");
        }

        public bool flipBool(bool a)
        {
            if (a == true) 
                return false;
            else
                return true;
        }
            
        public int[] arrOfMultiples(int num,int length)
        {
            int[] multiples = new int[length];
            for(int i = 0; i < length; i++)
            {
                multiples[i] = num * (i+1);
            }

            return multiples;
        }

        public string reverseCase(string astr)
        {
            //string astr = "IamtheChampion";
            char[] charstring = astr.ToCharArray();

            StringBuilder sbstring = new StringBuilder();
            foreach (char ch in charstring)
            {
                if(char.IsUpper(ch))
                    sbstring.Append(char.ToLower(ch));
                else
                    sbstring.Append(char.ToUpper(ch));

            }
            return sbstring.ToString();
        }

        public string Bomb(string bombstr)
        {
            string testbomb = bombstr.ToLower();
            if (testbomb.Contains("bomb"))
                return "Duck!!!";
            else
                return "Relax there is no Bomb!";
        }

        

        


        
}
}
