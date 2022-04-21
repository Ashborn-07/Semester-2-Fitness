using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BusinessLogicLayer;
using DataAccessLayer;

namespace SLfitnessDesktop
{
    public partial class ProductsForm : Form
    {
        private User user;
        private Menu menu;
        private ProductService service;

        public ProductsForm(User user, Menu menu)
        {
            InitializeComponent();
            this.user = user;
            this.menu = menu;
            IProductRepository repository = new ProductRepository();
            service = new ProductService(repository);
            PopulateFilterBoxes();
        }

        private void EquipmentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Show();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            ProductTypeSelect select = new ProductTypeSelect(this);
            select.Show();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            //TODO
            if (Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[0].Value) != -1)
            {
                Product product;

                try
                {
                    product = service.DisplayProductInformation(Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[0].Value));
                } catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                } catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                    return;
                }

                switch (product)
                {
                    case Clothing:
                        ClothingDetails formClothing = new ClothingDetails((Clothing)product, this);
                        formClothing.Show();
                        break;
                    case Protein:
                        ProteinDetails formProtein = new ProteinDetails((Protein)product, this);
                        formProtein.Show();
                        break;
                    case Vitamins:
                        VitaminDetails formVitamin = new VitaminDetails((Vitamins)product, this);
                        formVitamin.Show();
                        break;
                }
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[0].Value) != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the product", "", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        service.DeleteProduct(Convert.ToInt32(dgvProducts.SelectedRows[0].Cells[0].Value));
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    } catch (Exception es)
                    {
                        MessageBox.Show(es.Message);
                    }

                    RefreshData();
                    return;
                }
            } 
        }

        private void cbType_TextChanged(object sender, EventArgs e)
        {
            filterProducts();
        }

        private void cbBrand_TextChanged(object sender, EventArgs e)
        {
            filterProducts();
        }

        private void cbPrice_TextChanged(object sender, EventArgs e)
        {
            filterProducts();
        }

        private void filterProducts()
        {
            string brand = cbBrand.Text;
            string type = cbType.Text;
            string priceFilter = cbPrice.Text;
            dgvProducts.DataSource = service.DisplayProductsByFilter(brand, type, priceFilter);
        }

        private void PopulateFilterBoxes()
        {
            // Brands filter
            cbBrand.Items.Clear();
            cbBrand.Text = "";
            //productManager.PopulateFilterBox(cbBrand, "brand");
            foreach(var brand in service.PopulateFilterBox("brand"))
            {
                cbBrand.Items.Add(brand);
            }

            // Types filter
            cbType.Items.Clear();
            cbType.Text = "";
            //productManager.PopulateFilterBox(cbType, "type");
            foreach (var type in service.PopulateFilterBox("type"))
            {
                cbType.Items.Add(type);
            }

            // Price filter
            cbPrice.Items.Clear();
            cbPrice.Text = "";
            foreach (var price in service.PopulateFilterBox("price"))
            {
                cbPrice.Items.Add(price);
            }
        }

        public void RefreshData()
        {
            dgvProducts.DataSource = service.DisplayProducts();
        }
    }
}
