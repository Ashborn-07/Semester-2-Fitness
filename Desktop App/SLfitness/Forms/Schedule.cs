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
    public partial class Schedule : Form
    {
        ScheduleHandler scheduleHandler;
        private int activeUserID;

        public Schedule(int activeUserID)
        {
            InitializeComponent();
            this.activeUserID = activeUserID;
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {

        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            cbFilter.Text = "";
            dateTimePick.Value = DateTime.Now;

            scheduleHandler = new ScheduleHandler();
            scheduleHandler.DisplaySchedule(DataGridView);
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            scheduleHandler = new ScheduleHandler();
            scheduleHandler.DisplayByFilters(cbFilter.SelectedItem.ToString(), DataGridView);
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            scheduleHandler = new ScheduleHandler();
            scheduleHandler.DisplaySchedule(DataGridView);

            cbFilter.Items.Clear();

            foreach (var item in scheduleHandler.GetLocations())
            {
                cbFilter.Items.Add(item);
            }
        }

        private void dateTimePick_ValueChanged(object sender, EventArgs e)
        {
            //probably change to calendar for date and combo box for time
            scheduleHandler = new ScheduleHandler();
            DateTime dateTime = dateTimePick.Value;
            string date = dateTime.ToString("yyyy-MM--dd");

            scheduleHandler.FilterByDate(date, DataGridView);
        }

        private void Schedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to leave this page?", "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Menu menu = new Menu(activeUserID);
                menu.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
