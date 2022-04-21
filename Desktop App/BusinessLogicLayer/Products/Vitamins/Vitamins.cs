using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Vitamins : Product
    {
        private VitaminFlavour flavour;
        private Goal goal;

        public VitaminFlavour Flavour { get { return flavour; } set { flavour = value; } }
        public Goal Goal { get { return goal; } set { goal = value; } }

        public Vitamins(string name, string brand, string description, ProductType productType, decimal price, byte[] image, VitaminFlavour flavour, Goal goal) : base(name, brand, description, productType, price, image)
        {
            this.flavour = flavour;
            this.goal = goal;
        }

        public Vitamins(int id, string name, string brand, string description, ProductType productType, decimal price, byte[] image, VitaminFlavour flavour, Goal goal) : base(id, name, brand, description, productType, price, image)
        {
            this.flavour = flavour;
            this.goal = goal;
        }

        //TODO inheritance of product and displaying different kinds of products
    }
}
