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
    public partial class EquipmentsForm : Form
    {
        private int activeUserID;

        public EquipmentsForm(int activeUserID)
        {
            InitializeComponent();

            this.activeUserID = activeUserID;
        }

        private void EquipmentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu(activeUserID);
            menu.Show();
        }
    }
}
