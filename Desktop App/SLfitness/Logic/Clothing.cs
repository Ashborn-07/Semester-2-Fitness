﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLfitness
{
    public class Clothing : Product
    {
        private ClothType type;

        public Clothing(string name, string brand, string description, double price) : base(name, brand, description, price)
        {
        }

        //TODO inheritance of product and displaying different kinds of products
    }
}