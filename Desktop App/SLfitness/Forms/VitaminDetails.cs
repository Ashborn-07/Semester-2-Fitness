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
using System.Drawing.Imaging;

namespace SLfitnessDesktop
{
    public partial class VitaminDetails : Form
    {
        private ProductService service;
        private Vitamins vitamins;
        private ProductsForm form;

        public VitaminDetails(ProductsForm form)
        {
            InitializeComponent();
            IProductRepository repository = new ProductRepository();
            service = new ProductService(repository);
            this.form = form;
            PopulateFilterBox();
        }

        public VitaminDetails(Vitamins vitamins, ProductsForm form)
        {
            InitializeComponent();
            IProductRepository repository = new ProductRepository();
            service = new ProductService(repository);
            PopulateFilterBox();
            this.vitamins = vitamins;
            this.form = form;
            PopulateProductFields();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidationInput())
            {
                Goal goal = new Goal();

                switch (cbGoal.Text)
                {
                    case "BUILD MUSCLE":
                        goal = Goal.BUILD_MUSCLE;
                        break;
                    case "ENDURANCE":
                        goal = Goal.ENDURANCE;
                        break;
                    case "LOSE WEIGHT":
                        goal = Goal.LOSE_WEIGHT;
                        break;
                    case "STAY HEALTHY":
                        goal = Goal.STAY_HEALTHY;
                        break;
                    default:
                        break;
                }

                if (lblProductId.Text != ".")
                {
                    Vitamins vitamins = new Vitamins(Convert.ToInt32(lblProductId.Text), tbName.Text, cbBrand.Text, tbDescription.Text, ProductType.TABLETS, numPrice.Value, ImageToBytesConverter(picBox.Image), (VitaminFlavour)Enum.Parse(typeof(VitaminFlavour), cbVitaminFlavour.Text), goal);

                    try
                    {
                        service.UpdateProduct(vitamins);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Vitamins successfully updated");
                }
                else
                {
                    Vitamins vitamins = new Vitamins(tbName.Text, cbBrand.Text, tbDescription.Text, ProductType.TABLETS, numPrice.Value, ImageToBytesConverter(picBox.Image), (VitaminFlavour)Enum.Parse(typeof(VitaminFlavour), cbVitaminFlavour.Text), goal);

                    try
                    {
                        service.AddProduct(vitamins);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.Message);
                    }

                    NotificationAdded();
                }

                return;
            }

            MessageBox.Show("Please be sure to fill all fields and choose an image");
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images only. |*.jpg; *.jpeg; *.png; *.gif;";

            DialogResult result = openFileDialog.ShowDialog();

            if (!String.IsNullOrEmpty(openFileDialog.FileName))
            {
                Image image = Image.FromFile(openFileDialog.FileName);
                image = ResizeImage(image);
                picBox.Image = image;
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private byte[] ImageToBytesConverter(Image image)
        {
            byte[] img;

            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
            img = memoryStream.ToArray();

            return img;
        }

        private Image ByteToImageConverter(byte[] vs)
        {
            MemoryStream stream = new MemoryStream(vs);
            Image image = new Bitmap(stream);

            return image;
        }

        private void VitaminDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.RefreshData();
        }

        private void PopulateFilterBox()
        {
            cbBrand.Items.Clear();

            foreach (var brand in service.PopulateFilterBox("brand"))
            {
                cbBrand.Items.Add(brand);
            }
        }

        private void NotificationAdded()
        {
            DialogResult ds = MessageBox.Show("Product added successfully, do you want to add another clothing.", "", MessageBoxButtons.YesNo);

            if (ds == DialogResult.Yes)
            {
                tbName.Text = "";
                tbDescription.Text = "";
                cbBrand.Text = "Brand";
                cbVitaminFlavour.Text = "Vitamin flavour";
                numPrice.Value = Convert.ToDecimal(0.00);
                cbGoal.Text = "Goal";
                picBox.Image = null;
                return;
            }

            this.Close();
        }

        private void PopulateProductFields()
        {
            picBox.Image = ByteToImageConverter(vitamins.Image);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            tbName.Text = vitamins.Name;
            tbDescription.Text = vitamins.Description;
            numPrice.Value = vitamins.Price;
            cbBrand.Text = vitamins.Brand;
            cbVitaminFlavour.Text = vitamins.Flavour.ToString();
            if (vitamins.ID != null)
            {
                lblProductId.Text = vitamins.ID.ToString();
            }

            switch (vitamins.Goal.ToString())
            {
                case "BUILD_MUSCLE":
                    cbGoal.Text = "BUILD MUSCLE";
                    break;
                case "ENDURANCE":
                    cbGoal.Text = "ENDURANCE";
                    break;
                case "LOSE_WEIGHT":
                    cbGoal.Text = "LOSE WEIGHT";
                    break;
                case "STAY_HEALTHY":
                    cbGoal.Text = "STAY HEALTHY";
                    break;
                default:
                    break;
            }
        }

        private Image ResizeImage(Image imgToResize)
        {
            Image resizedImage = imgToResize;
            Bitmap bitmap = new Bitmap(resizedImage);
            return (Image)(new Bitmap(imgToResize, new Size(300, 300)));
        }

        private bool ValidationInput()
        {
            if (!String.IsNullOrEmpty(tbName.Text) && !String.IsNullOrEmpty(tbDescription.Text) 
                && cbGoal.SelectedIndex != -1 && cbVitaminFlavour.SelectedIndex != -1 && picBox.Image != null)
            {
                if (cbBrand.SelectedIndex != -1 || cbBrand.Text != "brand")
                {
                    return true;
                }
            }

            return false;
        }
    }
}
