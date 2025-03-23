using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCSharp
{
    internal class Second
    {
        static void Main(string[] args)
        {
            AccessSpecifiers acsobj2 = new AccessSpecifiers();
            //acsobj2.PrivateMethod();
            acsobj2.PublicMethod();
            //acsobj2.ProtectedMethod();
            acsobj2.InternalMethod();
            acsobj2.ProtectedInternalMethod();
        }
    }
}
