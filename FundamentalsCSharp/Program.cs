namespace FundamentalsCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            AStaticClass.DoSomething();
            //AStaticClass obj = new AStaticClass();
            ANonStaticClass.DoSomethingAgain();
            ANonStaticClass obj = new ANonStaticClass();
            obj.DoAnotherThing();
            //ANonStaticClass.aa;
            AbsChild childobj = new AbsChild();
            childobj.Add(4, 5);
            childobj.Sub(5, 10);
            childobj.Div(5, 10);
            childobj.Mulp(5, 10);

            PartialEmployee emp = new PartialEmployee()
            {
                FirstName = "Rukmini",
                LastName = "Rama",
                Title = "Manager",
                Gender = "Female"
            };

            emp.DisplayEmployeeName();
            emp.DisplayEMployeeDetails();

            Printer prone = new Printer();
            prone.Display();
            prone.Print();

            Laserjet prtwo = new Laserjet();
            prtwo.Display();
            prtwo.Print();

            Inkjet prthree = new Inkjet();
            prthree.Display();
            prthree.Print();

            Console.ReadLine();


        }
    }

    static class AStaticClass
    {
        static int a;
        static int b;

        public static void DoSomething()
        {
            a = 1;
            b = 2;
            Console.WriteLine($"A is {a} and B is {b}");

        }

    }

    class ANonStaticClass
    {
        public int aa;
        public static int bb;

        public static void DoSomethingAgain()
        {
            //ANonStaticClass.aa = 25;
            bb = 50;
            Console.WriteLine($"The value of a non static member(A) cannot be accessed from a static method and B is {bb}");
        }

        public void DoAnotherThing()
        {
            aa = 25;
            bb = 35;
            Console.WriteLine($"A non static method can access both static B({bb}) and non static A({aa}) variables");
        }
    }

    public abstract class AbsClass
    {
        public void Add(int x, int y)
        {
            Console.WriteLine($"Addition of {x} and {y} is {x + y}");
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine($"Differnece between {x} and {y} is {x - y}");
        }

        public abstract void Mulp(int x, int y);
        public abstract void Div(int x, int y);
    }

    public class AbsChild : AbsClass
    {
        public override void Mulp(int x, int y)
        {
            Console.WriteLine($"Multiplication of {x} and {y} is {x * y}");
        }

        public override void Div(int x, int y)
        {
            Console.WriteLine($"Division of {x} and {y} is {x / y}");
        }
    }

    public partial class PartialEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
    }

    public partial class PartialEmployee
    {
        public void DisplayEmployeeName()
        {
            Console.WriteLine($"The full name of the employee is {FirstName} {LastName}");
        }

        public void DisplayEMployeeDetails()
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine("----------------");
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Designation: {Title}");
            Console.WriteLine($"Gender: {Gender}");
        }
    }

    public class Printer
    {
        public virtual void Display()
        {
            Console.WriteLine("Display Dimension : 5*5");
        }

        public virtual void Print()
        {
            Console.WriteLine("Printer Printing.....");
        }
    }

    public class Laserjet : Printer
    {
        public sealed override void Display()
        {
            Console.WriteLine("Display Dimension : 10*10");
        }

        public override void Print()
        {
            Console.WriteLine("Laser Jet Printer Printing.....");
        }
    }

    public sealed class Inkjet : Laserjet
    {
        /*public override void Display()
        {

        }*/

        public override void Print()
        {
            Console.WriteLine("Ink Jet Printer Printing.....");
        }
    }
}
