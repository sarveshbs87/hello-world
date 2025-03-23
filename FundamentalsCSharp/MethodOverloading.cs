using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCSharp
{
    internal class MethodOverloading
    {
        double SI, rate, princ,time;

        public MethodOverloading()
        {
            this.time = 12;
            this.princ = 100000;
            this.rate = 8;
        }

        public void calcSI()
        {
            SI = (princ * time * rate) / 100;
            Console.WriteLine($"PRINCIPAL:{princ}");
            Console.WriteLine($"TIME:{time} months");
            Console.WriteLine($"RATE OF INTEREST:{rate}");
            Console.WriteLine($"The value of SI is {SI}");
        }

        public void calcSI(double rate,double time)
        {
            SI = (princ * time * rate) / 100;
            Console.WriteLine($"PRINCIPAL:{princ}");
            Console.WriteLine($"TIME:{time} months");
            Console.WriteLine($"RATE OF INTEREST:{rate}");
            Console.WriteLine($"The value of SI is {SI}");
        }

        public void calcSI(double princ, double rate, double time)
        {
            SI = (princ * time * rate) / 100;
            Console.WriteLine($"PRINCIPAL:{princ}");
            Console.WriteLine($"TIME:{time} months");
            Console.WriteLine($"RATE OF INTEREST:{rate}");
            Console.WriteLine($"The value of SI is {SI}");
        }
    }

    class MainMethodPoly
    {
        static void Main(string[] args)
        {
            MethodOverloading metovd = new MethodOverloading();
            metovd.calcSI();
            metovd.calcSI(8.5, 24);
            metovd.calcSI(2000000, 7, 60);
            Console.ReadKey();
        }
    }
}
