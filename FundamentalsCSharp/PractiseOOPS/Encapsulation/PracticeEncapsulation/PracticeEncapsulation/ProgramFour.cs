using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticeEncapsulation
{
    class ProgramFour
    {
        static void Main(string[] args)
        {
            try {
                Product product1 = new Product();
                product1.SetName("Toys");
                product1.SetQuantity(1);
                product1.SetPrice(2500);

                Product product2 = new Product();
                product1.SetName("");
                product1.SetQuantity(1);
                product1.SetPrice(-2500);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }

    class Product
    {
        private string? name;
        private double price;
        private double quantity;

        
        public void SetName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                this.name = name;
                Console.WriteLine($"The name of the product is {name}");
            }
            else
            {
                throw new Exception("Invalid product name, cannot be null or empty.");
            }
        }

        public void SetPrice(double price)
        {
            if(price <= 0)
            {
                throw new ArgumentException("Price cannot be zero or negative");
            }
            else
            {
                this.price = price;
                Console.WriteLine($"The price is {price}");

            }
        }

        public void SetQuantity(double quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Quantity cannot be zero or negative");
            }
            else
            {
                this.quantity = quantity;
                Console.WriteLine($"Number of units: {quantity}");
            }
        }
    }
}
