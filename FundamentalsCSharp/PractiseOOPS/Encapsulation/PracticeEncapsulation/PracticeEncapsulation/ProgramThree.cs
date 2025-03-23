using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeEncapsulation
{
     class ProgramThree
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.SetName("David");
            student.SetRollno(7);
            student.setMarks(69.69);

            Console.WriteLine(student.GetName());
            Console.WriteLine(student.GetRollNo());
            Console.WriteLine(student.GetMarks());
            
            Student stud = new Student();
            //stud.SetName("");
            Console.WriteLine("---------");
            Console.WriteLine(stud.GetName());
            Console.WriteLine(stud.GetRollNo());
            Console.WriteLine(stud.GetMarks());
            Console.WriteLine("---------");
        }

        class Student
        {
            private string? name;
            private int rollno;
            private double marks;

            public void SetName(string name)
            {
                if(string.IsNullOrWhiteSpace(name) || name == null)
                {
                    Console.WriteLine("Name cannot be null or whitespace or blank");
                }
                else
                {
                    this.name = name;
                }
            }

            public void SetRollno(int rollno)
            {
                if(rollno <= 0)
                {
                    Console.WriteLine("Roll number cannot be negative or zero");

                }
                else
                {
                    this.rollno = rollno;
                }
            }

            public void setMarks(double marks)
            {
                if(marks <0 && marks> 100)
                {
                    Console.WriteLine("Invalid marks, should be between 0 and 100");
                }
                else
                {
                    this.marks = marks;
                }
            }

            public string GetName()
            {
                return name;
            }

            public int GetRollNo()
            {
                return rollno;
            }

            public double GetMarks()
            {
                return marks;   
            }
        }
    }
}
