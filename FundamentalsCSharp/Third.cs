using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCSharp
{
    internal class Third:AccessSpecifiers
    {
        static void Main(string[] args)
        {
            Third acsobj3 = new Third();
            //acsobj3.PrivateMethod();
            acsobj3.PublicMethod();
            acsobj3.ProtectedMethod();
            acsobj3.InternalMethod();
            acsobj3.ProtectedInternalMethod();

            Console.ReadKey();

        }
    }
}
