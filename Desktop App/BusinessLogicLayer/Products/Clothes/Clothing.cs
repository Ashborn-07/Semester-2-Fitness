using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Clothing : Product
    {
        private ClothType type;
        private ClothSize size;

        public ClothType ClothType { get { return type; } set { this.type = value; } }
        public ClothSize ClothSize { get { return size; } set { size = value; } }

        public Clothing(string name, string brand, string description, decimal price, ProductType productType, byte[] image, ClothType type, ClothSize size) : base(name, brand, description, productType, price, image)
        {
            this.type = type;
            this.size = size;
        }

        public Clothing(int id, string name, string brand, string description, decimal price, ProductType productType, byte[] image, ClothType type, ClothSize size) : base(id, name, brand, description, productType, price, image)
        {
            this.type = type;
            this.size = size;
        }

        //TODO inheritance of product and displaying different kinds of products
    }
}
