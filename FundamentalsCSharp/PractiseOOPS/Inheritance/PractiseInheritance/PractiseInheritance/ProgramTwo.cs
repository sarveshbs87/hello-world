using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a Basic Class Hierarchy:
//Create a base class Vehicle with properties like Make and Model and methods like Drive().
//Derive classes like Car and Motorcycle from Vehicle.
//Add specific methods to the derived classes, such as Honk() for Car and RevEngine() for Motorcycle.

namespace PractiseInheritance
{
    class ProgramTwo
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", "Corolla");
            car.Drive();
            car.Honk();

            Motorcycle motorcycle = new Motorcycle("Yamaha", "R1");
            motorcycle.Drive();
            motorcycle.Rev();
        }
    }

    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }


        public Vehicle(string Make,string Model)
        {
            this.Make = Make;
            this.Model = Model;
        }


        public void Drive()
        {
            Console.WriteLine($"We are now driving the {Make} {Model}");
        }
    }

    public class Car : Vehicle
    {
        public Car(string Make, string Model) : base(Make, Model)
        {
        }

        public void Honk()
        {
            Console.WriteLine($"The {Make} {Model} is honking");
        }
    }

    public class Motorcycle: Vehicle
    {
        public Motorcycle(string Make,string Model) : base(Make, Model)
        {

        }
        public void Rev()
        {
            Console.WriteLine($"The {Make} {Model} is revving");
        }
    }
}
