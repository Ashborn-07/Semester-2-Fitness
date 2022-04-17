using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class ZeroCarbsDiet : Diet
    {
        public ZeroCarbsDiet(string name, string desription, int calories, int fat, int chef, byte[] image) : base(name, desription, calories, fat, chef, image)
        {

        }

        public ZeroCarbsDiet(int id, string name, string desription, int calories, int fat, int chef, byte[] image) : base(id, name, desription, calories, fat, chef, image)
        {

        }
    }
}
