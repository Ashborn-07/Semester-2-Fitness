﻿using System;
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
            //if (e.ColumnIndex == 4 && e.RowIndex != -1)
            //{
            //    string p = dataGridv.Rows[e.RowIndex].Cells[0].Value.ToString();
            //    int id = Convert.ToInt32(p);
            //    DietImageForm dietImageForm = new DietImageForm(id);
            //    dietImageForm.Show();
            //}
        }
    }
}
