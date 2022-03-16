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
    public partial class NewDiet : Form
    {
        private string pictureName;
        private int activeUserID;
        private DietsHandler dietHandler;

        public NewDiet(int activeUserID)
        {
            InitializeComponent();
            this.activeUserID = activeUserID;
        }

        private void btnPictureBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images only. |*.jpg; *.jpeg; *.png; *.gif;";

            DialogResult result = openFileDialog.ShowDialog();

            pictureName = openFileDialog.FileName;
            picBoxDiet.Image = new Bitmap(pictureName);
            picBoxDiet.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnAddDiet_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbName.Text) || String.IsNullOrEmpty(tbDescription.Text))
            {
                MessageBox.Show("All fields must be filled");
                return;
            }

            if (picBoxDiet.Image == null)
            {
                MessageBox.Show("Please choose a picture from your device");
                return;
            }

            FileStream fs = new FileStream(pictureName, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] image = new byte[br.BaseStream.Length];

            dietHandler = new DietsHandler();

            if (cbType.SelectedIndex == -1)
            {
                MessageBox.Show("Choose Type!");
                return;
            }
            else if (cbType.SelectedItem.ToString().Equals("Zero Carbs"))
            {
                ZeroCarbsDiet diet = dietHandler.GetCarbsDiet(tbName.Text, tbDescription.Text, activeUserID, image, (int)numCalories.Value, (int)numFat.Value);
                dietHandler.AddDiet(diet);
            }
            else if (cbType.SelectedItem.ToString().Equals("Healthy"))
            {
                HealthyDiet diet = dietHandler.GetHealthy(tbName.Text, tbDescription.Text, activeUserID, image, (int)numCalories.Value, (int)numFat.Value, (int)numCarbs.Value);
                dietHandler.AddDiet(diet);
            }
        }

        private void NewDiet_Load(object sender, EventArgs e)
        {

        }

        private void NewDiet_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to leave any unsaved data will be lost.", "", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }

            return;
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbType.SelectedItem.ToString().Equals("Zero Carbs"))
            {
                numCarbs.Enabled = false;
                return;
            }

            numCarbs.Enabled = true;
        }
    }
}
