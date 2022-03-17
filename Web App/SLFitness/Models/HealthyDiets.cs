namespace SLFitness.Models
{
    public class HealthyDiets : Diet
    {
        private int carbs;

        public HealthyDiets(int id, string name, string desription, int chef, byte[] image, int carbs) : base(id, name, desription, chef, image)
        {
            this.carbs = carbs;
        }

        public int Carbs { get { return carbs; } }
    }
}
