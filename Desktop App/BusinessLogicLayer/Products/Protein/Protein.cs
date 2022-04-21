using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Protein : Product
    {
        private Goal goal;
        private string occurance;
        private ProteinFlavour flavour;

        public Goal Goal { get { return goal; } set { this.goal = value; } }
        public ProteinFlavour Flavour { get { return flavour; } set { this.flavour = value; } }
        public string Occurance { get { return occurance; } set { this.occurance = value; } }

        public Protein(string name, string brand, string description, ProductType productType, decimal price, byte[] image, Goal goal, string occurance, ProteinFlavour flavour) : base(name, brand, description, productType, price, image)
        {
            this.goal = goal;
            this.occurance = occurance;
            this.flavour = flavour;
        }

        public Protein(int id, string name, string brand, string description, ProductType productType, decimal price, byte[] image, Goal goal, string occurance, ProteinFlavour flavour) : base(id, name, brand, description, productType, price, image)
        {
            this.goal = goal;
            this.occurance = occurance;
            this.flavour = flavour;
        }

        //TODO inheritance of product and displaying different kinds of products
    }
}
