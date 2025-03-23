using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCSharp
{
    class Parent
    {
        public virtual void Print()
        {
            Console.WriteLine("This is the Print method from the Parent class");
        }

        public void Show()
        {
            Console.WriteLine("This is the Show Method");
        }
    }

    class Child: Parent
    {
        public override void Print()
        {
            Console.WriteLine("This is the Print Method from the Child class");
        }

        public void Display()
        {
            Console.WriteLine("This is the Display Method");
        }
    }
    class MethodOverriding
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            Parent child = new Child();

            //Child child1 = new Parent();

            parent.Print();
            parent.Show();

            child.Print();
            //child.Display();
            Console.ReadKey();
        }
    }
}
