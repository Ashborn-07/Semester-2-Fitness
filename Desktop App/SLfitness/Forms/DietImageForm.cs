using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayer;

namespace SLfitnessDesktop
{
    public partial class DietImageForm : Form
    {
        private int id;
        private DietService service;

        public DietImageForm(int id)
        {
            InitializeComponent();
            this.id = id;
            IDietsRepository repository = new DietsRepository();
            service = new DietService(repository);
        }

        private void DietImageForm_Load(object sender, EventArgs e)
        {
            picBoxDietImage.Image = service.ReturnDietImage(id);
            picBoxDietImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
