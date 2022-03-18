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
    public partial class UpdateDiet : Form
    {
        DietsHandler dietHandler = new DietsHandler();
        private int activeUserID;
        private string type;
        private int dietId;
        private bool valid = true;

        public UpdateDiet(int dietId, string type, int activeUserID)
        {
            InitializeComponent();
           
            this.type = type;
            this.dietId = dietId;
            this.activeUserID = activeUserID;
        }

        private void UpdateDiet_Load(object sender, EventArgs e)
        {
            //TODO
            numCarbs.Enabled = false;
            dietHandler.DisplayAboutDiet(dietId, tbName, tbDescription, numCalories, numFat, numCarbs, picBoxDiet, type);
        }

        private void btnPictureBrowse_Click(object sender, EventArgs e)
        {
            //TODO
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
            if (numCarbs.Enabled == true)
            {
                dietHandler.UpdateHealthyDietInfo(dietId, tbName.Text, tbDescription.Text, (int)numCalories.Value, (int)numFat.Value, ConverterOfImage(picBoxDiet.Image), (int)numCarbs.Value);
            } else
            {
                dietHandler.UpdateZeroCarbsDietInfo(dietId, tbName.Text, tbDescription.Text, (int)numCalories.Value, (int)numFat.Value, ConverterOfImage(picBoxDiet.Image));
            }
            

            valid = false;
            this.Close();
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
