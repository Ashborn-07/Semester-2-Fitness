﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLfitness
{
    public class HealthyDiet : Diet
    {
        private int carbs;

        public HealthyDiet(string name, string desription, int calories, int fat, int chef, byte[] image, int carbs) : base(name, desription, calories, fat, chef, image)
        {
            this.carbs = carbs;
        }

        public int Carbs { get { return carbs; } }
    }
}
