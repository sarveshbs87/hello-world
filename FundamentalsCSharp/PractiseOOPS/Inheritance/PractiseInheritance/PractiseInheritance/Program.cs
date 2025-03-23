namespace PractiseInheritance
{
    internal class Program
    {
        class A
        {
            public A()
            {
                Console.WriteLine("A Constructor zero parameter");
            }

            public A(int x)
            {
                Console.WriteLine("A Constructor one parameter");
            }
        }

        class B : A
        {

            public B(int z) : base()
            {
                Console.WriteLine("B Constructor one parameter");
            }
            public B(int a, int b) : base(10)
            {
                Console.WriteLine("B Constructor two parameters");
            }
        }
        class C : B
        {
            public C() : base(20, 30)
            {
                Console.WriteLine("C Constructor zero parameter");

            }

            public C(int d) : base(10)
            {
                Console.WriteLine("C Constructor one parameter");
            }

            static void Main(string[] args)
            {
                //C obj = new C(10);
                A obja = new B(10);
                Console.ReadKey();
                
                //B objb = new A();
            }
        }
    }
}
