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

namespace SLfitness
{
    public partial class ProductsForm : Form
    {
        private User user;
        private Menu menu;

        public ProductsForm(User user, Menu menu)
        {
            InitializeComponent();
            this.user = user;
            this.menu = menu;
        }

        private void EquipmentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Show();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry but the products page is under development");
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
