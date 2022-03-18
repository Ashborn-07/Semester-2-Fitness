using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLfitness
{
    public class Product
    {
        protected string name;
        protected string brand;
        protected string description;
        protected double price;
        protected ProductType vitaminType;


        public string Name { get { return name; } set { name = value; } }
        public string Brand { get { return brand; } set { brand = value; } }
        public string Description { get { return description; } set { description = value; } }
        public double Price { get { return price; } set { price = value; } }

        public Product(string name, string brand, string description, double price)
        {
            this.name = name;
            this.brand = brand;
            this.description = description;
            this.price = price;
        }

        //TODO inheritance of product and displaying different kinds of products
    }
}
