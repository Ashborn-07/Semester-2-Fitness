using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLfitness
{
    public partial class UpdateDiet : Form
    {
        private string name;
        private string description;
        private int calories;
        private int fat;
        private int carbs;

        public UpdateDiet(string name, string description, int calories, int fat, int carbs)
        {
            InitializeComponent();
            this.name = name;
            this.description = description;
            this.calories = calories;
            this.fat = fat;
            this.carbs = carbs;
        }

        public UpdateDiet(string name, string description, int calories, int fat)
        {
            InitializeComponent();
            this.name = name;
            this.description = description;
            this.calories = calories;
            this.fat = fat;
        }

        private void UpdateDiet_Load(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnPictureBrowse_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
