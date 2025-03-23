using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCSharp
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

        public B(int z):base()
        {
            Console.WriteLine("B Constructor one parameter");
        }
        public B(int a, int b):base(10)
        {
            Console.WriteLine("B Constructor two parameters");
        }
    }
    class C: B
    {
        public C():base (20,30)
        {
            Console.WriteLine("C Constructor zero parameter");

        }

        public C(int d):base(10)
        {
            Console.WriteLine("C Constructor one parameter");
        }

        static void Main(string[] args)
        {
            C obj = new C(10);
            Console.ReadKey();
        }
    }
}
