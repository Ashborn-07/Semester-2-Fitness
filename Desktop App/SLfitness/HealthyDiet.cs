using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLfitness
{
    public class HealthyDiet : Diet
    {
        private int carbs;

        public HealthyDiet(string name, string desription, int calories, int fat, int chef, byte[] image, int carbs, string type) : base(name, desription, calories, fat, chef, image, type)
        {
            this.carbs = carbs;
        }

        public int Carbs { get { return carbs; } }
    }
}
