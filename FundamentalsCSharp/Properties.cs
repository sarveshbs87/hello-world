using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalsCSharp
{
    class Properties
    {
        double _radius = 3.14;
        private int _ID;
        private string _Name;
        private int _PassMark = 35;

        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("ID  can not be a non negative value");
                }
                _ID = value;
            }
        }

        public string Name
        {
            get
            {
                return string.IsNullOrEmpty(_Name) ? "No Name" : _Name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name should not be empty");
                }
                _Name = value;
            }
        }

        public int PassMark
        {

            get
            {
                return _PassMark;
            }
        }
        public double Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }

    }

    class PropertiesMain
    {
        static void Main(string[] args)
        {
            Properties propObj = new Properties();
            //propObj._radius = 3.15;
            Console.WriteLine($"The original value of radius is {propObj.Radius}");
            propObj.Radius = 3.15;
            Console.WriteLine($"The modified value of radius is {propObj.Radius}");


            //propObj.Name = "David";
            //propObj.Name;
            propObj.ID = 25;
            Console.WriteLine("-----STUDENT DETAILS");
            Console.WriteLine($"NAME: {propObj.Name}");
            Console.WriteLine($"ID: {propObj.ID}");
            Console.WriteLine($"Passing Marks: {propObj.PassMark}");
            Console.ReadKey();
        }
    }
}
