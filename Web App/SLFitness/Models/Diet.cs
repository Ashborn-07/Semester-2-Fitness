namespace SLFitness.Models
{
    public class Diet
    {
        protected int id;
        protected string name;
        protected string description;
        protected int chef;
        protected byte[] image;

        public int Id { get { return id; } }
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public int Chef { get { return chef; } set { chef = value; } }
        public byte[] Image { get { return image; } set { image = value; } }

        public Diet(int id, string name, string desription, int chef, byte[] image)
        {
            this.id = id;
            this.name = name;
            this.description = desription;
            this.chef = chef;
            this.image = image;
        }
    }
}
