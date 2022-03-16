using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLfitness
{
    public class Diet
    {
        protected string name;
        protected string description;
        protected int calories;
        protected string type;
        protected int fat;
        protected int chef;
        protected byte[] image;
       
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public int Calories { get { return calories; } set { calories = value; } }
        public int Fat { get { return fat; } set { fat = value; } }
        public int Chef { get { return chef; } set { chef = value; } }
        public byte[] Image { get { return image; } set { image = value; } }
        public string Type { get { return type; } set { type = value; } }

        public Diet(string name, string desription, int calories, int fat, int chef, byte[] image, string type)
        {
            this.name = name;
            this.description = desription;
            this.calories = calories;
            this.fat = fat;
            this.chef = chef;
            this.image = image;
            this.type = type;
        }
    }
}
