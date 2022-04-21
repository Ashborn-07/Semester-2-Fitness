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
    public partial class Settings : Form
    {
        private User user;
        private UserService service;
        private Menu menu;
        private bool valid = true;

        public Settings(User user, Menu menu)
        {
            InitializeComponent();
            this.user = user;
            this.menu = menu;
            IUserRepository repository = new UserRepository();
            service = new UserService(repository);
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                service.UpdateUserInfo(new User(user.Id, tbUsername.Text, tbFirstName.Text, tblastName.Text, tbEmail.Text, ConverterOfImageToBytes(picBox.Image)));
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
                return;
            }

            DisplayUserInformation();

            MessageBox.Show("Changes completely saved");

            valid = false;
            this.Close();
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
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

        private void Settings_Load(object sender, EventArgs e)
        {
            DisplayUserInformation();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (valid)
            {
                DialogResult dialogResult = MessageBox.Show("Do you really want to leave this page?", "Any unsaved data will be lost.", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    menu.Show();
                    return;
                }
                else if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
            }

            menu.Show();
        }

        private byte[] ConverterOfImageToBytes(Image image)
        {
            byte[] img;

            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
            img = memoryStream.ToArray();

            return img;
        }

        private Image ConverOfBytesToImage(byte[] vs)
        {
            if (vs != null)
            {
                MemoryStream ms = new MemoryStream(vs);
                Image image = new Bitmap(ms);

                return image;
            }

            return null;
        }

        private void DisplayUserInformation()
        {
            tbUsername.Text = user.UserName;
            tbEmail.Text = user.Email;
            tbFirstName.Text = user.FirstName;
            tblastName.Text = user.LastName;
            picBox.Image = ConverOfBytesToImage(user.Image);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
