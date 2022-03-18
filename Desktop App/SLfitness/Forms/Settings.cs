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
    public partial class Settings : Form
    {
        private int activeUserID;
        private SettingsHandler handler;
        private bool valid = true;

        public Settings(int activeUserID)
        {
            InitializeComponent();
            this.activeUserID = activeUserID;
        }

        private void tbSaveChanges_Click(object sender, EventArgs e)
        {
            handler = new SettingsHandler();

            handler.UpdateUserInfo(activeUserID, tbUsername.Text, tbEmail.Text, tbFirstName.Text, tblastName.Text, ConverterOfImage(picBox.Image));
            handler.DisplayProfileInformation(activeUserID, tbUsername, tbEmail, tbFirstName, tblastName, picBox);

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
            handler = new SettingsHandler();
            handler.DisplayProfileInformation(activeUserID, tbUsername, tbEmail, tbFirstName, tblastName, picBox);
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Menu menu = new Menu(activeUserID);
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

        private byte[] ConverterOfImage(Image image)
        {
            byte[] img;

            MemoryStream memoryStream = new MemoryStream();
            image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
            img = memoryStream.ToArray();

            return img;
        }
    }
}
