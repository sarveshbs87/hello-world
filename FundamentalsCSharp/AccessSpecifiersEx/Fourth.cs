using FundamentalsCSharp;

namespace AccessSpecifiersEx
{
    internal class Fourth:AccessSpecifiers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            AccessSpecifiers  acsobj4 = new AccessSpecifiers();

            acsobj4.PublicMethod();

        }
    }
}
