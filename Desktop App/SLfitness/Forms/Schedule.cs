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

namespace SLfitness
{
    public partial class Schedule : Form
    {
        private ScheduleService service;
        private Menu menu;
        private User user;

        public Schedule(User user, Menu menu)
        {
            InitializeComponent();
            this.user = user;
            this.menu = menu;
            IScheduleRepository repository = new ScheduleRepository();
            service = new ScheduleService(repository);
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            cbFilter.Text = "";
            dateTimePick.Value = DateTime.Now;
            DataGridView.DataSource = service.DisplaySchedules();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridView.DataSource = service.DisplaySchedulesByFilter(cbFilter.SelectedItem.ToString());
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            DataGridView.DataSource = service.DisplaySchedules();

            cbFilter.Items.Clear();

            foreach (var item in service.GetLocationsFilter())
            {
                cbFilter.Items.Add(item);
            }
        }

        private void dateTimePick_ValueChanged(object sender, EventArgs e)
        {
            //probably change to calendar for date and combo box for time
            //add filter option with hour and different coaches/users(maybe)
            DateTime dateTime = dateTimePick.Value;
            string date = dateTime.ToString("yyyy-MM--dd");

            DataGridView.DataSource = service.DisplaySchedulesByDate(date);
        }

        private void Schedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to leave this page?", "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            { 
                menu.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
