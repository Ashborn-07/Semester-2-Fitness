using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Product
    {
        protected int id;
        protected string name;
        protected string brand;
        protected string description;
        protected decimal price;
        protected ProductType productType;
        protected byte[] image;

        public int ID { get { return id; } }
        public string Name { get { return name; } set { name = value; } }
        public string Brand { get { return brand; } set { brand = value; } }
        public string Description { get { return description; } set { description = value; } }
        public decimal Price { get { return price; } set { price = value; } }
        public ProductType Type { get { return productType; } set { productType = value; } }
        public byte[] Image { get { return image; } set { image = value; } }

        public Product(string name, string brand, string description, ProductType productType, decimal price, byte[] image)
        {
            this.name = name;
            this.brand = brand;
            this.description = description;
            this.productType = productType;
            this.price = price;
            this.image = image;
        }

        //TODO inheritance of product and displaying different kinds of products
        public Product(int id, string name, string brand, string description, ProductType productType, decimal price, byte[] image)
        {
            this.id = id;
            this.name = name;
            this.brand = brand;
            this.description = description;
            this.productType = productType;
            this.price = price;
            this.image = image;
        }
    }
}
