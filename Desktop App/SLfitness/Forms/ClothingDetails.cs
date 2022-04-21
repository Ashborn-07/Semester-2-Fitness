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
    public partial class ClothingDetails : Form
    {
        private ProductService service;
        private Clothing clothing;
        private ProductsForm form;

        public ClothingDetails(ProductsForm form)
        {
            InitializeComponent();
            IProductRepository repository = new ProductRepository();
            service = new ProductService(repository);
            PopulateFilterBox();
            this.form = form;
        }

        public ClothingDetails(Clothing clothing, ProductsForm form)
        {
            InitializeComponent();
            IProductRepository repository = new ProductRepository();
            service = new ProductService(repository);
            PopulateFilterBox();
            this.clothing = clothing;
            this.form = form;
            PopulateProductFields();
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images only. |*.jpg; *.jpeg; *.png; *.gif;";

            DialogResult result = openFileDialog.ShowDialog();

            if (!String.IsNullOrEmpty(openFileDialog.FileName))
            {
                Image image = Image.FromFile(openFileDialog.FileName);
                picBox.Image = image;
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ClothType clothType = new ClothType();

            switch(cbClothType.Text)
            {
                case "T SHIRT":
                    clothType = ClothType.T_SHIRTS;
                    break;
                case "HOODIES":
                    clothType = ClothType.HOODIES;
                    break;
                case "JACKETS":
                    clothType = ClothType.JACKETS;
                    break;
                case "LEGGINGS":
                    clothType = ClothType.LEGGINGS;
                    break;
                case "SPORT BRAS":
                    clothType = ClothType.SPORT_BRAS;
                    break;
                case "SPORT SHOES":
                    clothType = ClothType.SPORT_SHOES;
                    break;
                default:
                    break;
            }

            Clothing clothing = new Clothing(tbName.Text, cbBrand.Text, tbDescription.Text, numPrice.Value, ProductType.CLOTHES, ImageToBytesConverter(picBox.Image), clothType, (ClothSize)Enum.Parse(typeof(ClothSize), cbSize.Text));

            try
            {
                service.AddProduct(clothing);
            } catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            } catch (Exception es)
            {
                MessageBox.Show(es.Message);
                return;
            }

            Notification();
        }

        private void PopulateFilterBox()
        {
            cbBrand.Items.Clear();

            foreach (var brand in service.PopulateFilterBox("brand"))
            {
                cbBrand.Items.Add(brand);
            }
        }

        private void PopulateProductFields()
        {
            picBox.Image = ByteToImageConverter(clothing.Image);
            tbName.Text = clothing.Name;
            tbDescription.Text = clothing.Description;
            numPrice.Value = clothing.Price;
            cbBrand.Text = clothing.Brand;
            cbSize.Text = clothing.ClothSize.ToString();

            switch (clothing.ClothType.ToString()) 
            {
                case "T_SHIRT":
                    cbClothType.Text = "T SHIRT";
                    break;
                case "HOODIES":
                    cbClothType.Text = "HOODIES";
                    break;
                case "JACKETS":
                    cbClothType.Text = "JACKETS";
                    break;
                case "LEGGINGS":
                    cbClothType.Text = "LEGGINGS";
                    break;
                case "SPORT_BRAS":
                    cbClothType.Text = "SPORT BRAS";
                    break;
                case "SPORT_SHOES":
                    cbClothType.Text = "SPORT SHOES";
                    break;
                default:
                    break;
            }
        }

        private Image ByteToImageConverter(byte[] vs)
        {
            MemoryStream stream = new MemoryStream(vs);
            Image image = new Bitmap(stream);

            return image;
        }

        private byte[] ImageToBytesConverter(Image image)
        {
            byte[] img;

            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
            img = memoryStream.ToArray();

            return img;
        }

        private void ClothingDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.RefreshData();
        }

        private void Notification()
        {
            DialogResult ds = MessageBox.Show("Product added successfully, do you want to add another clothing.", "", MessageBoxButtons.YesNo);

            if (ds == DialogResult.Yes)
            {
                tbName.Text = "";
                tbDescription.Text = "";
                cbBrand.Text = "Brand";
                cbClothType.Text = "Cloth type";
                numPrice.Value = Convert.ToDecimal(0.00);
                cbSize.Text = "Cloth size";
                picBox.Image = null;
                return;
            }

            this.Close();
        }
    }
}
