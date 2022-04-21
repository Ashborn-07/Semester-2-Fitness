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
    public partial class ProteinDetails : Form
    {
        private ProductService service;
        private ProductsForm form;
        private Protein protein;
        private int id;

        public ProteinDetails(ProductsForm form)
        {
            InitializeComponent();
            IProductRepository repository = new ProductRepository();
            service = new ProductService(repository);
            this.form = form;
            PopulateFilterBox();
        }

        public ProteinDetails(Protein protein, ProductsForm form)
        {
            InitializeComponent();
            IProductRepository repository = new ProductRepository();
            service = new ProductService(repository);
            PopulateFilterBox();
            this.protein = protein;
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

                if (label1.Text != ".")
                {
                    Protein protein = new Protein(Convert.ToInt32(lblProductId.Text), tbName.Text, cbBrand.Text, tbDescription.Text, ProductType.POWDER, numPrice.Value, ImageToBytesConverter(picBox.Image), goal, tbOccurance.Text, (ProteinFlavour)Enum.Parse(typeof(ProteinFlavour), cbProteinFlavour.Text));

                    try
                    {
                        service.UpdateProduct(protein);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    catch (ApplicationCustomException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.Message);
                        return;
                    }

                    MessageBox.Show("Protein updated successfully.");
                }
                else
                {
                    Protein protein = new Protein(tbName.Text, cbBrand.Text, tbDescription.Text, ProductType.POWDER, numPrice.Value, ImageToBytesConverter(picBox.Image), goal, tbOccurance.Text, (ProteinFlavour)Enum.Parse(typeof(ProteinFlavour), cbProteinFlavour.Text));

                    try
                    {
                        service.AddProduct(protein);
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    catch (ApplicationCustomException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    catch (Exception es)
                    {
                        MessageBox.Show(es.Message);
                        return;
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

        private void NotificationAdded()
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to add another product of that type?", "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                tbName.Text = "";
                tbDescription.Text = "";
                cbBrand.Text = "Brand";
                cbGoal.Text = "Goal";
                cbProteinFlavour.Text = "Protein flavour";
                tbOccurance.Text = "";
                numPrice.Value = Convert.ToDecimal(0.00);
                picBox.Image = null;
                return;
            }

            this.Close();
        }

        private void ProteinDetails_FormClosing(object sender, FormClosingEventArgs e)
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

        private void PopulateProductFields()
        {
            picBox.Image = ByteToImageConverter(protein.Image);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            tbName.Text = protein.Name;
            tbDescription.Text = protein.Description;
            numPrice.Value = protein.Price;
            cbBrand.Text = protein.Brand;
            cbProteinFlavour.Text = protein.Flavour.ToString();
            if (protein.ID != null)
            {
                lblProductId.Text = protein.ID.ToString();
            }

            switch (protein.Goal.ToString())
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
                && cbGoal.SelectedIndex != -1 && cbProteinFlavour.SelectedIndex != -1 && picBox.Image != null)
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
