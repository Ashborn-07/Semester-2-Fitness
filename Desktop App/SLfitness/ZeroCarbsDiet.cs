using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLfitness
{
    internal class ZeroCarbsDiet : Diet
    {
        public ZeroCarbsDiet(string name, string desription, int calories, int fat, int chef, byte[] image, string type) : base(name, desription, calories,  fat, chef, image, type)
        {

        }
    }
}
