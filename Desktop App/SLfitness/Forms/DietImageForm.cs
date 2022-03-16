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
    public partial class DietImageForm : Form
    {
        private int id;
        private DietsHandler dietHandler;

        public DietImageForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void DietImageForm_Load(object sender, EventArgs e)
        {
            dietHandler = new DietsHandler();
            picBoxDietImage.Image = dietHandler.GetImage(id);
            picBoxDietImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
