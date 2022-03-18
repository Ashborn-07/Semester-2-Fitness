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
    public partial class Menu : Form
    {

        private int activeUserID;
        private MenuHandler menuHandler;

        public Menu(int id)
        {
            InitializeComponent();

            this.activeUserID = id;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            menuHandler = new MenuHandler();
            pBoxProfile.Image = menuHandler.GetImage(activeUserID);
            pBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            lblGreeter.Text = lblGreeter.Text + menuHandler.GetFirstName(activeUserID);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDiets_Click(object sender, EventArgs e)
        {
            DietsForm dietsForm = new DietsForm(activeUserID);
            dietsForm.Show();
            this.Hide();
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            ProductsForm equipmentsForm = new ProductsForm(activeUserID);
            equipmentsForm.Show();
            this.Hide();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule(activeUserID);
            schedule.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(activeUserID);
            settings.Show();
            this.Hide();
        }
    }
}
