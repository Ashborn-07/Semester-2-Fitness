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
    public partial class DietsForm : Form
    {
        private int activeUserID;
        private DietsHandler dietsHandler;

        public DietsForm(int activeUserID)
        {
            InitializeComponent();

            this.activeUserID = activeUserID;
        }

        private void DietsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Menu menu = new Menu(activeUserID);
            menu.Show();
        }

        private void btnAddDiet_Click(object sender, EventArgs e)
        {
            NewDiet newDiet = new NewDiet(activeUserID);
            newDiet.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dietsHandler = new DietsHandler();
            dietsHandler.DisplayDiets(dataGridv);
        }

        private void dataGridv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string p = dataGridv.Rows[e.RowIndex].Cells[2].Value.ToString();
            int id = Convert.ToInt32(p);

            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                DietImageForm dietImageForm = new DietImageForm(id);
                dietImageForm.Show();
            }
            else if (e.ColumnIndex == 1 && e.RowIndex != -1)
            {
                //TODO with the UpdateDiet Form
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dietsHandler = new DietsHandler();

            if (cbFilter.SelectedItem.ToString().Equals("Zero Carbs"))
            {
                dietsHandler.DisplayZaroCarbsDiets(dataGridv);
            }
            else if (cbFilter.SelectedItem.ToString().Equals("Healthy"))
            {
                dietsHandler.DisplayHealthyDiets(dataGridv);
            } else
            {
                dietsHandler.DisplayDiets(dataGridv);
            }
        }
    }
}
