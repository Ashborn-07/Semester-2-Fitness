using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BusinessLogicLayer
{
    public interface IDietsRepository
    {
        public int AddDiet(Diet diet);

        public DataTable DisplayDiets();

        public DataTable DisplayHealthyDiets();

        public DataTable DisplayZaroCarbsDiets();

        public string GetTypeOfDiet(int id);

        public Diet DisplayAboutDiet(int id, string type, int chef);

        public void UpdateHealthyDietInfo(int id, string name, string description, int calories, int fat, byte[] image, int carbs);

        public void UpdateZeroCarbsDietInfo(int id, string name, string description, int calories, int fat, byte[] image);

        public Image GetImage(int id);

        public List<Diet> GetAllDiets();
    }
}
