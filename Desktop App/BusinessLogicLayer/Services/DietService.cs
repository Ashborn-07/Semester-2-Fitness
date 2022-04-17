using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BusinessLogicLayer
{
    public class DietService
    {
        private IDietsRepository repository;

        public DietService(IDietsRepository repository)
        {
            this.repository = repository;
        }

        public void AddDiet(Diet diet)
        {
            if (diet.Name.Length > 30)
            {
                throw new ApplicationException("Diet's name is too long. Must be equal or less than 30 characters.");
            }

            if (diet.Name.Length < 3)
            {
                throw new ApplicationException("Diet's name is too short. It must have at least 4 characters.");
            }

            repository.AddDiet(diet);
        }

        public DataTable DisplayDiets(string type)
        {
            DataTable dt = null;

            switch(type)
            {
                case "all":
                    dt = repository.DisplayDiets();
                    break;
                case "zerocarbs":
                    dt = repository.DisplayZaroCarbsDiets();
                    break;
                case "healthy":
                    dt = repository.DisplayHealthyDiets();
                    break;
                default:
                    throw new ApplicationException("DisplayDiets function malfunctioned.");
            }

            if (dt == null)
            {
                throw new ApplicationException("Error accesssing database.");
            }

            return dt;
        }

        public string ReturnDietType(int id)
        {
            if (id == -1)
            {
                throw new ApplicationException("Not properly selected diet.");
            }

            string type = repository.GetTypeOfDiet(id);

            if (type == null)
            {
                throw new ApplicationException("Unexpected problem while getting the type.");
            }

            return type;
        }


        public Image ReturnDietImage(int id)
        {
            if (id == -1)
            {
                throw new ApplicationException("Unexpected error occured from the diet id.");
            }

             Image image = repository.GetImage(id);

            if (image == null)
            {
                throw new ApplicationException("Unexpected error occured while accessing the diet image.");
            }

            return image;
        }

        public Diet DisplayInformationAboutDiet(int dietId, int chefId, string type)
        {
            Diet diet = null;

            diet = repository.DisplayAboutDiet(dietId, type, chefId);

            if (diet == null)
            {
                throw new ApplicationException("Unexpected error ocurred while displaying the information about the diet.");
            }

            return diet;
        }

        public void UpdateDietInformation(Diet diet)
        {
            switch(diet)
            {
                case ZeroCarbsDiet:
                    repository.UpdateZeroCarbsDietInfo(diet.Id, diet.Name, diet.Description, diet.Calories, diet.Fat, diet.Image);
                    break;
                case HealthyDiet:
                    repository.UpdateHealthyDietInfo(diet.Id, diet.Name, diet.Description, diet.Calories, diet.Fat, diet.Image, ((HealthyDiet)diet).Carbs);
                    break;
                default:
                    throw new ApplicationException("An unexpected error occurred during passing the information to the database.");
            }
        }
    }
}
