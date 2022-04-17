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

        public Goal Goal { get { return goal; } }

        public Protein(string name, string brand, string description, double price, Goal goal) : base(name, brand, description, price)
        {
            this.goal = goal;
        }

        //TODO inheritance of product and displaying different kinds of products
    }
}
