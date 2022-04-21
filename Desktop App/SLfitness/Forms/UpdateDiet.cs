using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;
using BusinessLogicLayer;
using DataAccessLayer;

namespace SLfitnessDesktop
{
    public partial class UpdateDiet : Form
    {
        private DietService service;
        User user;
        private string type;
        private int dietId;
        private byte[] picture;
        private bool valid = true;

        public UpdateDiet(int dietId, string type, User user)
        {
            InitializeComponent();

            this.type = type;
            this.dietId = dietId;
            this.user = user;
            IDietsRepository repository = new DietsRepository();
            service = new DietService(repository);
        }

        private void UpdateDiet_Load(object sender, EventArgs e)
        {
            //TODO
            numCarbs.Enabled = false;

            Diet diet = null;

            try
            {
                diet = service.DisplayInformationAboutDiet(dietId, user.Id, type);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            switch (diet)
            {
                case ZeroCarbsDiet:
                    tbName.Text = diet.Name;
                    tbDescription.Text = diet.Description;
                    numCalories.Value = diet.Calories;
                    numFat.Value = diet.Fat;
                    picBoxDiet.Image = ConverterOfBytesToImage(diet.Image);
                    break;
                case HealthyDiet:
                    tbName.Text = diet.Name;
                    tbDescription.Text = diet.Description;
                    numCalories.Value = diet.Calories;
                    numFat.Value = diet.Fat;
                    picBoxDiet.Image = ConverterOfBytesToImage(diet.Image);
                    numCarbs.Value = ((HealthyDiet)diet).Carbs;
                    break;
                default:
                    MessageBox.Show("Unexpected error occurred while displaying diet information at the window.");
                    break;
            }

            picBoxDiet.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnPictureBrowse_Click(object sender, EventArgs e)
        {
            //TODO
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images only. |*.jpg; *.jpeg; *.png; *.gif;";

            DialogResult result = openFileDialog.ShowDialog();

            if (!String.IsNullOrEmpty(openFileDialog.FileName))
            {
                Image image = Image.FromFile(openFileDialog.FileName);
                MemoryStream memoryStream = new MemoryStream();
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
                picture = memoryStream.ToArray();

                picBoxDiet.Image = image;
                picBoxDiet.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void UpdateDiet_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (valid)
            {
                DialogResult dialogResult = MessageBox.Show("Do you really want to leave this page?", "Any unsaved data will be lost.", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

        private void btnUpdateDiet_Click(object sender, EventArgs e)
        {
            try
            {
                if (numCarbs.Enabled == true)
                {
                    service.UpdateDietInformation(new HealthyDiet(dietId, tbName.Text, tbDescription.Text, (int)numCalories.Value, (int)numFat.Value, user.Id, ConverterOfImageToByte(picBoxDiet.Image), (int)numCarbs.Value));
                }
                else
                {
                    service.UpdateDietInformation(new ZeroCarbsDiet(dietId, tbName.Text, tbDescription.Text, (int)numCalories.Value, (int)numFat.Value, user.Id, ConverterOfImageToByte(picBoxDiet.Image)));
                }
            }
            catch (MysqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (ApplicationCustomException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            valid = false;
            this.Close();
        }

        private byte[] ConverterOfImageToByte(Image image)
        {
            byte[] img;

            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
            img = memoryStream.ToArray();

            return img;
        }

        private Image ConverterOfBytesToImage(byte[] vs)
        {
            MemoryStream ms = new MemoryStream(vs);
            Image img = new Bitmap(ms);

            return img;
        }
    }
}
