using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Diet
    {
        protected int id;
        protected string name;
        protected string description;
        protected int calories;
        protected int fat;
        protected int chef;
        protected byte[] image;
        
        public int Id { get { return id; } private set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public int Calories { get { return calories; } set { calories = value; } }
        public int Fat { get { return fat; } set { fat = value; } }
        public int Chef { get { return chef; } set { chef = value; } }
        public byte[] Image { get { return image; } set { image = value; } }
        
        public Diet(string name, string desription, int calories, int fat, int chef, byte[] image)
        {
            this.name = name;
            this.description = desription;
            this.calories = calories;
            this.fat = fat;
            this.chef = chef;
            this.image = image;
        }

        public Diet(int id, string name, string desription, int calories, int fat, int chef, byte[] image)
        {
            this.id = id;
            this.name = name;
            this.description = desription;
            this.calories = calories;
            this.fat = fat;
            this.chef = chef;
            this.image = image;
        }
    }
}
