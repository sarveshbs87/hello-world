namespace ConstructorsEx
{
    internal class ConstructorDemo
    {
        int empID;
        string empName;
        string empLoc;
        
        public ConstructorDemo()
        {
            empID = 03;
            empName = "Krishna";
            empLoc = "Dwaraka";
        }

        public ConstructorDemo(int empID, string empName,string empLoc)
        {
            this.empID = empID;
            this.empName = empName;
            this.empLoc = empLoc;
        }

        public ConstructorDemo(int empID)
        {
            this.empID = empID;
            empName = "GuestCandidate";
            empLoc = "Bengaluru";

        }

        public ConstructorDemo(ConstructorDemo demo)
        {
            this.empID = demo.empID;
            this.empName = demo.empName;
            this.empLoc = demo.empLoc;

        }

        static ConstructorDemo()
        {
            Console.WriteLine("This is a static constructor");
        }
        
        public void PrintDetails()
        {
            Console.WriteLine("-------EMP DETAILS------");
            Console.WriteLine($"EMP NAME: {empName}");
            Console.WriteLine($"EMP ID: {empID}");
            Console.WriteLine($"EMP LOCATION: {empLoc}");
        }
        static void Main(string[] args)
        {
            ConstructorDemo demo1 = new ConstructorDemo();
            //ConstructorDemo demo2 = new ConstructorDemo(99,"Sarvesh","Ooty");
            //ConstructorDemo demo3 = new ConstructorDemo(001);
            //ConstructorDemo demo4 = new ConstructorDemo(demo1);
            //demo1.PrintDetails();
            //demo2.PrintDetails();
            //demo3.PrintDetails();
            demo1.PrintDetails();
            Console.ReadKey();
        }
    }
}
