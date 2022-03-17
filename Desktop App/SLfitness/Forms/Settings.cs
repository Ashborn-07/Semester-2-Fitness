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

        public Settings(int activeUserID)
        {
            InitializeComponent();
            this.activeUserID = activeUserID;
        }

        private void tbSaveChanges_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            handler = new SettingsHandler();
            handler.DisplayProfileInformation(activeUserID, tbUsername, tbEmail, tbFirstName, tblastName, pictureBox1);
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to leave this page?", "Any unsaved data will be lost.", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Menu menu = new Menu(activeUserID);
                menu.Show();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
