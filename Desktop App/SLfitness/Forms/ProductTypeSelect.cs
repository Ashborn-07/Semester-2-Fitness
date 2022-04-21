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
    public partial class ProductTypeSelect : Form
    {
        private ProductsForm form;

        public ProductTypeSelect(ProductsForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void btnClothing_Click(object sender, EventArgs e)
        {
            ClothingDetails clothing = new ClothingDetails(form);
            clothing.Show();
            this.Close();
        }

        private void btnProtein_Click(object sender, EventArgs e)
        {
            ProteinDetails protein = new ProteinDetails(form);
            protein.Show();
            this.Close();
        }

        private void btnVitamin_Click(object sender, EventArgs e)
        {
            VitaminDetails vitamin = new VitaminDetails(form);
            vitamin.Show();
            this.Close();
        }
    }
}
