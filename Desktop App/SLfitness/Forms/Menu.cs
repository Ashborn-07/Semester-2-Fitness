using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayer;

namespace SLfitnessDesktop
{
    public partial class Menu : Form
    {

        private User user;

        public Menu(User user)
        {
            InitializeComponent();

            this.user = user;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            pBoxProfile.Image = ConverterOfBytesToImage(user.Image);
            pBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            lblGreeter.Text = lblGreeter.Text + user.FirstName;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDiets_Click(object sender, EventArgs e)
        {
            DietsForm dietsForm = new DietsForm(user, this);
            dietsForm.Show();
            this.Hide();
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            ProductsForm equipmentsForm = new ProductsForm(user, this);
            equipmentsForm.Show();
            this.Hide();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule(user, this);
            schedule.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(user, this);
            settings.Show();
            this.Hide();
        }

        private Image ConverterOfBytesToImage(byte[] vs)
        {
            if (vs != null)
            {
                MemoryStream ms = new MemoryStream(vs);
                Image image = new Bitmap(ms);

                return image;
            }

            return null;
        }
    }
}
