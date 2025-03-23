using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FundamentalsCSharp;

namespace AccessSpecifiersEx
{
    internal class Fifth:AccessSpecifiers
    {
        static void Main(string[] args)
        {
            Fifth acsobj5 = new Fifth();
            acsobj5.ProtectedInternalMethod();
            acsobj5.ProtectedMethod();
            acsobj5.PublicMethod();
            //acsobj5.PrivateMethod();
            //acsobj5.InternalMethod();

        }
    }
}
