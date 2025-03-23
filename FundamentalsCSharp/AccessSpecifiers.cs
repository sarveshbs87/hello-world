using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCSharp
{
    public class AccessSpecifiers
    {
        private void PrivateMethod()
        {
            Console.WriteLine($"This is a private method...");
        }

        public void PublicMethod()
        {
            Console.WriteLine($"This ia a public method...");
        }

        protected void ProtectedMethod()
        {
            Console.WriteLine($"This is a protected method...");
        }

        internal void InternalMethod()
        {
            Console.WriteLine($"This is an internal method...");
        }

        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine($"This is a protected internal method");
        }

        static void Main(string[] args)
        {
            AccessSpecifiers acsobj = new AccessSpecifiers();
            acsobj.PrivateMethod();
            acsobj.PublicMethod();
            acsobj.ProtectedMethod();
            acsobj.InternalMethod();
            acsobj.ProtectedInternalMethod();

            Console.ReadKey();
        }
    }
}
