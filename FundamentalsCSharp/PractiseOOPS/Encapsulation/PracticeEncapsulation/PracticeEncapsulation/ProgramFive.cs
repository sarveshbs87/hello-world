using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEncapsulation
{
    //Employee Data:
    //Create a class Employee with private fields for Name, ID, and Salary.
    //Add methods to allow controlled access to these fields, e.g., only allow a salary increase but not direct modification.
    class ProgramFive
    {
    }

    class Employee
    {
        private string _name;
        private int _id;
        private double _salary;

        public Employee(string name,int id,double salary)
        {
            _name = name;
            _id = id;
            _salary = salary;
        }

        public string GetName()
        {
            return _name;
        }

        public int GetID()
        {
            return _id;
        }

        public double GetSalary()
        {
            return _salary;
        }
    }
}